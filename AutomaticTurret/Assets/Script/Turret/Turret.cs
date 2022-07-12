using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Player;
    public float scriptOutput = 0.0f;
    public float randomTime = 0.0f;
    public float randomCount = 0.5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        scriptOutput += Time.deltaTime;
        if(scriptOutput >= randomCount)
        {
            scriptOutput = 0.0f;
            randomCount = Random.Range(0.5f, 3f);
            GameObject bullet = Instantiate(BulletPrefab, transform);
            bullet.transform.LookAt(Player);

        }
        
    }
}
