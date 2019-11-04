using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatCodes : MonoBehaviour
{
    public Player player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("f1") && Input.GetKey("0"))
        {
            player.transform.position = new Vector3(829, 92, 0);
            player.spawnLocation = player.transform.position;
            player.spawnGravity = player.controller.gravityDirection;
            player.cameraLevel = 8;
        }
        if (Input.GetKey("f5") && Input.GetKey("0"))
        {
            player.transform.position = new Vector3(player.transform.position.x + 100, player.transform.position.y, player.transform.position.z);
            player.spawnLocation = player.transform.position;
            player.spawnGravity = player.controller.gravityDirection;
            player.cameraLevel += 1;
        }
    }
}
