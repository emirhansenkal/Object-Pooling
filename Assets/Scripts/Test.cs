using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float spawnInterval = 1;

    [SerializeField] private ObjectPool objectPool = null;
    void Start()
    {
        StartCoroutine(nameof(SpawnRoutine));
    }

    private IEnumerator SpawnRoutine()
    {
        int counter = 0;
        while (true)
        {

           GameObject obj = objectPool.GetPooledObject(counter++ % 2);
           obj.transform.position = Vector3.zero;
            
            yield return  new WaitForSeconds(spawnInterval);
        }
    }

}
