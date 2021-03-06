﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Text))]
public class StarDisplay : MonoBehaviour
{

    private Text starText;
    public int stars;
    public enum Status { SUCCESS, FAILURE };

    // Use this for initialization
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }

    public Status UseStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
            return Status.SUCCESS;
        }

        else
        {
            Debug.LogWarning("No stars left");
                return Status.FAILURE;
        }
    }

    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

}
