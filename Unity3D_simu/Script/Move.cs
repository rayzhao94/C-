using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
    public CharacterController controller;
    public float RoteSpeed=1.0f;
    public float MoveSpeed=1.0f;
    public MainPro main;
    public float MoveMaxSpeed;
    //public float MoveMinSpeed;

    public float wheelRoteSpeed=1.0f;
    public GameObject[] wheel;
    bool isCarCam = true;
    public GameObject CarCam;
    public GameObject CarCam11;
    GameObject fireCam;
	// Use this for initialization
	void Start () {

       // fireCam = main.fireCam;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, Input.GetAxis("Horizontal") * RoteSpeed/2f, 0);
        wheelRote();
        carMove();
       
	}

    private void carMove()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = MoveSpeed * Input.GetAxis("Vertical");
        controller.SimpleMove(-forward * curSpeed*15);

    }
    void wheelRote() {

        wheel[0].transform.Rotate(-Vector3.up * Input.GetAxis("Vertical") * wheelRoteSpeed * Time.deltaTime);
        wheel[2].transform.Rotate(-Vector3.up * Input.GetAxis("Vertical") * wheelRoteSpeed * Time.deltaTime);
        wheel[1].transform.Rotate(Vector3.up * Input.GetAxis("Vertical") * wheelRoteSpeed * Time.deltaTime);
        wheel[3].transform.Rotate(Vector3.up * Input.GetAxis("Vertical") * wheelRoteSpeed * Time.deltaTime);
    }

}
