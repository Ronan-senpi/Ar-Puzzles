using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorsManager : MonoBehaviour
{
    [SerializeField]
    GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Instantiate(go, GenerateRdmCoordinate(transform.position, 1.000001f, 1.000001f), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public Vector3 GenerateRdmCoordinate(Vector3 origin, float minRadius, float maxRadius)
    {
        Vector3 rdmSphe = Random.insideUnitSphere;
        rdmSphe.x += origin.x;
        rdmSphe.y += origin.y;
        rdmSphe.z += origin.z;
        var randomDirection = rdmSphe.normalized;

        float randomDistance = Random.Range(minRadius, maxRadius);

        var point = origin + randomDirection * randomDistance;

        return point;
    }

}
