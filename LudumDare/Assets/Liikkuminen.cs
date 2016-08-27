using UnityEngine;
using System.Collections;

public class Liikkuminen : MonoBehaviour {
    private float juoksunopeus = 5;
    private Rigidbody rb;
    public GameObject pelaaja;

    void FixedUpdate()
    {
        if (Input.GetKey("up"))
        {
            transform.Translate(0, juoksunopeus * Time.deltaTime, 0);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(0, -juoksunopeus * Time.deltaTime, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(-juoksunopeus * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(juoksunopeus * Time.deltaTime, 0, 0);
        }
    }
}
