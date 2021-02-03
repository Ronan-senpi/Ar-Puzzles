using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipBehaviour : MonoBehaviour
{
    [SerializeField] private List<Transform> shipParts = new List<Transform>();
    [SerializeField] private Vector3 globalDirection;
    [SerializeField] private float tolerance;
    [SerializeField] private float maxDistance;

    private bool isCompleted;

    // Start is called before the first frame update
    void Start()
    {
        isCompleted = false;   
    }

    // Update is called once per framez
    void Update()
    {
        Debug.Log(CheckPartsRotation());
        //if (CheckPartsRotation())
        //{
        //    isCompleted = true;
        //}
    }

    bool CheckPartsRotation()
    {
        for(int i = 0; i < shipParts.Count; i++)
        {
            //float angle = Vector3.Angle();
            //if()
            //{
            //    return false;
            //}
        }
        return true;
    }
}
