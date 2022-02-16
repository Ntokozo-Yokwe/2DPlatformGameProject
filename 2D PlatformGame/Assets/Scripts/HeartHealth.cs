using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartHealth : MonoBehaviour
{

    private GameObject heart1; // Heart healthbar sprite 
    private GameObject heart2;
    private GameObject heart3;
    private GameObject heart4;
    private GameObject heart5;
    private GameObject heart6;

    int deathTally; // Int that talleys up the amount of times the player has collided and taken damage

    private void Awake()
    {
        heart1 = GameObject.Find("Heart1"); // Heart healthbar sprite
        heart2 = GameObject.Find("Heart2");
        heart3 = GameObject.Find("Heart3");
        heart4 = GameObject.Find("Heart4");
        heart5 = GameObject.Find("Heart5");
        heart6 = GameObject.Find("Heart6");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("TopDamage")) // Collision with object with the topdamage tag
        {
            Destroy(collision.gameObject);  // We destroy the object collided with
        }

        if (collision.collider.gameObject.CompareTag("Enemy"))  // Collision with object with the enemy tag
        {
            deathTally += 1; // Talleys up the amount of times the player has collided
        }

        if(deathTally == 1) // If the player collision is equal to the specified number, the Heart sprite specified below will be destroyed 
        {
            Destroy(heart1);
        }
        if (deathTally == 2)
        {
            Destroy(heart4);
        }
        if (deathTally == 3)
        {
            Destroy(heart2);
        }
        if (deathTally == 4)
        {
            Destroy(heart5);
        }
        if (deathTally == 5)
        {
            Destroy(heart3);
        }
        if (deathTally == 6)
        {
            Destroy(heart6);
        }

    }

}
