using UnityEngine;
using System.Collections;

public class SpawnT : MonoBehaviour
{
    //Spawn Ints
    private int tSpawn = 1;
    private int spawnTInt = 0;
    private int seconds = 0;
    public static int scoreInt = 1;

    //Game Object
    public GameObject squareObj;
    public GameObject lShapeObj;
    public GameObject longObj;


    // Use this for initialization
    void Start()
    {
        StartCoroutine(Counter());  
    }

    IEnumerator Counter()
    {
        print("3 Sec Remaining");
        yield return new WaitForSeconds(1);
        print("0 Sec Remaining");
        seconds = 1;
        StartCoroutine(Counter());
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space") && seconds == 1)
        {
            spawnTInt = 1;
            tSpawn = (Random.Range(1, 3));
            Debug.Log("NewT");
        }

        //spawn Square
        if (spawnTInt == 1 && tSpawn == 1)
        {
            Instantiate(squareObj, new Vector3(0, 4, 0), Quaternion.identity);
            spawnTInt = 0;
            seconds = 0;
            scoreInt++;
        }
        //spawn LShape
        if (spawnTInt == 1 && tSpawn == 2)
        {
            Instantiate(lShapeObj, new Vector3(0, 4, 0), Quaternion.identity);
            spawnTInt = 0;
            seconds = 0;
            scoreInt++;
        }
        //spawn Long
        if (spawnTInt == 1 && tSpawn == 3)
        {
            Instantiate(longObj, new Vector3(0, 4, 0), Quaternion.identity);
            spawnTInt = 0;
            seconds = 0;
            scoreInt++;  
        }

    }
}






