using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float movementSpeed;
    public float rotationSpeed;
    public float runningSpeed;


    private CharacterController controller;

    static Animator animator;
    private bool isRunning;
    private float isWalking;

    RaycastHit hit;
    GameObject pickedUpObject;

    public float runMultiplier = 1;
    public float screamMultiplier = 20;
    public bool scream = false;
    public Slider slider;

    public bool berserker = false;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();


    }


    void Update()
    {
        //Movement
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed, 0);

        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = movementSpeed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);

        isWalking = Input.GetAxis("Horizontal");
        isWalking = Input.GetAxis("Vertical");

        //Running
        isRunning = Input.GetButton("Fire3");
        if (Input.GetButton("Fire3"))
        {
            animator.SetBool("isRunning", true);
            movementSpeed = runningSpeed;

            slider.value += (runMultiplier * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isRunning", false);
            movementSpeed = 2;
        }

        animator.SetBool("isRunning", isRunning);

        //Scream
        if (Input.GetButtonDown("Fire1") && !scream)
        {
            slider.value += screamMultiplier;
            scream = true;
            StartCoroutine("WaitBottomToBePressed");

        }

        //Berserker
        if (slider.value == 100)
        {
            berserker = true;

            movementSpeed = 8;

            transform.Rotate(0, Input.GetAxis("Vertical") * rotationSpeed, 0);

            forward = transform.TransformDirection(Vector3.forward);
            float currentSpeed = movementSpeed * Input.GetAxis("Horizontal");
            controller.SimpleMove(forward * curSpeed);

            transform.Translate(new Vector3(movementSpeed, 0) * Time.deltaTime);

            StartCoroutine("Berserker");
        }

            //Interaction with Raycast
        if (Input.GetKeyDown(KeyCode.E))
        {
                if (Physics.Raycast(transform.position, transform.forward, out hit, 100))
                {
                    if (hit.collider.gameObject.tag == "cube")
                    {
                        pickedUpObject = hit.collider.gameObject;
                        hit.collider.gameObject.transform.parent = transform;
                        hit.collider.gameObject.transform.position = transform.position - transform.forward;
                        print("Hit!");
                    }
                }
        }
        else
        {
               if(pickedUpObject != null)
               {
                pickedUpObject.transform.parent = null;
                pickedUpObject = null;
               }
        }
        
        forward = transform.TransformDirection(Vector3.forward) * 100;
        Debug.DrawLine(transform.position, forward, Color.magenta);

    
    }

    IEnumerator WaitBottomToBePressed()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            scream = false;
        }
    }

    IEnumerator Berserker()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f);
            berserker = false;
            slider.value = 0;
            break;
        }
    }
}

