using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_gameOverText;
    [SerializeField] TextMeshProUGUI m_timerText;
    [SerializeField] float m_gameTimeInSeconds = 60f;
    float m_timer;
    static bool m_gameIsPlaying = false;
    public static bool GameIsPlaying = m_gameIsPlaying;
    public static float RespawnHeight = -5f;

    void Start()
    {
        // Set the timescale to 0 to pause the game at the start
        Time.timeScale = 0f;

        // Set the game timer to number of seconds in a round
        m_timer = m_gameTimeInSeconds;

        // Update the timer text
        UpdateTimer();
    }

    void FixedUpdate()
    {
        // If the game is not playing, stop here
        if(!m_gameIsPlaying) return;

        // Subtract the fixed delta time from the timer
        m_timer -= Time.fixedDeltaTime;

        // If the timer hits zero, enter the game over state
        if(m_timer <= 0) 
        {
            GameOver();
            m_timer = 0;
        }

        // Update the timer text
        UpdateTimer();
    }

    void UpdateTimer()
    {
        // {0:0}:{1:00}
        // first number (0 and 1) is the index
        // : separates the index and the formatter
        // the 0 are leading zeros
        m_timerText.text = ((int)m_timer).ToString();
    }

    void GameOver() 
    {
        m_gameIsPlaying = false;

        // Pause the game by setting the time scale to zero
        Time.timeScale = 0f;

        // Display the end game text
        string gameOverText = "GAME OVER";
        // if(m_playerScore.ScoreValue > m_opponentScore.ScoreValue)
        //     gameOverText = "YOU WIN!";
        // else if (m_playerScore.ScoreValue < m_opponentScore.ScoreValue)
        //     gameOverText = "YOU LOSE!";
        // else
        //     gameOverText = "TIE";

        m_gameOverText.text = gameOverText + "\n\nPress SPACE to Restart";

        // // Show the game over text once it has been set
        m_gameOverText.gameObject.SetActive(true);
    }

    public void RestartGame() 
    {
        if(!m_gameIsPlaying)
        {
            // Unpause the game by setting the timescale to 1
            Time.timeScale = 1f;

            // Hide the game over text
            m_gameOverText.gameObject.SetActive(false);

            // Reset the game timer
            m_timer = m_gameTimeInSeconds;
            m_gameIsPlaying = true;
        }
    }
}
