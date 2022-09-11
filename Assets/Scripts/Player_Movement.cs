using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
  
    public Rigidbody rb;
    public Vector3 moveDirection;
    public GameObject Jugador;

    public Object Stage;

    public Patron velocidad;
    public DestroyPrefab TIEMPODEVIDA;

    public bool IsGrounded;

    // Start is called before the first frame update
    void Start()
    {
        velocidad = FindObjectOfType<Patron>();
        TIEMPODEVIDA = FindObjectOfType<DestroyPrefab>();

        IsGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        MovementCharacter();

    }

  public void MovementCharacter()
        
    {
        transform.Translate(moveDirection, Space.World);

        if (Input.GetKeyDown(KeyCode.A) && transform.position.x != -6)
        {
            transform.position += new Vector3(-6.0f, 0f, 0f);
            
        }

        if (Input.GetKeyDown(KeyCode.D) && transform.position.x != 6)
        {
            transform.position += new Vector3(6.0f, 0f, 0f);

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0f, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
        {
            transform.position += new Vector3(0f, 3f, 0f);
            IsGrounded = false;
        }

    }



    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Enemy"))
        {
            Destroy(Jugador);
        }

        if (collider.gameObject.CompareTag("generador")) //47f
        {
            
            moveDirection.z += 0.001f;  //0.01
            TIEMPODEVIDA.tiempoDeVida = 1f;
            Instantiate(Stage, new Vector3(-60.99654f, - 89.3436f, Jugador.transform.position.z), Quaternion.identity);
        }

    }

    /*private void OnTriggerStay(Collider other)
    {
        if (Collider.gameObject.CompareTag("Limite"))
        {
            Destroy(Jugador);
        }
    }*/

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = true;
        }
    }


    /*
       private void OnTriggerEnter(Collider other)
    {
        Destroy(Jugador);
    } 
     */
}
