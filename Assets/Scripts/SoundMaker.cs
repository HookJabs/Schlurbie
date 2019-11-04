using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMaker : MonoBehaviour
{
    public AudioClip[] splats;
    private AudioSource asrc;
    public AudioClip lvlOne;

    // Start is called before the first frame update
    void Start()
    {
        asrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playSplat()
    {
        Debug.Log("splat");
        int chosenSplat = (int)Random.Range(0, splats.Length);
        asrc.PlayOneShot(splats[chosenSplat]);
    }
}
