using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    private void OnEnable()
    {
        Finish.OnFinished += ReloadLevel;
        PlayerHealth.OnPlayerDied += ReloadLevel;
    }

    private void OnDisable()
    {
        Finish.OnFinished -= ReloadLevel;
        PlayerHealth.OnPlayerDied -= ReloadLevel;
    }

    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
