using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 

namespace LotterySystem.Models
{
    public class SystemInfoModel
    {
    }

    public class GameModel
    {
        private string gameName;
        private string gameStatus;
        private string os;

        private string[] selectOSList;


        private List<AttributeModel> osList = new List<AttributeModel>();
        private string[] selectBrowserList;


        private List<AttributeModel> browserList = new List<AttributeModel>();
 
        private string browser;
        private float taxRate;
        private int allRoomLimit;
        private int onePersonRoomLimit;
        private int oneRoomTableLimit;
        private int oneTablePersonLimit;
        private int bankerSelectNumTimeLimit;
        private int playerSelectNumTimeLimit;

        public List<AttributeModel> OsList
        {
            get { return osList; }
            set { osList = value; }
        }
        public List<AttributeModel> BrowserList
        {
            get { return browserList; }
            set { browserList = value; }
        }

        public string[] SelectOSList
        {
            get { return selectOSList; }
            set { selectOSList = value; }
        }
        public string[] SelectBrowserList
        {
            get { return selectBrowserList; }
            set { selectBrowserList = value; }
        }

        public void setOSList()
        {
            osList.Clear();
            for (int i = 0; i < SysConstants.OS_LIST.Length;i++ )
            {
                AttributeModel attr = new AttributeModel();
                attr.AttrKey = SysConstants.OS_LIST[i];
                if (null != os && os.Contains(SysConstants.OS_LIST[i]))
                {
                    attr.AttrValue = "checked";
                }
                else
                {
                    attr.AttrValue = "";
                }
                osList.Add(attr);
                
            }

        }
        public string getOsStr()
        {
            string osStr = "";
            if (null != selectOSList)
            {
                for (int i = 0; i < selectOSList.Length; i++)
                {
                    if (i != 0)
                    {
                        osStr += SysConstants.OS_BROWSER_SPLIT;
                    }
                    osStr += selectOSList[i];

                }
            }

            return osStr;
        }


        public string getBrowserStr()
        {
            string str = "";

            if (null != selectBrowserList)
            {

                for (int i = 0; i < selectBrowserList.Length; i++)
                {
                    if (i != 0)
                    {
                        str += SysConstants.OS_BROWSER_SPLIT;
                    }
                    str += selectBrowserList[i];

                }
            }
            return str;
        }


         public void setBrowserList()
        {
            browserList.Clear();
            for (int i = 0; i < SysConstants.BROWSER_LIST.Length;i++ )
            {
                AttributeModel attr = new AttributeModel();
                attr.AttrKey = SysConstants.BROWSER_LIST[i];

                if (null != browser && browser.Contains(SysConstants.BROWSER_LIST[i]))
                {
                    attr.AttrValue = "checked";
                }
                else
                {
                    attr.AttrValue = "";
                }
                browserList.Add(attr);
                
            }

        }

        public string GameStatus
        {
            get { return gameStatus; }
            set { gameStatus = value; }
        }


        public string GameName
        {
            get { return gameName; }
            set { gameName = value; }
        }
        public string Os
        {
            get { return os; }
            set { os = value; }
        }

        public string Browser
        {
            get { return browser; }
            set { browser = value; }
        }

        public float TaxRate
        {
            get { return taxRate; }
            set { taxRate = value; }
        }

        public int AllRoomLimit
        {
            get { return allRoomLimit; }
            set { allRoomLimit = value; }
        }

        public int OnePersonRoomLimit
        {
            get { return onePersonRoomLimit; }
            set { onePersonRoomLimit = value; }
        }

        public int OneRoomTableLimit
        {
            get { return oneRoomTableLimit; }
            set { oneRoomTableLimit = value; }
        }

        public int OneTablePersonLimit
        {
            get { return oneTablePersonLimit; }
            set { oneTablePersonLimit = value; }
        }

        public int BankerSelectNumTimeLimit
        {
            get { return bankerSelectNumTimeLimit; }
            set { bankerSelectNumTimeLimit = value; }
        }

        public int PlayerSelectNumTimeLimit
        {
            get { return playerSelectNumTimeLimit; }
            set { playerSelectNumTimeLimit = value; }
        }
    }
}