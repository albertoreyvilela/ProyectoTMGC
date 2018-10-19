using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Inventory/List", order = 1)]
public class InventarioBaseDatos : ScriptableObject
{
    [System.Serializable]
    public struct ObjetoInventario
    {
        public string nombre;
        public Sprite sprite;
        public string health;
        public string damage;
        public ItemType itemType;
    }
    public enum ItemType
    {
        weapon,
        food,
        mis,
        Other,
        
    }
    public enum Uso
    {
        
        equipable,
        consumible
    }

    public ObjetoInventario[] baseDatos;

}