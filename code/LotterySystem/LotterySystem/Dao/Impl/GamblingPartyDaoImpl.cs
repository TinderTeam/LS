using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Models;
using LotterySystem.Test.Stub;
namespace LotterySystem.Dao.Impl
{
    public class GamblingPartyDaoImpl:GamblingPartyDao
    {
        public  List<GamblingParty> getAll()
        {
            List<GamblingParty> list = DBStub.getDBStub().getGamblingPartyList();
            return list;
        }
        public GamblingParty getGamblingPartyByGamblingPartyID(String gamblingPartyID)
        {
            return null;
        }
        public void creatGamblingParty(GamblingParty gamblingParty)
        {
        }
        public void deleteGamblingPartyByGamblingPartyID(String gamblingPartyID)
        {
        }
        public void updateGamblingParty(GamblingParty gamblingParty)
        {
        }

        public  List<GamblingParty> getGamblingPartyByGameAndRoom(String game, String room)
        {
            List<GamblingParty> gamblingParty = new List<GamblingParty>();
            List<GamblingParty> list = DBStub.getDBStub().getGamblingPartyList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GameName.Equals(game) && list[i].RoomName.Equals(room))
                {
                    gamblingParty.Add(list[i]);
                }
                
            }
            return gamblingParty;
        }
     }
}