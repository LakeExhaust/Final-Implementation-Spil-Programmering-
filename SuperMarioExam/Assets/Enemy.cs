using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

 
   public GameObject player;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
       
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        OnMove();
    }

    public void OnMove()
    {
       if(player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
    
        
    
    
}
