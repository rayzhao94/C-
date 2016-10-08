using UnityEngine;
using System.Collections;

public class ThirdandFirst : MonoBehaviour {
    public Transform cameraTransform;
    public Transform oriTriansform;
    private Vector3 FirstPosition;
    private Quaternion FirstRotion;

    public Transform cube;
    bool isB = false;
    // Use this for initialization
    void Start()
    {

    }
    void Awake()
    {
        FirstPosition = this.transform.localPosition;//保存原始位置
        FirstRotion = this.transform.localRotation;//保存原始角度

    }

    // Update is called once per frame
    void Update()
    {
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

            this.transform.localPosition = Vector3.Lerp(oriTriansform.localPosition, cameraTransform.localPosition, 0.2f);
            this.transform.localRotation = Quaternion.Lerp(oriTriansform.localRotation, cameraTransform.localRotation, 0.2f);
        }
        if (!isB)
        {
            if (transform.localPosition == cameraTransform.localPosition)
            {
                transform.localPosition = FirstPosition;
                transform.localRotation = FirstRotion;
                //this.transform.localPosition = Vector3.Lerp(cameraTransform.localPosition, cube.localPosition, 0.2f);
                //this.transform.localRotation = Quaternion.Lerp(cameraTransform.localRotation, cube.localRotation, 0.2f);
             
            }

        }
    }
}
