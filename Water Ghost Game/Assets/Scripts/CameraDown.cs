using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDown : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _cameraDown;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      //transform.eulerAngles = new Vector3(0,0,90);
      //transform.Rotate ( Vector3.up * ( RotationSpeed * Time.deltaTime ) );
      //transform.Rotate ( Vector3.forward);
      //transform.LookAt(target);
      //transform.rotation = Quaternion.LookRotation(Vector3.down);
      //transform.rotation = Quaternion.Euler(45*Time.deltaTime,0,0);

      if (Input.GetKeyDown(KeyCode.D)) {
        _cameraDown.SetActive(true);
      }

      if (_cameraDown.active) {
        //mian code starts
        if (transform.eulerAngles.x <= 50) {
          transform.RotateAround(transform.position, Vector3.right, 20 * Time.deltaTime);
          //transform.Translate(Vector3.forward * Time.deltaTime * 0.7f);
          transform.position = Vector3.MoveTowards(transform.position, _cameraDown.transform.position, Time.deltaTime * 0.7f);
        }
        else{
          _cameraDown.SetActive(false);
        }
        //mian code ends
      }
    }
}
