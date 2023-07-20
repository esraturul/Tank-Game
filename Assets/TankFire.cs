using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankFire : MonoBehaviour
{
    public Transform firePose;
    RaycastHit hit;
    Ray ray;
    public GameObject Expeffect;

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {


            ray = new Ray(firePose.position, firePose.forward);
            if (Physics.Raycast(ray, out hit, 1000f))
            {

                if (hit.transform.gameObject != null)
                {
                    GameObject _effect = Instantiate(Expeffect, hit.point, Quaternion.LookRotation(hit.normal));
                    if(!hit.transform.gameObject.CompareTag("dontDelete"))
                    {
                        Destroy(hit.transform.gameObject);
                    }
                    Destroy(_effect, 3);
                }
               
            }
            
        }
        Debug.DrawRay(firePose.position, firePose.forward*40 , Color.red);
    }
}
