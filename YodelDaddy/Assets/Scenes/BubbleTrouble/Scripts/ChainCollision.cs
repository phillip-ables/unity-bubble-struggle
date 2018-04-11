using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainCollision : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        Chain.IsFired = false;

        if(collision.collider.tag == "ball")
        {
            collision.collider.GetComponent<Ball>().Split();
        }

    }
}
