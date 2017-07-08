using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour {
    public bool paused;
    private GameObject pauseLabel;
    // Use this for initialization
    void Start () {
        paused = false;
        FindYouPause();
        pauseLabel.SetActive(false);
    }
    void FindYouPause()
    {
        pauseLabel = GameObject.Find("Panel");
        if (!pauseLabel)
        {
            Debug.LogWarning("Please create You pause object");
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
    void OnMouseDown()
    {
        paused = !paused;
        if(paused)
        {
            Time.timeScale = 0;
            pauseLabel.SetActive(true);

        }
        else if(!paused)
        {
            Time.timeScale = 1;
            pauseLabel.SetActive(false);
        }
    }
}
