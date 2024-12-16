using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Quand le joueur entre en collision avec un objet
    private void OnCollisionEnter(Collision collision)
    {
        // V�rifier si le joueur entre en collision avec un mur
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Appeler la m�thode HandleCollision pour g�rer la collision
            ScoreManager.Instance.HandleCollision();

            // Appeler la m�thode DestroyWall pour d�truire le mur
            ScoreManager.Instance.DestroyWall(collision.gameObject);
        }
    }
}