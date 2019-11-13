using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace simuframework.MVC.Infrastructure

{


    public class Inventory : MonoBehaviour
    {
        public InventoryItemData[] inventoryArray;

        int index = 0;


        // private void Update() 
        // {
        //     if (Input.GetKeyDown(KeyCode.Space))    
        //     {
        //         NextItemInfo();
        //     }
        // }

        public void NextItemInfo()
        {
            if (index > inventoryArray.Length)
            {
                index = 0;
            }

            Debug.Log("Item name: " + inventoryArray[index].name);
            Debug.Log("Attack power: " + inventoryArray[index].attack);

            switch (inventoryArray[index].type)
            {
                case InventoryItemType.Axe:
                    Debug.Log("Item type: Axe");
                    break;

                case InventoryItemType.Dagger:
                    Debug.Log("Item type: Dagger");
                    break;

                case InventoryItemType.Potion:
                    Debug.Log("Item type: Staff");
                    break;

                case InventoryItemType.Sword:
                    Debug.Log("Item type: Sword");
                    break;
            }
            Debug.Log("Item price: " + inventoryArray[index].GetPrice());
            index++;
        }
    }
}