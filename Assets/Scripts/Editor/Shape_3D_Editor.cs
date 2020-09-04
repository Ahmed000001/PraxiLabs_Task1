using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Shape_3D))]
public class Shape_3D_Editor : Editor
{

    Shape_3D shape;
    private void OnEnable()
    {
        shape = (Shape_3D)target;
    }
    public override  void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Save"))
        {
         
            ModelDataSerializer.SerializeDataModeltoDisc(shape.GetShapeData(), Application.persistentDataPath,shape.Name+"Data.xml");
            Debug.Log(Application.persistentDataPath);
        }
        if (GUILayout.Button("Load"))
        {
           var md= ModelDataSerializer.DeSerializeDataModelfromDisc(Application.persistentDataPath,shape.Name+"Data.xml");
            shape.SetShapeData(md);
        }

    }

}
