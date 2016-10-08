using UnityEngine;
using System.Collections;

public class MainPro : MonoBehaviour {

	public const int STATE_READY     = 0;
	public const int STATE_FIRST     = 1;
	public const int STATE_SECOND    = 2;
	public const int STATE_THIRD     = 3;
	public const int STATE_FOURTH    = 4;
	public const int STATE_EXIT      = 5;
	
    float timeBegin;
    float timeLast;
    float timeState;
    int gameState;
	
	void Start () 
	{
		gameState = STATE_READY;
		timeBegin = timeLast= timeState = 0;
       // fireCam = GameObject.Find("FireCam");
	}		

	bool bReady = true;
	void Update ()
	{
       // ReturnMenuScene();
		timeLast = Time.time - timeBegin;
		switch(gameState)
		{
			case STATE_READY:
				bReady = true;
                move.enabled = true;
                label_text.enabled = false;
			    UpdateReady();
				break;
			
			case STATE_FIRST:
				bReady = false;	
			    UpdateFirst();
				break;
				
			case STATE_SECOND:
				bReady = false;				
				UpdateSecond();		
				break;
				
			case STATE_THIRD:
				bReady = false;							
				UpdateThird();		
				break;
				
			case STATE_FOURTH:
				bReady = false;	
			    UpdateFourth();
				break;			
				
			case STATE_EXIT:
				//Application.Quit();
                bReady = true;
			    UpdateReady();
				break;
		}				

		if((Input.GetKeyDown(KeyCode.Alpha1) || Socket.operateDate.Begin) && bReady)
		{
			gameState = STATE_FIRST;
			timeBegin = Time.time;	
			PressBegin();			
		}
		else if(Input.GetKeyDown(KeyCode.Alpha2) && bReady)
		{
			gameState = STATE_SECOND;
			timeBegin = Time.time;
			PressSecond();						
		}
	    else if(Input.GetKeyDown(KeyCode.Alpha3) && bReady)
		{
			gameState = STATE_THIRD;
			timeBegin = Time.time;
			PressThird();			
		}
		else if(Input.GetKeyDown(KeyCode.Alpha4) && bReady)
		{
			gameState = STATE_FOURTH;
			timeBegin = Time.time;
			PressFourth();
		}
		else if((Input.GetKeyDown(KeyCode.Alpha5) ) && !bReady)
		{
			gameState = STATE_READY;
			timeBegin = Time.time;			
		}
		else if(Input.GetKeyDown(KeyCode.Escape))
		{
			gameState = STATE_EXIT;

		}	
	}
	
	
	static public bool bRunReady = false;	
	void UpdateReady()
	{
		bRunReady =true;
		//max:100 now:25
		for(int i =0; i<100;i++)
		{
			Music.bResetM[i]=false;
		}
		Music.Stop();
		Music.StopBG();
		//scene one	
		GUICam.SetActive(false);
		if(countdownObj)
		{
			Destroy(countdownObj);			
		}			
		//fireCam.SetActive(false);
		RocketFlame.bStart = false;		
		MyAnimation.Play("Rocket1","Reset");
		//InitObject.rocket1.transform.rotation = new Quaternion(0,0,0,0);
		bFEvent1 = bFEvent2 = bFEvent3 = true;
		bFire0 =bFire1 =bFire2 = false;
		//scene tow		
		MyAnimation.Play("RocketS","Reset");		
		separateCam.SetActive(false);
		RocketFlame.bStartF1 = false;
		RocketFlame.bStartF2 = false;
		RocketFlame.bStartF3 = false;
		RocketFlame.bStartLF = false;
		InitObject.DictateCabin.SetActive(false);
		InitObject.ServiceCabin.SetActive(false);
		InitObject.MoonSpaceCabin.SetActive(false);
        InitObject.OrbitZongHe2.SetActive(false);
		bEvent1 =bEvent2 =bEvent3 =true;
		bTZ = bButt = bButt1 = false;
		RocketFlame.bStartD = RocketFlame.bStartU = RocketFlame.bStartR = RocketFlame.bStartL = false;
		
		tiaoZiCam.transform.rotation = new Quaternion(-0.9f,0.3f,0.0f,0.1f);
		TZRange = 0;
		tiaoZiCam.SetActive(false);
		InitObject.TZCabin.transform.position = InitObject.TZCabinPos;
		//InitObject.TZBG.SetActive(false);
		
		MyAnimation.Play("ButtCabin","Reset");			
		buttCam0.SetActive(false);		
		//InitObject.ButtCabin.SetActive(false);
		
		//InitObject.ButtCabin.transform.position = InitObject.ButtCabinPos;
		//InitObject.ButtCabin1.transform.position = InitObject.ButtCabin1Pos;
		//InitObject.ButtCabinMoonSpace.transform.position = InitObject.ButtCabinMoonSpacePos;
		//MyAnimation.Play("ButtCabin1","Reset2");			
		buttCam1.SetActive(false);		
		//InitObject.ButtCabin1.SetActive(false);
		
		
		
		//scene three
		InitObject.OrbitZongHe.SetActive(true);
		orbitCam0.SetActive(false);
		InitObject.OrbitZongHe1.SetActive(false);
		orbitCam1.SetActive(false);
		InitObject.OrbitDengYue2.SetActive(false);
		orbitCam2.SetActive(false);
		bOrbit = bOrbitSeparate = false;
		//scene fore
		landLight.SetActive(false);
		landCam.SetActive(false);
		//CarCam.SetActive(false);
		InitObject.LandMoonCar.transform.position = InitObject.LandMoonCarPos;
		InitObject.LandMoonCar.transform.rotation = InitObject.LandMoonCarQuat;
		InitObject.LandMoonCar.SetActive(false);
		MyAnimation.Play("MoonCar@Out","Reset");
		bBcak = false;		
		
		InitObject.OrbitScene.transform.rotation = InitObject.OrbitSceneQuat;		
		InitObject.OrbitZongHe.transform.position = InitObject.OrbitZongHePos;
		InitObject.OrbitZongHe.transform.rotation = InitObject.OrbitZongHeQuat;
		InitObject.OrbitDengYue.transform.position = InitObject.OrbitDengYuePos;
		InitObject.OrbitZongHe1.transform.position = InitObject.OrbitZongHe1Pos;
		InitObject.OrbitZongHe1.transform.rotation = InitObject.OrbitZongHe1Quat;
		InitObject.OrbitDengYue2.transform.position = InitObject.OrbitDengYue2Pos;
		InitObject.OrbitZongHe2.transform.position = InitObject.OrbitZongHe2Pos;
		InitObject.LandMoonCarOut.transform.position = InitObject.LandMoonCarOutPos;
		InitObject.Earth.transform.rotation = InitObject.EarthQuat;
		gScale = 1.0f;
		gTime = 0.0f;
		InitObject.OrbitDengYue.transform.localScale = new Vector3(gScale,gScale,gScale);
	}
	//scent one
	public GameObject countdown;
	GameObject countdownObj;
	void PressBegin()
	{
		bRunReady = false;	
		fireCam.SetActive(true);	
		Music.Play("begin",ref Music.bResetM[0]);
	}	
	bool bFEvent1 = true;
	bool bFEvent2 = true;
	bool bFEvent3 = true;
	
