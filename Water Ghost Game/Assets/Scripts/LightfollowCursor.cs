using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightfollowCursor : MonoBehaviour
{
    // Start is called before the first frame update
    //private Vector3 _mousePosition;
    //public GameObject _yellowFollow;
    private RectTransform _RectTransform;

    void Start()
    {
      _RectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void OnGUI()
    {
      //_mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      //GUI.DrawTexture(new Rect(_mousePosition.x,Screen.height - _mousePosition.y,_cursorTexure.width/10,_cursorTexure.height/10),_cursorTexure);

      CanvasScaler scaler = GetComponentInParent<CanvasScaler>();
      _RectTransform.localPosition  = new Vector2(Input.mousePosition.x * scaler.referenceResolution.x / Screen.width, Input.mousePosition.y * scaler.referenceResolution.y / Screen.height);
    }
}
