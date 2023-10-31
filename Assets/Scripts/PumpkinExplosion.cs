using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinExplosion : MonoBehaviour
{
    public SkeletonJumpscare Jumpscare;

    public GameObject jumpScareTrig;
    public GameObject skeleton;
    public Vector3 awayFromSkeleton;
    public bool activated = false;
    public float forcePower;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Jumpscare = jumpScareTrig.GetComponent<SkeletonJumpscare>();
        rb = GetComponent<Rigidbody>();
        awayFromSkeleton = (gameObject.transform.position - skeleton.transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        if (Jumpscare.jumpscareActive && !activated)
        {
            rb.AddForce(awayFromSkeleton * forcePower, ForceMode.Impulse);
            activated = true;

        }
    }
}
