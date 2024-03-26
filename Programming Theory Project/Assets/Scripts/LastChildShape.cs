using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LastChildShape : ShapeBase
{
    [SerializeField] private Rigidbody shapeRb;
    [SerializeField] private float clickForce = 2.0f;
    [SerializeField] private ShapeBase ShapeOne;
    [SerializeField] private ChildShape ShapeTwo;
    [SerializeField] private OtherChildShape ShapeThree;

    private void Awake()
    {
        shapeRb = gameObject.GetComponent<Rigidbody>();
        FindOtherShapes();//Abstractoin
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        shapeRb.AddForce(Vector3.up * clickForce, ForceMode.Impulse);
        RandomizeShapeColors();
    }

    private void FindOtherShapes()
    {
        ShapeOne = GameObject.FindAnyObjectByType<ShapeBase>();
        ShapeTwo = GameObject.FindAnyObjectByType<ChildShape>();
        ShapeThree = GameObject.FindAnyObjectByType<OtherChildShape>();
    }

    private void RandomizeShapeColors()
    {
        ShapeOne.RandomColor();
        ShapeTwo.RandomColor();
        ShapeThree.RandomColor();
    }
}
