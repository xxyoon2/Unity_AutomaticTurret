using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public void Die()
    {
        // 게임 오브젝트를 삭제
        gameObject.SetActive(false);
    }

    // 피격 입장
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            Die();
        }
    }
}
