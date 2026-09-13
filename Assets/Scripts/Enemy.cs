using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 3;
    public int scoreValue = 10;
    public float speed = 2f;
    public float attackRange = 1.5f;
    public float attackRate = 1.5f;
    private float nextAttack;
    private Transform player;

    void Start()
    {
        player = Camera.main.transform;
        
        // AUTO-CONFIGURACIÓN: Esto asegura que el enemigo pueda recibir balas
        if (GetComponent<Rigidbody>() == null)
        {
            Rigidbody rb = gameObject.AddComponent<Rigidbody>();
            rb.isKinematic = true; // Para que no se caiga al suelo, pero detecte choques
        }
    }

    void Update()
    {
        if (player == null || GameManager.instance.lives <= 0) return;

        float dist = Vector3.Distance(transform.position, player.position);

        if (dist > attackRange)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            direction.y = 0;
            transform.position += direction * speed * Time.deltaTime;
        }

        transform.LookAt(new Vector3(player.position.x, transform.position.y, player.position.z));

        if (dist <= attackRange + 0.5f && Time.time >= nextAttack)
        {
            Attack();
            nextAttack = Time.time + attackRate;
        }
    }

    void Attack()
    {
        if (GameManager.instance != null)
            GameManager.instance.LoseLife();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("¡Enemigo herido! Vida restante: " + health);
        
        if (health <= 0) Die();
    }

    void Die()
    {
        if (GameManager.instance != null)
            GameManager.instance.AddScore(scoreValue);
        
        Destroy(gameObject);
    }
}