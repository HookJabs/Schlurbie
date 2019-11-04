using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pingpong : MonoBehaviour
{
    public int pingpongrange = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * 50, pingpongrange) + 850, 125, transform.position.z);
    }
}
