using UnityEngine;
using System.Collections;

public class Front : MonoBehaviour {

    private Transform fort_tran;
    private RaycastHit hit;
    private Ray ray;
    private LineRenderer line;
  
    void Start()
    {
        fort_tran = gameObject.GetComponent<Transform>();
        line = gameObject.GetComponent<LineRenderer>();
    }

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
             fort_tran.LookAt(hit.point);
        }
        if (Input.GetMouseButtonDown(0))
        {
            line.SetPosition(0, fort_tran.position);
            line.SetPosition(1, Input.mousePosition);
        }

    }
}

