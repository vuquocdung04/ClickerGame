using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : LoadAutoComponents
{
    [Header("UIManger")]
    [SerializeField] protected TopRight topRight;
    public TopRight TopRight => topRight;

    [SerializeField] protected Left left;
    public Left Left => left;

    [SerializeField] protected Right right;
    public Right Right => right;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTopRight();
        this.LoadLeft();
        this.LoadRight();
    }

    protected virtual void LoadTopRight()
    {
        if (this.topRight != null) return;
        this.topRight = GetComponentInChildren<TopRight>();

        Debug.LogWarning(transform.name + ": LoadTopLeft", gameObject);
    }

    protected virtual void LoadLeft()
    {
        if (this.left != null) return;
        this.left = GetComponentInChildren<Left>();

        Debug.LogWarning(transform.name + ": LoadLeft", gameObject);
    }
    protected virtual void LoadRight()
    {
        if (this.right != null) return;
        this.right = GetComponentInChildren<Right>();

        Debug.LogWarning(transform.name + ": LoadRight", gameObject);
    }

}
