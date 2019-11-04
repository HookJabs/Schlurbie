using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutrorial2 : MonoBehaviour
{
    public GameObject tutorial;
    public Player Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Player.cameraLevel != 0)
        {
            tutorial.SetActive(false);
        }
    }
}
