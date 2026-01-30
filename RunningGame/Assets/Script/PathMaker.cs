using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathMaker : MonoBehaviour
{
    public GameObject Block;
    // Start is called before the first frame update
    void Start()
    {
       GameObject obj = Instantiate(Block);

        obj.transform.position = new Vector3(10f, 0f, 0f);
        obj.transform.eulerAngles = new Vector3(90f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
