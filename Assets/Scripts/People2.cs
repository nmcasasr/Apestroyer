using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People2 : MonoBehaviour
{

    public float speed;
    public float lifeTime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;

    public GameObject destroyEffect;

    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }

    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Player1"))
            {
                hitInfo.collider.GetComponent<Life>().TakeDamage(damage);

            }
            DestroyProjectile();
        }


        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void DestroyProjectile()
    {
        FindObjectOfType<AudioManager1>().PlayImpactSound();
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}