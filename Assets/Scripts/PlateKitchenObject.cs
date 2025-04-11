using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Serialization;

public class PlateKitchenObject : KitchenObject
{
    public event EventHandler<OnIngredientAddedEventArgs> OnIngredientAdded;

    public class OnIngredientAddedEventArgs : EventArgs
    {
        public KitchenObjectSO kitchenObjectSO;
    }

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
            OnIngredientAdded?.Invoke(this, new OnIngredientAddedEventArgs() { kitchenObjectSO = kitchenObjectSO });
            return true;
        }

        return false;
    }

    public List<KitchenObjectSO> GetKitchenObjectSOList()
    {
        return kitchenObjectSOs;
    }
}