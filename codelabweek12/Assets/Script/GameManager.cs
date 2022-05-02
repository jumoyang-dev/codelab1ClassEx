using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    //TMP_Text text;
    //list holding the NPCs
    //public List<GameObject> npcObjs = new List<GameObject>();
    public GameObject prefab;

    Dictionary<string, float> npcInfo = new Dictionary<string, float>();

    void Start()
    {
        npcInfo.Add("bob", 0.9f);
        npcInfo.Add("lorg", 0.8f);
        npcInfo.Add("akshay", 0.6f);
        npcInfo.Add("sophie", 0.95f);

        //float testValue;
        //npcInfo.TryGetValue("akshay", out testValue);
        //Debug.Log(testValue);

        foreach (KeyValuePair<string, float> pair in npcInfo)
        {
            Debug.Log(pair.Key);
            Debug.Log(pair.Value);

            GameObject clone = Instantiate(prefab, new Vector3(Random.Range(-14, 14), 0.5f, Random.Range(-14, 14)),Quaternion.identity);

            clone.GetComponentInChildren<TextMeshProUGUI>().SetText(pair.Key);
            clone.GetComponent<NPCController>().sight = pair.Value;
        }

        

        //loop thorugh dictoionay
        //for each pair in dic
        //set name to string set float to value
       // ------------------------------------------------------------------------------------
        //1.loop through all the NPCs (for/foreach loop)
        //2.access each npcObjs
        //3.access each NPC's text component 
        //4.set te text of that text component

        //foreach(var npc in npcObjs)
        //{

        //npc.GetComponentInChildren<TextMeshProUGUI>().SetText("Enemy");

        //GameObject text = child.transform.GetChild(0).gameObject;
        //text = child.GetComponent<TMP_Text>();
        //text.text = "enemy";
        //}
    }

    void Update()
    {
        
    }
}
