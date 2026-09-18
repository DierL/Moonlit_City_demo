using UnityEngine;

public class Shooter : EnemyBase
{
    [Header("Shooter Attack")]

    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private float attackCooldown = 1f;

    private float attackTimer = 0f;

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Attack()
    {
        base.Attack();

        if (player == null)
            return;

        if (currentState != EnemyState.Attack)
            return;

        attackTimer -= Time.deltaTime;

        if (attackTimer > 0f)
            return;

        Shoot();

        attackTimer = attackCooldown;
    }

    private void Shoot()
    {
        Vector2 direction =
            (player.position - transform.position).normalized;

        GameObject bullet =
            Instantiate(
                bulletPrefab,
                transform.position,
                Quaternion.identity
            );

        EnemyBullet enemyBullet =
            bullet.GetComponent<EnemyBullet>();

        enemyBullet.SetDirection(direction);

        Debug.Log($"{name} : Shoot!");
    }
}