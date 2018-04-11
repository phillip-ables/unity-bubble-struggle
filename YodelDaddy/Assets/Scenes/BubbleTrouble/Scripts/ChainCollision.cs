using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainCollision : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");
        Chain.IsFired = false;

        if (collision.tag == "Ball")
        {
            collision.GetComponent<Ball>().Split();
        }

    }
}
