using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 1f;
    private float nextFireTime;

    public Transform player; // 👈 อ้างอิงผู้เล่น

    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            ShootAtPlayer();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    void ShootAtPlayer()
    {
        if (player == null) return;

        // ✅ คำนวณทิศทางไปยังผู้เล่น
        Vector2 direction = (player.position - firePoint.position).normalized;

        // ✅ สร้างกระสุน
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.linearVelocity = direction * 5f;
    }
}
