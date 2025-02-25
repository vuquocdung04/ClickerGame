using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Right : UIAbstract
{
    [SerializeField] protected Button btnClick;
    public Button BtnClick => btnClick;

    float gold = 0;
    public float Gold => gold;


    float goldIncrement = 1;
    private void Start()
    {
        this.btnClick.onClick.AddListener(OnClick);

        ObserverManager<float>.AddObserver(Const.CoinUpgrade, OnGoldIncreased);
        ObserverManager<float>.AddObserver(Const.DeadCoin, OnDeadGold);
    }


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBtnClick();
    }

    protected virtual void LoadBtnClick()
    {
        if (this.btnClick != null) return;
        this.btnClick = GetComponentInChildren<Button>();

        Debug.LogWarning(transform.name + ": LoadBtnClick", gameObject);
    }

    public virtual void OnClick()
    {
        gold += this.goldIncrement;
        ObserverManager<float>.Notify(Const.CoinText, gold);
    }

    private void OnGoldIncreased(float gold)
    {
        this.goldIncrement += gold;
    }

    private void OnDeadGold(float gold)
    {
        this.gold -= gold;
    }
}
