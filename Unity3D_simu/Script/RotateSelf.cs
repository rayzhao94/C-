using UnityEngine;
using System.Collections;

public class RotateSelf : MonoBehaviour {
	public bool bRotate = false;
	public Vector3 RotateSpeed = new Vector3(0,0,0);	
	
	public Vector3 RotateAPoint = new Vector3(0,0,0);
	public Vector3 RotateAAxis = new Vector3(0,0,0);
	public float RotateASpeed = 0.0f;
	
	
	public bool bMove = false;		
	public Vector3 MoveDirection = new Vector3 (0,0,0);
	
	void Start () 
	{	
	}	
	
	int count = 0;
	bool b = false;
	void Update ()
	{
		if(bRotate)
		{
			this.transform.Rotate(RotateSpeed*Time.deltaTime);		 
			this.transform.RotateAround(RotateAPoint,RotateAAxis ,Time.deltaTime*RotateASpeed);
		}
		
		if(bMove)
		{				
			if(b && count < 50)
			{
				count ++;
				this.transform.Translate(MoveDirection * Time.deltaTime);
				if(count >= 49)
					b = false;
			}
			else if(!b && count >-50 )
			{
				count --;
				this.transform.Translate(-MoveDirection * Time.deltaTime);
				if(count <= -49)
					b = true;
			}
		}
	}
}
