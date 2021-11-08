using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOfDetected : MonoBehaviour
{
    public ConeDetection _coneDetector;
    Renderer _renderer;

    public void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        _renderer.material.SetColor("_Color", Color.white);
        foreach (GameObject obj in _coneDetector.GameObjectsInCone)
        {
            if (obj.name == transform.name)
                _renderer.material.SetColor("_Color", Color.cyan);
                
        }
    }
}
