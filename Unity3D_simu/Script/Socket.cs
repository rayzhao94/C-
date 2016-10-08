using UnityEngine;
using System.Collections;
//using System; 
//using System.Net; 
//using System.Net.Sockets; 
//using System.Text; 
using System.Threading; 
//using System.IO; 
using System.Runtime.InteropServices;
//using System.Collections.Generic;

public class Socket : MonoBehaviour {
	
	[DllImport("SocketModule")]
    public static extern void SenderInitialize(string LocalIP, int LocalPort);
    [DllImport("SocketModule")]
    public static extern bool SenderAppendReceiver(string IP, int Port);
    [DllImport("SocketModule")]
    public static extern void SenderSendData(ref KSendScheduler Buffer, int BufferSize);

    [DllImport("SocketModule")]
    public static extern void ReceiverInitialize(string LocalIP, int LocalPort);
    [DllImport("SocketModule")]
    public static extern bool ReceiverSetSender(string IP, int Port);
    [DllImport("SocketModule")]
    public static extern void ReceiverReceiveData(ref kReceiveScheduler Buffer, int BufferSize);
	
	//定义发送数据的结构体
	[StructLayout(LayoutKind.Sequential)]  
	public struct KSendScheduler  
	{ 
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		public byte[] m_Byte;
	}
	
	//定义接收数据的结构体
	[StructLayout(LayoutKind.Sequential)]  
	public struct kReceiveScheduler
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		public byte[] m_Byte;		
	}	
	
	public KSendScheduler m_SendData;
	public kReceiveScheduler m_ReceiveData;		

	
	void SendThread()
	{
		do
		{		
		    SenderSendData(ref m_SendData, Marshal.SizeOf(typeof(KSendScheduler)));	
			Thread.Sleep(100);
		}
		while(true);
	}
	
	void ReceiveThread()
	{
		do
		{		
		    ReceiverReceiveData(ref m_ReceiveData, Marshal.SizeOf(typeof(kReceiveScheduler)));
			Thread.Sleep(90);
		}
		while(true);
	}
	
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
	
	public bool bInputRun = false;
	public bool bSocketRun = false;
	
	void Start ()
	{	
		operateDate = new SOperate();
		
		if(!bSocketRun)
		{
			return;
		}
		m_SendData = new KSendScheduler();
		m_ReceiveData = new kReceiveScheduler();		
		SenderInitialize("127.0.0.1",8001);
		SenderAppendReceiver("127.0.0.1",8002);			
		ReceiverInitialize("127.0.0.1",8002);
		ReceiverSetSender("127.0.0.1",8001);		
		
		Thread _sendThread = new Thread(new ThreadStart(SendThread));
		_sendThread.Start();
		
		Thread _receiveThread = new Thread(new ThreadStart(ReceiveThread));
		_receiveThread.Start();
		
		
	}
	

	
	void Update ()
	{		
		//input	
		if(!bInputRun)
		{
			goto TOSOCKET;
		}
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

	TOSOCKET:
		if(!bSocketRun)
		{
			return;
		}
		if((m_ReceiveData.m_Byte[0]&0x01) != 0) {   operateDate.Begin  = true;    }
		else                                    {   operateDate.Begin  = false;   }
		if((m_ReceiveData.m_Byte[0]&0x02) != 0) {	operateDate.TiaoZi = true;    }
		else                                    {   operateDate.TiaoZi = false;   }
		if((m_ReceiveData.m_Byte[0]&0x04) != 0) {	operateDate.Butt0  = true;    }
		else                                    {   operateDate.Butt0  = false;   }		
	                 
			
		
	}
}
