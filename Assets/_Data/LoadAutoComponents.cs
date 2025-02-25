using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAutoComponents : MonoBehaviour
{
    protected virtual void Awake()
    {
        this.LoadComponents();
    }

    protected virtual void Reset()
    {
        this.LoadComponents();
        this.ResetValues();
    }

    protected virtual void LoadComponents()
    {
        //For override
    }

    protected virtual void ResetValues()
    {
        //For override
    }
}
