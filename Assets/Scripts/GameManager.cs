using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject AI;
    public GameObject Spawner;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawn), 1f, 10f);
    }
    void Spawn()
    {

        Instantiate(AI, transform.position, Quaternion.identity);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
