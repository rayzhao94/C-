using UnityEngine;
using System.Collections;

public class MoveFont : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	int distance = 0;
	public GameObject next;
	float _t =0.0f;
	void Update ()
	{
	    if(distance<50)
		{
			transform.Translate(Vector3.down * Time.deltaTime*60);
			
			_t+=Time.deltaTime;
			if(_t>=0.01)
			{
				distance++;
				_t = 0.0f;
			}
			
		}
	    else if(distance>49)
		{
			distance = 0;
			next.SetActive(true);
			gameObject.SetActive(false);
			
		}
	}
}
