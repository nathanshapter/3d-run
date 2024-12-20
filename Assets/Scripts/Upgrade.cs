using UnityEngine;

public class Upgrade : MonoBehaviour
{
    [SerializeField] private Vector3 direction = new Vector3(0, 0, 1);
    [SerializeField] private float speed = 5f;

    [SerializeField] GameObject leftUpgrade, rightUpgrade;


    void Update()
    {

        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
