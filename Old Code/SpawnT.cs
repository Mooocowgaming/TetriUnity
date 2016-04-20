using UnityEngine;
using System.Collections;

public class SpawnT : MonoBehaviour
{
    //Spawn Ints
    private int tSpawn = 1;
    public int spawnTInt = 0;


    //Game Object
    public GameObject squareObj;
    public GameObject lShapeObj;
    public GameObject longObj;


    // Use this for initialization
    void Start() {
        
    }
    // Update is called once per frame
        void Update()
    {

            if (Input.GetKeyDown("space"))
            {
            spawnTInt = 1;
            tSpawn = (Random.Range(1, 4));
            Debug.Log("NewT");
            }
            //spawn Square
            if (spawnTInt == 1 && tSpawn == 1)
            {
                Instantiate(squareObj, new Vector3(0, 4, 0), Quaternion.identity);
                spawnTInt = 0;
            }
            //spawn LShape
            if (spawnTInt == 1 && tSpawn == 2)
            {
                Instantiate(lShapeObj, new Vector3(0, 4, 0), Quaternion.identity);
                spawnTInt = 0;

            }
            //spawn Long
            if (spawnTInt == 1 && tSpawn == 3)
            {
                Instantiate(longObj, new Vector3(0, 4, 0), Quaternion.identity);
                spawnTInt = 0;

            }
            //spawn Long
            if (spawnTInt == 1 && tSpawn == 4)
            {
                (GetComponent("Control") as MonoBehaviour).enabled = false;
            }

            }
        }

    



