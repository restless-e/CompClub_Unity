using UnityEngine;
using System.Collections;

public class playerMovement2 : MonoBehaviour {

    CharacterController controller;

    Vector3 vecMove;

    public float moveSpeed = 5.0f;

	// Use this for initialization
	void Start () {

        controller = GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {
        vecMove = new Vector3();

        if (Input.GetKey("i"))
            vecMove.z = 1;
        if (Input.GetKey("k"))
            vecMove.z = -1;
        if (Input.GetKey("j"))
            vecMove.x = -1;
        if (Input.GetKey("l"))
            vecMove.x = 1;


        vecMove.Normalize();
        controller.Move(vecMove * moveSpeed * Time.deltaTime);
	}
}
