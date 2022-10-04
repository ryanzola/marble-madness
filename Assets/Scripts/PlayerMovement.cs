using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    RollingMovement m_rollingMovement;
    Vector3 m_startPosition;
    Score m_score;

    private static Vector2 distanceTraveled;

    // Start is called before the first frame update
    void Start()
    {
        // Gather components
        m_rollingMovement = GetComponent<RollingMovement>();
        m_score = GetComponent<Score>();
    }

    private void Update() {

        
    }

    public void OnMove(InputAction.CallbackContext context) {
        // Get the movement vector, apply it to the rollingmovement component
        Vector2 movement = context.ReadValue<Vector2>();
        m_rollingMovement.m_movementDirection = new Vector3(movement.x, 0f, movement.y);
    }
}
