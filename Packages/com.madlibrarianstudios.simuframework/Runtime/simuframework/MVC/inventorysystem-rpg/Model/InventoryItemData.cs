using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace simuframework.MVC.Infrastructure

{
    [CreateAssetMenu]
    public class InventoryItemData : ScriptableObject
    {
        public string itemName;
        public InventoryItemType type;
        public float attack;
        public Sprite icon;
        public float GetPrice()
        {
            return attack * 40;
        }
    }

    public enum InventoryItemType
    {
        Dagger,
        Axe,
        Sword,
        Potion
    }
}