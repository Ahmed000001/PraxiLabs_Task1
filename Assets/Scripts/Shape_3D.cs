using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class Shape_3D : MonoBehaviour
{
    public int ID;
    public string Name;

   public void SetShapeData(ShapeDataModel dataModel)
    {
       
        transform.SetPositionAndRotation(dataModel.position, dataModel.rotation);
        transform.localScale = dataModel.size;
        GetComponent<MeshRenderer>().sharedMaterial.color = dataModel.color;

    }
    public ShapeDataModel GetShapeData()
    {
        ShapeDataModel dataModel = new ShapeDataModel();
        dataModel.position = transform.position;
        dataModel.rotation = transform.rotation;
        dataModel.size = transform.localScale;
        dataModel.color = GetComponent<MeshRenderer>().sharedMaterial.color;
        return dataModel;


    }

   
}
