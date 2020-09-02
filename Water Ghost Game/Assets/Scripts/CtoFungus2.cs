using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class CtoFungus2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Flowchart.BroadcastFungusMessage("messageDownSecond");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
