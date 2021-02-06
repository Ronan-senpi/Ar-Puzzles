using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    [Range(1, 10)]
    [SerializeField]
    int healPoints = 1;

    [SerializeField]
    GameObject deathExplosion;
    int currentHeal;

    private void Start()
    {
        currentHeal = healPoints;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHeal -= damageAmount;
        if (currentHeal <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        Instantiate(deathExplosion, transform.position, Quaternion.identity);
        AudioManager.Instance.Play("Explosion");
        Destroy(gameObject);
    }
}
