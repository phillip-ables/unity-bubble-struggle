using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainCollision : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        Chain.IsFired = false;

        if(collision.collider.tag == "Ball")
        {
            Debug.Log("It totally should work");
            collision.collider.GetComponent<Ball>().Split();
        }

    }
}
