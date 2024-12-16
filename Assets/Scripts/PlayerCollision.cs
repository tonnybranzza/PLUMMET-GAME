using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            ScoreManager.Instance.HandleCollision(); // Utilise la méthode HandleCollision
            Destroy(collision.gameObject); // Détruire le mur après collision
        }
    }

    private void Update()
    {
        // Exemple pour détecter si le joueur franchit la ligne d'arrivée
        if (Input.GetKeyDown(KeyCode.F)) // Simule un franchissement avec la touche F
        {
            ScoreManager.Instance.PlayerCrossedFinishLine();
        }
    }
}