using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{

    public List<Shape_3D>  Shapes;


    public Shape_3D CurrentShape=null;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void SpawnShape(int ID)
    {
        
        
        var shape = Shapes.Find((s) => s.ID == ID);
        var shapeData = ModelDataSerializer.DeSerializeDataModelfromDisc(Application.persistentDataPath, shape.Name+"Data.xml");

        if (CurrentShape!=null)
                Destroy(CurrentShape.gameObject);

            CurrentShape = Instantiate(shape);
        if(shapeData!=null)
           CurrentShape.SetShapeData(shapeData);
       

    }
}
