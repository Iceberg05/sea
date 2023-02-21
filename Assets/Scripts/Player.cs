using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int foodGiven;


    private float horizontalMovement;
    private float verticalMovement;
    public float speed = 5.0f;
          public float drag;
    private Rigidbody rb;

    public bool foodtaken;

    [SerializeField] string food;

    void Start()
    {
        foodGiven = 5;
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");

                                                                                                                           //PC DE TEST AMAÇLI HAREKET KODU
        Vector3 movementDirection = transform.forward * verticalMovement + transform.right * horizontalMovement;

        rb.AddForce(movementDirection * speed, ForceMode.Force);
    
        rb.drag = drag;

    }

    void OnTriggerEnter(Collider collision)          
    {

        if (collision.gameObject.tag == "chicken")
        {
            food = "chicken";
            foodGiven = 0;
        }

        if (collision.gameObject.tag == "beer")
        {
            food = "beer";
            foodGiven = 1;
        }

        if (collision.gameObject.tag == "drumstick")
        {                                                          //fýrýnlara girince yemeði seçiyor
            food = "drumstick";
            foodGiven = 2;
        }

        if (collision.gameObject.tag == "wine")
        {
            food = "wine";
            foodGiven = 3;
        }

        if (collision.gameObject.tag == "beer")
        {
            food = "beef";
            foodGiven = 4;
        }

        }




    }




   
    


