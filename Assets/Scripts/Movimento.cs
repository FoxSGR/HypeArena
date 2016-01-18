using UnityEngine;
using System.Collections;


public class Movimento : MonoBehaviour {

    float velocidade;

	// Use this for initialization
	void Start () {

        velocidade = 18f * Time.deltaTime;

	}
	
	// Update is called once per frame
	void Update () {
	
        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, velocidade);
        }

        if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, -velocidade);
        }

        if (Input.GetKey("d"))
        {
            transform.Translate(velocidade, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(-velocidade, 0, 0);
        }

    }
}
