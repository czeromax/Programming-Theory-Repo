using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialApplier : MonoBehaviour
{
    public static MaterialApplier Instance;

    public Material[] materials;

    private void Awake()
    {
        Instance = this;
    }

    public void ApplyOther()
    {
        //
    }
}
