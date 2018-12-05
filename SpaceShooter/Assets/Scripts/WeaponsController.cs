using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities;

public class WeaponsController : MonoBehaviour
{
    // need bullet prefab, firing rate, bullet speed, 
    // need a private gameobject as parent of bullets

    // == constants ==
    private const string SHOOT_METHOD = "Shoot";

    [SerializeField]
    private BulletScript bulletPrefab;

    [SerializeField]
    private float bulletSpeed;

    [SerializeField]
    private float firingRate = 0.5f;

    [SerializeField]
    private float nextfire = 0.0f;


    private GameObject bulletParent;
    public AudioSource audioBul;

    // == private methods ==
    private void Start()
    {
        bulletParent = ParentUtils.FindBulletParent();
      
    
    }

    private void Update()
    {
        //code to use with space key
        /* if(Input.GetKeyDown(KeyCode.Space))
         {
             InvokeRepeating(SHOOT_METHOD, 0f, firingRate);
         }
         if(Input.GetKeyUp(KeyCode.Space))
         {
             CancelInvoke(SHOOT_METHOD);
         }*/
        if (Time.time > nextfire)
        {
            nextfire = Time.time + firingRate;

            BulletScript bullet = Instantiate(bulletPrefab, bulletParent.transform);
            bullet.transform.position = transform.position;
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = Vector3.up * bulletSpeed;

            audioBul.Play();
            
        }
    }


}
