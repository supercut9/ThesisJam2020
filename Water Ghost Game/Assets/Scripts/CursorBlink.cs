using UnityEngine;

public class CursorBlink : MonoBehaviour
{
    
    void OnGUI()
    {
        GUI.skin.settings.cursorFlashSpeed = -1;
        
    }
}