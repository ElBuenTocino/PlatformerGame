using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class ResetScene : MonoBehaviour
{
    public void OnEnter()
    {
        Debug.Log("HOLA");
        SceneManager.LoadScene("Gameplay");
    }
}
