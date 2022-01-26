using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [Header("GameObject Player")]
    public GameObject Player;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Player.transform.position = new Vector3(-12.74f, -8.6f, 17.3f);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Player.transform.position = new Vector3(-0.1400003f, -8.6f, 17.3f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Player.transform.position = new Vector3(10.86f, -8.6f, 17.3f);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Player.transform.position = new Vector3(-0.1400003f, -8.6f, 17.3f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Front")
        {
            AvoidedTrainsScore.avoidedTrainsValue = 0;
            SceneManager.LoadScene("SampleScene");
        }
    }
}
