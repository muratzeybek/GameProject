using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    class CampaignManager : ICampaignService
    {
        public void AddCampaign()
        {
            Console.WriteLine("Campaign added...");
        }

        public void DeleteCampaign()
        {
            Console.WriteLine("Campaign deleted...");
        }

        public void UpdateCampaign()
        {
            Console.WriteLine("Campaign updated...");
        }
    }
}
