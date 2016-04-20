using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour
{

    public float speed = 1;
    public float rotateSpeed = 40;

    //Public's of Game Obects



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    { 

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
            Debug.Log("Disabled");
        }
    }

}