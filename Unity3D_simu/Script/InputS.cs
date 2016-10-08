using UnityEngine;
using System.Collections;
//using System; 
//using System.Net; 
//using System.Net.Sockets; 
//using System.Text; 
//using System.Threading; 
using System.IO; 
//using System.Runtime.InteropServices;
//using System.Collections.Generic;

public class InputS : MonoBehaviour {


	public struct SOperate
	{
		public bool Begin;
		public bool Fire;
	    public bool TiaoZi;
		public bool Butt0;
		public bool Butt1;
		public bool Orbit;
		public bool DengYue;
		public bool Back;		
		public float xAxis;
		public float yAxis;

	};	 
	static public SOperate operateDate;
	
	void Start ()
	{	
		operateDate = new SOperate();
		
		
	}
	
	void Update ()
	{		
		if(Input.GetButton("Btn0") ||Input.GetKeyDown(KeyCode.F1))	{   operateDate.Begin   = true;     }
		else                                                        {   operateDate.Begin   = false;    }
		if(Input.GetButton("Btn1") ||Input.GetKeyDown(KeyCode.F3))	{   operateDate.TiaoZi  = true;     }
		else                                                        {   operateDate.TiaoZi  = false;    }
		if(Input.GetButton("Btn2") ||Input.GetKeyDown(KeyCode.F4))	{   operateDate.Butt0   = true;     }
		else                                                        {   operateDate.Butt0   = false;    }
		if(Input.GetButton("Btn3") ||Input.GetKeyDown(KeyCode.F5))	{   operateDate.Butt1   = true;     }
		else                                                        {   operateDate.Butt1   = false;    }
		if(Input.GetButton("Btn4") ||Input.GetKeyDown(KeyCode.F6))	{   operateDate.Orbit   = true;     }
		else                                                        {   operateDate.Orbit   = false;    }
		if(Input.GetButton("Btn5") ||Input.GetKeyDown(KeyCode.F7))	{   operateDate.DengYue = true;     }
		else                                                        {   operateDate.DengYue = false;    }
		if(Input.GetButton("Btn6") ||Input.GetKeyDown(KeyCode.F8))	{   operateDate.Back    = true;     }
		else                                                        {   operateDate.Back    = false;    }
		if(Input.GetButton("Btn7") ||Input.GetKeyDown(KeyCode.F2))	{   operateDate.Fire     = true;     }
		else                                                        {   operateDate.Fire     = false;    }
		
		if(Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.RightArrow))
		{
			if(Input.GetKey(KeyCode.UpArrow))	        {   operateDate.yAxis     = -1;      }		
			else if(Input.GetKey(KeyCode.DownArrow))	{   operateDate.yAxis     =  1;      }
		    else if(Input.GetKey(KeyCode.LeftArrow))	{   operateDate.xAxis     = -1;      }
			else if(Input.GetKey(KeyCode.RightArrow))   {   operateDate.xAxis     =  1;      }
			else                                        {   operateDate.yAxis     =  0;      }
		}
		else
		{
			operateDate.xAxis = Input.GetAxis("X");
		    operateDate.yAxis = Input.GetAxis("Y");
		}

		//Debug.Log(operateDate.xAxis+" "+operateDate.yAxis);

	//TOSOCKET:
		//if(!bSocketRun)
		//{
	//		return;
	//	}
		/*if(m_ReceiveData.m_Byte[0]==1) {   operateDate.Begin  = true;    }
		else                           {   operateDate.Begin  = false;   }
		if(m_ReceiveData.m_Byte[0]==2) {	operateDate.Fire = true;    }
		else                           {   operateDate.Fire = false;   }
		if(m_ReceiveData.m_Byte[0]==3) {	operateDate.yAxis     = -1;   }
		else                           {   operateDate.yAxis     = 0;    }		
		if(m_ReceiveData.m_Byte[0]==4) {	operateDate.yAxis     = 1;   }
		else                           {   operateDate.yAxis     = 0;    }		            
		if(m_ReceiveData.m_Byte[0]==5) {	operateDate.xAxis     = -1;   }
		else                           {   operateDate.xAxis     = 0;    }			
		if(m_ReceiveData.m_Byte[0]==6) {	operateDate.xAxis     = 1;   }
		else                            {   operateDate.xAxis     = 0;    }		*/
	}
}
