using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinPanel : MonoBehaviour
{
    public GameObject skinToequip;

    public void EquipSckin()
    {
        SkinLoader.skinToLoad = skinToequip;
    }

}
