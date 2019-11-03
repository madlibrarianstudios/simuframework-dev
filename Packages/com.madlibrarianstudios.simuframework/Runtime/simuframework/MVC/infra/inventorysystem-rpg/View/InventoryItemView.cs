
using System;

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

namespace simuframework.MVC.Infrastructure

{

    public class InventoryItemView : MonoBehaviour

    {

        public Button button;

        public Image itemIcon;



        private InventoryItemData itemData;



        public void InitItem(InventoryItemData item)

        {

            this.itemData = item;

            itemIcon.sprite = itemData.icon;



            button.onClick.AddListener(ButtonClicked);

        }



        private void ButtonClicked()

        {

            Debug.Log(itemData.name);

        }

    }
}