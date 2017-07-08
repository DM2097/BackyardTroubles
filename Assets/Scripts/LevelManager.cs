using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;
    
    private void Start()
    {

        if (autoLoadNextLevelAfter <= 0)
        {
            
        }
        else
        {
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
        }
    }
    public void LoadLevel(string name)

	{
		Debug.Log ("load level requested" + name);
		Application.LoadLevel (name);
	}
	public void QuitRequest()
	{
		Debug.Log ("Quit level requested");
		Application.Quit ();
	}
	public void LoadNextLevel()
	{
		Application.LoadLevel (Application.loadedLevel + 1);
	}
}
