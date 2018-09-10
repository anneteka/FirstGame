using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    private bool _rightDirection;

    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _rightDirection = true;
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector2.up * 8000);
        }

        if (moveX > 0 && !_rightDirection) flip();
        else if (moveX < 0 && _rightDirection) flip();
    }

    void flip()
    {
        _rightDirection = !_rightDirection;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, 0);
    }
}