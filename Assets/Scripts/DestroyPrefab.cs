using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPrefab : MonoBehaviour
{
    public float tiempoDeVida = 10;

    public GameObject Muro;
    public GameObject Obstaculo;


    public Vector3 center;
    public Vector3 size;




    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, tiempoDeVida);


        //SpawnObtaculo();
        /*for (int i = 0; i <= 5; i++)
        {
            SpawnMuro();
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
      
    }

 
/*
    public void SpawnObtaculo()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), 0);

        Instantiate(Obstaculo, pos, Quaternion.identity);
    }

    public void SpawnMuro()
    {    
            Vector3 randomSpawnPositionMuro = new Vector3(Random.Range(-8 , 18),  ,Random.Range(-8, 18));
            Instantiate(Muro, randomSpawnPositionMuro, Quaternion.identity);
    }
*/
}
