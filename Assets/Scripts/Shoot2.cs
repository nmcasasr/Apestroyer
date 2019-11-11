using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot2 : MonoBehaviour
{

    public float offset;

    public GameObject projectile;
    // public GameObject shotEffect;
    public Transform shootPoint;
    // public Animator camAnim;
    float timeToShoot = 0;
    bool shooting = false;
    private float timeBtwShots;
    public float startTimeBtwShots;
    void Start()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, -60);
    }
    private void Update()
    {

        //transform.rotation = Quaternion.Euler(0f,0f,-60);
        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, -60);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 60);
        }
        if (timeBtwShots <= 0)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {

                //Instantiate(shotEffect, shotPoint.position, Quaternion.identity);
                //Instantiate(shotPoint.position, Quaternion.identity);
                //camAnim.SetTrigger("shake");
                //Instantiate(projectile, shootPoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
                shooting = true;
            }
        }
        if (shooting)
        {
            timeToShoot += Time.deltaTime;
            if (timeToShoot > 0.3)
            {
                Instantiate(projectile, shootPoint.position, transform.rotation);
                shooting = false;
                timeToShoot = 0;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }


    }
}