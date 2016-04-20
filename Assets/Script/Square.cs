using UnityEngine;
using System.Collections;

public class Square : MonoBehaviour
{

    public float speed = 1;
    public float rotateSpeed = 40;
    public int tSpawn = Random.Range(1, 5);
    public int spawnTInt = 0;

    //Public's of Game Obects

    public GameObject squareObj;
    public GameObject lShapeObj;
    public GameObject longObj;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {

        // Random rng = new Random();
        // theAnswer = rng.Next(1, 5);

        // Movement Left (Float Left)
        if (Input.GetKey("a"))
        {
            transform.Translate(speed * -1 * Time.deltaTime, 0, 0);
        }
        //Movement Right (Float Right)
        if (Input.GetKey("d"))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("left"))
        {
            transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 0, rotateSpeed * -1 * Time.deltaTime);
        }

        if (Input.GetKeyDown("space"))
        {
            speed = 0;
            rotateSpeed = 0;
            spawnTInt = 1;
        }
            //spawn Square
        if(spawnTInt == 1 && tSpawn == 1)
        {
           
        }
            //spawn LShape
        if (spawnTInt == 1 && tSpawn == 2)
        {

        }
             //spawn Long
        if (spawnTInt == 1 && tSpawn == 3)
        {

        }
             //spawn Long
        if (spawnTInt == 1 && tSpawn == 4)
        {

        }
    }


    
}

