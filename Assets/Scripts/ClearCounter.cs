using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{

    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;
    
    public void Interact() {
        Debug.Log("Interact!");
        Transform kitchecObjectTransform = Instantiate(kitchenObjectSO.prefeb, counterTopPoint);
        kitchecObjectTransform.localPosition = Vector3.zero;

        Debug.Log(kitchecObjectTransform.GetComponent<KitchenObject>().GetKitchenObjectSO().objectName);
    }
}
