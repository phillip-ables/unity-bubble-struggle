using UnityEngine;

public class Ball : MonoBehaviour {
    public Rigidbody2D rb;
    public Vector2 startSpeed;
	void Start () {
        rb.AddForce(startSpeed, ForceMode2D.Impulse);
	}
}
