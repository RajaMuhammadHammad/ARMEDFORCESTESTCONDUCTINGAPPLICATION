using DataAccessLayer;
using DataAcessesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ISSBFORMLBLL
    {
        ISSBFORMDAL registrationDAL = new ISSBFORMDAL();
        public void InsertData(String ForcetoApply, string name, string fname, string cnic, string fcnic, string gender, string status, string religion, string province, string domicile, String dob, string email, string postalAddress, string permanentAddress, string candidateMobile, string fatherMobile)
        {

            registrationDAL.InsertData(ForcetoApply, name, fname, cnic, fcnic, gender, status, religion, province, domicile, dob, email, postalAddress, permanentAddress, candidateMobile, fatherMobile);
        }
    }

}
