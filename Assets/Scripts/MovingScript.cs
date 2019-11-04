using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float heightt = 91;
    private Vector3 PlatformMove;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 5, 10) + heightt, transform.position.z);
    }
}
