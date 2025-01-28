using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObject;
    [SerializeField] private Transform counterTopPoint;

    public void Interact()
    {
        Debug.Log("Interact");
        Transform kitchenObjTransform = Instantiate(kitchenObject.prefab, counterTopPoint);
        kitchenObjTransform.localPosition = Vector3.zero;

        Debug.Log(kitchenObjTransform.GetComponent<KitchenObject>().getKitchenObjectSo().objectName);
    }
}