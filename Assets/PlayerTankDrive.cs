using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTankDrive : MonoBehaviour
{
    public float speed = 10f;
    public static float rotSpeed=10f;
    Rigidbody rbTank;
  
    public static float forwardBack;
    public static float leftRight;
    bool forward =false;
    bool back= false;
     bool left = false;
    bool right = false;

       void Awake()
    {
        rbTank = GetComponent<Rigidbody>();
    }
    public void Forward()
    {
        forward = true;
    }
    public void Back()
    {
        back = true;
    }
     public void Left()
    {
        left = true;
    }
    public void Right()
    {
        right = true;
    }
   

    // Update is called once per frame
    void Update()
    {
       forwardBack = Input.GetAxis("Vertical") * speed * Time.deltaTime;
       leftRight = Input.GetAxis("Horizontal")* rotSpeed * Time.deltaTime;
      

       if(forward == true)
       {
        forwardBack = -1f;
       } 
       if(back == true)
       {
        forwardBack = 1f;
       }
        if(left == true)
       {
        leftRight = -1f;
       }
       if(right == true)
       {
        leftRight= 1f;
       }
     
    
    }
     void FixedUpdate()
    {
        TankForwardBack();   
        TankRotateLeftRight(); 
    }
    void TankForwardBack()
    {
        Vector3 moveFB = transform.forward * forwardBack * speed *Time.deltaTime;
        rbTank.MovePosition(rbTank.position + moveFB);
    }
     void TankRotateLeftRight()
    {
        Quaternion rotateLR = Quaternion.Euler(0f , leftRight , 0f);
        rbTank.MoveRotation(rbTank.rotation * rotateLR);
    }
  
    public void SwitchBoolsOff()
    {
        forward =  false;
        back = false;
        left=false;
        right=false;
       
    }
}
