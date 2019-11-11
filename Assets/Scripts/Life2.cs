using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public GameObject deathEffect;
    public GameObject lose;
    private Shake shake;
    // Update is called once per frame
    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }
    void Update()
    {
        if (health <= 0)
        {
            //Time.timeScale = 0;
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            lose.SetActive(true);
            Destroy(gameObject);
        }

    }
    public void TakeDamage(int damage)
    {
        shake.CamShake();
        FindObjectOfType<AudioManager1>().PlayDamageSound();
        health -= damage;
    }
}
