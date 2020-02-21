using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public Sprite meteor;
    public new static CapsuleCollider2D collider;
    public GameObject[] meteors;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<CapsuleCollider2D>();
        System.Random r = new System.Random();
        int meteorDB = r.Next(10, 20);

        meteors = new GameObject[meteorDB];

        for (int i = 0; i < meteorDB; i++)
        {
            meteors[i] = new GameObject();
            meteors[i].AddComponent<SpriteRenderer>();
            meteors[i].GetComponent<SpriteRenderer>().sprite = meteor;
            meteors[i].GetComponent<SpriteRenderer>().sortingLayerName = "meteor";
            meteors[i].transform.position = new Vector3((float)r.NextDouble() * collider.size.x - (collider.size.x / 2), (float)r.NextDouble() * collider.size.y - (collider.size.y / 2), transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
