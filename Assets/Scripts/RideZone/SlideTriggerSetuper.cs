using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideTriggerSetuper : MonoBehaviour
{
    private void Start()
    {
        var triggers = GetComponentsInChildren<SlideTrigger>();
        
        for (var i = 0; i < triggers.Length; i++)
        {
            if (i < triggers.Length - 1)
            {
                triggers[i].Setup(triggers[i + 1]);
            }
        }
    }
}

   

