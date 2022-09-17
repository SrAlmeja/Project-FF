using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerMovement : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right * speed;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left * speed;   
        }
    }
}
