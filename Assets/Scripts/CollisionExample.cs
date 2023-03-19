using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CollisionExample : MonoBehaviour
{
    public GameObject retryButton;
    public GameObject expolsion;
    public GameObject expolsion2;
    public GameObject quitButton;
    public Animator cameraAnim;
 
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Capsule")        
        {
            StartCoroutine(HitStop());
        }
    }

    public IEnumerator HitStop()
    {
        Instantiate(expolsion2, transform.position, transform.rotation);
        Time.timeScale = 0.1f;
        yield return new WaitForSecondsRealtime(0.25f);
        Time.timeScale = 1f;
        Instantiate(expolsion, transform.position, transform.rotation);
        cameraAnim.SetTrigger("Shake");
        GameObject.Find("Rocket").SetActive(false);
        GameObject.Find("ThrusterEffect").SetActive(false);
        yield return new WaitForSeconds(1f);
        retryButton.SetActive(true);
        quitButton.SetActive(true);
        Destroy(gameObject);

    }


}
