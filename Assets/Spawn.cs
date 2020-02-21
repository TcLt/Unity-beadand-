//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Spawn : MonoBehaviour
//{
//    // Start is called before the first frame update
//    //Array of objects to spawn
//    public GameObject[] theGoodies;
//    GameObject goods;

//    //Time it takes to spawn theGoodies
//    [Space(3)]
//    public float waitingForNextSpawn = 10;
//    public float theCountdown = 10;

//    // the range of X
//    [Header("X Spawn Range")]
//    public float xMin;
//    public float xMax;

//    // the range of y
//    [Header("Y Spawn Range")]
//    public float yMin;
//    public float yMax;


//    void Start()
//    {
//        // goods now represents the random object within the array
//        goods = theGoodies[Random.Range(0, theGoodies.Length)];
//    }



//    public void Update()
//    {
//        // timer to spawn the next goodie Object
//        theCountdown -= Time.deltaTime;
//        if (theCountdown <= 0)
//        {
//            SpawnGoodies();
//            theCountdown = waitingForNextSpawn;
//        }
//    }


//    void SpawnGoodies()
//    {
//        // Defines the min and max ranges for x and y
//        Vector2 pos = new Vector2(Random.Range(-11f, 11f), Random.Range(-6.8f, 6.8f));

//        // Creates the random object at the random 2D position.
//        Instantiate(goods, pos);
//    }

//}
