using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public Transform sprite;
	Vector2 dir;

	public float speed; public float jumpSpeed;

	private Rigidbody rb;
	private int count;

	public bool jumping;

	public double maxheight = 25.0f;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
	}

	void FixedUpdate()
	{
		// float moveHorizontal = Input.GetAxis("Horizontal");
		// float moveVertical = Input.GetAxis("Vertical");
		// Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		transform.Translate(0, 0, 0.1f, sprite);
    //
		// // rb.AddForce(movement * speed);
		// //If onPlane true you can hit Space and jump, otherwise not possbile
		// if (onPlane)
		// {
		// 	if (Input.GetKey(KeyCode.Space))
		// 	{
		// 		rb.velocity = new Vector3(0f, -jumpSpeed, 0f); // I like more velocity than AddForce
		// 		//After you hit jump, make onPlane false, so hitting Space for the second time or
		// 		// holding it wouldn't change anything
		// 		onPlane = false;
		// 	}
		// }
		float yPosition = (float)sprite.localPosition.y;
		print (yPosition);
		print (maxheight);
		print (yPosition < maxheight);

		if(jumping == true && yPosition < maxheight){
			transform.Translate(0,0.1f,0, Camera.main.transform);
		}
		else if(jumping == true && yPosition > maxheight){
			print ("b");
			jumping = false;
		}
		else if(jumping == false && yPosition > 0){
			print ("c");
			transform.Translate(0,-0.1f, 0, Camera.main.transform);
		}
		else{
			print ("d");
			jumping = false;
		}

	}
	//after the object touches the floor again, make onPlane true
	private void OnCollisionEnter(Collision collision)
	{
		//Notice you have to create a tag for this method. You can name it the way you want.
		if (collision.gameObject.CompareTag("Plane"))
		{
			jumping = false;
		}
	}

	public void Jump() {
		print ("got here tbh");
		jumping = true;
	}
}
