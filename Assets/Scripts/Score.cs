using UnityEngine;
using System.Collections;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_scoreText;
    [SerializeField] float m_levelMultiplier;
    RollingMovement m_rollingMovement;
    public float ScoreValue { get; private set; }
    public Vector3 startPos;
    public Vector3 currentPos;
    float posDelta = 0f;
    int current = 0;

    private void Start() {
        startPos = transform.position;
        currentPos = transform.position;
        m_rollingMovement = GetComponent<RollingMovement>();
    }

    private void FixedUpdate() {
        // Every fixed update, update the score string
        StartCoroutine(CountUpToTarget());
    }

    // Start is called before the first frame update
    public void ResetScore()
    {
        ScoreValue = 0f;
        // Distance = 0f;
    }



    private void CalculateDistance() {
        currentPos = transform.position;

        posDelta = Vector3.Distance(startPos, currentPos);
        posDelta *= m_levelMultiplier;
        // Debug.Log((int)posDelta);


        // Distance += 0.01f;
    }

    IEnumerator CountUpToTarget()
    {
            CalculateDistance();
            int delta = (int)posDelta;

            if(posDelta > 1 && (int)posDelta % 10 == 0 && delta != current) {
                // if((int)posDelta == current) yield return null;
                
                current = delta;
                ScoreValue += 10f;
                m_scoreText.text = (int)ScoreValue + "";
            }

            // ScoreValue += Time.deltaTime; // or whatever to get the speed you like
            // ScoreValue = Mathf.Clamp(ScoreValue, 0f, 1000f);
            // m_scoreText.text = (int)ScoreValue + "";
            yield return null;
    }
}
