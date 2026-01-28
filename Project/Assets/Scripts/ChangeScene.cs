using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private PlayerInput playerInput;

    void Awake()
    {
        var input = GetComponent<PlayerInput>();
        input.enabled = true;
        input.ActivateInput();
    }

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

    public void OnEscape(InputValue value)
    {
        if (value.isPressed == true)
        {
            QuitGame();
        }
    }

    public void OnEnter(InputValue value)
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

            if (SceneManager.GetActiveScene().name == "Lose")
            {
                StartGame();
            }
        }
    }
}
