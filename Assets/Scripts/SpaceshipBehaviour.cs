using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipBehaviour : MonoBehaviour
{
    [SerializeField] private List<Transform> shipParts = new List<Transform>();
    [SerializeField] private float tolerance;
    private float angle;
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
            angle = Vector3.Angle(Vector3.forward, -shipParts[i].up);
            if(!(angle >= 0 - tolerance && angle <= 0 + tolerance))
            {
                return false;
            }
        }
        return true;
    }
}
