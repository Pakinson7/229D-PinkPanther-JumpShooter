using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public int damage = 1;
    public string targetTag = "Enemy"; // หรือ "Player" สำหรับกระสุนศัตรู

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(targetTag))
        {
            Health hp = other.GetComponent<Health>();
            if (hp != null)
            {
                hp.TakeDamage(damage);
                Destroy(gameObject); // ทำลายกระสุน
                Debug.Log($"{damage}");
            }
        }
    }
}
