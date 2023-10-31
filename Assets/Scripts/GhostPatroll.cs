using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPatroll : MonoBehaviour
{
    public GameObject[] patrollPoints;
    public float moveSpeed;
    public int point;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {

        point = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (point >= patrollPoints.Length)
        {
            point = 0;
        }

        GameObject currentPoint = patrollPoints[point];
        direction = (currentPoint.transform.position - gameObject.transform.position).normalized;
        transform.Translate(direction * Time.deltaTime * moveSpeed, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PatrollPoint"))
        {
            point += 1;
        }
    }
}
