using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTest : MonoBehaviour
{
    public GameObject[] pieces;
    // Start is called before the first frame update
    void Start()
    {
        //if (pieces == null)
        pieces = GameObject.FindGameObjectsWithTag("Piece");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
