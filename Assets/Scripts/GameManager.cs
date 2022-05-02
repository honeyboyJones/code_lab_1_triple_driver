using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> npcObjs = new List<GameObject>();
    
    //called before the first frame update
    void Start()
    {
        //loop through all the NPCs (for loop, for each)
        //access each npcObj
        //access each npcObj text component
        //set the text of that text component

        // foreach(GameObject NPC in npcObjs)
        // {
        //     NPC.GetComponent<NPCController>().nameCanvas.transform.GetChild(0);
        // }

        for(int i = 0; i < npcObjs.Count; i++)
        {
            npcObjs[i].GetComponentInChildren<TextMeshProUGUI>().SetText("COOL PLAYER");
        }
    }

    //called once per frame
    void Update()
    {
        
    }
}
