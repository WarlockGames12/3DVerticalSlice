using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{

    [Header("Movement of the Train")]
    public float SpeedTrain = 30f;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * SpeedTrain * Time.deltaTime ;
        transform.position = new Vector3(transform.position.x, -11, transform.position.z);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "UnSpawn")
        {
            //this will destroy the train behind the player
            Destroy(gameObject);
        }
    }
}
