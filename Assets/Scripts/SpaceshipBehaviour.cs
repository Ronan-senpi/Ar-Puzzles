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
    [SerializeField] private GameObject completeShip;
    [SerializeField] private List<Transform> shipParts = new List<Transform>();
    [SerializeField] private GameObject buttonLaunchScene;   
    [SerializeField] private float maxDistance;
    [SerializeField] private float toleranceRotation;
    private float angle;
    private float dist;
    public int numberOfPartsOrdered;
    public int NumberOfPartsOrdered
    {
        get { return numberOfPartsOrdered; }
        set { numberOfPartsOrdered = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        numberOfPartsOrdered = 0;
    }

    // Update is called once per framez
    void Update()
    {
        if (numberOfPartsOrdered < 0)
            numberOfPartsOrdered = 0;

        if(numberOfPartsOrdered >= 2 && CheckPartsRotation() && CheckDistance())
        {
            PuzzleVictory();
        }
    }

    bool CheckPartsRotation()
    {
        for (int i = 0; i < shipParts.Count; i++)
        {
            angle = Vector3.Angle(Vector3.forward, -shipParts[i].up);
            Debug.Log("Angle : " + angle);
            if(!(angle >= 0 - toleranceRotation && angle <= 0 + toleranceRotation))
            {
                return false;
            }
        }
        return true;
    }

    bool CheckDistance()
    {
        if (shipParts.Count > 1)
        {
            for (int i = 0; i < shipParts.Count - 1; i++)
            {
                for (int j = i + 1; j < shipParts.Count; j++)
                {
                    dist = Vector3.Distance(shipParts[i].transform.position, shipParts[j].transform.position);
                    Debug.Log("Distance : " + dist);
                    if(dist > maxDistance)
                    {
                        return false;
                    }
                }
            }
        }
        return true;
    }

    void PuzzleVictory()
    {
        AudioManager.Instance.Play("Victory");
        completeShip.SetActive(true);
        buttonLaunchScene.SetActive(true);
        for(int i = 0; i < shipParts.Count; i++)
        {
            shipParts[i].gameObject.SetActive(false);
        }
    }

    public void DecrementNumberOfPartsOrdered()
    {
        numberOfPartsOrdered--;
    }
}