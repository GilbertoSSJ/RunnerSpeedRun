using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_Generation : MonoBehaviour
{
    public GameObject Stage;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Stage, new Vector3(-60.99654f,  -89.3436f, -21.06673f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
