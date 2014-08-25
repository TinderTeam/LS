using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;

namespace LotterySystem.Dao
{
    public interface GamblingPartyDao
    {
        List<GamblingParty> getAll();
        GamblingParty getGamblingPartyByGamblingPartyID(String gamblingPartyID);
        void creatGamblingParty(GamblingParty gamblingParty);
        void deleteGamblingPartyByGamblingPartyID(String gamblingPartyID);
        void updateGamblingParty(GamblingParty gamblingParty);

    }
}