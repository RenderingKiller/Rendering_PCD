using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLook : MonoBehaviour {

    public float sensitivity;
    public Transform characterBody;
    public float xClamp = 0;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        RotateCamera();

    }

    void RotateCamera()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        float rX = x * sensitivity;
        float rY = y * sensitivity;

        xClamp -= rY;

        Vector3 tarCam = transform.rotation.eulerAngles;
        Vector3 tarBody = characterBody.rotation.eulerAngles;

        tarCam.x -= rY;
        tarBody.y += rX;

        if (xClamp > 90)
        {
            xClamp = 90;
            tarCam.x = 90;
        }
        else if (xClamp < -90)
        {
            xClamp = -90;
            tarCam.x = -90;
        }

        transform.rotation = Quaternion.Euler(tarCam);
        characterBody.rotation = Quaternion.Euler(tarBody);
    }
}
