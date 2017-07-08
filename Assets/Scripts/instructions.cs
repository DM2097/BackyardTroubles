using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instructions : MonoBehaviour {
    public bool instruct;
    private GameObject instructLabel;
    // Use this for initialization
    void Start()
    {
        instruct = false;
        FindYouInstruct();
        instructLabel.SetActive(false);
    }
    void FindYouInstruct()
    {
        instructLabel = GameObject.Find("instructions");
        if (!instructLabel)
        {
            Debug.LogWarning("Please create You pause object");
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        instruct = !instruct;
        if (instruct)
        {
            
            Time.timeScale = 0;
            instructLabel.SetActive(true);


        }
        else if (!instruct)
        {
           
            Time.timeScale = 1;
            instructLabel.SetActive(false);

        }
    }
}
