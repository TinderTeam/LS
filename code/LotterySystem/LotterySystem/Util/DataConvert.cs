using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Util
{
    public class DataConvert
    {
        public static List<T> ConvertIListToList<T>(System.Collections.IList gbList) where T : class
        {
            if (gbList != null && gbList.Count >= 1)
            {
                List<T> list = new List<T>();
                for (int i = 0; i < gbList.Count; i++)
                {
                    T temp = gbList[i] as T;
                    if (temp != null)
                        list.Add(temp);
                }
                return list;
            }
            return null;
        }

        public static List<string> ConvertArrayToList(string[] arrays)  
        {
            List<string> list = new List<string>();
            if (arrays != null )
            {
                
                for (int i = 0; i < arrays.Length; i++)
                {
                    list.Add(arrays[i]);
                }
             
            }
            return list;
        }

        public static List<string> splitWithFlag(string str, char split)
        {
            List<string> strList = new List<string>();
            if (null != str)
            {
                strList = DataConvert.ConvertArrayToList(str.Split(split));
            }
            return strList;
    
            
        }
    }


}