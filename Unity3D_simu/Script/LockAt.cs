using UnityEngine;
using System.Collections;

public class LockAt : MonoBehaviour {

	// Use this for initialization
	public GameObject lookObj;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.LookAt(lookObj.transform.position);
	}
}
