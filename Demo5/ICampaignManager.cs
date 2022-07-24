using System;
using System.Collections.Generic;
using System.Text;

namespace Demo5
{
    internal interface ICampaignManager
    {
        void Add(Campaign campaign);
        void Remove(Campaign campaign);
        void Update(Campaign campaign);
        void ListOfCampaign();
    }
}
