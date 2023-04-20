using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace RealEstateTermProject
{
    [Serializable]
    public class RealEstateAgent
    {
        private String CompanyName;
        private String AgentName;
        private String PhoneNumber;


        public String companyName
        {
            get { return CompanyName; }
            set { CompanyName = value; }
        }


        public String agentName
        {
            get { return AgentName; }
            set { AgentName = value; }
        }

        public String phoneNumber
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }
    }
}