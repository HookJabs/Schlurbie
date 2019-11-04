using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossScript : MonoBehaviour
{

    public SideTracker left;
    public SideTracker Right;
    public SideTracker Up;
    public SideTracker Bottom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerDied()
    {
        left.Hit = false;
        Right.Hit = false;
        Up.Hit = false;
        Bottom.Hit = false;
        left.tag = "Untagged";
        Right.tag = "Untagged";
        Up.tag = "Untagged";
        Bottom.tag = "Untagged";
    }

    public void CheckWin()
    {
        Debug.Log("check win");
        if (left.Hit && Right.Hit && Up.Hit && Bottom.Hit)
        {
            Debug.Log("Winning");
            //You win!
            //roll credits later
            SceneManager.LoadScene("Credits");
            
        }
    }
}
