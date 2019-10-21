using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SplineController : MonoBehaviour
{
    public CinemachinePathBase m_path;
    public CinemachinePathBase.PositionUnits m_PositionUnits = CinemachinePathBase.PositionUnits.Distance;
    public float m_speed;
    public float m_position;

    Rigidbody body;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        SetCartPosition(600);
    }

    private void FixedUpdate()
    {
        m_position += Input.GetAxis("Horizontal") * m_speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.velocity = transform.up * 5;
            Debug.Log("jump");
        }

        right = Input.GetAxis("Horizontal") > 0;
        SetCartPosition(m_position * Time.deltaTime); 
    }

    bool right;

    //public void movePlayer()
    //{
    //    m_position += Input.GetAxis("Horizontal") * m_speed;

    //    right = Input.GetAxis("Horizontal") > 0;
    //    SetCartPosition(m_position * Time.deltaTime);
    //}
    //public void Jump()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        body.velocity = transform.up * 5;
    //    }
    //}

    void SetCartPosition(float distanceAlongPath)
    {
        if(m_path != null)
        {
            Vector3 pos = m_path.EvaluatePositionAtUnit(m_position, m_PositionUnits);
            pos.y = transform.position.y;
            transform.position = pos;

            if(Input.GetAxis("Horizontal") != 0)
            {
                if (right)
                {
                    body.MovePosition(body.position + Camera.main.transform.right);
                    
                }
                else
                {
                    body.MovePosition(body.position + -Camera.main.transform.right);
                }
            }
        }
    }
}
