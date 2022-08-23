using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{  
    public float playerSpeed;
    private float lDirecction = -1;
    private float rDireccionn = 1;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement ()
    {
            transform.Translate((playerSpeed*Time.deltaTime),0,0);
    }


}
