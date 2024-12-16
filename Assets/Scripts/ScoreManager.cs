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

    // M�thode qui g�re la collision avec un mur
    public void HandleCollision()
    {
        playerEnergy -= 100;  // Exemple de r�duction d'�nergie
        playerCollisions++;   // Incr�mente les collisions
        remainingWalls--;     // R�duit les murs restants
    }

    // M�thode pour d�truire un mur
    public void DestroyWall(GameObject wall)
    {
        // Vous pouvez appeler Destroy pour supprimer le mur de la sc�ne
        Destroy(wall);
        remainingWalls--; // D�cr�menter le nombre de murs restants
    }

    public int CalculateScore()
    {
        return (playerEnergy - playerCollisions) + remainingWalls;
    }
}