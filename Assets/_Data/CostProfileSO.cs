using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "CostProfileSO/SO")]
public class CostProfileSO : ScriptableObject
{
    [SerializeField] public List<int> costs = new();
}
