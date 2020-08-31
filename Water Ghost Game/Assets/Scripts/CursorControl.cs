using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class CursorControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _InvisibleRef;
    //cursor general setup
    public CursorMode _cursorMode = CursorMode.Auto;
    public Vector2 _hotSpot;
    //move with cursor
    private Vector3 _mousePosition;
    //cursor shine 1st
    public GameObject _yellowLightRef;
    public Texture2D _cursorYellow1;
    public Texture2D _cursorOver;
    public Texture2D _cursorWipe;

    public GameObject _mirrorCover;

    //private float _changeA = 0;
    private SpriteRenderer _rend;

    public GameObject _RefCameraDown;

    public bool cameraActive = false;

    private float _t = 0;
    private float _dt = 0;

    void Start()
    {
      _hotSpot = new Vector2 (_cursorYellow1.width, _cursorYellow1.height);
      _rend = _mirrorCover.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

      if (_InvisibleRef.active) {
        Cursor.visible = false;
      }
      else{
        Cursor.visible = true;
      }
/*
      if (_yellowLightRef.active) {
        //follow cursor ends
        Cursor.SetCursor(_cursorYellow1, _hotSpot, _cursorMode);
      }
      else {
        Cursor.SetCursor(null, Vector2.zero, _cursorMode);
      }
      */

      if (cameraActive) {
        _mirrorCover.SetActive(false);
        _RefCameraDown.SetActive(true);
      }



    }

    void OnMouseOver(){
      Cursor.SetCursor(_cursorOver, _hotSpot, _cursorMode);
      if (Input.GetMouseButton(0)) {
        //_changeA += 1;
        Cursor.SetCursor(_cursorWipe, _hotSpot, _cursorMode);
        //Flowchart.BroadcastFungusMessage("Camera Down 1");
        //_t = Time.time;
        StartCoroutine(FadeTo(0.0f, 5.0f - _dt));
      }
      else{
        //StopCoroutine(FadeTo(0.0f, 5.0f - _dt));
        //_dt += Time.time - _t;
        Cursor.SetCursor(_cursorOver, _hotSpot, _cursorMode);
        //_changeA = false;
      }
      /*
      while (_changeA && _rend.color.a != 0f){
        _rend.color -= new Color(0f,0f,0f,1f) * Time.deltaTime;
      }
      */
    }


    void OnMouseExit(){
      if (_yellowLightRef.active) {
        //follow cursor ends
        Cursor.SetCursor(_cursorYellow1, _hotSpot, _cursorMode);
      }
      else {
        Cursor.SetCursor(null, Vector2.zero, _cursorMode);
      }
    }

    IEnumerator FadeTo(float aValue, float aTime){
    float alpha = _rend.color.a;
    float _aaa = 0;
    for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
    {
        Color newColor = new Color(_rend.color.r, _rend.color.g, _rend.color.b, Mathf.Lerp(alpha,aValue,t));
        _rend.color = newColor;
        _aaa = _rend.color.a;
        yield return null;
    }
    /*
    if (_aaa == 0) {
      _mirrorCover.SetActive(false);
      _RefCameraDown.SetActive(true);
    }
    */
    //yield return new WaitForSeconds(5);
    cameraActive = true;
  }
/*
  IEnumerator FadeTo(float aValue, float aTime){
  */

}
