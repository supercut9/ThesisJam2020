using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUp : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _cameraUp;
    //public GameObject _RefCameraUp;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      /*
      if (_RefCameraUp.active) {
        _cameraUp.SetActive(true);
      }
*/
      if (_cameraUp.active) {
        //mian code starts
        if (Mathf.Abs(transform.position.z) < Mathf.Abs(_cameraUp.transform.position.z) ) {
          transform.RotateAround(transform.position, Vector3.right, 20 * Time.deltaTime * 1.2f);
          //transform.Translate(Vector3.forward * Time.deltaTime * 0.7f);
          transform.position = Vector3.MoveTowards(transform.position, _cameraUp.transform.position, Time.deltaTime * 0.42f);
        }
        if (transform.position.z == _cameraUp.transform.position.z) {
          _cameraUp.SetActive(false);
        }
        //mian code ends
      }
    }
}
