using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1;
    public float speed = 40f;

    void Start()
    {
        transform.SetParent(null);
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Buscamos al enemigo
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy == null) enemy = other.GetComponentInParent<Enemy>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Debug.Log("¡Impacto en el enemigo!");
            Destroy(gameObject);
        }
        else if (!other.CompareTag("Player"))
        {
            // Si toca el suelo o paredes, se destruye
            Debug.Log("Bala chocó con: " + other.name);
            Destroy(gameObject);
        }
    }
}