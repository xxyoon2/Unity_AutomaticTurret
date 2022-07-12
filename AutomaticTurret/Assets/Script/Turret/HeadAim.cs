using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadAim : MonoBehaviour
{
    private Turret _Turret;
    public Transform Player;

    void Start()
    {
        
    }

    void Update()
    {
        //transform.Rotate(0f, 0.5f, 0f);

        transform.LookAt(Player);
    }
}
