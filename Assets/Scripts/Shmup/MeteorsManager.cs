using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorsManager : MonoBehaviour
{
    [SerializeField]
    GameObject meteor;
    [SerializeField]
    float meteorSpawnTime = 1f;
    
    float passedTine = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        passedTine += Time.deltaTime;
        if (passedTine >= meteorSpawnTime)
        {
            passedTine = 0;
            SpawnMeteor();
        }
    }
    protected Vector3 GenerateRdmCoordinate(Vector3 origin, float minRadius, float maxRadius)
    {
        Vector3 rdmSphe = Random.insideUnitSphere;
        //rdmSphe.x += origin.x;
        //rdmSphe.y += origin.y;
        //rdmSphe.z += origin.z;
        var randomDirection = rdmSphe.normalized;

        float randomDistance = Random.Range(minRadius, maxRadius);

        var point = origin + randomDirection * randomDistance;

        return point;
    }
    protected void SpawnMeteor()
    {
        GameObject go = Instantiate(meteor, 
                                    GenerateRdmCoordinate(transform.position, 10.000001f, 10.000001f),
                                    Quaternion.LookRotation(transform.position));
        MeteorController mc = go.GetComponent<MeteorController>();
        mc.SetTarget(transform);
    }
}
