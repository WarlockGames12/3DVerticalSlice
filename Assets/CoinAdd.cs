using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAdd : MonoBehaviour
{

    public AudioSource CoinSound;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //remove the coin
            Destroy(gameObject);
            CoinSound.Play();
            AvoidedTrainsScore.coinValue += 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

}
