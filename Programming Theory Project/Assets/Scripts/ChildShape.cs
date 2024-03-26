using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChildShape : ShapeBase
{
    [SerializeField] private Rigidbody shapeRb;
    [SerializeField] private float clickForce = 2.0f;
    // Start is called before the first frame update
    private void Awake()
    {
        shapeRb = gameObject.GetComponent<Rigidbody>();
        RandomColor();
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        //add extra funcionality in overide function
        //perhaps add an impulse force on a rigid body
        shapeRb.AddForce(Vector3.up * clickForce, ForceMode.Impulse);
    }


    
}
