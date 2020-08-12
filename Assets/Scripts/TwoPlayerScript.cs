using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TwoPlayerScript : MonoBehaviour
{
    public GameObject gameObject;
    private ScriptMain actionTarget;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        actionTarget = gameObject.GetComponent<ScriptMain>();
    }

    void OnMouseDown()
    {
        actionTarget.test(1);
        //ScriptMain.modeSelection = 1;
        UnityEngine.Debug.Log(i);

    }
}
