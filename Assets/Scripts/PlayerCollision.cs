using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            ScoreManager.Instance.HandleCollision(); // Utilise la m�thode HandleCollision
            Destroy(collision.gameObject); // D�truire le mur apr�s collision
        }
    }

    private void Update()
    {
        // Exemple pour d�tecter si le joueur franchit la ligne d'arriv�e
        if (Input.GetKeyDown(KeyCode.F)) // Simule un franchissement avec la touche F
        {
            ScoreManager.Instance.PlayerCrossedFinishLine();
        }
    }
}