using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterWeapon : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform spawnPoint;
    private GameObject firedBullet;
    private Rigidbody2D rb;
    BlasterManager bm;
    // Start is called before the first frame update


    void Start()
    {
        bm = GetComponent<BlasterManager>();
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            onFire();
        }
    }
  
    public void onFire()
    {
        if (bm.isPickedUp()==true)
        {
            firedBullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
            rb = firedBullet.GetComponent<Rigidbody2D>();
            rb.AddForce(spawnPoint.up * 20, ForceMode2D.Impulse);
        }
    }

   
}
