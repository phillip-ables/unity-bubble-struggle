using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 4;
    public Rigidbody2D rb;

    private float movement;

    void Update () {
        movement = Input.GetAxisRaw("Horizontal") * speed;  // I like it with deltaTime
	}

    void FixedUpdate()  // physics engine likes for us to update velocity in this
    {
        rb.MovePosition(rb.position + new Vector2 (movement * Time.fixedDeltaTime, 0f));
    }
}
