using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCars : MonoBehaviour
{
    public float tmax = 1;
    public float tinicial = 0;
    public GameObject carEnemy;
    public float speed;

    void Start()
    {
        GameObject newCarEnemy = Instantiate(carEnemy);
        newCarEnemy.transform.position = transform.position = new Vector3(Random.Range(-1,1),0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (tinicial > tmax)
        {
            GameObject nuevoobst = Instantiate(carEnemy);
            nuevoobst.transform.position = transform.position + new Vector3(0,0,speed);
            tinicial = 0;
        }
        else
        {
            tinicial += Time.deltaTime;
        }
    }
}
