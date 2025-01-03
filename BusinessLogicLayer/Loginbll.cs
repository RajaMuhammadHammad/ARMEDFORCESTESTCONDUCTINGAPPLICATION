using System;
using DataAcessesLayer;

namespace BusinessLogicLayer
{
    public class Loginbll
    {
        private Login loginDal = new Login();
        public static string id;
        public static string cnic;
        public bool ValidateUser( string nic, string Id)
        {
            bool result= loginDal.ValidateUser(nic, Id);
            if (result)
            {
                id = Id;
                cnic = nic;
            }
            return result;
        }
    }
}
