using UnityEngine;
using System.Collections;

public class LooseCollider : MonoBehaviour
{

    private LevelManager levelManager;
    private AudioSource audioSource;
    private int count;
    private lives liveDisplay;

    // Use this for initialization
    void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        audioSource = GameObject.FindObjectOfType<AudioSource>();
        liveDisplay = GameObject.FindObjectOfType<lives>();
    }

    void OnTriggerEnter2D()
    {
        liveDisplay.Addlives(1);
        count++;
        
        if (count >=3)
        {
            Destroy(audioSource);
            levelManager.LoadLevel("Lose");
        }
    }
}
