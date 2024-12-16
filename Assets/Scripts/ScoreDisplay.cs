using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    // R�f�rences aux �l�ments UI
    public Text energyText;
    public Text collisionsText;
    public Text wallsText;

    // R�f�rence � ScoreManager
    private void Update()
    {
        // Met � jour les �l�ments UI avec les valeurs actuelles du ScoreManager
        energyText.text = "�nergie: " + ScoreManager.Instance.PlayerEnergy;
        collisionsText.text = "Collisions: " + ScoreManager.Instance.PlayerCollisions;
        wallsText.text = "Murs Restants: " + ScoreManager.Instance.RemainingWalls;
    }
}