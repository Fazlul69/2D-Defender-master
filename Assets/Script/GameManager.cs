using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject spawnObj;
    public int enemyInScene;
    public int spawnRate;
    public float spawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        spawnRate = 8;
        spawnDelay = 0.7f;
      
        StartCoroutine(spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public IEnumerator spawn() {
        if (enemyInScene < 8) {

            for(int i =0; i<spawnRate; i++)
            {
                GameObject newEnemy = Instantiate(enemies[0]);
                newEnemy.transform.position = spawnObj.transform.position;
                enemyInScene += 1;
                yield return new WaitForSeconds(spawnDelay);
            }
            StartCoroutine(spawn());
        }
        
    }
}
