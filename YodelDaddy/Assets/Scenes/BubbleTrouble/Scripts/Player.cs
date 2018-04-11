using UnityEngine;
using UnityEngine.SceneManagement;

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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ball")
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
