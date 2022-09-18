using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InutController : MonoBehaviour
{
    [SerializeField] InputAction _moveInput = null;

    void OnEnable()
    {
        _moveInput.Enable();
    }

    void OnDisable()
    {
        _moveInput.Disable();
    }

    public Vector2 MoveInput()
    {
        return _moveInput.ReadValue<Vector2>();
}
}
