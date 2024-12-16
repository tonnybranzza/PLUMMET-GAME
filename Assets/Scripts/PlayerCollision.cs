using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Quand le joueur entre en collision avec un objet
    private void OnCollisionEnter(Collision collision)
    {
        // Vérifier si le joueur entre en collision avec un mur
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Appeler la méthode HandleCollision pour gérer la collision
            ScoreManager.Instance.HandleCollision();

            // Appeler la méthode DestroyWall pour détruire le mur
            ScoreManager.Instance.DestroyWall(collision.gameObject);
        }
    }
}