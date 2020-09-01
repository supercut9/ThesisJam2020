using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class CameraDowntoFungus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      Flowchart.BroadcastFungusMessage("messageAboutCameraDown");
    }

    // Update is called once per frame
    void Update()
    {

      //Debug.Log("stop changing");
      //if (Input.anyKeyDown) {
      //Flowchart.BroadcastFungusMessage("time to start");
      //}


    }
}
