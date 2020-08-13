using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMaterialScript : MonoBehaviour
{
    public GameObject gameObject;
    private int i;
    private ScriptMain _actionTarget;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<MeshRenderer>().material = materialArray[0];
        i = 0;
        _actionTarget = gameObject.GetComponent<ScriptMain>();

    }

    void OnMouseDown()
    {
        _actionTarget.test(i);
        //Debug.Log(i);
        //this.gameObject.GetComponent<MeshRenderer>().material = materialArray[0];

    }

}
