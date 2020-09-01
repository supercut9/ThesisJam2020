using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class CheckBeta : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer _rend;
    public GameObject _RefCameraUp;

    void Start()
    {
        _rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_rend.color.a == 0f)
        {
            //this.SetActive(false);
            Debug.Log("Received");
            //Flowchart.BroadcastFungusMessage("Camera Up 1");
            _RefCameraUp.SetActive(true);
        }
    }
}
