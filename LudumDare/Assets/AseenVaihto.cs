using UnityEngine;
using System.Collections;

public class AseenVaihto : MonoBehaviour {

    public GameObject[] aseet;

    public int nykyinenase = 0;

    private int aseennumero;

	void Start ()
    {
        aseennumero = aseet.Length;

        VaihdaAse(nykyinenase);
	}

    void Update()
    {
        for (int i = 1; i <= aseennumero; i++)
        {
            if (Input.GetKeyDown("" + i))
            {
                nykyinenase = i - 1;

                VaihdaAse(nykyinenase);

            }
        }
    }

    void VaihdaAse(int index)
    {

        for (int i = 0; i < aseennumero; i++)
        {
            if (i == index)
            {
                aseet[i].gameObject.SetActive(true);
            }
            else
            {
                aseet[i].gameObject.SetActive(false);
            }
        }
    }

}