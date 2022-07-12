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

    void Update()
    {
        //transform.Rotate(0f, 0.5f, 0f);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            scriptOutput += Time.deltaTime;
            if(scriptOutput >= randomCount)
            {
                scriptOutput = 0.0f;
                randomCount = Random.Range(0.5f, 3f);

                GameObject bullet = Instantiate(BulletPrefab, transform);
                bullet.transform.LookAt(Player);
            }

            transform.LookAt(Player);
        }

    }
}
