using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    ShapeSpawner shapeSpawner;

   
    private void Start()
    { 
        shapeSpawner = FindObjectOfType<ShapeSpawner>();
        
    }

    public void OnDropdownChanged(int ShapeID)
    {
        shapeSpawner.SpawnShape(ShapeID);
    }

}
