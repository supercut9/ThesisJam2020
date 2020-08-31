using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 _mousePosition;

    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
      _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      transform.position = new Vector3(_mousePosition.x, _mousePosition.y, transform.position.z);
    }
}
