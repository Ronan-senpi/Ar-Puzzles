using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{
    float speedBase = 2.5f;
    float speedModifier = 2.5f;

    float courrentSpeed;

    float lifetime = 10.0f;
    public Vector3 direction;

    public void SetTarget(Transform spaceship)
    {
        transform.LookAt(spaceship);
        //direction = Vector3.MoveTowards(transform.position, spaceshipPostion, 0.001f).normalized;
    }
    // Start is called before the first frame update
    void Start()
    {
        this.courrentSpeed = Random.Range(speedBase - speedModifier, speedBase + speedModifier);
        StartCoroutine(Destroy());
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward*2);
        transform.position += transform.forward * courrentSpeed * Time.deltaTime;
    }
}
