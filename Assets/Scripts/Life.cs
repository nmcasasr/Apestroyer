using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public GameObject deathEffect;
    public GameObject lose;
    private Shake shake;
    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }
    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            //Time.timeScale = 0;
            Instantiate(deathEffect,transform.position,Quaternion.identity);
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
    public int getLife()
    {
        return health;
    }
}
