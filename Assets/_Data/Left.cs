using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : UIAbstract
{
    [Header("Left")]
    [SerializeField] protected CoinUp coinUp;
    public CoinUp CoinUp => coinUp;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCoinUp();
    }

    protected virtual void LoadCoinUp()
    {
        if (this.coinUp != null) return;
        this.coinUp = GetComponentInChildren<CoinUp>();

        Debug.LogWarning(transform.name + ": LoadCoinUp", gameObject);
    }
}
