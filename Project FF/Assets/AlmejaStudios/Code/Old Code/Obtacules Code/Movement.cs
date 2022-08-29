using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject myObjects;
    [SerializeField] floatVariable speed;

    // Update is called once per frame
    void Update()
    {
        Move();
        speed.Value += 0.00009f;

    }

    public void Move()
    {
        transform.position += (Vector3.back * (speed.Value)) * Time.deltaTime;
    }

}
