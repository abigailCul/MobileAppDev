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
    private float bulletSpeed = 6f;

    [SerializeField]
    private float firingRate = 0.4f;

    [SerializeField]
    private AudioClip shootClip;

    private GameObject bulletParent;

    // == private methods ==
    private void Start()
    {
        bulletParent = ParentUtils.FindBulletParent();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            InvokeRepeating(SHOOT_METHOD, 0f, firingRate);
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            CancelInvoke(SHOOT_METHOD);
        }
    }

    private void Shoot()
    {
        BulletScript bullet = Instantiate(bulletPrefab, bulletParent.transform);
        bullet.transform.position = transform.position;
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = Vector3.up * bulletSpeed;
       
    }

}
