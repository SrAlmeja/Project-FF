using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(InutController))]
public class NewPlayerMovement : MonoBehaviour
{
    //Input call
    private InutController _inutController = null;
    
    // Movement Variables
    [SerializeField]private PlayerInput playerInput;
    private Vector3 inputVector;
    [SerializeField] public float speed = 0f;
    // Clamp Variables
    private float maxClampX;
    private float minClampX;
    private float maxClampZ;
    private float minClampZ;

    private void Awake()
    {
        _inutController = GetComponent<InutController>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector2 input = _inutController.MoveInput();
        
        transform.position += transform.right * input.x * speed * Time.deltaTime;
        transform.position += transform.forward * input.y * speed * Time.deltaTime;

    }
}
