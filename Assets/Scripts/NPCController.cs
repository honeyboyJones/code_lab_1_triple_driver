using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MathUtil;

public class NPCController : MonoBehaviour
{
    GameObject player;

    //called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    //called once per frame
    void Update()
    {
        if(Util.CanSeeObj(player, gameObject, 0.9f))
        {
            //print("I CAN SEE THE PLAYER");
        }

        Util.ObjSide(player, gameObject);
    }
}
