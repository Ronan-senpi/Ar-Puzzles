using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonolitController : MonoBehaviour
{
    [SerializeField]
    LayerMask shipLayer;
    [SerializeField]
    LayerMask meteorLayer;
    private void OnCollisionEnter(Collision collision)
    {
        if ((shipLayer.value & (1 << collision.gameObject.layer)) > 0)
        {
            ShipController sc;
            if (collision.gameObject.TryGetComponent<ShipController>(out sc))
            {
                sc.TakeDamage(1000000000);
            }
        }
        if ((meteorLayer.value & (1 << collision.gameObject.layer)) > 0)
        {
            MeteorController mc;
            if (collision.gameObject.TryGetComponent<MeteorController>(out mc))
            {
                mc.HitByProjectl();
            }
        }

    }
}
