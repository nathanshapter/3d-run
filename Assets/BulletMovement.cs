using System.Collections;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] private Vector3 direction = new Vector3(0, 0, 1);
    [SerializeField] private float speed = 5f;



    private void Start()
    {
        StartCoroutine(SelfDestruct());
    }
    void Update()
    {

        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }


    private IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }
}
