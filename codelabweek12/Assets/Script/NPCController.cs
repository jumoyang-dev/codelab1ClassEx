using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MathUtil;

public class NPCController : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if (Util.CanSeeObj(player, gameObject, 0.9f))
        {
            Debug.Log("can see player");
        }
        Util.ObjSide(player, gameObject);
    }
}
