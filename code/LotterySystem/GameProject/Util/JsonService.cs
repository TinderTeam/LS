using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
namespace GameProject.Util
{
    public class JsonService
    {
            

        public static String getJsonStr(Object obj){
           
          
            string json = JsonConvert.SerializeObject(obj);
            return json;
        }

    }
}