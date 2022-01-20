using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    [Header("PauseMenu GameObject & Bool")]
    public GameObject PausingMenu;
    public bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        PausingMenu.SetActive(false);
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused == false)
            {
                PausingMenu.SetActive(true);
                isPaused = true;
            }
            else
            {
                PausingMenu.SetActive(false);
                isPaused = false;
            }

        }
    }

    public void PauseButton()
    {
        PausingMenu.SetActive(true);
        isPaused = true;
    }
}
