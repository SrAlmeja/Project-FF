using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject myObjects;
    public float spawntime;
    //public float dificult;
    public float elapsedTime;
    public float zDistance1, zDistance2;
    [SerializeField] floatVariable Dificult;

    void Start()
    {
        Dificult.Value = 5;
    }

    void Update()
    {
        Spawn();
        elapsedTime += Time.deltaTime;
        Dificult.Value -= 0.0002f;
        
    }
    
    public void Spawn()
    {
        if (Dificult.Value <= -0.009f)
        {
            Dificult.Value = -0.009f;
        }
        if (elapsedTime >= Dificult.Value)
        {
            GameObject newMyObjects = Instantiate(myObjects);
            newMyObjects.transform.position = transform.position + new Vector3(Random.Range(-1, 2), 0, Random.Range(zDistance1, zDistance2));
            elapsedTime = 0;
            DestroyObject(newMyObjects, 20);
        }
    }
 
}
