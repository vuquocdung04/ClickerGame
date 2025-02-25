using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public abstract class CoinBase : LoadAutoComponents
{
    [Header("Coint Base")]

    [SerializeField] protected Left left;

    [SerializeField] protected Button btn;
    public Button Btn => btn;

    [SerializeField] protected Slider slider;
    public Slider Slider => slider;

    [SerializeField] protected TMP_Text textCost;
    public TMP_Text TextCost => textCost;

    [SerializeField] protected CostProfileSO costProfile;

    protected int i = 0;
    private void Start()
    {
        this.btn.onClick.AddListener(this.OnClickUpgrade);
        this.textCost.text = costProfile.costs[0].ToString() + "$";
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadButton();
        this.LoadSlider();
        this.LoadTextCost();
        this.LoadLeft();
    }

    protected virtual void LoadButton()
    {
        if (this.btn != null) return;
        this.btn = GetComponentInChildren<Button>();

        Debug.LogWarning(transform.name + ": LoadButton", gameObject);
    }

    protected virtual void LoadSlider()
    {
        if (this.slider != null) return;
        this.slider = GetComponentInChildren<Slider>();

        Debug.LogWarning(transform.name + ": LoadSlider", gameObject);
    }
    protected virtual void LoadTextCost()
    {
        if (this.textCost != null) return;
        this.textCost = GetComponentInChildren<TMP_Text>();

        Debug.LogWarning(transform.name + ": LoadTextCost", gameObject);
    }
    protected virtual void LoadLeft()
    {
        if (this.left != null) return;
        this.left = GetComponentInParent<Left>();

        Debug.LogWarning(transform.name + ": LoadLeft", gameObject);
    }
    protected virtual void OnClickUpgrade()
    {
        //For:overide

    }
}
