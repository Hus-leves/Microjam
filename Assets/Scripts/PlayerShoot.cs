using System.Collections;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public float coolDown = 0.5f;
    private bool canShoot = true;
        
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && canShoot)
        {
            StartCoroutine(Cooldown());
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
    IEnumerator Cooldown()
    {
        canShoot = false;
        yield return new WaitForSeconds(coolDown);
        canShoot = true;
    }
}
