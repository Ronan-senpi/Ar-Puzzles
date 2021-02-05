using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipBehaviour : MonoBehaviour
{
    private static SpaceshipBehaviour instance;
    public static SpaceshipBehaviour Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<SpaceshipBehaviour>();

            return instance;
        }
    }

    [SerializeField] private List<Transform> shipParts = new List<Transform>();
    [SerializeField] private float tolerance;
    private float angle;
    private bool isCompleted;
    private int numberOfPartsOrdered;
    public int NumberOfPartsOrdered
    {
        get { return numberOfPartsOrdered; }
        set { numberOfPartsOrdered = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        isCompleted = false;
        numberOfPartsOrdered = 0;
    }

    // Update is called once per framez
    void Update()
    {
        if(numberOfPartsOrdered >= 2 && CheckPartsRotation())
        {
            Debug.Log("It's Victory !");
        }
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

    bool CheckOrder()
    {
        return true;
    }
}
