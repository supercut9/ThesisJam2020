using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class erase : MonoBehaviour
{
    // Start is called before the first frame update
    public Texture2D _cursorOver;
    public Texture2D _cursorWipe;
    public CursorMode _cursorMode = CursorMode.Auto;
    public Vector2 _hotSpot;

    public GameObject _mirrorCover;

    private bool _changeA;
    private SpriteRenderer _rend;

    public GameObject _cameraDownRef;

    void Start()
    {
      _changeA = false;
      _rend = _mirrorCover.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
      _hotSpot = new Vector2 (_cursorOver.width, _cursorOver.height);
      if (_rend.color.a == 0f) {
        _mirrorCover.SetActive(false);
        Flowchart.BroadcastFungusMessage("Camera Down 1");
      }
    }

    void OnMouseOver(){
      Cursor.SetCursor(_cursorOver, _hotSpot, _cursorMode);
      if (Input.GetMouseButton(0)) {
        Cursor.SetCursor(_cursorWipe, _hotSpot, _cursorMode);
        _changeA = true;
      }
      else{
        _changeA = false;
      }
      while (_changeA && _rend.color.a != 0f){
        _rend.color -= new Color(0f,0f,0f,1f) * Time.deltaTime;
      }
    }

    void OnMouseExit(){
      Cursor.SetCursor(_cursorWipe, _hotSpot, _cursorMode);
    }
}
