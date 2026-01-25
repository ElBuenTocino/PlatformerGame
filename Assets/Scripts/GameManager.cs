using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private void OnEnable()
    {
        DeathTrigger.OnDeath += DeathScene;
    }

    private void OnDisable()
    {
        DeathTrigger.OnDeath -= DeathScene;
    }

    private void DeathScene()
    {
        SceneManager.LoadScene("Lose");
    }
}
