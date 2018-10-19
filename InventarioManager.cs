using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioManager : MonoBehaviour
{

    [System.Serializable]
    public struct ObjetoInventarioId
    {
        public int id;
        public int cantidad;

        public ObjetoInventarioId(int id, int cantidad)
        {
            this.id = id;
            this.cantidad = cantidad;
        }
    }

    public InventarioBaseDatos baseDatos;
    public List<ObjetoInventarioId> inventario;

    public void AgregarAlgoAlInventario(int id, int cantidad)
    {
        for (int i = 0; i < inventario.Count; i++)
        {
            if (inventario[i].id == id)
            {
                inventario[i] = new ObjetoInventarioId(inventario[i].id, inventario[i].cantidad + cantidad);
               
                return;
            }
        }
        inventario.Add(new ObjetoInventarioId(id, cantidad));
    
    }
    public void EliminarAlgoDeInventario(int id, int cantidad)
    {
        for (int i = 0; i < inventario.Count; i++)
        {
            if (inventario[i].id == id)
            {
                inventario[i] = new ObjetoInventarioId(inventario[i].id, inventario[i].cantidad - cantidad);
                if (inventario[i].cantidad <= 0)
                    inventario.Remove(inventario[i]);
                
                return;
            }
        }
        Debug.LogError("No existe el objeto a eliminar");
    }

    public void IntercambiarPuestos(int i1, int i2)
    {
        ObjetoInventarioId i = inventario[i1];
        inventario[i1] = inventario[i2];
        inventario[i2] = i;
       
    }

    public void Start()
    {
      
    }


    public InventarioObjetoInterface prefab;
    public Transform inventarioUI;
    List<InventarioObjetoInterface> pool = new List<InventarioObjetoInterface>();

 



}

    