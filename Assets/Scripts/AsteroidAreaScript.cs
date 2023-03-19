using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidAreaScript : MonoBehaviour
{

    public GameObject[] spawner;
    public GameManager gameManager;
    public GameObject star;

    public void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        int rnd = Random.Range(0, 2);

        if(rnd == 1)
        {

            Instantiate(star, transform.position, transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            for(int i=0; i<spawner.Length; i++)
            {
             spawner[i].SetActive(true);
            }    
            
        
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            gameManager.SpawnAsteroidField();
        }
    }

}
