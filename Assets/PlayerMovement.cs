using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] Transform firePosition;

    [SerializeField] GameObject bullet;

    [SerializeField] private float speed = 5f; // Movement speed


    [SerializeField] private float xMin = -4.2f, xMax = 4.4f; 
    [SerializeField] private float zMin = -6f, zMax = 0f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
           
          GameObject o=  Instantiate(bullet,firePosition);

            o.transform.parent = null;
           
        }
       
        float horizontal = Input.GetAxis("Horizontal"); 
        float vertical = Input.GetAxis("Vertical"); 

       
        Vector3 movement = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;

        
        transform.Translate(movement);




        // Clamp the position to keep the player within specified bounds
        float clampedX = Mathf.Clamp(transform.position.x, xMin, xMax);
        float clampedZ = Mathf.Clamp(transform.position.z, zMin, zMax);

        // Apply the clamped position back to the player
        transform.position = new Vector3(clampedX, transform.position.y, clampedZ);
    }


   

}
