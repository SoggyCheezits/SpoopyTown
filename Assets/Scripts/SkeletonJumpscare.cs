using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SkeletonJumpscare : MonoBehaviour
{
    public bool jumpscareActive = false;

    public GameObject[] pumpkins;
    // Start is called before the first frame update
    void Start()
    {
       pumpkins = GameObject.FindGameObjectsWithTag("Jumpscare");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            jumpscareActive = true;
        }
    }

}