	bool bFire0 = false;
	bool bFire1 = false;
	bool bFire2 = false;
	
	public GameObject fireCam;
	public GameObject GUICam;

	void UpdateFirst()
	{	
		if(bFEvent1)
		{
			if((Socket.operateDate.Fire || timeLast>12) && !bFire0)
			{
				Music.Play("fire0",ref Music.bResetM[1]);
				
				timeState = timeLast;
				bFire0 = true;
				GUICam.SetActive(true);
		        countdownObj = (GameObject)Instantiate(countdown,countdown.transform.position,countdown.transform.rotation);
			}
			if(timeLast - timeState >11 && timeLast- timeState <12 && bFire0)
			{
				RocketFlame.bStart = true;
                RocketFlame.bStartU = true;
				MyAnimation.Play("Rocket1","Fire",2);	
				Music.PlayBG("rocket", ref Music.bResetM[25]);
			}
			else if(timeLast- timeState>16 && timeLast- timeState <26 && bFire0)
			{

                float speed1 = 1f;
                speed1 += 1f;
                InitObject.rocket1.transform.Translate(Vector3.up*speed1*10,Space.Self);


                float speed = 5f;
                speed += 0.4f;
                //InitObject.rocket1.transform.Rotate(Vector3.back, Time.deltaTime * speed);
				//InitObject.rocket1.transform.Rotate(Vector3.back,Time.deltaTime*8);
				if(timeLast- timeState>23)
				{
					Music.Play("cloud",ref Music.bResetM[2]);
				}
			}			
			else if(timeLast- timeState>26 && bFire0)
            {
                separateCam.SetActive(true);
                fireCam.transform.position = separateCam.transform.position;
                fireCam.transform.rotation = separateCam.transform.rotation;
                fireCam.transform.parent = separateCam.transform;
				GUICam.SetActive(false);
				//fireCam.SetActive(false);
				RocketFlame.bStart = false;
                RocketFlame.bStartU = false;
				MyAnimation.Play("Rocket1","Reset");
		        InitObject.rocket1.transform.rotation = new Quaternion(0,0,0,0);
				bFEvent1 = false;
				
			    timeBegin = Time.time;
				gameState = STATE_SECOND;
				
				MyAnimation.Play("RocketS","Separate",1.5f);
				RocketFlame.bStartF1 = true;
				InitObject.DictateCabin.SetActive(true);
			}
		}
		else if(bFEvent2)
		{
			if((Socket.operateDate.Fire || timeLast>12) && !bFire1)
			{
				
				
				timeState = timeLast;
				bFire1 = true;		       
			}
			if(timeLast - timeState >1 && timeLast- timeState <2 && bFire1)
			{
				RocketFlame.bStart = true;
				MyAnimation.Play("Rocket1","Fire",2);	
				Music.Play("firing0",ref Music.bResetM[20]);
				Music.PlayBG("rocket", ref Music.bResetM[27]);
			}
			else if(timeLast- timeState>6 && timeLast- timeState <10 && bFire1)
            {
               // Debug.Log("adfafdd");	
				InitObject.rocket1.transform.Rotate(Vector3.right,Time.deltaTime*15);
				InitObject.rocket1.transform.Rotate(Vector3.back,Time.deltaTime*8);
			}			
			else if(timeLast- timeState>10 && bFire1)
			{	
				fireCam.SetActive(false);
				RocketFlame.bStart = false;	
				MyAnimation.Play("Rocket1","Reset");
		        InitObject.rocket1.transform.rotation = new Quaternion(0,0,0,0);
				bFEvent2 = false;
				timeBegin = Time.time;
				gameState = STATE_SECOND;					
			}			
		}
		else if(bFEvent3)
		{
			if((Socket.operateDate.Fire || timeLast>12) && !bFire2)
			{				
				timeState = timeLast;
				bFire2 = true;			
			}
			if(timeLast - timeState >1 && timeLast- timeState <2 && bFire2)
			{
				RocketFlame.bStart = true;
				MyAnimation.Play("Rocket1","Fire",2);	
				Music.Play("firing1",ref Music.bResetM[21]);
				Music.PlayBG("rocket", ref Music.bResetM[28]);
			}
			else if(timeLast- timeState>6 && timeLast- timeState <10 && bFire2)
			{				
				InitObject.rocket1.transform.Rotate(Vector3.right,Time.deltaTime*15);
				InitObject.rocket1.transform.Rotate(Vector3.back,Time.deltaTime*8);
			}			
			else if(timeLast- timeState >10 && bFire2)
			{				
				fireCam.SetActive(false);
				RocketFlame.bStart = false;	
				MyAnimation.Play("Rocket1","Reset");
		        InitObject.rocket1.transform.rotation = new Quaternion(0,0,0,0);
				bFEvent3 = false;
				timeBegin = Time.time;
				gameState = STATE_SECOND;				
			}
		}	

	}
    public RocketMove rock_move;
	//scene tow
    public Material skybox;
    public Skybox sky1;
    public Skybox sky2;
	void PressSecond()
	{
        sky1.material = skybox;
        sky2.material = skybox;
        rock_move.enabled = true;
        separateCam.SetActive(true);
        fireCam.transform.position = separateCam.transform.position;
        fireCam.transform.rotation = separateCam.transform.rotation;
        fireCam.transform.parent = separateCam.transform;
		bRunReady = false;
		//separateCam.SetActive(true);
		MyAnimation.Play("RocketS","Separate",1.5f);
		RocketFlame.bStartF1 = true;
		InitObject.DictateCabin.SetActive(true);		
	    //bEvent3 =true; bEvent2  = bEvent1 =false;
	}
	bool bEvent1 = true;
	bool bEvent2 = true;
	bool bEvent3 = true;
	
