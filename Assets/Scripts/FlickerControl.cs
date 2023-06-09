using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerControl : MonoBehaviour
{
   public bool isFlickering = false;
    public float timeDelay;
    void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(FlickeringLight());
        }
    }
    IEnumerator FlickeringLight()
    {
        isFlickering = true;
        this.gameObject.GetComponent<Light>().enabled = true;
        this.gameObject.GetComponent<MeshRenderer>().enabled = true;
        timeDelay = Random.Range(0f, 90f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = false;
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        timeDelay = Random.Range(1f, 2f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering= false;
    }
}
