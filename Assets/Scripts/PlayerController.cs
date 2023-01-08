using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private new Rigidbody2D rigidbody;

    public Transform[] firePoints;
    public GameObject laserPrefab;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rigidbody.velocity = new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal"), rigidbody.velocity.y);
        rigidbody.velocity = new Vector2(rigidbody.velocity.x, moveSpeed * Input.GetAxisRaw("Vertical"));

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserPrefab, firePoints[0].position, Quaternion.identity);
        }
    }
}
