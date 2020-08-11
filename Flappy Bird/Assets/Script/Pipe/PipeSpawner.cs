using System.Collections;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private Bird bird;
    [SerializeField] private Pipe pipeUp, pipeDown;
    [SerializeField] private float spawnInterval = 3f;
    [SerializeField] private GameObject point;
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject amountAdd;

    private float randPipeUp, randPipeDown;
    
    private Coroutine CR_Spawn;
    void Start()
    {
        StartSpawn();
    }

    void StartSpawn()
    {
        if(CR_Spawn == null)
        {
            CR_Spawn = StartCoroutine(IeSpawn());
        }
    }

    void StopSpawn()
    {
        if(CR_Spawn != null)
        {
           StopCoroutine(CR_Spawn);
        }
    }
    void SpawnPipe()
    {
        randPipeUp = Random.Range(2f, 7f);
        Pipe newPipeUp = Instantiate(pipeUp, new Vector2(12f, randPipeUp), Quaternion.Euler(0,0,180));
        newPipeUp.gameObject.SetActive(true);

        if(randPipeUp > 2 && randPipeUp < 3)
            randPipeDown = Random.Range(-7f, -6f);
        else if(randPipeUp > 3 && randPipeUp < 4)
            randPipeDown = Random.Range(-7f, -5f);
        else if (randPipeUp > 4 && randPipeUp < 5)
            randPipeDown = Random.Range(-7f, -4f);
        else if (randPipeUp > 5 && randPipeUp < 6)
            randPipeDown = Random.Range(-7f, -4f);
        else
            randPipeDown = Random.Range(-7f, -3f);
        Pipe newPipeDown = Instantiate(pipeDown, new Vector2(12f, randPipeDown), Quaternion.identity);
        newPipeDown.gameObject.SetActive(true);

        Instantiate(point, new Vector2(12f, randPipeDown), Quaternion.identity);

        if((randPipeUp > 5f && randPipeUp < 7f) && (randPipeDown > -7f && randPipeDown < -5f))
        {
            Instantiate(enemy, new Vector2(12f, 0), Quaternion.identity);
            Instantiate(amountAdd, new Vector2(12f, 0), Quaternion.identity);
            amountAdd.gameObject.SetActive(true);
            enemy.gameObject.SetActive(true);
        }
    }

    IEnumerator IeSpawn()
    {
        while (true)
        {
            if (bird.IsDead())
            {
                StopSpawn();
            }

            SpawnPipe();

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