	bool bTZ = false;
	bool bButt = false;
	bool bButt1 = false;	

	public GameObject separateCam;
	public GameObject tiaoZiCam;
	public GameObject buttCam0;
	public GameObject buttCam1;
	
	int TZRange = 0;
	void UpdateSecond()
    {
        sky1.material = skybox;
        sky2.material = skybox;
        rock_move.enabled = true;
		if(bEvent1)
		{
			if(timeLast>22)
			{
           
				Music.PlayBG("flying", ref Music.bResetM[26]);
				//separateCam.SetActive(false);
                //Debug.Log("1111111111111111");
                PressThird();
                gameState = STATE_THIRD;	
				//tiaoZiCam.SetActive(true);
				Music.Play("tiaozi",ref Music.bResetM[6]);
										
				if((Socket.operateDate.TiaoZi || timeLast>32) && !bTZ)
				{	
					InitObject.TZCabin.transform.Translate(Vector3.up * Time.deltaTime/25);
					Music.Play("operate",ref Music.bResetM[7]);
					timeState =timeLast;
					bTZ = true;
				}
				else if(!bTZ)
				{
					InitObject.TZCabin.transform.Translate(Vector3.up * Time.deltaTime/50);
				}
				if(timeLast-timeState<13 && bTZ)
				{
					InitObject.TZCabin.transform.Translate(Vector3.up * Time.deltaTime/25);	
					if(Socket.operateDate.xAxis <0 )											
						RocketFlame.bStartR = true;					
					else
						RocketFlame.bStartR = false;
					if(Socket.operateDate.xAxis >0 )											
						RocketFlame.bStartL = true;						
					else
						RocketFlame.bStartL = false;
					if(Socket.operateDate.yAxis <0)
						RocketFlame.bStartD = true;
					else
						RocketFlame.bStartD = false;
					if(Socket.operateDate.yAxis >0)
						RocketFlame.bStartU = true;
					else
						RocketFlame.bStartU = false;
				}
				else if((timeLast-timeState>13 && bTZ))
				{
					Music.Play("fire1",ref Music.bResetM[8]);
					InitObject.DictateCabin.SetActive(false);
					InitObject.TZCabin.transform.position = InitObject.TZCabinPos;
					tiaoZiCam.SetActive(false);	
					RocketFlame.bStartD = RocketFlame.bStartU = RocketFlame.bStartR = RocketFlame.bStartL = false;
					bEvent1 =false;
    
					timeBegin = Time.time;
                    PressThird();
					gameState = STATE_THIRD;	
					//fireCam.SetActive(true);
					Music.StopBG();
				}
			}
			else if(timeLast>18)
			{
				Music.Play("sep4",ref Music.bResetM[5]);
				RocketFlame.bStartF2 = false;
			}
			else if(timeLast>15)
			{
				RocketFlame.bStartF2 = true;
			}
			else if(timeLast>14)
			{
				Music.Play("sep3",ref Music.bResetM[4]);
				RocketFlame.bStartF3 = false;
			}
			else if(timeLast>11)
			{
				Music.Play("sep2",ref Music.bResetM[3]);
			}
			else if(timeLast>8)
			{
				RocketFlame.bStartF3 = true;
			}
			else if(timeLast>7)
			{
				Music.Play("sep1",ref Music.bResetM[23]);
				RocketFlame.bStartF1 = false;
			}			
		}
		else if(bEvent2)
		{				
			Music.Play("butt0",ref Music.bResetM[9]);	
			Music.PlayBG("flying", ref Music.bResetM[29]);
			//InitObject.ButtCabin.SetActive(true);
			buttCam0.SetActive(true);
			
			if((Socket.operateDate.Butt0 || timeLast>12) && !bButt)
			{
				Music.Play("operate",ref Music.bResetM[10]);
				timeState =timeLast;
				bButt = true;					
				MyAnimation.Play("ButtCabin","Butt",1.0f);
			}
			else if(!bButt)
			{
				MyAnimation.Play("ButtCabin","Reset",1.0f);		
				//InitObject.ButtCabin.transform.Translate(new Vector3(-1,0,1) * Time.deltaTime/260);
			}
			if(timeLast-timeState<15 && bButt)
			{
				if(Socket.operateDate.xAxis <0 )											
					RocketFlame.bStartR = true;					
				else
					RocketFlame.bStartR = false;
				if(Socket.operateDate.xAxis >0 )											
					RocketFlame.bStartL = true;						
				else
					RocketFlame.bStartL = false;
				if(Socket.operateDate.yAxis <0)
					RocketFlame.bStartD = true;
				else
					RocketFlame.bStartD = false;
				if(Socket.operateDate.yAxis >0)
					RocketFlame.bStartU = true;
				else
					RocketFlame.bStartU = false;
			}
			else if(timeLast-timeState>15 && bButt)
			{				
				MyAnimation.Play("ButtCabin","Reset");
				buttCam0.SetActive(false);
				//InitObject.ButtCabin.SetActive(false);	
				RocketFlame.bStartD = RocketFlame.bStartU = RocketFlame.bStartR = RocketFlame.bStartL = false;
				bEvent2 =false;	
				
				timeBegin = Time.time;
				gameState = STATE_THIRD;
				fireCam.SetActive(true);
				Music.Play("fire2",ref Music.bResetM[11]);
				Music.StopBG();
			}			
		}
		else if(bEvent3)
		{	
			Music.Play("butt1",ref Music.bResetM[12]);
			Music.PlayBG("flying", ref Music.bResetM[30]);
			//InitObject.ButtCabin1.SetActive(true);
			buttCam1.SetActive(true);
			
			if((Socket.operateDate.Butt1 || timeLast>12) && !bButt1)
			{
				Music.Play("operate",ref Music.bResetM[13]);
				timeState =timeLast;
				bButt1 = true;	
				
			}
			else if(!bButt1)
			{
				//InitObject.ButtCabin1.transform.Translate(new Vector3(-1,0,1) * Time.deltaTime/260);
			}
			if(timeLast-timeState<8 && bButt1)
			{
				//InitObject.ButtCabin1.transform.Translate(new Vector3(-1,0,1) * Time.deltaTime/120);
				//InitObject.ButtCabinMoonSpace.transform.Translate(Vector3.up *Time.deltaTime/208);	
				
				if(Socket.operateDate.xAxis <0 )											
					RocketFlame.bStartR = true;					
				else
					RocketFlame.bStartR = false;
				if(Socket.operateDate.xAxis >0 )											
					RocketFlame.bStartL = true;						
				else
					RocketFlame.bStartL = false;
				if(Socket.operateDate.yAxis <0)
					RocketFlame.bStartD = true;
				else
					RocketFlame.bStartD = false;
				if(Socket.operateDate.yAxis >0)
					RocketFlame.bStartU = true;
				else
					RocketFlame.bStartU = false;
			}
			else if(timeLast-timeState>9 && bButt1)
			{				
				//InitObject.ButtCabin1.transform.position = InitObject.ButtCabin1Pos;
				//InitObject.ButtCabinMoonSpace.transform.position = InitObject.ButtCabinMoonSpacePos;             	
				buttCam1.SetActive(false);
				//InitObject.ButtCabin1.SetActive(false);				     	
				bEvent1 = bEvent2 = bEvent3 =true;	
				
				timeBegin = Time.time;
				gameState = STATE_THIRD;				
				orbitCam0.SetActive(true);
				Music.Play("orbit0",ref Music.bResetM[14]);
			}
		}			
	}
	
