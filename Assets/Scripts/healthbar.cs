using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthbar : MonoBehaviour
{
    private int life;
    Vector3 localScale;
    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
        
        
    }

    // Update is called once per frame
    void Update()
    {
          
        life = (GameObject.FindGameObjectWithTag("Player1").GetComponent<Life>().getLife()/10);
        print(life);
        localScale.x = life;
        transform.localScale = localScale;
    }
}
