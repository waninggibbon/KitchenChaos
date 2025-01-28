using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSo;
    private ClearCounter _clearCounter;

    public KitchenObjectSO GetKitchenObjectSo()
    {
        return kitchenObjectSo;
    }

    public void SetClearCounter(ClearCounter clearCounter)
    {
        if (_clearCounter != null)
        {
            _clearCounter.ClearKitchenObject();
        }

        _clearCounter = clearCounter;
        if (clearCounter.HasKitchenObject())
        {
            Debug.LogError("Counter already has a kitchen object.");
        }

        clearCounter.SetKitchenObject(this);

        transform.parent = clearCounter.GetCounterTopPoint();
        transform.localPosition = Vector3.zero;
    }

    public ClearCounter GetClearCounter()
    {
        return _clearCounter;
    }
}