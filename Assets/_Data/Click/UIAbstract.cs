using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAbstract : LoadAutoComponents
{
    [Header("UIAbstract")]
    [SerializeField] protected UIManager uIManager;
    public UIManager UIManager => uIManager;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadUIManager();
    }

    protected virtual void LoadUIManager()
    {
        if (this.uIManager != null) return;
        this.uIManager = GetComponentInParent<UIManager>();

        Debug.LogWarning(transform.name + ": LoadUIManager", gameObject);
        
    }
}
