using UnityEngine;

public class Ball : MonoBehaviour {
    public GameObject nextBall;
    public Rigidbody2D rb;
    public Vector2 startSpeed;
	void Start () {
        rb.AddForce(startSpeed, ForceMode2D.Impulse);
	}
    public void Split()
    {
        if(nextBall != null)
        {
            GameObject ballRight = Instantiate(nextBall, rb.position + Vector2.right / 4, Quaternion.identity);
            GameObject ballLeft = Instantiate(nextBall, rb.position + Vector2.left / 4, Quaternion.identity);
        }

        Destroy(gameObject);
    }
}
