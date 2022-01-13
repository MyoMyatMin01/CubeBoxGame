using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    // Start is called before the first frame update
    public bool gameHasEnded = false;

    public void CompleteLevel () {
        completeLevelUI.SetActive(true);
    }

    public void EndGame () {
        if (gameHasEnded == false) {
            Invoke("Restart", 1f);
            gameHasEnded = true;
        }
    }

    void Restart () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
