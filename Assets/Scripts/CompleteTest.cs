using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteTest : MonoBehaviour
{
    [SerializeField] private GameObject new_object;
    [SerializeField] private ParticleSystem particles;
    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        //AudioManager.Instance.Play("Sparkle");
        Instantiate(particles, transform.position, transform.rotation);
        coroutine = WaitParticules(2.5f);
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator WaitParticules(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        AudioManager.Instance.Play("Victory");
        Instantiate(new_object, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
