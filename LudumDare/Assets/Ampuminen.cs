using UnityEngine;

public class Ampuminen : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float nuolenlähtovoima;


    void Awake ()
    {
        GameObject Cube = GameObject.Find("Cube");
        AseenVaihto aseenvaihto = Cube.GetComponent<AseenVaihto>();
        aseenvaihto.aseet = GameObject.Find("aseet").GetComponent<AseenVaihto>().aseet;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Tulta();
        }
    }


    void Tulta()
    {
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = new Vector3(0, 10, 0 * nuolenlähtovoima);

        Destroy(bullet, 2.0f);
    }
}
