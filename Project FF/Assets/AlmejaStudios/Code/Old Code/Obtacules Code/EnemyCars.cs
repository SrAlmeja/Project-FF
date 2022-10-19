using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCars : MonoBehaviour
{
    [SerializeField] float tmax = 1;
    [SerializeField] float tinicial = 0;
    [SerializeField] GameObject carEnemy;
    public float speed;

    void OnObjectSpawn()
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
