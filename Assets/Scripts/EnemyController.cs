using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private new Rigidbody2D rigidbody;

    private SpriteRenderer sR;
    public Sprite[] enemySprites;

    private bool hasRestartedCollider;
    private PolygonCollider2D pCol;

    public enum EnemyType
    {
        Enemy1,
        Enemy2,
        Enemy3,
        Enemy4,
        Enemy5,
        Enemy6,
        Enemy7,
        Enemy8,
    }

    public EnemyType type;

    void Start()
    {
        sR = GetComponent<SpriteRenderer>();
        rigidbody = GetComponent<Rigidbody2D>();

        if(!pCol)
        {

        }
        else
        {
            pCol = GetComponent<PolygonCollider2D>();
        }
    }

    void Update()
    {
        switch (type)
        {
            case EnemyType.Enemy1:
                EnemyOne();
                break;

            case EnemyType.Enemy2:
                EnemyTwo();
                break;

            case EnemyType.Enemy3:
                EnemyThree();
                break;

            case EnemyType.Enemy4:
                EnemyFour();
                break;

            case EnemyType.Enemy5:
                EnemyFive();
                break;

            case EnemyType.Enemy6:
                EnemySix();
                break;

            case EnemyType.Enemy7:
                EnemySeven();
                break;

            case EnemyType.Enemy8:
                EnemyEight();
                break;
        }

        if(transform.position.y <= -6)
        {
            Destroy(gameObject);
        }
    }

    private void EnemyOne()
    {
        sR.sprite = enemySprites[0];

        if(!hasRestartedCollider)
        {
            ResetColliderComponent();
        }

        float moveSpeed = 1;
        rigidbody.velocity = new Vector2(rigidbody.velocity.x, -moveSpeed);
    }

    private void EnemyTwo()
    {
        sR.sprite = enemySprites[1];

        if (!hasRestartedCollider)
        {
            ResetColliderComponent();
        }

        float moveSpeed = 2;
        rigidbody.velocity = new Vector2(rigidbody.velocity.x, -moveSpeed);
    }

    private void EnemyThree()
    {
        sR.sprite = enemySprites[2];

        if (!hasRestartedCollider)
        {
            ResetColliderComponent();
        }

        float moveSpeed = 3;
        rigidbody.velocity = new Vector2(rigidbody.velocity.x, -moveSpeed);
    }

    private void EnemyFour()
    {
        sR.sprite = enemySprites[3];

        if (!hasRestartedCollider)
        {
            ResetColliderComponent();
        }

        float moveSpeed = 4;
        rigidbody.velocity = new Vector2(rigidbody.velocity.x, -moveSpeed);
    }

    private void EnemyFive()
    {
        sR.sprite = enemySprites[4];

        if (!hasRestartedCollider)
        {
            ResetColliderComponent();
        }

        float moveSpeed = 5;
        rigidbody.velocity = new Vector2(rigidbody.velocity.x, -moveSpeed);
    }

    private void EnemySix()
    {
        sR.sprite = enemySprites[5];

        if (!hasRestartedCollider)
        {
            ResetColliderComponent();
        }

        float moveSpeed = 6;
        rigidbody.velocity = new Vector2(rigidbody.velocity.x, -moveSpeed);
    }

    private void EnemySeven()
    {
        sR.sprite = enemySprites[6];

        if (!hasRestartedCollider)
        {
            ResetColliderComponent();
        }

        float moveSpeed = 7;
        rigidbody.velocity = new Vector2(rigidbody.velocity.x, -moveSpeed);
    }

    private void EnemyEight()
    {
        sR.sprite = enemySprites[7];

        if (!hasRestartedCollider)
        {
            ResetColliderComponent();
        }

        float moveSpeed = 8;
        rigidbody.velocity = new Vector2(rigidbody.velocity.x, -moveSpeed);
    }

    private void ResetColliderComponent()
    {
        Destroy(gameObject.GetComponent<PolygonCollider2D>());
        gameObject.AddComponent<PolygonCollider2D>();
        hasRestartedCollider = true;
    }
}
