using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int diamonds = 0;                                      // Int that incriments showing the amount of diamonds collected

    [SerializeField] private Text diamondsText;                    // The diamond text displayed on the screen

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Diamonds"))  // Collision with object with the diamond tag
        {
            Destroy(collision.gameObject);                         // We destroy the object collided with  
            diamonds++;
            diamondsText.text = "Diamonds: " + diamonds;
        }
    }    

}
