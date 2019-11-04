using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleGravity : MonoBehaviour
{

    public float particlespeed = 33f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ParticleSystem test = GetComponent<ParticleSystem>();
        var force = test.forceOverLifetime;
        var gravity = test.gravityModifier;
        force.enabled = true;
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            force.x = particlespeed;
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            force.x = -particlespeed;
        }
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            force.z = particlespeed;
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            force.z = -particlespeed;
        }


    }
}
