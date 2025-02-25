using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CoinUp : CoinBase
{
    protected override void OnClickUpgrade()
    {
        base.OnClickUpgrade();

        if (this.slider.value > this.slider.maxValue) return;
        if (this.left.UIManager.Right.Gold < this.costProfile.costs[i]) return;

        i++;
        this.textCost.text = this.costProfile.costs[i].ToString() + "$";
        this.slider.value += 1;

        ObserverManager<float>.Notify(Const.CoinUpgrade, 2);
        ObserverManager<float>.Notify(Const.DeadCoin, this.costProfile.costs[i-1]);
        ObserverManager<float>.Notify(Const.CoinText, this.left.UIManager.Right.Gold);

    }
}
