using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MathUtil;

public class NPCController : MonoBehaviour
{
    GameObject player;

    public GameObject nameCanvas;
    public float sight;

    //called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    //called once per frame
    void Update()
    {
        if(Util.CanSeeObj(player, gameObject, sight))
        {
            //print("I CAN SEE THE PLAYER");
        }

        Util.ObjSide(player, gameObject);

        nameCanvas.transform.forward = Camera.main.transform.forward;
    }
}
