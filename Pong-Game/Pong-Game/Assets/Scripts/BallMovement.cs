using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 8f;

    void Start()
    {
        float x = Random.value > 0.5f ? 1 : -1; // Random left or right start
        float y = Random.Range(-1f, 1f);        // Random up or down angle
        GetComponent<Rigidbody2D>().velocity = new Vector2(x * speed, y * speed);
    }

    void Update()
    {
        if (transform.position.x < -10 || transform.position.x > 10)
        {
            transform.position = Vector2.zero;  // Reset to center
            float x = Random.value > 0.5f ? 1 : -1;
            float y = Random.Range(-3f, 3f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(x * speed, y);  // New random direction
        }
    }
}