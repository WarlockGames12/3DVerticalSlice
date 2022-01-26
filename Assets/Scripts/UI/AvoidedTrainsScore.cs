using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvoidedTrainsScore : MonoBehaviour
{
    [Header("Avoided Trains")]
    public static int avoidedTrainsValue = 0;
    public Text score;

    void Start()
    {
        score = GameObject.Find("Text").GetComponent<Text>();
    }

    void Update()
    {
        score.text = "Meters: " + avoidedTrainsValue;
        avoidedTrainsValue += 1;
    }
}
