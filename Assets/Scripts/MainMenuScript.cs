using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public Animator mainMenuAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if(Input.anyKey)
        {
            mainMenuAnimator.SetTrigger("Begin");
        }
    }

    public void quit()
    {
        Application.Quit();
    }
}
