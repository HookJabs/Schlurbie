using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    Text Display = null;
    public float timeremaining = 10;
    public float TimePerLevel = 10;


    // Start is called before the first frame update
    void Start()
    {
        Display = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeremaining = timeremaining - Time.deltaTime;

        Display.text = timeremaining.ToString("F2");
    }
}
