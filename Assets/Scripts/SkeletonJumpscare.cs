using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SkeletonJumpscare : MonoBehaviour
{
    public bool jumpscareActive = false;

    public GameObject[] pumpkins;

    public AudioSource audio;
    public AudioClip explosion;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
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
            audio.PlayOneShot(explosion);
        }
    }

}
