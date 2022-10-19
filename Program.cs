using System.Reflection.PortableExecutable;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.XPath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.Reflection;
using System.Text.Json;
using System.IO;
using xmlReadNodeByNode;
using System.Collections;

static class Program
{
    private static void Main(string[] args)
    {



        var dirFileName = Directory.GetCurrentDirectory() + @"/ALL_ZIP/";

        var xmlFolderStatus = Directory.Exists(dirFileName + "/xml/");


        if (xmlFolderStatus == false)
        {

            var zipStatus = UnzipXML(dirFileName);

            if (zipStatus)
            {
                FolderRead(dirFileName);
            }

        }
        else
        {
            // unzip already
            FolderRead(dirFileName);
        }
    }

    private static IDictionary<string, object> GetAttributeValue(XElement child)
    {
        IDictionary<string, object> attributeAndValues = new Dictionary<string, object>();
        try
        {

            foreach (var data in child.Attributes())
            {

                var itemName = data.Name.LocalName;

                object val = data.Value;

                attributeAndValues.Add(itemName, val);

            }

        }
        catch
        {

        }


        return attributeAndValues;
    }

    private static object Dump(XElement element, int level)
    {

        var all = new List<dynamic>();

        if (element.HasElements) //for child node
        {

            foreach (var child in element.Elements())
            {

                IDictionary<string, object> numberNames = new Dictionary<string, object>();
                IDictionary<string, object> attributeAndValues = new Dictionary<string, object>();
                IDictionary<string, object> relationParentChildData = new Dictionary<string, object>();

                var parentObjectList = new List<dynamic>();

                // nested child

                if (child.HasElements)
                {
                    var data = Dump(child, level + 1);

                    var itemName = child.Name.LocalName;



                    var desiredElement = child.FirstNode as XElement;


                    string? elementName = desiredElement == null ? itemName : null;
                    if (desiredElement != null) // In case first node is not an element, but for instance text or comment
                    {
                        elementName = desiredElement.Name.LocalName == null ? itemName : desiredElement.Name.LocalName;
                    }


                    // get Attribute

                    if (child.HasAttributes)
                    {
                        var attributeIs = GetAttributeValue(child);
                        numberNames = attributeIs;
                    }

                    numberNames.Add(elementName, data);

                    relationParentChildData.Add(itemName, numberNames);

                    all.Add(relationParentChildData);

                }
                else
                {

                    // get Attribute

                    if (child.HasAttributes)
                    {
                        attributeAndValues = GetAttributeValue(child);

                    }
                    var itemName = child.Name.LocalName;

                    object val = child.Value;

                    attributeAndValues.Add(itemName, val);

                    numberNames.Add(itemName, attributeAndValues);

                    all.Add(numberNames);

                }


            }
        }
        else
        {

        }

        return all;
    }



    private static void FolderRead(string dirFileName)
    {

        var xmlPath = dirFileName + "xml/";
        string[] files = Directory.GetFiles(xmlPath, "*.xml");

        //XMlReaderToJsonFileConvertator("M02502togeenvhch01");


        foreach (var file in files)
        {

            var fileName = Path.GetFileName(file);
            var newJsonFileName = fileName.Substring(0, fileName.Length - 4);

            XMlReaderToJsonFileConvertator(newJsonFileName);
        }
    }

    private static bool UnzipXML(string dirFileName)
    {
        var status = true;
        try
        {

            System.IO.Compression.ZipFile.ExtractToDirectory(dirFileName + "/xml.zip", dirFileName);
            status = true;

        }
        catch (Exception ex)
        {
            status = false;
        }
        return status;

    }

    public static bool IsList(object o)
    {
        if (o == null) return false;
        return o is IList &&
               o.GetType().IsGenericType &&
               o.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>));
    }

    public static bool IsDictionary(object o)
    {
        if (o == null) return false;
        return o is IDictionary &&
               o.GetType().IsGenericType &&
               o.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(Dictionary<,>));
    }


    private static void XMlReaderToJsonFileConvertator(string fileName)
    {

        //var fileName = "M02502togeenvhch01.xml";

        XmlReaderSettings settings = new XmlReaderSettings();

        settings.XmlResolver = new XmlUrlResolver();

        settings.ValidationType = ValidationType.DTD;
        settings.DtdProcessing = DtdProcessing.Parse;
        settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
        settings.ValidationType = ValidationType.DTD;
        settings.IgnoreWhitespace = true;
        settings.Async = true;

        var dirFileName = Directory.GetCurrentDirectory() + "/ALL_ZIP/xml/" + fileName + ".xml";

        try
        {

            using (XmlReader reader = XmlReader.Create(dirFileName, settings))
            {

                dynamic user = new System.Dynamic.ExpandoObject();
                var data = new List<dynamic>();

                while (reader.Read())
                {
                    dynamic itemAttribute = new ExpandoObject();

                    while (reader.ReadToFollowing("toyota_om_vh_ge_en"))
                    {
                        var eventData = (XElement)XElement.ReadFrom(reader);

                        var item = Dump(eventData, 0);


                        var json = JsonSerializer.Serialize(item);

                        // var Dejson = JsonSerializer.Deserialize(json);

                        var folderStatus = CreateDirectory("JSON_FILE_SAVE");


                        if (folderStatus)
                        {  
                            System.IO.File.WriteAllText(Directory.GetCurrentDirectory() + @"/JSON_FILE_SAVE/" + fileName + ".json", json.ToString());

                        }



                    }
                }
            }



        }
        catch (Exception err)
        {
            Console.WriteLine("Error on  : {}", err);
        }
    }

    private static bool CreateDirectory(string folderName)
    {
        var folderCreateStatus = false;

        var path = Directory.GetCurrentDirectory() + "/" + folderName;
        try
        {
            // Determine whether the directory exists.
            if (Directory.Exists(path))
            {
                folderCreateStatus = true;
            }

            // Try to create the directory.
            DirectoryInfo di = Directory.CreateDirectory(path);

            folderCreateStatus = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());

            folderCreateStatus = true;
        }


        return folderCreateStatus;

    }

    private static void ValidationCallBack(object sender, ValidationEventArgs e)
    {
        if (e.Severity == XmlSeverityType.Warning)
            Console.WriteLine("Warning: Matching schema not found.  No validation occurred." + e.Message);
        else // Error
             //Console.WriteLine("Validation error: " + e.Message);
            Console.WriteLine("");
    }
}