using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeManager;
public class OBJDrag : MonoBehaviour
{
    BoxCollider BoxCol;
    MathMAN instance = new MathMAN();

    void Start()
    {
        BoxCol = GetComponent<BoxCollider>();
    }

    void OnMouseDrag()
    {
        BoxCol.enabled = false;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {   

            transform.position = new Vector3(instance.Rounding((int)hit.point.x), 125, instance.Rounding((int)hit.point.z));
            Debug.Log(hit.collider.name);
        }
    }

    void OnMouseUp()
    {
        BoxCol.enabled = true;
    }
}
