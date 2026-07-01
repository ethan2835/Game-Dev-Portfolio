using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0 : 1;  // Pause/unpause game
            Debug.Log(isPaused ? "PAUSED" : "RESUMED");
        }
    }
}