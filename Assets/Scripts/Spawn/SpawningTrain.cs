using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningTrain : MonoBehaviour
{

    [Header("Array of GameObjects and Transforms")]
    public GameObject[] RandomTrains;
    public Transform[] RandomTransform;


    [Header("Train Noises")]
    public AudioSource TrainNoice;

    [Header("Floats")]
    [SerializeField] private float LifeTime = 5f;

    [Header("Floats in coroutines")]
    private IEnumerator coroutine;

    private void Awake() => Invoke("TrainSpawn", LifeTime);

    // Start is called before the first frame update
    private void Start()
    {
        TrainsSpawn();
    }

    public void TrainsSpawn()
    {
        GameObject NewTrains = RandomTrains[Random.Range(0, RandomTrains.Length)];
        Transform Pingas = RandomTransform[Random.Range(0, RandomTransform.Length)];
        Quaternion spawnRotation = Quaternion.identity;
        Debug.Log(Pingas);

        //After you made the gameObject, transform and Quaternion, instantiate it with a GameObject so you can later destroy the instantiated gameobject if it goes behind the player
        GameObject DestroyTrain = Instantiate(NewTrains, Pingas.transform.position, spawnRotation) as GameObject;
        TrainNoice.Play();

        //Rotate the train
        if (NewTrains != null && NewTrains.name == "train karting" && RandomTransform[0] == Pingas)
        {
            RandomTrains[0].transform.position = RandomTransform[0].transform.position;
            DestroyTrain.transform.Rotate(0, 90, 0);
        }
        else if (NewTrains != null && NewTrains.name == "TrainWithWagons" && RandomTransform[0] == Pingas)
        {
            RandomTrains[1].transform.position = RandomTransform[0].transform.position;
            DestroyTrain.transform.Rotate(0, 180, 0);
        }
        else if (NewTrains != null && NewTrains.name == "Trains" && RandomTransform[0] == Pingas)
        {
            RandomTrains[2].transform.position = RandomTransform[0].transform.position;
            DestroyTrain.transform.Rotate(0, 0, 0);
        }
        else if (NewTrains != null && NewTrains.name == "train karting" && RandomTransform[1] == Pingas)
        {
            RandomTrains[0].transform.position = RandomTransform[1].transform.position;
            DestroyTrain.transform.Rotate(0, 90, 0);
        }
        else if (NewTrains != null && NewTrains.name == "TrainWithWagons" && RandomTransform[1] == Pingas)
        {
            RandomTrains[1].transform.position = RandomTransform[1].transform.position;
            DestroyTrain.transform.Rotate(0, 180, 0);
        }
        else if (NewTrains != null && NewTrains.name == "Trains" && RandomTransform[1] == Pingas)
        {
            RandomTrains[2].transform.position = RandomTransform[1].transform.position;
            DestroyTrain.transform.Rotate(0, 0, 0);
        }
        else if (NewTrains != null && NewTrains.name == "train karting" && RandomTransform[2] == Pingas)
        {
            RandomTrains[0].transform.position = RandomTransform[2].transform.position;
            DestroyTrain.transform.Rotate(0, 90, 0);
        }
        else if (NewTrains != null && NewTrains.name == "TrainWithWagons" && RandomTransform[2] == Pingas)
        {
            RandomTrains[1].transform.position = RandomTransform[2].transform.position;
            DestroyTrain.transform.Rotate(0, 180, 0);
        }
        else if (NewTrains != null && NewTrains.name == "Trains" && RandomTransform[2] == Pingas)
        {
            RandomTrains[2].transform.position = RandomTransform[2].transform.position;
            DestroyTrain.transform.Rotate(0, 0, 0);
        }

        //Wait for seconds after Train Karting (clone) comes up
        if (DestroyTrain != null && DestroyTrain.name == "train karting(Clone)")
        {
            if (RandomTransform[0] == Pingas && RandomTrains[0] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
            else if (RandomTransform[1] == Pingas && RandomTrains[0] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
            else if (RandomTransform[2] == Pingas && RandomTrains[0] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
            else if (RandomTransform[3] == Pingas && RandomTrains[0] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
        }

        //Wait for seconds after TrainWithWagons (clone) comes up
        else if (DestroyTrain != null && DestroyTrain.name == "TrainWithWagons(Clone)")
        {
            if (RandomTransform[0] == Pingas && RandomTrains[1] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
            else if (RandomTransform[1] == Pingas && RandomTrains[1] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
            else if (RandomTransform[2] == Pingas && RandomTrains[1] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
            else if (RandomTransform[3] == Pingas && RandomTrains[1] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
        }

        else if (DestroyTrain != null && DestroyTrain.name == "Trains(Clone)")
        {
            if (RandomTransform[0] == Pingas && RandomTrains[2] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
            else if (RandomTransform[1] == Pingas && RandomTrains[2] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
            else if (RandomTransform[2] == Pingas && RandomTrains[2] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
            else if (RandomTransform[3] == Pingas && RandomTrains[2] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
        }
    }

    public IEnumerator RandomTrains1()
    {
            yield return new WaitForSeconds(3f);
            TrainsSpawn();
    }
}
