using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {

	static public bool[] bResetM;
	static AudioSource musicAudio;
	static AudioSource bgAudio;
	void Start ()
	{	
		bResetM = new bool[100];
		musicAudio = audio;	
		GameObject _bgObj = GameObject.Find("bgMusic");
		bgAudio = _bgObj.audio;
	}	

	void Update ()
	{
		
	}
	
	//static bool bPlay = true;
	static public void Play(string name,ref bool bReset)
	{		

		if(bReset)
		{
			//bPlay = true;
		}
		else if(!bReset /*&& bPlay*/)
		{
			musicAudio.Stop();
			//bPlay = false;
			string _name = "Sound/"+name;
	     	AudioClip _clip = Resources.Load(_name) as AudioClip;
			musicAudio.PlayOneShot(_clip);
			bReset = true;			
		}		
	}
	
	static public void Stop()
	{
		musicAudio.Stop();
	}
	
	//static bool bPlayBG = true;
	static public void PlayBG(string name,ref bool bReset)
	{
		if(bReset)
		{
			//bPlayBG = true;
//			if(bgAudio.volume< 1)
//			{
//				bgAudio.volume += 0.01f;
//			}
		}
		else if(!bReset /*&& bPlayBG*/)
		{
			//bPlayBG = false;
			string _name = "Sound/"+name;
	     	AudioClip _clip = Resources.Load(_name) as AudioClip;
			bgAudio.clip = _clip;
			bgAudio.loop = true;
			bgAudio.volume = 1;
			bgAudio.Play();
			bReset = true;
		}
	}
	
	static public void StopBG()
	{
		bgAudio.Stop();		
	}
}
