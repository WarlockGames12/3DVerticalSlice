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
    private int Transforms = 0;

    [Header("Floats in coroutines")]
    private IEnumerator coroutine;

    private void Awake() => Invoke("TrainSpawn", LifeTime);

    // Start is called before the first frame update
    private void Start()
    {
        coroutine = RandomTrains1();
        TrainsSpawn();
    }

   

    public void TrainsSpawn()
    {
        //Make gameobject, transform and a quaternion, so you can use it for a random spawner
        GameObject NewTrains = RandomTrains[Random.Range(0, RandomTrains.Length)];
        Transform Pingas = RandomTransform[Random.Range(0, RandomTransform.Length)];
        Quaternion spawnRotation = Quaternion.identity;
        Debug.Log(Pingas);

        //After you made the gameObject, transform and Quaternion, instantiate it with a GameObject so you can later destroy the instantiated gameobject if it goes behind the player
        GameObject DestroyTrain = Instantiate(NewTrains, Pingas.transform.position, spawnRotation) as GameObject;
        TrainNoice.Play();

        if (NewTrains != null && NewTrains.name == "train karting" && RandomTransform[0] == Pingas)
        {
            DestroyTrain.transform.Rotate(0, 90, 0);
        }
        if (NewTrains != null && NewTrains.name == "TrainWithWagons" && RandomTransform[0] == Pingas)
        {
            DestroyTrain.transform.Rotate(0, 180, 0);
        }
        if (NewTrains != null && NewTrains.name == "train karting" && RandomTransform[1] == Pingas)
        {
            DestroyTrain.transform.Rotate(0, 90, 0);
        }
        if (NewTrains != null && NewTrains.name == "TrainWithWagons" && RandomTransform[1] == Pingas)
        {
            DestroyTrain.transform.Rotate(0, 180, 0);
        }
        if (NewTrains != null && NewTrains.name == "train karting" && RandomTransform[2] == Pingas)
        {
            DestroyTrain.transform.Rotate(0, 90, 0);
        }
        if (NewTrains != null && NewTrains.name == "TrainWithWagons" && RandomTransform[2] == Pingas)
        {
            DestroyTrain.transform.Rotate(0, 180, 0);
        }

        

        if (DestroyTrain != null && DestroyTrain.name == "train karting(Clone)")
        {
            if (RandomTransform[0] == Pingas && RandomTrains[0] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
            if (RandomTransform[1] == Pingas && RandomTrains[0] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
            if (RandomTransform[2] == Pingas && RandomTrains[0] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
            if (RandomTransform[3] == Pingas && RandomTrains[0] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
        } 
        if (DestroyTrain != null && DestroyTrain.name == "TrainWithWagons(Clone)")
        {
            if (RandomTransform[0] == Pingas && RandomTrains[1] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
            if (RandomTransform[1] == Pingas && RandomTrains[1] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
            if (RandomTransform[2] == Pingas && RandomTrains[1] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
            if (RandomTransform[3] == Pingas && RandomTrains[1] == NewTrains)
            {
                StartCoroutine(RandomTrains1());
            }
        }
    }

    public IEnumerator RandomTrains1()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Start();
        }
    }

   

}
