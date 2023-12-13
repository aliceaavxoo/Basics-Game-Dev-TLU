using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public AudioClip destructionSFX;

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "PlayerProjectile")
        {
            AudioSource.PlayClipAtPoint(destructionSFX, Vector3.zero);

            Destroy(gameObject);

            Destroy(collision.gameObject);
        }
    }
}
