using UnityEngine;
using System.Collections;



public class playerMovement1 : MonoBehaviour {

    CharacterController controller;

    Vector3 vecMove;

    public float moveSpeed = 5.0f;

    // Use this for initialization
    void Start () {

        controller = GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {

        vecMove = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        vecMove.Normalize();
        controller.Move(vecMove * moveSpeed * Time.deltaTime);
	}
}
