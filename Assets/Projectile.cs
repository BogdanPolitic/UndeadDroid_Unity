using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public enum Direction
    {
        LEFT,
        RIGHT
    }
    public float speed;
    public Direction direction;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        /*rb.velocity = (direction == Direction.LEFT)
            ? speed * Time.deltaTime * Vector3.left
            : speed * Time.deltaTime * Vector3.right
            ;*/
        transform.position += (direction == Direction.LEFT)
            ? speed * Time.deltaTime * Vector3.left
            : speed * Time.deltaTime * Vector3.right
            ;
    }
}
