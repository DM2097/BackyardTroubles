using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lives : MonoBehaviour {

    private Text liveText;
    public int Lives;
    void Start () {
        liveText = GetComponent<Text>();
        Updatelives();
	}
    public void Addlives(int count)
    {
        Lives -= count;
        if (Lives > 0)
        {
            Updatelives();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
    private void Updatelives()
    {
        liveText.text = Lives.ToString();
    }
}
