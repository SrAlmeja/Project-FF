using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject myObjects;
    public float spawntime;
    //public float dificult;
    public float elapsedTime;
    public float zDistance1, zDistance2;
    [SerializeField] floatVariable dificult;
    [SerializeField] private float easy, medium, hard;

    void Awake()
    {
        dificult.Value = 0;
    }

    void Update()
    {
        
        Spawn();
        elapsedTime += Time.deltaTime;
        dificult.Value = (elapsedTime/10);
        
    }
    
    public void Spawn()
    {
        if (dificult.Value >= easy)
        {
            dificult.Value = -0.009f;
        }
        if (elapsedTime >= dificult.Value)
        {
            GameObject newMyObjects = Instantiate(myObjects);
            newMyObjects.transform.position = transform.position + new Vector3(Random.Range(-1, 2), 0, Random.Range(zDistance1, zDistance2));
            elapsedTime = 0;
            DestroyObject(newMyObjects, 20);
        }
    }
 
}
