using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToothBrush : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 mOffset;
    private float mZCoord;

    public GameObject _brushUp;
    public GameObject _brushDown;
    public GameObject _brushLeft;
    public GameObject _brushRight;

    public GameObject _brushingSound;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown(){
      mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
      // Store offset = gameobject world pos - mouse world pos
      mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
      //mOffset = new Vector3 (gameObject.transform.position.x - GetMouseAsWorldPoint().x, gameObject.transform.position.y - GetMouseAsWorldPoint().y, gameObject.transform.position.z);
   }

   private Vector3 GetMouseAsWorldPoint(){
     // Pixel coordinates of mouse (x,y)
     Vector3 mousePoint = Input.mousePosition;
     // z coordinate of game object on screen
     mousePoint.z = mZCoord;
     // Convert it to world points
     return Camera.main.ScreenToWorldPoint(mousePoint);
   }

   void OnMouseDrag(){
     transform.position = GetMouseAsWorldPoint() + mOffset;
     _brushingSound.SetActive(true);

     /*
     if (transform.position.x > _brushRight.transform.position.x) {
       //transform.position = new Vector3(GetMouseAsWorldPoint().x + mOffset.x, transform.position.y, GetMouseAsWorldPoint().z + mOffset.z);
       transform.position = new Vector3(_brushRight.transform.position.x, transform.position.y, transform.position.z);
     }

     if (transform.position.x < _brushLeft.transform.position.x) {
       transform.position.x = _brushLeft.transform.position.x;
     }

     if (transform.position.y > _brushUp.transform.position.y) {
       transform.position.y = _brushUp.transform.position.y;
     }

     if (transform.position.y < _brushDown.transform.position.y) {
       transform.position.y = _brushDown.transform.position.y;
     }
     */
   }

   void OnMouseExit(){
     _brushingSound.SetActive(false);
   }
}
