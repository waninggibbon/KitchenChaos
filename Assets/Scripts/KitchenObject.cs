using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSo;

    public KitchenObjectSO getKitchenObjectSo()
    {
        return kitchenObjectSo;
    }
}