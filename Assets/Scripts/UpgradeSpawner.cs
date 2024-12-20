using UnityEngine;

public class UpgradeSpawner : MonoBehaviour
{
    


    [SerializeField] GameObject upgrade;

    [SerializeField] Material menMat, speedMat, ammoMat;

    private void Start()
    {
        Instantiate(upgrade,this.transform);
    }
}
