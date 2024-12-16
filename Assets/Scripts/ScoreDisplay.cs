using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    // Références aux éléments UI
    public Text energyText;
    public Text collisionsText;
    public Text wallsText;

    // Référence à ScoreManager
    private void Update()
    {
        // Met à jour les éléments UI avec les valeurs actuelles du ScoreManager
        energyText.text = "Énergie: " + ScoreManager.Instance.PlayerEnergy;
        collisionsText.text = "Collisions: " + ScoreManager.Instance.PlayerCollisions;
        wallsText.text = "Murs Restants: " + ScoreManager.Instance.RemainingWalls;
    }
}