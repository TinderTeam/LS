using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Models
{
    public class AttributeModel
    {
        private string attrKey;

        public string AttrKey
        {
            get { return attrKey; }
            set { attrKey = value; }
        }
        private string attrValue;

        public string AttrValue
        {
            get { return attrValue; }
            set { attrValue = value; }
        }

    }
}