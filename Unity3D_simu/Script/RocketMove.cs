using UnityEngine;
using System.Collections;

public class RocketMove : MonoBehaviour {
    public GameObject tar;
    Vector3 dir;
	// Use this for initialization
	void Start () {
        dir = (tar.transform.position - transform.position).normalized;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(dir * Time.deltaTime * 17);
	}
}
