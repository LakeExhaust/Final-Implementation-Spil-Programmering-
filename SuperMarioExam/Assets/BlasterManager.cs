using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterManager : MonoBehaviour
{
    private PlayerController player;
    private bool hasPickedUp;

   

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            onPickUp();
        }
    }

    public void onPickUp()
    {
        hasPickedUp = true;
        Debug.Log("Player has picked up the blaster weapon");
        player.setAnim();
    }

    public bool isPickedUp()
    {
        return hasPickedUp;
    }



}
