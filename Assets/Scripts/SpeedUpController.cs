using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpController : MonoBehaviour
{
    public Collider ball;
    public float force;

    private float z;
    
    private void Start()
    {
        z = gameObject.transform.position.z;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other == ball && other.transform.position.z < z)
        {
            other.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        }
    }
}
