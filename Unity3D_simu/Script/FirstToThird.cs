using UnityEngine;
using System.Collections;

public class FirstToThird : MonoBehaviour {
    public Transform cameraTransform;
    public Transform oriTriansform;
    private Vector3 FirstPosition;
    private Quaternion FirstRotion;
     bool isB = false;
	// Use this for initialization
     void Start() { 

     }
     void Awake()
     {

         oriTriansform.localPosition = this.transform.localPosition;//保存原始位置
         oriTriansform.localRotation = this.transform.localRotation;//保存原始角度
       // Debug.Log("1" + oriTriansform.localPosition + "  " + oriTriansform.localRotation);
         //Debug.Log("adfaf");

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.B))
        {
            isB = !isB;
        }
        FirstToThirdToFirst();
	}

    private void FirstToThirdToFirst()
    {
        if (isB)
        {
            
            Debug.Log("2" + oriTriansform.localPosition );
            this.transform.localPosition = Vector3.Lerp(oriTriansform.localPosition, cameraTransform.localPosition,0.1f);
            this.transform.localRotation = Quaternion.Lerp(oriTriansform.localRotation, cameraTransform.localRotation, 0.1f);
        }
        if (!isB)
        {
            if (transform.localPosition == cameraTransform.localPosition)
            {
                Debug.Log("3" + oriTriansform.localPosition );
                //Debug.Log("shi fou xiang deng");
                this.transform.localPosition = Vector3.Lerp(cameraTransform.localPosition, oriTriansform.localPosition, 0.1f);
                this.transform.localRotation = Quaternion.Lerp(cameraTransform.localRotation, oriTriansform.localRotation, 0.1f);
            }
           
        }
    }
}
