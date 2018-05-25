using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

    CharacterController pController;
    public float moveSpeed;
    private void Awake()
    {
        pController = GetComponent<CharacterController>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MoveCharacter();
	}

    void MoveCharacter()
    {
        float movhoriz = Input.GetAxis("Horizontal");
        float movvert = Input.GetAxis("Vertical");

        Vector3 moveDirSide = transform.right * movhoriz * moveSpeed;
        Vector3 moveDirForward = transform.forward * movvert * moveSpeed;

        pController.SimpleMove(moveDirSide);
        pController.SimpleMove(moveDirForward);
    }
}
