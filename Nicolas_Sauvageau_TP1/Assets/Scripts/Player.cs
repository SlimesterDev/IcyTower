using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D m_rigidbody;
    public Vector2 m_vector;
    private bool m_ground = false;
    public Vector2 m_jumpforce;

    void Start()
    {
        m_vector = new Vector2();
    }

    void Update()
    {
        m_vector = m_rigidbody.velocity;

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            m_vector.x = 0f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            m_vector.x = -5f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            m_vector.x = 5f;
        }
        else
        {
            m_vector.x = 0f;
        }

        m_rigidbody.velocity = m_vector;
    }

}
