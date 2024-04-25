using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class FaceCoords : MonoBehaviour {
    // Start is called before the first frame update
    private ARFace arFace;
 
    Transform bubble;

    
    void Start()
    {
       /*arFace = GetComponent<ARFace>();*/
        bubble = transform.GetChild(0);
        bubble.transform.eulerAngles = BubbleData.rotation;
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateBubble();

       /* if (arFace*//**//*.leftEye.b)*/



             
    }

    void RotateBubble()
    {
        bubble.Rotate(new Vector3(0, 0, 2f));
        BubbleData.rotation = bubble.transform.eulerAngles;
        Debug.Log(bubble.rotation.eulerAngles.x);
    }
}
