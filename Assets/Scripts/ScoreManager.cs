using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	// Singleton
	public static ScoreManager Instance { get; private set; }

	// Variables pour le score
	private int playerEnergy = 1000;  // �nergie maximale du joueur
	private int playerCollisions = 0; // Nombre de collisions du joueur
	private int remainingWalls = 10;  // Nombre de murs restants

	// M�thode pour initialiser le singleton
	private void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
		else
		{
			Destroy(gameObject); // �vite qu'il y ait plus d'une instance
		}
	}

	// Getter et Setter pour l'�nergie
	public int PlayerEnergy
	{
		get { return playerEnergy; }
		set { playerEnergy = Mathf.Clamp(value, 0, 1000); } // Limite entre 0 et 1000
	}

	// Getter et Setter pour les collisions
	public int PlayerCollisions
	{
		get { return playerCollisions; }
		set { playerCollisions = Mathf.Max(0, value); } // Limite le nombre de collisions � 0 minimum
	}

	// Getter et Setter pour les murs restants
	public int RemainingWalls
	{
		get { return remainingWalls; }
		set { remainingWalls = Mathf.Max(0, value); } // Limite les murs restants � 0 minimum
	}

	// M�thode pour r�duire l'�nergie lors d'une collision
	public void ReduceEnergy(int amount)
	{
		PlayerEnergy -= amount;
	}

	// M�thode pour ajouter une collision
	public void AddCollision()
	{
		PlayerCollisions++;
	}

	// M�thode pour r�duire les murs restants
	public void RemoveWall()
	{
		RemainingWalls--;
	}

	// M�thode pour r�initialiser le score � la fin de la partie
	public void ResetScore()
	{
		PlayerEnergy = 1000;
		PlayerCollisions = 0;
		RemainingWalls = 10; // ou le nombre total de murs au d�but de la partie
	}
}