using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "AlmejaStudio/Variable/Float")]
public class floatVariable : ScriptableObject
{
    public string DeveloperDescription;
    public float Value;

    public void SetValue (float value)
    {
        Value = value; 
    }
}
