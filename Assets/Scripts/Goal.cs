using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other) {
        if(other.gameObject.CompareTag("Player")) {
            Debug.Log("holy fuck");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
