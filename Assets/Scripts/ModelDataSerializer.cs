
using System.Xml.Serialization;
using System.IO;
public static class ModelDataSerializer
{
    public static void SerializeDataModeltoDisc(ShapeDataModel dataModel,string path,string filename)
    {

        var cpath = Path.Combine(path, filename);
        if (File.Exists(cpath))
        {
            File.Delete(cpath);
        }
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(ShapeDataModel));
        StreamWriter streamWriter = new StreamWriter(cpath);
        xmlSerializer.Serialize(streamWriter, dataModel);
        streamWriter.Close();
       
    }
    public static ShapeDataModel DeSerializeDataModelfromDisc(string path,string filename)
    {
        var cpath = Path.Combine(path, filename);

        if(!File.Exists(cpath))
               return null;

        XmlSerializer xmlSerializer = new XmlSerializer(typeof(ShapeDataModel));
        StreamReader streamReader = new StreamReader(cpath);
        var modeldata =(ShapeDataModel)xmlSerializer.Deserialize(streamReader);
        streamReader.Close();
        return modeldata;

    }

}