	//scene three
	void PressThird()
	{
		bRunReady = false;
		orbitCam0.SetActive(true);
        sky1.material = skybox;
        sky2.material = skybox;
        fireCam.transform.position = orbitCam0.transform.position;
        fireCam.transform.rotation = orbitCam0.transform.rotation;
        fireCam.transform.parent = orbitCam0.transform;
     
		bEvent1 = true;
		bEvent2 = true;
		bEvent3 = true;
	}	
	
	bool bOrbit = false;
	bool bOrbitSeparate = false;
	public GameObject orbitCam0;
	public GameObject orbitCam1;
	public GameObject orbitCam2;
    public GameObject OrbitCam0111;
    public GameObject OrbitCam0222;
    bool isCam1 = true;
    bool isCam2 = true;
	float gScale =1.0f;
	float gTime = 0.0f;
    public GameObject orbitscene;
    public GameObject dengyuecang2;
	void UpdateThird()
	{
        //Debug.Log("3333333333333");
		//Music.PlayBG("flying", ref Music.bResetM[31]);
		if(bEvent1)
		{
			if((Socket.operateDate.Orbit || timeLast>10) && !bOrbit)
			{
				timeState = timeLast;
				bOrbit =true;
			}
			else 
			{
				//Debug.Log(timeLast-timeState);
			}
			if(timeLast-timeState <7 && bOrbit)
			{
                RocketFlame.bStartF4 = true;
				InitObject.OrbitZongHe.transform.Translate(Vector3.down*Time.deltaTime*2*9);
				InitObject.OrbitZongHe.transform.Rotate(Vector3.up*Time.deltaTime*3,Space.World);
				if(gTime<0.1f)
				{
					gTime +=Time.deltaTime;
				}
				else
				{
					gTime = 0.0f;
					gScale-=Time.deltaTime/4;
				}
				InitObject.OrbitDengYue.transform.localScale = new Vector3(gScale,gScale,gScale);
				InitObject.OrbitDengYue.transform.Translate(Vector3.down*Time.deltaTime/8);
			}
			else if(timeLast-timeState >7 && timeLast-timeState <15 && bOrbit)
			{
				Music.Play("tomoon",ref Music.bResetM[24]);
				InitObject.OrbitZongHe.transform.Translate(new Vector3(1.3f,-12,-1.1f)*Time.deltaTime*10);		
				if(gTime<0.1f)
				{
					gTime +=Time.deltaTime;
				}
				else
				{
					gTime = 0.0f;
					gScale-=Time.deltaTime/4;
				}
				InitObject.OrbitDengYue.transform.localScale = new Vector3(gScale,gScale,gScale);
				InitObject.OrbitDengYue.transform.Translate(Vector3.down*Time.deltaTime/8*10);
				InitObject.OrbitDengYue.transform.Translate(Vector3.forward*Time.deltaTime/16*10);
				InitObject.OrbitDengYue.transform.Translate(Vector3.right*Time.deltaTime/16*10);
			}
			else if(timeLast-timeState >15 && timeLast-timeState <33 && bOrbit)
			{
				Music.Play("orbit1",ref Music.bResetM[15]);
				//orbitCam0.SetActive(false);
				InitObject.OrbitZongHe.SetActive(false);
                //RocketFlame.bStartF4 = false;
                if (isCam1)
                {
                    orbitCam1.SetActive(true);
                    fireCam.transform.position = orbitCam1.transform.position;
                    fireCam.transform.rotation = orbitCam1.transform.rotation;
                    fireCam.transform.parent = orbitCam1.transform;
                    OrbitCam0111.SetActive(false);
                }
                if (isCam1==false)
                {
                    OrbitCam0111.SetActive(true);
                    fireCam.transform.position = OrbitCam0111.transform.position;
                    fireCam.transform.rotation = OrbitCam0111.transform.rotation;
                    fireCam.transform.parent = OrbitCam0111.transform;
                    orbitCam1.SetActive(false);
                }
                if (Input.GetKeyDown(KeyCode.B))
                {
                    isCam1 = !isCam1;
                 
                    
                }
				InitObject.OrbitZongHe1.SetActive(true);				
				InitObject.OrbitZongHe1.transform.RotateAround(InitObject.OrbitMoon.transform.position,new Vector3(0,1,0),Time.deltaTime*24);
				InitObject.OrbitZongHe1.transform.Translate(new Vector3(0,0,1)*Time.deltaTime/2.8f);
			}
			else if(timeLast-timeState >33 && bOrbit)
			{
                InitObject.OrbitZongHe2.SetActive(true);
               /* fireCam.transform.position = orbitCam2.transform.position;
                fireCam.transform.rotation = orbitCam2.transform.rotation;
                fireCam.transform.parent = orbitCam2.transform;*/
				orbitCam1.SetActive(false);
                OrbitCam0111.SetActive(false);
				InitObject.OrbitZongHe1.SetActive(false);
				

                if (isCam2)
                {
                    orbitCam2.SetActive(true);

                    fireCam.transform.position = orbitCam2.transform.position;
                    fireCam.transform.rotation = orbitCam2.transform.rotation;
                    fireCam.transform.parent = orbitCam2.transform;
                    OrbitCam0222.SetActive(false);
                }
                if (isCam2==false)
                {
                    OrbitCam0222.SetActive(true);
                    fireCam.transform.position = OrbitCam0222.transform.position;
                    fireCam.transform.rotation = OrbitCam0222.transform.rotation;
                    fireCam.transform.parent = OrbitCam0222.transform;
                    
                    orbitCam2.SetActive(false);
                }
                if (Input.GetKeyDown(KeyCode.B))
                {
                    isCam2 = !isCam2;
                 
                
                }
				InitObject.OrbitDengYue2.SetActive(true);				
				timeLast = 0;
				timeBegin = Time.time;
				bEvent1 = false;
				Music.Play("zhuolu",ref Music.bResetM[16]);
			}			
		}
		else if(bEvent2)
		{
			if((Socket.operateDate.DengYue || timeLast>12) && !bOrbitSeparate)
			{
				timeState = timeLast;
				bOrbitSeparate = true;
			}			
			if(timeLast-timeState <9 && bOrbitSeparate)
			{				
				InitObject.OrbitDengYue2.transform.Translate(Vector3.down * Time.deltaTime/16);
				InitObject.OrbitZongHe2.transform.Translate(Vector3.up * Time.deltaTime/8);				
			}
			else if(timeLast-timeState >9 && bOrbitSeparate)
			{
              
				InitObject.OrbitDengYue2.SetActive(false);
				bEvent1 = bEvent2 = bEvent3 =true;
				timeLast = 0;
				timeBegin = Time.time;
				gameState = STATE_FOURTH;
                landCam.SetActive(true);
                fireCam.transform.position = landCam.transform.position;
                fireCam.transform.rotation = landCam.transform.rotation;
                fireCam.transform.parent = landCam.transform;
                fireCam.transform.LookAt(InitObject.LandMoonCarOut.transform);
                orbitCam2.SetActive(false);
                OrbitCam0222.SetActive(false);			
				Music.Play("fantui",ref Music.bResetM[17]);						
			}
		}
	}
	
