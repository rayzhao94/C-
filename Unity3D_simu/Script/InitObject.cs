using UnityEngine;
using System.Collections;

public class InitObject : MonoBehaviour {
	//FS
	static public GameObject rocket1;
	//FL
	static public GameObject DictateCabin;
	static public GameObject ServiceCabin;
	static public GameObject MoonSpaceCabin;
	//TZ
	static public GameObject TZCam;
	//static public GameObject TZBG;
	static public GameObject TZCabin;
	static public Vector3 TZCabinPos;
	//DJ
	static public GameObject ButtCabin;
	static public GameObject ButtCabin1;
	static public GameObject ButtCabinMoonSpace;
	//BG
	static public GameObject OrbitZongHe;
	static public GameObject OrbitDengYue;
	static public GameObject OrbitZongHe1;
	static public GameObject OrbitMoon;
	static public GameObject OrbitDengYue2;
	static public GameObject OrbitZongHe2;
	//ZL
	static public GameObject LandMoonCarOut;
	static public GameObject LandMoonCar;
	
	static public Vector3 ButtCabinPos;
	static public Vector3 ButtCabin1Pos;
	static public Vector3 ButtCabinMoonSpacePos;
	static public Vector3 OrbitZongHePos;
	static public Quaternion OrbitZongHeQuat;
	static public Vector3 OrbitDengYuePos;
	static public Vector3 OrbitZongHe1Pos;
	static public Quaternion OrbitZongHe1Quat;
	static public Vector3 OrbitDengYue2Pos;
	static public Vector3 OrbitZongHe2Pos;
	static public Vector3 LandMoonCarOutPos;
	static public Vector3 LandMoonCarPos;
	static public Quaternion LandMoonCarQuat;
	
	static public GameObject Earth;
	static public Quaternion EarthQuat;
	
	static public GameObject OrbitScene;
	static public Quaternion OrbitSceneQuat;
	
	void Start ()
	{	
		rocket1 = GameObject.Find("Rocket1");		
		DictateCabin = GameObject.Find("polySurface585");
		ServiceCabin = GameObject.Find("polySurface586");
		MoonSpaceCabin = GameObject.Find("polySurface584");	
		TZCam = GameObject.Find("TZCam");
		//TZBG = GameObject.Find("TZBG");
		TZCabin = GameObject.Find("TiaoZi@DictateCabin");
		TZCabinPos = TZCabin.transform.position;
		
		//ButtCabin = GameObject.Find("ButtCabin");
		//ButtCabin1 = GameObject.Find("ButtCabin1");
		//ButtCabinMoonSpace = GameObject.Find("ButtCabinMoonSpace");
		
		OrbitZongHe = GameObject.Find("Orbit@ZongHeCang0");
		OrbitDengYue = GameObject.Find("Orbit@DengYueCang0");
		OrbitZongHe1 = GameObject.Find("Orbit@ZongHeCang1");
		OrbitMoon = GameObject.Find("Orbit@Moon");		
		OrbitDengYue2 = GameObject.Find("Orbit@DengYueCang2");
		OrbitZongHe2 = GameObject.Find("Orbit@ZongHeCang2");
		
		LandMoonCarOut = GameObject.Find("MoonCar@Out");
		LandMoonCar = GameObject.Find("MoonCar");
		
		//ButtCabinPos = ButtCabin.transform.position;
		//ButtCabin1Pos = ButtCabin1.transform.position;
		//ButtCabinMoonSpacePos = ButtCabinMoonSpace.transform.position;
		OrbitZongHePos = OrbitZongHe.transform.position;
		OrbitZongHeQuat = OrbitZongHe.transform.rotation;
		OrbitDengYuePos = OrbitDengYue.transform.position;
		OrbitZongHe1Pos = OrbitZongHe1.transform.position;
		OrbitZongHe1Quat = OrbitZongHe1.transform.rotation;
		OrbitDengYue2Pos = OrbitDengYue2.transform.position;
		OrbitZongHe2Pos = OrbitZongHe2.transform.position;
		LandMoonCarOutPos = LandMoonCarOut.transform.position;
		LandMoonCarPos = LandMoonCar.transform.position;
		LandMoonCarQuat = LandMoonCar.transform.rotation;
		
		Earth = GameObject.Find("Earth");
		EarthQuat = Earth.transform.rotation;
		
		OrbitScene = GameObject.Find("OrbitScene");
		OrbitSceneQuat = OrbitScene.transform.rotation;
	}	
	
	void Update ()
	{
	
	}
}
