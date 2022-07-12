using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool UP { get; private set; }
    public bool DOWN { get; private set; }
    public bool RIGHT { get; private set; }
    public bool LEFT { get; private set; }
    
    void Update()
    {
        UP = Input.GetKey(KeyCode.W);
        DOWN = Input.GetKey(KeyCode.S);
        RIGHT = Input.GetKey(KeyCode.A);
        LEFT = Input.GetKey(KeyCode.D);
    }
}
