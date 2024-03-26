using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OtherChildShape : ShapeBase
{
    private Rigidbody shapeRb;
    [SerializeField] private float clickForce = 5.0f;
    // Start is called before the first frame update
    private void Awake()
    {
        shapeRb = gameObject.GetComponent<Rigidbody>();
        RandomColor();
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        shapeRb.AddForce(Vector3.up * clickForce, ForceMode.Impulse);
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);
    }

    public override void OnPointerEnter(PointerEventData eventData)
    {
        base.OnPointerEnter(eventData);
        transform.localScale += new Vector3(2, 2, 2);
    }

    public override void OnPointerExit(PointerEventData eventData)
    {
        base.OnPointerExit(eventData);
        transform.localScale -= new Vector3(2, 2, 2);
    }
}


