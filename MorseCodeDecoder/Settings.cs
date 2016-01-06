using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class Settings
{
    public int selected_index { get; set; }
    public Preset[] Presets;
}

public class Preset
{
    public string preset_name { get; set; }
    public int brightness_th { get; set; }
    public int dot_pause_th { get; set; }
    public int char_pause_th { get; set; }
    public int word_pause_th { get; set; }
    public int frameinterval { get; set; }
}

public static class Global
{
    public static T[] RemoveAt<T>(this T[] source, int index)
    {
        T[] dest = new T[source.Length - 1];
        if (index > 0)
            Array.Copy(source, 0, dest, 0, index);

        if (index < source.Length - 1)
            Array.Copy(source, index + 1, dest, index, source.Length - index - 1);

        return dest;
    }
}

public static class XmlSerializing
{
    static public void Serialize(Settings settings, string file_path = "setting_presets.xml")
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Settings));
        using (TextWriter writer = new StreamWriter(file_path))
        {
            serializer.Serialize(writer, settings);
        }
    }

    // To Clean XML
    static public string SerializeToPlain(Settings value, string file_path = "setting_presets.xml")
    {
        var emptyNamepsaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
        var serializer = new XmlSerializer(value.GetType());
        var settings = new XmlWriterSettings();
        settings.Indent = true;
        settings.OmitXmlDeclaration = true;

        using (var stream = new StringWriter())
        using (var writer = XmlWriter.Create(stream, settings))
        {
            serializer.Serialize(writer, value, emptyNamepsaces);
            // Create the XmlDocument.
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.LoadXml(stream.ToString());
            doc.Save(file_path);

            return stream.ToString();
        }
    }

    static public Settings DeSerialize(string file_path)
    {
        Settings settings = null;
        XmlSerializer serializer = new XmlSerializer(typeof(Settings));

        StreamReader reader = new StreamReader(file_path);
        settings = (Settings)serializer.Deserialize(reader);
        reader.Close();
        return (settings);
    }
}
