using UnityEngine;
using UnityEngine.SceneManagement;


public class Gamemanager : MonoBehaviour
{
    bool GameHasEnded = false;
    public float restartDelay;
    public GameObject Restartt;
    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Invoke("Restart", restartDelay);
            RestartMenu();
        }
    }
    public void RestartMenu()
    {
        if (GameHasEnded)
        {
           Restartt.SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }  
}
