using UnityEngine;
using System.Collections;

public class Wheel : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	public float speed0 = 50.0f;
	public float speed1 = 40.0f;

	int wheelRange = 0;
	void Update () 
	{
	
		if(Socket.operateDate.yAxis > 0)
		{
			transform.Rotate(Vector3.up * Time.deltaTime * speed0);
		}
		else if(Socket.operateDate.xAxis != 0 || Socket.operateDate.yAxis < 0)
		{
			transform.Rotate(-Vector3.up * Time.deltaTime * speed0);
		}
		
		if(Socket.operateDate.xAxis <-0.5f && wheelRange >-20 )
		{
			transform.Rotate(-Vector3.up * Time.deltaTime * speed1,Space.World);
			wheelRange--;
		}
		else if(Socket.operateDate.xAxis >0.5f && wheelRange<20)
		{
			transform.Rotate(Vector3.up * Time.deltaTime * speed1,Space.World);
			wheelRange++;
		}
		else 
		{
			if(wheelRange <0)
			{
				wheelRange++;
				transform.Rotate(Vector3.up * Time.deltaTime * speed1,Space.World);
			}
			else if(wheelRange>0)
			{
				wheelRange--;
				transform.Rotate(-Vector3.up * Time.deltaTime * speed1,Space.World);
			}
		}
	}
}
