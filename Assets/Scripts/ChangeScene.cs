using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
        
    void Update()
    {
         
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void LoadTitle()
    {
        SceneManager.LoadScene("Title");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void OnEscape(InputValue value)
    {
        if (value.isPressed == true) 
        {
            Debug.Log("furula?");
            QuitGame();
        }
    }

    void OnEnter(InputValue value)
    {
        if (value.isPressed == true)
        {
            if (SceneManager.GetActiveScene().name == "Win")
            {
                LoadTitle();
            }

            if (SceneManager.GetActiveScene().name == "Gameplay")
            {
                LoadTitle();
            }

            if (SceneManager.GetActiveScene().name == "Title")
            {
                StartGame();
            }
        }
    }
}
