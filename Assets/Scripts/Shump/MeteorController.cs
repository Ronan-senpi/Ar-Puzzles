using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{
    [SerializeField]
    float speedBase = 2.5f;
    [SerializeField]
    float speedModifier = 2.5f;
    float currentSpeed;

    [SerializeField]
    float rotationBase = 50f;
    [SerializeField]
    float rotationModifier = 5f;
    float currentRotation;
    [SerializeField]
    float lifetime = 10.0f;
    [SerializeField]
    bool movable = true;

    Transform toRotate;
    public void SetTarget(Transform spaceship)
    {
        transform.LookAt(spaceship);
        //direction = Vector3.MoveTowards(transform.position, spaceshipPostion, 0.001f).normalized;
    }
    // Start is called before the first frame update
    void Start()
    {
        toRotate = transform.Find("Asteroid");
        this.currentSpeed = Random.Range(speedBase - speedModifier, speedBase + speedModifier);
        this.currentRotation = Random.Range(rotationBase - rotationModifier, rotationBase + rotationModifier);
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
        if (movable)
        {
            Debug.DrawRay(transform.position, transform.forward * 2);
            transform.position += transform.forward * currentSpeed * Time.deltaTime;
        }
        //Vector3 v = toRotate.rotation.eulerAngles;
        //v += Vector3.one * currentRotation * Time.deltaTime;
        toRotate.Rotate(Vector3.left * currentRotation * currentSpeed * Time.deltaTime);

        //transform.rotation =;
    }

    internal void HitByProjectl()
    {
        Destroy(gameObject);
    }
}
