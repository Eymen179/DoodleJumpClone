using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBounce : MonoBehaviour
{
    public float bouncePower;
    private Vector2 characterSpeed;
    private Rigidbody2D characterPhysics;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0)
        {
            characterPhysics = collision.collider.GetComponent<Rigidbody2D>();

            if (characterPhysics != null)
            {
                characterSpeed = characterPhysics.velocity;
                characterSpeed.y = bouncePower;
                characterPhysics.velocity = characterSpeed;
            }
        }
    }
}
