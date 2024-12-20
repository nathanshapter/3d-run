using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) 

        {
            print("that shits real bro");
        }
    }
}
