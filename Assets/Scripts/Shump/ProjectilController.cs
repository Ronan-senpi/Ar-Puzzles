﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilController : MonoBehaviour
{
    [SerializeField]
    protected float speed = 20f;
    protected float lifeTime = 2.5f;
    protected float passedTime = 0;
    Camera cam;
    private void Start()
    {
        cam = Camera.main;
    }
    private void Update()
    {
        passedTime += Time.deltaTime;
        transform.position += cam.transform.forward * speed * Time.deltaTime;
        if (passedTime >= lifeTime)
        {
            Destroy(gameObject);
        }
    }

}
