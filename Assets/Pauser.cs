using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Pauser : MonoBehaviour
{
    public GameObject pauseScreen;
    private bool pauseactive = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void quit()
    {
        Application.Quit();
    }

    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            switch(pauseactive)
            {
                case true:
                    pauseScreen.SetActive(false);
                    pauseactive = false;
                    break;
                case false:
                    pauseactive = true;
                    pauseScreen.SetActive(true);
                    break;
            }
            
        }
    }
}
