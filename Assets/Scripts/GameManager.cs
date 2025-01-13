using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer;
    public int startingtime;
    public TMP_Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timer = startingtime;
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = timer.ToString("F2");

        if (timer<=0)
        {
            Debug.Log("Out of time.");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}

// perculiar...
