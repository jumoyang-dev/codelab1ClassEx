using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MathUtil;

public class NPCController : MonoBehaviour
{
    GameObject player;

    public GameObject nameCanvas;
    //show how much NPC can see
    public float sight;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if (Util.CanSeeObj(player, gameObject, sight))
        {
            Debug.Log("can see player");
        }
        Util.ObjSide(player, gameObject);

        nameCanvas.transform.forward = Camera.main.transform.forward;
    }
}
