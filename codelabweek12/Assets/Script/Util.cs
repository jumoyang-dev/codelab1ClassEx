using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathUtil
{
    public class Util : MonoBehaviour
    {
        public static bool CanSeeObj(GameObject destination, GameObject origin, float range)                            //function to draw a vector between the object and a target
        {
            Vector3 dir = Vector3.Normalize(destination.transform.position - origin.transform.position);
            float angleDis = Vector3.Dot(origin.transform.forward, dir);

            Debug.DrawRay(origin.transform.position, origin.transform.forward * 10, Color.red);
            Debug.DrawRay(origin.transform.position, dir * 10, Color.green);

            if (angleDis > range)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Vector3 ObjSide(GameObject destination, GameObject origin)                                    //function to clamp the maximum vision of the object
        {
            Vector3 dir = Vector3.Normalize(destination.transform.position - origin.transform.position);
            Vector3 crossProd = Vector3.Cross(origin.transform.forward, dir);
            if (crossProd.y < 0)
            {
                //Debug.Log(destination.name + " is left of " + origin.name);
            }else
            {
                //Debug.Log(destination.name + " is right of " + origin.name);
            }
            return crossProd;
        }

    }
}
