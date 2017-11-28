using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour {

	public float velocidade;

	// Use this for initialization
	void Start () {
		
		//reposicionar o sprite para coordenada especifica
		//transform.position = new Vector2 (-10.0f, 0.0f);

	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate(5.0f*Time.deltaTime, 0.0f, 0.0f);
		//transform.Translate (Vector2.up*0.5f *Time.deltaTime);
		//transform.Rotate(Vector3.back * velocidade * Time.deltaTime);
		//print(Input.GetAxis("Horizontal"));

		/*float move_x = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
		float move_y = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
		transform.Translate (move_x, move_y, 0.0f);

		if (Input.GetButtonDown ("Jump")) {
			transform.position = Vector2.zero;
		}*/

	}
}
