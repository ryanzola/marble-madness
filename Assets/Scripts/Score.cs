using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_scoreText;
    public int ScoreValue { get; private set; }

    private void FixedUpdate() {
        // Every fixed update, update the score string
        m_scoreText.text = ScoreValue.ToString();
    }

    // Start is called before the first frame update
    public void ResetScore()
    {
        ScoreValue = 0;
    }

    // Update is called once per frame
    public void IncrementScore()
    {
        ScoreValue+=10;
    }
}
