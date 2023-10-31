using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinLights : MonoBehaviour
{
    public Light pumpkinLight;

    // Start is called before the first frame update
    void Start()
    {
        pumpkinLight = GetComponent<Light>();
        pumpkinLight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pumpkinLight.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pumpkinLight.enabled = false;
        }
    }
}
