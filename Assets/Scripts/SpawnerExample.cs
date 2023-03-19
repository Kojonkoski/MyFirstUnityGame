using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerExample : MonoBehaviour
{

    public GameObject obstacle;
    public float spawnTimer = 3;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obstacle, transform.position, transform.rotation);
        // use this to make object spawning repeating
        //Invoke("Spawn",3);

    }


}
