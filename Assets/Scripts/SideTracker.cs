using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideTracker : MonoBehaviour
{
    private BossScript boss;
    public bool Hit = false;
    // Start is called before the first frame update
    void Start()
    {
        boss = GetComponentInParent<BossScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Hit = true;
            //this.tag = "DIE";
            boss.CheckWin();
        }
    }
}
