using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ClickOnField : MonoBehaviour
{
    public GameObject gObject;
    private ScriptMain script;

    // Start is called before the first frame update
    void Start()
    {
        script = gObject.GetComponent<ScriptMain>();

    }

    void OnMouseDown()
    {
        script.ClickOnField(gameObject);

    }
}
