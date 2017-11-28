using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D c){
		print ("colidi");
		//print (c.gameObject.name);
		//print (c.gameObject.transform.position);
		//print (c.gameObject.tag);
		if(c.gameObject.tag == "piso"){
			Destroy (gameObject); // destoy a si mesmo
			//Destroy (c.gameObject);//destroy o chao
		}

	}

	void OnCollisionStay2D(Collision2D c){
		print ("estou colidindo....");
	}


	void OnCollisionExit2D(Collision2D c){
		print ("parei de colidir!!!");
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
