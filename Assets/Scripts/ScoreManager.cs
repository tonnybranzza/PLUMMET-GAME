using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public delegate void GameOverHandler();
    public static event GameOverHandler OnGameOver;

    public int PlayerEnergy { get; private set; } = 1000;
    public int PlayerCollisions { get; private set; } = 0;
    public int RemainingWalls { get; private set; } = 10;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void HandleCollision()
    {
        PlayerEnergy -= 100;
        PlayerCollisions++;
        RemainingWalls--;

        if (PlayerEnergy <= 0)
        {
            TriggerGameOver();
        }
    }

    public void PlayerCrossedFinishLine()
    {
        TriggerGameOver();
    }

    private void TriggerGameOver()
    {
        OnGameOver?.Invoke(); // Déclenche l'événement si un abonné existe
        Debug.Log("Game Over triggered!");
    }
}