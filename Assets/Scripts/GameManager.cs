using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    private void OnEnable()
    {
        DeathTrigger.OnDeath += ReloadScene;
    }

    private void OnDisable()
    {
        DeathTrigger.OnDeath -= ReloadScene;
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
