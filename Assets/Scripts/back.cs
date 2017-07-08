using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{
    private GameObject helpLabel;
    // Use this for initialization
    void Start()
    {
        helpLabel = GameObject.Find("help");
        helpLabel.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {


        helpLabel.SetActive(false);


    }

}
