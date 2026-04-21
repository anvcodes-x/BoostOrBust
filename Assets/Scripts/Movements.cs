using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movements : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] InputAction thrust;
    private void OnEnable()
    {
        thrust.Enable();
    }
    void Update()
    {
        if (thrust.IsPressed())
        {
            Debug.Log("Space is pressed");
        }
    }
}
