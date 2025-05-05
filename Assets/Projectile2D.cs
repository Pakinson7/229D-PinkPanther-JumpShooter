using UnityEngine;

public class Projectile2D : MonoBehaviour
{
    public Transform shootPoint;
    public Rigidbody2D bulletPrefab;
    public float fireRate = 0.5f;
    private float nextFireTime;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + fireRate;

            // แปลงตำแหน่งเมาส์เป็น world point
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos.z = 0;

            // คำนวณทิศทาง
            Vector2 direction = (mouseWorldPos - shootPoint.position).normalized;

            // ยิง
            Rigidbody2D bullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
            bullet.linearVelocity = direction * 10f; // ปรับความเร็วได้
        }
    }
}
