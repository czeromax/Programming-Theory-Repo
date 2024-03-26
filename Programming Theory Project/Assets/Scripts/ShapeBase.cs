using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShapeBase : MonoBehaviour, IPointerDownHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler
{
    private Color color = Color.red;
    public Color Color { get => color; set => color = value; }

    public string ShapeName { get => shapeName; set => shapeName = value; }
    private string shapeName = "Base Shape";

    public Material myMaterial;

    private void Awake()
    {
        //myMaterial = gameObject.GetComponent<Material>();
        RandomColor();
        myMaterial.color = color;
    }
    //These functions handle mouse interaction
    public void OnPointerDown(PointerEventData eventData)
    {
        myMaterial.color = Color.green;
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        myMaterial.color = color;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //blanck
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //blanck
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //blanck
    }

    private void RandomColor()
    {
        color.r = Random.Range(0f, 1f);
        color.g = Random.Range(0f, 1f);
        color.b = Random.Range(0f, 1f);
        color.a = 1f;
    }
}
