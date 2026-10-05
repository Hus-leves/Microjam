using UnityEngine;

public class Bulletscript : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameObject player;
    private Vector3 mousePosition;
    public Vector2 direction;
    public float bulletSpeed = 10;

    void Start()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody2D>();
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");
        LocateMouse();
        rb.linearVelocity = direction * bulletSpeed;
    }
    void LocateMouse()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        direction = (mousePosition - transform.position).normalized;
    }
}
