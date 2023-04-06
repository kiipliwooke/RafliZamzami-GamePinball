using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier = 1;
    public Color color;

    private Renderer renderer;
    private Animator animator;
    
    private void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.color = color;
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider == bola)
        {
            Rigidbody bolaRigbod = bola.GetComponent<Rigidbody>();
            bolaRigbod.velocity *= multiplier;
            animator.SetTrigger("BallHit");
        }
    }
}
