using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
   [SerializeField] Transform[] spawnPoints;


   [SerializeField] GameObject enemyCube;

  [SerializeField]  private GameObject[] enemyCubePool;
    [SerializeField] int spawnCount;


    private void Start()
    {
        enemyCubePool = new GameObject[spawnCount];


        for (int i = 0; i < spawnCount; i++)
        {
            GameObject o = Instantiate(enemyCube, spawnPoints[ChooseSpawnParent()]);
            o.SetActive(false);
            enemyCubePool[i] = o;
        }
             StartCoroutine(ActivateCubes());   
    }

    int ChooseSpawnParent()
    {
        int i = Random.Range(0, spawnPoints.Length);
        return i;
    }

    private IEnumerator ActivateCubes()
    {
        yield return new WaitForSeconds(Random.Range(0.1f, 0.7f));

       int amountOfCubesToActivate = Random.Range(1, 4); // spawn between 1-3 of them

        


        for (int i = 0; i < amountOfCubesToActivate; i++)
        {
            int o = Random.Range(0, enemyCubePool.Length); 

            enemyCubePool[o].gameObject.SetActive(true);
            enemyCubePool[o].gameObject.transform.position = spawnPoints[ChooseSpawnParent()].transform.position;

            
        }


       StartCoroutine(ActivateCubes());


    }

}
