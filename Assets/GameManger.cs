using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{

    public AudioSource startSound;

    // Start is called before the first frame update
    void Start()
    {
        startSound.Play(0);
        startSound.Play(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
