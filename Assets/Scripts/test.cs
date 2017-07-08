using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void testD(bool testc)
    { 
        if(testc==false)
        
        {
            Debug.LogWarning("Not a defender");
        }
    }
    public void testattackerinsite(bool testm)
    {
        if (testm == false)
        {
            Debug.LogWarning("no attacker in site");
        }
        else
        {
            Debug.LogWarning("attacker in site");
        }
    }
    public void checkattacker(bool testm)
    {
        if(testm==false)
        {
            Debug.LogWarning("No attacker ahead in lane");
        }
    }
    public void checkstars(bool tests)
    {
        if(tests==false)
        {
            Debug.LogWarning("No stars left");
        }
       
    }
}
