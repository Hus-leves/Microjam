using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemyscript : MonoBehaviour
{
    public float moveSpeed = 0.3f;
    private GameObject player;
    void Start()
    {
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate() 
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Bullet"))
        {
            Hits hits = GameObject.FindFirstObjectByType<Hits>();
            hits.HitTextUpdate();
            Destroy(hit.gameObject);
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            Hits hits = GameObject.FindFirstObjectByType<Hits>();
            hits.Save();
            SceneManager.LoadScene("Gameover");
        }
    }
}
