using Microsoft.MixedReality.Toolkit.Input;
using System;
using TMPro;
using UnityEngine;

public class ClickableThingyGlobal : BaseInputHandler, IMixedRealityInputHandler
{
    [SerializeField]
    private TextMeshPro _debugText;

    [SerializeField]
    private MixedRealityInputAction _desiredInputAction;

    public void OnInputUp(InputEventData eventData)
    {
        if( eventData.MixedRealityInputAction != _desiredInputAction)
        {
            return;
        }
        GetComponent<MeshRenderer>().material.color = Color.white;
        AddDebugText("up", eventData);
    }

    public void OnInputDown(InputEventData eventData)
    {
        if (eventData.MixedRealityInputAction != _desiredInputAction)
        {
            return;
        }
        GetComponent<MeshRenderer>().material.color = Color.red;
        AddDebugText("down", eventData);
    }

    private void AddDebugText( string eventPrefix, InputEventData eventData)
    {
        if( _debugText == null)
        {
            return;
        }
        var description = eventData.MixedRealityInputAction.Description;
        _debugText.text += 
            $"{eventPrefix} {gameObject.name} : {description}{Environment.NewLine}";
    }
}

