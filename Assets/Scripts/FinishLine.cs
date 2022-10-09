using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    // private void Awake() {
    //     GameManager.OnGameStateChanged += GameManagerOnStateChanged;
    // }

    // private void OnDestroy() {
    //     GameManager.OnGameStateChanged -= GameManagerOnStateChanged;
    // }

    // private void GameManagerOnStateChanged(GameState state) {

    // }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("other" + other.gameObject);
        if(other.tag == "Player") {
            // Debug.Log("Lets fucking gooooo");
            // other.GetComponent("PlayerMovement").active = false;

            // stop the timer

            // add finish bonus

            // calculate remaining time bonus
        }
    }
}
