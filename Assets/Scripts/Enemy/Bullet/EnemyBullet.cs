using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;

    [SerializeField]
    private int damage = 1;

    [SerializeField]
    private float lifeTime = 3f;

    private Vector2 direction;

    private void Awake()
    {
        Destroy(gameObject, lifeTime);
    }

    public void SetDirection(Vector2 newDirection)
    {
        direction = newDirection.normalized;
    }

    private void Update()
    {
        transform.position +=
            (Vector3)(direction * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        PlayerHealth playerHealth =
            other.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}