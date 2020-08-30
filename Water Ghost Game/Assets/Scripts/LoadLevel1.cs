using UnityEngine;
using System.Collections;

public class LoadLevel1 : MonoBehaviour
{


    public AudioClip Drowning;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(LoadDrowning("MainScreen"));
    }

    IEnumerator LoadDrowning(string levell)
    {
        yield return new WaitForSeconds(20.0f); // wait time
        GetComponent<AudioSource>().PlayOneShot(drowning1);

        yield return new WaitForSeconds(10.0f);

        Application.LoadLevel(levell);
    }

}