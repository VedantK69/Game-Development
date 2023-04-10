using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerController player;
    public float sensitivity = 200;
    private float clampAngle = 85f;
  
    private float verticalRotation;
    private float horizontalRotation;

  private void Start()
  {

    this.verticalRotation = this.transform.localEulerAngles.x;
    this.horizontalRotation = this.transform.eulerAngles.y;
  }

  private void LateUpdate()
  {
    Look();
    Debug.DrawRay(this.transform.position, this.transform.forward * 2, Color.red);
  }
  private void LateUpdate1()
  {
    Look();
    Debug.DrawRay(this.transform.position, this.transform.forward * 2, Color.red);
  }


    private void Look()
    {
    float mouseVertical = -Input.GetAxis("Mouse Y");
    float mouseHorizontal = -Input.GetAxis("Mouse X");
                
    this.verticalRotation += mouseVertical * sensitivity * Time.deltaTime;
    this.horizontalRotation += mouseHorizontal * sensitivity * Time.deltaTime;

    this.verticalRotation = Mathf.Clamp(this.verticalRotation, -this.clampAngle, this.clampAngle);
    
    this.transform.localRotation = Quaternion.Euler(this.verticalRotation, 0f, 0f);
    this.player.transform.rotation = Quaternion.Euler(0f, this.horizontalRotation, 0f);
    }
}
