using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderTrigger : MonoBehaviour
{
    [SerializeField] private Transform partToCheck;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == partToCheck.name)
        {
            SpaceshipBehaviour.Instance.NumberOfPartsOrdered++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == partToCheck.name)
        {
            SpaceshipBehaviour.Instance.NumberOfPartsOrdered--;
        }
    }
}
