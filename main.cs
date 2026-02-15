using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveX, moveY);

        rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);
    }

    void FixedUpdate()
    {
    }
}

public class Platform : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
    }
}

public class Enemy : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
    }
}

public class GameManager : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
    }
}