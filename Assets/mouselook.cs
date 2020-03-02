using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    public float mouseSens = 100f; //Defines the mouse sensitivity (Could Make Varible?)
    public Transform playerModel;
    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //Stops Cursor From being used
    }
    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime; //Mouse Tracking For X axis and Y axis movement
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRotation -= mouseY; //y-axis lookscript
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        playerModel.Rotate(Vector3.up * mouseX); //x-axis LookScript
    }
}
    //Helpful Links 
    // https://www.youtube.com/watch?v=_QajrabyTJc
    // https://docs.unity3d.com/Manual/CreatingAndUsingScripts.html
    // https://docs.unity3d.com/Manual/UnderstandingVectorArithmetic.html
    // https://docs.unity3d.com/Manual/EventFunctions.html