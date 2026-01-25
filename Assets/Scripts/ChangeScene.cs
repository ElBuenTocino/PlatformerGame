using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private PlayerInput playerInput;
    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
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
        Debug.Log("ILY");
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

            if (SceneManager.GetActiveScene().name == "Title" || SceneManager.GetActiveScene().name == "Lose")
            {
                StartGame();
            }
        }
    }
}
