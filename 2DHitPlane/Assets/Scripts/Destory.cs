using UnityEngine;
using System.Collections;

public class Destory : MonoBehaviour {

    private Transform m_Transform;

    void Update()
    {
        m_Transform = gameObject.GetComponent<Transform>();
        if (m_Transform.position.y <-8)
        {
            Destroy(gameObject);
        }
    }
}
