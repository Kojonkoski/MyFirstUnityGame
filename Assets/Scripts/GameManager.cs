using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int score;
    public static int hiScore = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hiScoreText;

    public GameObject[] asteroidFields;
    public GameObject player;

    public Animator fadeScreen;
    public float transitiontime = 2f;

    private void Start()
    {
        hiScore = PlayerPrefs.GetInt("HiScore");
        hiScoreText.text = hiScore.ToString();
        
    }

    public void StartGame()
    {
        StartCoroutine(LoadLevel(1));
    }

    public void Retry()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()    
    {
        StartCoroutine(LoadLevel(0));
    }

    public IEnumerator LoadLevel(int levelToLoad)
    {
        fadeScreen.SetTrigger("FadeOut");
        yield return new WaitForSeconds(transitiontime);
        SceneManager.LoadScene(levelToLoad);
    }
    public void AddScore ()
    {
        score += 10;
        scoreText.text = score.ToString();

        if(score > hiScore)
        {
            hiScore = score;
            hiScoreText.text = hiScore.ToString();
            PlayerPrefs.SetInt("HiScore", hiScore);
            PlayerPrefs.Save();
            


        }

    }
    public void ClearData()
        {
            PlayerPrefs.SetInt("HiScore", 0);
            hiScore = PlayerPrefs.GetInt("HiScore");
            hiScoreText.text = hiScore.ToString();
            PlayerPrefs.Save();

        }

    public void QuitGame()
    {
        Application.Quit();

    }

    

    public void SpawnAsteroidField()
    {
        int rnd = Random.Range(0, 4);
        Instantiate(asteroidFields[rnd], new Vector3(player.transform.position.x, player.transform.position.y+10, player.transform.position.z), player.transform.rotation);
    }

 

}
