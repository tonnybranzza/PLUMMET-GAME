using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	// Singleton
	public static ScoreManager Instance { get; private set; }

	// Variables pour le score
	private int playerEnergy = 1000;  // Énergie maximale du joueur
	private int playerCollisions = 0; // Nombre de collisions du joueur
	private int remainingWalls = 10;  // Nombre de murs restants

	// Méthode pour initialiser le singleton
	private void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
		else
		{
			Destroy(gameObject); // Évite qu'il y ait plus d'une instance
		}
	}

	// Getter et Setter pour l'énergie
	public int PlayerEnergy
	{
		get { return playerEnergy; }
		set { playerEnergy = Mathf.Clamp(value, 0, 1000); } // Limite entre 0 et 1000
	}

	// Getter et Setter pour les collisions
	public int PlayerCollisions
	{
		get { return playerCollisions; }
		set { playerCollisions = Mathf.Max(0, value); } // Limite le nombre de collisions à 0 minimum
	}

	// Getter et Setter pour les murs restants
	public int RemainingWalls
	{
		get { return remainingWalls; }
		set { remainingWalls = Mathf.Max(0, value); } // Limite les murs restants à 0 minimum
	}

	// Méthode pour réduire l'énergie lors d'une collision
	public void ReduceEnergy(int amount)
	{
		PlayerEnergy -= amount;
	}

	// Méthode pour ajouter une collision
	public void AddCollision()
	{
		PlayerCollisions++;
	}

	// Méthode pour réduire les murs restants
	public void RemoveWall()
	{
		RemainingWalls--;
	}

	// Méthode pour réinitialiser le score à la fin de la partie
	public void ResetScore()
	{
		PlayerEnergy = 1000;
		PlayerCollisions = 0;
		RemainingWalls = 10; // ou le nombre total de murs au début de la partie
	}
}