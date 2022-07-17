using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update

    //SerializeField = enables us to write to the field
    //Changing a value in the Unity inspector is a 'sticky' change, doesn't update this file?
    
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Slowing down...");
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Speed Up")
        {
            Debug.Log("Boost On!");
            moveSpeed = boostSpeed;
        }               
    }

    // Update is called once per frame
    // the addition of Time.deltaTime accounts for hardware differences
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
