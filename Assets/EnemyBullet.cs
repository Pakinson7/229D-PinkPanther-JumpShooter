using UnityEngine;


public class EnemyBullet : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    public float force;
    void Start()
    {
        Destroy(gameObject, 5f); // ลบเองหลัง 5 วิ
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        Vector3 vector3 = player.transform.position - transform.position;
        Vector3 direction = vector3;
        rb.linearVelocity = new Vector2(direction.x, direction.y).normalized * force;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Hit!");
            Destroy(gameObject); // กระสุนหาย
        }

    }
}