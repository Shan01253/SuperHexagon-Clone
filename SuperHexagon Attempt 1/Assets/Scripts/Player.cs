using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public float movementSpeed = 600f;

	float movement = 0f;
	
	// Update is called once per frame
	void Update () {
		movement = Input.GetAxisRaw("Horizontal");

	}

	public void FixedUpdate(){
		transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -movementSpeed);
	}

	private void OnTriggerEnter2D(Collider2D collision){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("GameOver");
	}
}