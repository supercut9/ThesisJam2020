using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class CtoFungus3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Flowchart.BroadcastFungusMessage("messageDownThird");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
