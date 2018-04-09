using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 4;
    Rigidbody2D rb;

    public float movement;

    void Update () {
        movement = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;  // I like it with deltaTime
	}


}
