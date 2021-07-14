using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float launchVelocity = 2000f;

    AudioSource shootSound;

    private void Start()
    {
        shootSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shootSound.PlayOneShot(shootSound.clip);
            GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * launchVelocity);
            Destroy(newBullet, 3f);
        }
    }
}
