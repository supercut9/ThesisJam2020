using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _modelKira;
    public Material _KiraNormal;
    public Material _KiraGhost;

    public GameObject _Octopus;

    private Material _Kira;

    public GameObject _RefNormal;
    public GameObject _RefGhost;

    void Start()
    {
      //Debug.Log("Running");
      _Kira = _modelKira.GetComponent<SkinnedMeshRenderer>().material;

    }

    // Update is called once per frame
    void Update()
    {

      //_Kira = _KiraNormal;
      if (_RefNormal.active) {
        _modelKira.GetComponent<SkinnedMeshRenderer>().material = _KiraNormal;
      }
      if (_RefGhost.active) {
        _modelKira.GetComponent<SkinnedMeshRenderer>().material = _KiraGhost;
        _Octopus.SetActive(true);
      }

      if (!_RefNormal.active && !_RefGhost.active) {
        _modelKira.GetComponent<SkinnedMeshRenderer>().material = _Kira;
        _Octopus.SetActive(false);
      }

    }
}
