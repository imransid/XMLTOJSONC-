using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
//using Newtonsoft.Json;
using System.Text.Json;

namespace xmlReadNodeByNode
{
    public class CreateSectionJSON
    {
        private static int i;

        public CreateSectionJSON()
        {
        }

        public static void CreateNewObject(List<object> tempObj)
        {
            try
            {


                Console.WriteLine(tempObj);
              //foreach()



            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in CreateNewObject");
            }
        }

        public static void CreateNestedSectionJSONFile(List<object> josnObj)
        {


            Console.WriteLine(josnObj);

            //IDictionary<string, object> finalNewJSON = new josnObj();

            //var status = false;
            //try
            //{
            //    if(josnObj != null)
            //    {

          


            //            foreach (KeyValuePair<string, object > kvp in josnObj)
            //            {

            //            var demo = new Properties.Book();
            //            var result = demo.SelectMany(pair => new string[] { kvp.Key }.Concat(kvp.Value));
            //            //Properties.Root book = "new" ;


            //            Console.WriteLine("kvp  {0} {1}", kvp.Key, kvp.Value);

            //            //foreach (var elem in josnObj[kvp.Key])
            //            //{
            //            //    Console.WriteLine(elem);
            //            //}

            //            //foreach (KeyValuePair<string, object> k_vp in kvp.Value)
            //            //{

            //            //}
            //            }





            //    }

            //    //JsonSerializer.Deserialize(<Properties.Root>);

            //    //var result = JsonConvert.DeserializeObject<Properties.Root>((string)josnObj);

            //    //Console.WriteLine("Obj is {0}", result);

            //}catch(Exception ex)
            //{
            //    Console.WriteLine("Error in CreateSectionJSON {0}", ex);
            //}


            //return status;

        }
    }
}

