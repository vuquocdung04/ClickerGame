using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TopRight : UIAbstract
{
    [SerializeField] protected TMP_Text textGold;
    public TMP_Text TextGold => textGold;

    private void Start()
    {
        ObserverManager<float>.AddObserver(Const.CoinText, OnUpdateText);
    }

    private void OnDestroy()
    {
        ObserverManager<float>.RemoveObserver(Const.CoinText, OnUpdateText);
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTextGold();
    }

    protected virtual void LoadTextGold()
    {
        if (this.textGold != null) return;
        this.textGold = transform.Find("TextGold").GetComponent<TMP_Text>();

        Debug.LogWarning(transform.name + ": LoadTextGold", gameObject);
    }

    public virtual void OnUpdateText(float gold)
    {
        this.textGold.text = gold.ToString();
    }
}
