using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

public class ClickableThingyGlobal : BaseInputHandler, IMixedRealityInputHandler
{
    public void OnInputUp(InputEventData eventData)
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
    }

    public void OnInputDown(InputEventData eventData)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}

