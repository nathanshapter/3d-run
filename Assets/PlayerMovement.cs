using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] Transform firePosition;



    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("yo");
        }
    }
}
