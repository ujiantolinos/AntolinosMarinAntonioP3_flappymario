using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject tuberia;
    public float timeToInstantiate;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle",timeToInstantiate,timeToInstantiate);
    }

    // Update is called once per frame
    void CreateObstacle()
    {
        Instantiate(tuberia);
    }
}
