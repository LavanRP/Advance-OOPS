using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class IDInfo : PersonalInfo
    {
        //VoterID, AadharID, PANnumber
        public string VoterID { get; set; }
        public string AadharID { get; set; }
        public string PANNumber { get; set; }

        public IDInfo(string name,Gender gender,DateTime dob,string phone,string voterID,string aadharID,string panNumber):base(name,gender,dob,phone)
        {
            VoterID = voterID;
            AadharID = aadharID;
            PANNumber = panNumber;
        }
    }
}