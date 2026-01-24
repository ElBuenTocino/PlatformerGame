using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            QuitGame();
        }
        if (Input.GetKey(KeyCode.Return))
        {
            StartGame();
        }
    }


    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
