using UnityEngine;
using System.Collections;

public class Miekkailu : MonoBehaviour {

    private bool hyökkäämässä = false;

    private float hyökkäysaika = 0;
    private float hyökkääyscd = 0.3f;

    public Collider2D hyökkäystriggeri;

    void Awake()
    {
        hyökkäystriggeri.enabled = false;
    }

    void Update()
    {

        if (Input.GetKeyDown("space") && !hyökkäämässä)
        {
            hyökkäämässä = true;
            hyökkäysaika = hyökkääyscd;

            hyökkäystriggeri.enabled = true;
        }

        if (hyökkäämässä)
        {
            if (hyökkäysaika > 0)
            {
                hyökkäysaika -= Time.deltaTime;
            }
            else
            {
                hyökkäämässä = false;
                hyökkäystriggeri.enabled = false;
            }
        }
    }
}