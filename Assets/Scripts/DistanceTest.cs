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
        float dist;
        if(pieces.Length>1){
            for(int i=0; i<pieces.Length-1; i++){
                for(int j=i+1; j<pieces.Length; j++){
                    dist = Vector3.Distance(pieces[i].transform.position, pieces[j].transform.position);
                    print("Distance to other: " + dist);
                }
            }
        }
    }
}
