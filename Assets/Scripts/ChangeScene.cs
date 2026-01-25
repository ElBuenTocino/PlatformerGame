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
        Debug.Log("PlayerInput active: " + GetComponent<PlayerInput>().enabled);
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
            Debug.Log("furula?");
            QuitGame();
        }
    }

    public void OnEnter(InputValue value)
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

            if (SceneManager.GetActiveScene().name == "Title")
            {
                StartGame();
            }

            if (SceneManager.GetActiveScene().name == "Lose")
            {
                Debug.Log("Is In Lose");
                StartGame();
            }
        }
    }
}
