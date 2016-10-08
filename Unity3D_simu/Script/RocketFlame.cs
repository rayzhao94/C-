using UnityEngine;
using System.Collections;

public class RocketFlame : MonoBehaviour {
	
	void Start ()
	{	
	}
	//Fire	
	public Flame flame0;
	public Flame flame1;
	public Flame flame2;
	public Transform smoke;
	static public bool bStart = false;
	
	//Separate
	public Flame F1;
	public Flame F2;
	public Flame F3;
    public Flame F4;
	static public bool bStartF1 = false;
	static public bool bStartF2 = false;
	static public bool bStartF3 = false;
    static public bool bStartF4 = false;
	public Flame LandF;
	static public bool bStartLF;
	
	public SmokeStart[] FlameU;
	public Flame[] FlameD;
	public Flame[] FlameL;
	public Flame[] FlameR;


	static public bool bStartU;
	static public bool bStartD;
	static public bool bStartL;
	static public bool bStartR;
	void Update ()
	{
       // Debug.Log(transform.gameObject.name);
        //Debug.Log("flame");
		if(bStart)
		{
			flame0.StartFlame();
			flame1.StartFlame();
			flame2.StartFlame();
			//smoke.position = new Vector3(1033,4,2336);
            smoke.localPosition = new Vector3(4.5f, 4, 11);
		}
		else
		{
			flame0.StopFlame();
			flame1.StopFlame();
			flame2.StopFlame();
			smoke.position = new Vector3(1033,-1000,2336);
		}	
		
		if(bStartF1) {F1.StartFlame();} else {F1.StopFlame();}
		
		if(bStartF2) {F2.StartFlame();}	else {F2.StopFlame();}
		
		if(bStartF3) {F3.StartFlame();} else {F3.StopFlame();}

        if (bStartF4) { F4.StartFlame(); } else { F4.StopFlame(); }

		if(bStartLF) {LandF.StartFlame();} else {LandF.StopFlame();}
		
		if(bStartU)
		{
            foreach (SmokeStart fu in FlameU)
			{
                fu.strat_smoke();

			}
		}
		else
		{
            foreach (SmokeStart fu in FlameU)
			{
                fu.stop_smoke();
			}
		}

        /*if(bStartD)
        {
            foreach(Flame fd in  FlameD )
            {
                fd.StartFlame();
            }
        }
        else
        {
            foreach(Flame fd in  FlameD )
            {
                fd.StopFlame();
            }
        }
		
        if(bStartL)
        {
            foreach(Flame fl in  FlameL )
            {
                fl.StartFlame();
            }
        }
        else
        {
            foreach(Flame fl in  FlameL )
            {
                fl.StopFlame();
            }
        }
		
        if(bStartR)
        {
            foreach(Flame fr in  FlameR )
            {
                fr.StartFlame();
            }
        }
        else
        {
            foreach(Flame fr in  FlameR )
            {
                fr.StopFlame();
            }
        }*/
	}
}
