using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int playerEnergy = 1000;
    private int playerCollisions = 0;
    private int remainingWalls = 10;

    public int PlayerEnergy
    {
        get { return playerEnergy; }
        set { playerEnergy = value; }
    }

    public int PlayerCollisions
    {
        get { return playerCollisions; }
        set { playerCollisions = value; }
    }

    public int RemainingWalls
    {
        get { return remainingWalls; }
        set { remainingWalls = value; }
    }

    public static ScoreManager Instance;

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

    // Méthode qui gère la collision avec un mur
    public void HandleCollision()
    {
        playerEnergy -= 100;  // Exemple de réduction d'énergie
        playerCollisions++;   // Incrémente les collisions
        remainingWalls--;     // Réduit les murs restants
    }

    // Méthode pour détruire un mur
    public void DestroyWall(GameObject wall)
    {
        // Vous pouvez appeler Destroy pour supprimer le mur de la scène
        Destroy(wall);
        remainingWalls--; // Décrémenter le nombre de murs restants
    }

    public int CalculateScore()
    {
        return (playerEnergy - playerCollisions) + remainingWalls;
    }
}