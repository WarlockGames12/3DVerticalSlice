using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinMeter : MonoBehaviour
{

    [Header("Audio for Coins")]
    public AudioSource CoinSound;

    [Header("Strings and ints")]
    public static int coinValue = 0;
    public Text CoinText;

    // Start is called before the first frame update
    void Start()
    {
        CoinText = GetComponent<Text>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Coins")
        {
            CoinSound.Play();
            CoinText.text = "Coins: " + coinValue;
            Destroy(collision.gameObject);
        }
    }

}
