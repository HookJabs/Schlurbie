using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SoundMaker soundMaker;
    public Controller controller;

    private Collider playerCollider;

    public Vector3 spawnLocation;

    public Vector3 spawnGravity;

    public Camera camera;

    public int cameraLevel = 0;

    public Light light;

    public Timer timer = null;

    public BossScript boss = null;

    // Start is called before the first frame update
    void Start()
    {
        soundMaker = GameObject.FindGameObjectWithTag("SoundMaker").GetComponent<SoundMaker>();
        timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
        playerCollider = this.GetComponent<Collider>();
        spawnLocation = transform.position;
        spawnGravity = controller.gravityDirection;
        boss = GameObject.FindGameObjectWithTag("Boss").GetComponent<BossScript>();
    }

    // Update is called once per frame
    void Update()
    {

        //if(soundMaker == null)
        //{
        //    soundMaker = GameObject.FindGameObjectWithTag("SoundMaker").GetComponent<SoundMaker>();
        //}

        //if(timer == null)
        //{
        //    try
        //    {
        //        timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>(); 
        //    }
        //    catch (System.Exception e)
        //    {

        //    }
        //} else 
        if (timer.timeremaining <= 0)
        {
            KillScript();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "GOAL")
        {
            transform.position = new Vector3(transform.position.x + 100, transform.position.y, transform.position.z);
            spawnLocation = transform.position;
            spawnGravity = controller.gravityDirection;
            light.color = Random.ColorHSV();
            camera.backgroundColor = Random.ColorHSV();
            cameraLevel += 1;
            timer.timeremaining = 10;
        }

        if (other.tag == "GOALTWO")
        {
            transform.position = new Vector3(866, 86, 0);
            spawnLocation = transform.position;
            spawnGravity = controller.gravityDirection;
            light.color = Random.ColorHSV();
            camera.backgroundColor = Random.ColorHSV();
            camera.orthographicSize = 60f;
            cameraLevel += 1;
            timer.timeremaining = 999;
            timer.TimePerLevel = 999;
        }

        if (other.tag == "RESET_TIMER")
        {
            transform.position = new Vector3(transform.position.x + 4, transform.position.y, transform.position.z);
            spawnLocation = transform.position;
            spawnGravity = controller.gravityDirection;

            camera.transform.position = new Vector3(camera.transform.position.x + 100, camera.transform.position.y, camera.transform.position.z);
            //camera.backgroundColor = Random.ColorHSV();
            //camera.transform.rotation = new Vector3(camera.transform.rotation.x, camera.transform.position.y, camera.transform.position.z);
        }

        
        if(other.tag == "DIE")
        {
            KillScript();
        }

    }

    private void KillScript()
    {
        light.color = Random.ColorHSV();
        transform.position = spawnLocation;
        controller.gravityDirection = spawnGravity;
        timer.timeremaining = timer.TimePerLevel;
        if(boss != null)
        {
            boss.PlayerDied();
        }
  
    }

    private void OnCollisionEnter(Collision collision)
    {

        soundMaker.playSplat();


        if (collision.gameObject.tag == "DIE")
        {
            KillScript();
        }
    }
}
