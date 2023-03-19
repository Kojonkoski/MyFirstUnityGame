using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScipt : MonoBehaviour
{

    public float speed = 4f;
    public float timer;
    public float timeToTurn = 3f;

    // Start is called before the first frame update
    void Start()
    {
        int dir = Random.Range(0, 2);

        if (dir == 0)
        {
            speed = -speed;
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y);

        }

        else
        {
            speed = speed;
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        transform.position = transform.position + Vector3.right * speed * Time.deltaTime;

        // Use this if u want to obstacles change their directions with timer
        /*
        if (timer > timeToTurn)
        {
            speed = -speed;
            timer = 0f;

        }
        */
    }

    private void OnTriggerExit(Collider other)
    {
        speed = -speed;
    }

}
