using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveManager : MonoBehaviour
{
    [SerializeField] private Transform CameraTrs;
    [SerializeField] private Transform CharTrs;
    [SerializeField] private Rigidbody Charrd;

    [SerializeField] private float m_speed;
    [SerializeField] private float m_jumpPower;

    // Update is called once per frame
    void Update()
    {
        Move(CameraTrs);
        Move(CharTrs);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Move(Transform _trs)
    {
        Vector3 pos = _trs.position;
        pos.x += m_speed * Time.deltaTime;
        _trs.position = pos;
    }

    private void Jump()
    {
        Debug.Log("Space");
        Rigidbody rigidbody = CharTrs.GetComponent<Rigidbody>();

        Vector3 power = new Vector3(0, m_jumpPower, 0);
        Charrd.AddForce(power);
    }
}
