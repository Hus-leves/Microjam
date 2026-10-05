using UnityEngine;

public class PlayerCharacterMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }
    }
        
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            rb.linearVelocityX = -moveSpeed;
        else if (Input.GetKey(KeyCode.D))
            rb.linearVelocityX = moveSpeed;
        else
            rb.linearVelocityX = 0f;
        if (Input.GetKey(KeyCode.W))
            rb.linearVelocityY = moveSpeed;
        else if (Input.GetKey(KeyCode.S))
            rb.linearVelocityY = -moveSpeed;
        else
            rb.linearVelocityY = 0f;
    }
}
