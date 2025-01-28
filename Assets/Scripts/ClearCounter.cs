using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSo;
    [SerializeField] private Transform counterTopPoint;
    [SerializeField] private ClearCounter secondCounter;
    [SerializeField] private bool testing;
    
    private KitchenObject _kitchenObject;

    private void Update()
    {
        if (testing && Input.GetKeyDown(KeyCode.T))
        {
            if (_kitchenObject != null)
            {
                _kitchenObject.SetClearCounter(secondCounter);
            }
        }
    }

    public void Interact()
    {
        if (_kitchenObject == null)
        {
            Transform kitchenObjTransform = Instantiate(kitchenObjectSo.prefab, counterTopPoint);
            kitchenObjTransform.GetComponent<KitchenObject>().SetClearCounter(this);
        }
        else
        {
            Debug.Log(_kitchenObject.GetClearCounter());
        }
   

    }

    public Transform GetCounterTopPoint()
    {
        return counterTopPoint;
    }

    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this._kitchenObject = kitchenObject;
    }

    public KitchenObject GetKitchenObject()
    {
        return this._kitchenObject;
    }

    public void ClearKitchenObject()
    {
        this._kitchenObject = null;
    }

    public bool HasKitchenObject()
    {
        return _kitchenObject != null;
    }
}