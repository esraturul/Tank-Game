using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurretControl : MonoBehaviour
{
    public float rotSpeed=0.5f;
    bool left = false;
    bool right = false;
    public float rotspeedGun=0.25f;
     float maxGunUp =20f;
     float maxGunDown=-10f;
     float counter=0f;
     public static bool gun_up=false;
     bool gun_down=false;
     public GameObject gun;
    public void RotateLeft()
    {
        left=true;
    }
    public void RotateRight()
    {
        right = true;
    }
     public void GunUp()
    {
        gun_up = true;
    }
    public void GunDown()
    {
        gun_down= true;
    }

    void FixedUpdate()
    {
        if(left == true)
        {
            transform.Rotate(0, -rotSpeed ,0);
        }
        if(right==true)
        {
            transform.Rotate(0, rotSpeed ,0);
        }
        if(gun_down == true && counter<maxGunUp)
        {
            gun.transform.Rotate(rotspeedGun,0,0);
            counter += rotspeedGun;
        }
         if(gun_up == true && counter>maxGunDown)
        {
            gun.transform.Rotate(-rotspeedGun,0,0);
            counter -= rotspeedGun;
        }
        
     }
       public void RotateStop()
          {
        left = false;
        right = false;
        gun_up=false;
        gun_down=false;
        
    }
}
