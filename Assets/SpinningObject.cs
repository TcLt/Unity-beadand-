using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpinningObject : MonoBehaviour
{
    public float speedX = 0.0f;
    public float speedY = 1.0f;
    public float speedZ = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(speedX, speedY, speedZ);

    }
}