	void PressFourth()
	{
        sky1.material = skybox;
        sky2.material = skybox;
		bRunReady = false;
        landCam.SetActive(true);
        fireCam.transform.position = landCam.transform.position;
        fireCam.transform.rotation = landCam.transform.rotation;
        fireCam.transform.parent = landCam.transform;
        fireCam.transform.LookAt(InitObject.LandMoonCarOut.transform);
        orbitCam2.SetActive(false);
        OrbitCam0222.SetActive(false);	
		//landCam.SetActive(true);
	}
	
    bool bBcak = false;	
	public GameObject landCam;
	public GameObject CarCam;
    public GameObject CarCam11;
    bool isCarCam = true;
	public GameObject landLight;

	void UpdateFourth()
	{
        landCam.SetActive(true);
     
		if(bEvent1)
		{
			if(timeLast<14.4f)
			{
				if(timeLast>13)
				{
					RocketFlame.bStartLF = false;
					Music.StopBG();
				}
				else if(timeLast>0)
				{
					Music.PlayBG("rocket1", ref Music.bResetM[32]);
					RocketFlame.bStartLF = true;
				}
				InitObject.LandMoonCarOut.transform.Translate(Vector3.down * Time.deltaTime/1f);
			}
			else if(timeLast<15f)
			{
				MyAnimation.Play("MoonCar@Out","Out");
				Music.Play("car",ref Music.bResetM[18]);
			}
			else if(timeLast>25)
			{
				//MyAnimation.Play("MoonCar@Out","Reset");
				landCam.SetActive(false);
				//InitObject.LandMoonCar.SetActive(true);
				//CarCam.SetActive(true);				
				timeBegin = Time.time;
				bEvent1 = false;	
				//Music.Play("back",ref Music.bResetM[22]);
			}
				
		}
		else if(bEvent2)
		{
			if((Socket.operateDate.Back || timeLast>15) && !bBcak)
			{
				bBcak = true;
				timeBegin = Time.time;
				MyAnimation.Play("MoonCar@Out","Reset");
                InitObject.LandMoonCar.SetActive(true);
                if (isCarCam)
                {
                    fireCam.transform.position = CarCam.transform.position;
                    fireCam.transform.rotation = CarCam.transform.rotation;
                    fireCam.transform.parent = CarCam.transform;


                }
                if (isCarCam==false)
                {
                    fireCam.transform.position = CarCam11.transform.position;
                    fireCam.transform.rotation = CarCam11.transform.rotation;
                    fireCam.transform.parent = CarCam11.transform;
                }
                if (Input.GetKeyDown(KeyCode.B))
                {
                    isCarCam = !isCarCam;
                 

                }
				landCam.SetActive(false);
                Invoke("sucess", 20f);

				//InitObject.LandMoonCar.SetActive(false);
				//CarCam.SetActive(false);
				//Music.Play("middle",ref Music.bResetM[19]);
			}
		}
		else if(bEvent3)
		{
           // Debug.Log("mooncar");
		}
	}
    public ExampleMenu label_text;
    public Move move;
    private void sucess()
    {
        move.enabled = false;
        label_text.enabled = true;
        Invoke("ReturnMenuScene", 5.0f);
    }
	void OnGUI()
	{
		if(bRunReady)
		{
			Texture2D BGTex = Resources.Load("BGTex") as Texture2D;
			//GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),BGTex,ScaleMode.StretchToFill);
		}
		if(bBcak)
		{
			//MovieTexture movTex = Resources.Load("middle") as MovieTexture;
			//GUI.DrawTexture(new Rect(0,0,1920,1080),movTex,ScaleMode.StretchToFill);
			//if(!movTex.isPlaying)
			//{
				//movTex.Play();
				
				//timeState = timeLast;
			//}
			if(timeLast - timeState >174)
			{
				bBcak = false;
				//movTex.Stop();	
				timeBegin = Time.time;
				gameState = STATE_READY;
			}
		}
	}
    void ReturnMenuScene()
    {
            Application.LoadLevel(0);
    }

    void rocketRote()
    {
   
    }
}
