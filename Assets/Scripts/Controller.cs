using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Controller : MonoBehaviour
{

    [Header("Player")]
    public GameObject player;
    public float GRAVITY_ACCEL = -9.81f;
    public float gravitySpeedUpAmount = 2.0f;
    private Animator playerAnimator;

    [Space(10)]

    private short currentCell;

    [Header("Timer")]
    public int timePerLevel = 10;
    public float timeSpeedUpAmount = 2.5f;
    //public int timerCurrentTime = 0;
    private float timef;

    //Camera animation
    public Transform[] views;
    public float transitionSpeed;
    Transform currentView;
    




    private Rigidbody playerRB;

    public Vector3 gravityDirection;

    //private enum flipdir {left, right, up, down}; I've never used an enum, forgive me for what I am about to do with a string below:
    private string flipDir = "";


    // Start is called before the first frame update
    void Start()
    {
        currentCell = 0;
        playerRB = player.GetComponent<Rigidbody>();
        gravityDirection = new Vector3(0, 1, 0);
        playerAnimator = player.GetComponentInChildren<Animator>();
    }

    public void flipSprite(string dir)
    {
        Debug.Log(dir);
        playerAnimator.SetTrigger(dir);
    }


    // Update is called once per frame
    void Update()
    {
        //playerAnimator.
        //playerAnimator.ResetTrigger("FlipDown");
        //playerAnimator.ResetTrigger("FlipUp");
        //playerAnimator.ResetTrigger("FlipLeft");
        //playerAnimator.ResetTrigger("FlipRight");
        timef += Time.deltaTime;


        //gravity acts on schlurbie
        playerRB.AddForce(gravityDirection * GRAVITY_ACCEL, ForceMode.Force);

        

        //playerAnimator.Play("Idle");

        //if(playerAnimator.state)

        #region DirectionalMovement
        //up
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            //if the gravity is truely transitioning
            if (!gravityDirection.Equals(new Vector3(0, -1, 0)))
            {
                //player.transform.rotation = Quaternion.Euler(0, 0, 0);
                playerAnimator.SetTrigger("FlipDown");

                playerAnimator.ResetTrigger("FlipLeft");
                playerAnimator.ResetTrigger("FlipUp");
                playerAnimator.ResetTrigger("FlipRight");

                //flipDir = "up";
                // Debug.Log(flipDir);
                //player.transform.rotation = Quaternion.Euler(0, 0, 180);
            }
            gravityDirection = new Vector3(0, -1, 0);
            
        }
        //down
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            //if the gravity is truely transitioning
            if (!gravityDirection.Equals(new Vector3(0, 1, 0)))
            {
                //player.transform.rotation = Quaternion.Euler(0, 0, 180);
                //flipDir = "down";
                playerAnimator.SetTrigger("FlipUp");

                playerAnimator.ResetTrigger("FlipDown");
                playerAnimator.ResetTrigger("FlipLeft");
                playerAnimator.ResetTrigger("FlipRight");
                //playerAnimator.Play("Flippy");
            }
            gravityDirection = new Vector3(0, 1, 0);
        }
        //left
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            //if the gravity is truely transitioning
            if (!gravityDirection.Equals(new Vector3(1, 0, 0)))
            {
                playerAnimator.SetTrigger("FlipLeft");

                playerAnimator.ResetTrigger("FlipDown");
                playerAnimator.ResetTrigger("FlipUp");
                playerAnimator.ResetTrigger("FlipRight");
                //playerAnimator.Play("Flippy");
            }
            gravityDirection = new Vector3(1, 0, 0);
        }
        //right
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            //if the gravity is truely transitioning
            if(!gravityDirection.Equals(new Vector3(-1, 0, 0)))
            {
                playerAnimator.SetTrigger("FlipRight");

                playerAnimator.ResetTrigger("FlipDown");
                playerAnimator.ResetTrigger("FlipUp");
                playerAnimator.ResetTrigger("FlipLeft");
                //playerAnimator.Play("Flippy");
            }
            gravityDirection = new Vector3(-1, 0, 0);
        }
        #endregion

        currentView = views[player.GetComponent<Player>().cameraLevel];
    }

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);
    }

    //IEnumerator transitionCamera()
    //{

    //}
}
