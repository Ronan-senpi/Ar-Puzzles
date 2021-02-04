using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    [SerializeField]
    protected GameObject projectil;
    [SerializeField]
    protected Transform instancatePosition;
    [Range(0.2f, 5f)]
    [SerializeField]
    protected float cooldown = 1;
    protected float passedTimeFromLastShoot;
    bool canShoot = true;
    // Start is called before the first frame update
    void Start()
    {
        passedTimeFromLastShoot = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (passedTimeFromLastShoot >= cooldown)
            canShoot = true;
        else
            passedTimeFromLastShoot += Time.deltaTime;

        if (canShoot && Input.GetButton("Fire1"))
        {
            passedTimeFromLastShoot = 0f;
            canShoot = false;
            GameObject p = Instantiate(projectil, instancatePosition.position, Quaternion.identity);
        }
    }
}
