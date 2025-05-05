using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHP = 10;
    private int currentHP;
    private bool isDead = false;

    public Slider hpSlider; // ถ้ามี

    void Start()
    {
        currentHP = maxHP;
        if (hpSlider != null)
        {
            hpSlider.maxValue = maxHP;
            hpSlider.value = currentHP;
        }
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return; // ป้องกันซ้ำ

        currentHP -= damage;
        if (hpSlider != null)
            hpSlider.value = currentHP;

        if (currentHP <= 0)
        {
            isDead = true;
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject); // หรืออนิเมชัน ตาย
        SceneManager.LoadScene(1);
    }
}
