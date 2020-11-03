using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public GameObject objtoChange;
    public Color ChangedColor;
    // Start is called before the first frame update
    void Start()
    {
        var shaperender = objtoChange.GetComponent<Renderer>();

        shaperender.material.SetColor("_Color", ChangedColor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
