using UnityEngine;
using System.Collections;

public class HuanCamera : MonoBehaviour {
    public GameObject game;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.B))
        {
            game.SetActive(true);
            this.gameObject.SetActive(false);
        }
	}
}
