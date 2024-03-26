using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShapeBase : MonoBehaviour, IPointerDownHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler
{
    private Color m_color;
    public Color Color { get { return m_color;} set { m_color = value; } }

    public string ShapeName { get => shapeName; set => shapeName = value; }
    private string shapeName = "Base Shape";

    public Material myMaterial;

    private void Awake()
    {
        //myMaterial = gameObject.GetComponent<Material>();
        RandomColor();
    }
    //These functions handle mouse interaction
    public virtual void OnPointerDown(PointerEventData eventData)
    {
        myMaterial.color = Color.green;
    }


    public virtual void OnPointerUp(PointerEventData eventData)
    {
        myMaterial.color = m_color;
    }

    public virtual void OnPointerExit(PointerEventData eventData)
    {
        //blanck
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //blanck
    }

    public virtual void OnPointerEnter(PointerEventData eventData)
    {
        //blanck
    }

    public void RandomColor()
    {
        m_color.r = Random.Range(0f, 1f);
        m_color.g = Random.Range(0f, 1f);
        m_color.b = Random.Range(0f, 1f);
        m_color.a = 1f;
        myMaterial.color = m_color;
    }
}
