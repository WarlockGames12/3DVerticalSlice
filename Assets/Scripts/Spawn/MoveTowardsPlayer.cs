using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{

    [Header("Movement of the Train")]
    public float SpeedTrain = 30f;
    public bool Game = false; 

    // Start is called before the first frame update
    void Start()
    {
        Game = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * SpeedTrain * Time.deltaTime ;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "UnSpawn")
        {
            //this will destroy the train behind the player
            Destroy(gameObject);
            Game = true;
        }
    }
}
