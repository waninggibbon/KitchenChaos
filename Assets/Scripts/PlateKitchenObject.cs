using UnityEngine;
using System.Collections.Generic;

public class PlateKitchenObject : KitchenObject
{
    [SerializeField] private List<KitchenObjectSO> validKitchenObjectSOs;
    private List<KitchenObjectSO> kitchenObjectSOs;

    private void Awake()
    {
        kitchenObjectSOs = new List<KitchenObjectSO>();
    }

    public bool TryAddIngredient(KitchenObjectSO kitchenObjectSO)
    {
        if (!kitchenObjectSOs.Contains(kitchenObjectSO) && validKitchenObjectSOs.Contains(kitchenObjectSO))
        {
            kitchenObjectSOs.Add(kitchenObjectSO);
            return true;
        }

        return false;
    }
}