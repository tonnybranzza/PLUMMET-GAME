using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private void OnEnable()
    {
        // Abonnez la m�thode RestartGame � l'�v�nement OnGameOver
        ScoreManager.OnGameOver += RestartGame;
    }

    private void OnDisable()
    {
        // D�sabonnez la m�thode pour �viter les r�f�rences nulles
        ScoreManager.OnGameOver -= RestartGame;
    }

    private void RestartGame()
    {
        Debug.Log("Restarting Game...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Recharge la sc�ne actuelle
    }
}