using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private void OnEnable()
    {
        // Abonnez la méthode RestartGame à l'événement OnGameOver
        ScoreManager.OnGameOver += RestartGame;
    }

    private void OnDisable()
    {
        // Désabonnez la méthode pour éviter les références nulles
        ScoreManager.OnGameOver -= RestartGame;
    }

    private void RestartGame()
    {
        Debug.Log("Restarting Game...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Recharge la scène actuelle
    }
}