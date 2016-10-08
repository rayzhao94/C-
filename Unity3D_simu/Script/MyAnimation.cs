using UnityEngine;
using System.Collections;

public class MyAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	static private GameObject aniObj;
	static public bool Init(string aniName)
	{
		aniObj = GameObject.Find(aniName);
		if(!aniObj) return false;
		return true;			
	}
	
	static public bool Play(string actionName)
	{
		return aniObj.animation.Play(actionName);
	}
	
	static public bool Play(string aniName,string actionName)
	{
		GameObject _obj = GameObject.Find(aniName);
		if(!_obj) return false;	

		return _obj.animation.Play(actionName);
		
	}	
	
    static public bool Play(string aniName,string actionName,float speed)
	{
		GameObject _obj = GameObject.Find(aniName);
		if(!_obj) return false;		
		_obj.animation[actionName].speed = speed;
		return _obj.animation.Play(actionName);
		
	}

	static public void Stop(string aniName,string actionName)
	{
		GameObject _obj = GameObject.Find(aniName);		
		_obj.animation.Stop();
		
	}
		
	static public bool PlayCuttingAnimation(string aniName,string actionName,int startFrame, int endFrame)
	{
		GameObject _obj = GameObject.Find(aniName);
		AnimationClip _clip = _obj.animation.clip;		
		_obj.animation.AddClip(_clip,"CutClip",startFrame,endFrame);
		return _obj.animation.Play("CutClip");
	}
	
	static public bool PlayCombinedAnimation(string aniName,int startFrame0,int endFrame0,int startFrame1,int endFrame1)
	{
		GameObject _obj = GameObject.Find(aniName);
		AnimationClip _clip = _obj.animation.clip;
		_obj.animation.AddClip(_clip,"StartClip",startFrame0,endFrame0,false);
		_obj.animation.AddClip(_clip,"EndClip",startFrame1,endFrame1,false);
		_obj.animation.PlayQueued("StartClip",QueueMode.PlayNow);
		return _obj.animation.PlayQueued("EndClip",QueueMode.CompleteOthers);
		
	}
	
	static public bool PlaySilderAnimation(string aniName, string actionName, float time)
	{
		GameObject _obj = GameObject.Find(aniName);
		if(!_obj.animation.IsPlaying(actionName))
		{
			_obj.animation.Play(actionName);
		}
		_obj.animation.animation[actionName].time = time;
		
		return true;
	}
}
