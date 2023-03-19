using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    public AudioSource myAudio;
    public float thrustVolMax = 0.1f;
    public float thrustVolMin = 0.1f;
    public float soundTransitionTime = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        myAudio.volume = thrustVolMin;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            myAudio.volume = Mathf.Lerp(myAudio.volume,thrustVolMax,soundTransitionTime*Time.deltaTime);
        }
        else
        {
            myAudio.volume = Mathf.Lerp(myAudio.volume,thrustVolMin,soundTransitionTime*Time.deltaTime);

        }
    }
}
