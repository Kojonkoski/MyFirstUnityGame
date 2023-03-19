using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraExample : MonoBehaviour
{
    public Transform target;
    public float camdelay = 1f;
    public float camset = 1f;
    public Camera[] cameras;
    public GameObject[] postEffects;
    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        cameras[1].enabled = false;
        cameras[2].enabled = false;

        postEffects[1].SetActive(false);
        postEffects[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(target.position, target.position, camdelay*Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.H))
        {
            DisableCameras();
            cameras[1].enabled = true;
            ui.SetActive(false);
            postEffects[1].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            DisableCameras();
            cameras[2].enabled = true;
            ui.SetActive(false);
            postEffects[2].SetActive(true);

        }

        if (Input.GetKeyDown(KeyCode.G))
        {

            DisableCameras();
            cameras[0].enabled = true;
            ui.SetActive(true);
            postEffects[0].SetActive(true);

        }

    }

    public void DisableCameras()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].enabled = false;
            postEffects[i].SetActive(false);
        }
    }
}
