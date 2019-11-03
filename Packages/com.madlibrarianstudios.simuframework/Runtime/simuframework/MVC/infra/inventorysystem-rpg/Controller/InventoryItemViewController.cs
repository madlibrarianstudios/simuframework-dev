using System.Collections;

using System.Collections.Generic;

using UnityEngine;


namespace simuframework.MVC.Infrastructure

{

    public class InventoryItemViewController : MonoBehaviour

    {

        public Inventory inventoryHolder;

        public Transform inventoryViewParent;

        public GameObject itemViewPrefab;



        private void Start()

        {

            foreach (var item in inventoryHolder.inventoryArray)

            {

                var itemGO = GameObject.Instantiate(itemViewPrefab, inventoryViewParent);

                itemGO.GetComponent<InventoryItemView>().InitItem(item);

            }

        }

    }
}