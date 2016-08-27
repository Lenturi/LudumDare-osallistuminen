using UnityEngine;
using System.Collections;

public class KameraLiikkuminen : MonoBehaviour {
    public Transform kohde;
    private float aika = 0.3f;
    private Vector3 velocity = Vector3.zero;

    // Use this for initialization
    void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 targetPosition = kohde.TransformPoint(new Vector3(0, 3, -10));
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, aika);
    }
}
