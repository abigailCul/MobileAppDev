using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{

    public Text tCount;

    GameObject gOb = null;
    Plane obPlane;
    Vector3 mO;

   private Ray GenerateMouseRay(Vector3 touchPos)
    {
        Vector3 mousePosFar = new Vector3(touchPos.x, touchPos.y,
            Camera.main.farClipPlane);

        Vector3 mousePosNear = new Vector3(touchPos.x, touchPos.y, Camera.main.nearClipPlane);

        Vector3 mousePosF = Camera.main.ScreenToViewportPoint(mousePosFar);
        Vector3 mousePosN = Camera.main.ScreenToViewportPoint(mousePosNear);

        Ray mr = new Ray(mousePosN, mousePosF - mousePosN);
        return mr;
    }

    void Update()
    {
        tCount.text = Input.touchCount.ToString();

        if(Input.touchCount > 0)
        {
            if(Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Ray mouseRay = GenerateMouseRay(Input.GetTouch(0).position);
                RaycastHit hit;

                if(Physics.Raycast(mouseRay.origin, mouseRay.direction, out hit))
                {
                    gOb = hit.transform.gameObject;
                    obPlane = new Plane(Camera.main.transform.forward * -1, gOb.transform.position);

                    //calc touch offset m
                    Ray mRay = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                    float rayDistance;
                    obPlane.Raycast(mRay, out rayDistance);

                }
            }
        }
    }
}
