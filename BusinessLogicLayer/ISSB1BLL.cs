using DataAcessesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ISSB1BLL
    {
        private Login loginDal = new Login();
        public static string id;
        public static string cnic;
        public bool ValidateUser(string nic, string Id)
        {
            bool result = loginDal.ValidateUser(nic, Id);
            if (result)
            {
                id = Id;
                cnic = nic;
            }
            return result;

        }
    }
}
