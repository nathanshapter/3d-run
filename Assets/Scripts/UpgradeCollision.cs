using TMPro;
using UnityEngine;

public class UpgradeCollision : MonoBehaviour
{
   [SerializeField] TextMeshPro text;

    int upgradeNumber = 0;


    private void Start()
    {
        text.text = upgradeNumber.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("hen");
        if (collision.gameObject.CompareTag("Bullet"))
        {
            upgradeNumber++;
            text.text = upgradeNumber.ToString();
        }
    }
    

    
    
}
