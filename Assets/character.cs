using UnityEngine;
using System.Collections;

public class character : MonoBehaviour {
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	public float moveSpeed = 3.0F;
	private Vector3 moveDirection = Vector3.zero;
	private Animator Anim;
	public float speedFloat;
	public bool turn_left;
	public bool turn_right;
	public bool walk;
	public bool turn_back;
	void Start () {
		speedFloat = 0f;
		Anim = GetComponent<Animator> ();
		walk = false;
		turn_left = false;
		turn_right = false;
		turn_back = false;
	}
	
	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		bool entered = false;
		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) {
//				moveDirection.z = moveSpeed;
			walk = true;
		} else {
			walk = false;
		}
		if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) {
			turn_left = true;
		} else {
			turn_left = false;
		}
		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) {
			turn_right = true;
		} else {
			turn_right = false;
		}
		if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)) {
			turn_back = true;
		} else {
			turn_back = false;
		}
//		if(!entered) {
//			walk = false;
//			turn_left = false;
//			turn_right = false;
//		}
		//controller.transform.position = new Vector3 (1, 0, 0);
//		if (controller.isGrounded) {
//			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
//			moveDirection = transform.TransformDirection(moveDirection);
//			moveDirection *= speed;
//			if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) {
////				moveDirection.z = moveSpeed;
//				speedFloat += 0.1f;
//			}
//				
////			if (Input.GetKeyDown(KeyCode.DownArrow))
////				moveDirection.z = -1 * moveSpeed;
////			if (Input.GetKeyDown(KeyCode.LeftArrow))
////				moveDirection.x = moveSpeed;
////			if (Input.GetKeyDown(KeyCode.RightArrow))
////				moveDirection.x = -1 * moveSpeed;
//
//		}
//		controller.Move(moveDirection * Time.deltaTime);
//		if (Input.GetKey (KeyCode.W)) {
//			speedFloat += 0.1f;
//		} else {
//			if (speedFloat > 0) {
//				speedFloat -= 0.1f;
//			}
//		}

		Anim.SetBool ("right", turn_right);
		Anim.SetBool ("left", turn_left);
		Anim.SetBool ("walk", walk);
		Anim.SetBool ("back", turn_back);



	}
}
