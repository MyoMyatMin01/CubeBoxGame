using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter () {
        gameManager.CompleteLevel();
    }
}
