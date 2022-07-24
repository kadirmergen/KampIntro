using System;
using System.Collections.Generic;
using System.Text;

namespace Demo5
{
    internal class CampaignService : ICampaignManager
    {
        List<Campaign> campaigns = new List<Campaign>();
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignId +" "+campaign.CampaignName + " added as a new Campaign!");
            campaigns.Add(campaign);
        }
        public void Remove(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignId + " " + campaign.CampaignName + " named campaign is removed!");
            campaigns.Remove(campaign);
        }
        public void ListOfCampaign()
        {
            Console.WriteLine("The Campaigns: ");
            foreach (Campaign campaign in campaigns)
            {
                Console.WriteLine(campaign.CampaignId + " " + campaign.CampaignName);
            }
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignId + " " + campaign.CampaignName+" named campaign is updated!");
        }
    }
}
