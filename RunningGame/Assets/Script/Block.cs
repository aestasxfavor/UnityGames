using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Transform TargetTrs;
    // Start is called before the first frame update
    void Start()
    {
        TargetTrs = GameObject.Find("Back").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float targetPosX = TargetTrs.position.x;
        float myPosX = transform.position.x + transform.localPosition.x;
    }
}
