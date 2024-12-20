using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) 

        {
            Destroy(collision.gameObject);
            this.gameObject.SetActive(false);
        }
    }
}
