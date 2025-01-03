using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using BusinessLogicLayer;

namespace Project
{
    public partial class NavyRegistration : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Page load logic here
            }
        }
        private class FormValues
        {
            public string Force { get; set; }
            public string CandidateName { get; set; }
            public string CandidateCNIC { get; set; }
            public string FatherName { get; set; }
            public string FatherCNIC { get; set; }
            public string Gender { get; set; }
            public string MaritalStatus { get; set; }
            public string Religion { get; set; }
            public string Province { get; set; }
            public string Domicile { get; set; }
            public string DateOfBirth { get; set; }
            public string Email { get; set; }
            public string PostalAddress { get; set; }
            public string PermanentAddress { get; set; }
            public string CandidateMobile { get; set; }
            public string FatherMobile { get; set; }
            public HttpPostedFileBase file { get; set; }
        }
        private FormValues GetFormValues()
        {
            // Create a new instance of the FormValues class
            FormValues formValues = new FormValues();

            // Get values from form controls

            formValues.Force = advertisement.Value;
            formValues.CandidateName =  c_name.Value;
            formValues.CandidateCNIC = c_cnic.Value;
            formValues.FatherName = f_name.Value;
            formValues.FatherCNIC = f_cnic.Value;
            formValues.Gender = gender.Value;
            formValues.MaritalStatus = status.Value;
            formValues.Religion = religion.Value;
            formValues.Province = province.Value;
            formValues.Domicile = domicile.Value;
           formValues.DateOfBirth =dob.Value;
            formValues.Email = email.Value;
            formValues.PostalAddress = postaladdress.Value;
            formValues.PermanentAddress = permanentaddress.Value;
            formValues.CandidateMobile = candidatemobile.Value;
            formValues.FatherMobile = fathermobile.Value;
            

            // Return the FormValues object
            return formValues;
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            //getting image code
            //HttpPostedFileBase postedFileBase = ;
            //string fileName = ;
            FormValues formValues = GetFormValues();


            Registrationbll registrationBLL = new Registrationbll();
            string ForcetoApply = formValues.Force;
            string name = formValues.CandidateName;
            string fname = formValues.FatherName;
            string cnic = formValues.CandidateCNIC;
            string fcnic = formValues.FatherCNIC;
            string gender = formValues.Gender;
            string status = formValues.MaritalStatus;
            string religion = formValues.Religion;
            string province = formValues.Province;
            string domicile = formValues.Domicile;
            string dob = Convert.ToString(formValues.DateOfBirth);
            string email = formValues.Email;
            string postalAddress = formValues.PostalAddress;
            string permanentAddress = formValues.PermanentAddress;
            string candidateMobile = formValues.CandidateMobile;
            string fatherMobile = formValues.FatherMobile;
            registrationBLL.InsertData(ForcetoApply, name, fname, cnic, fcnic, gender, status, religion, province, domicile,dob,  email, postalAddress, permanentAddress, candidateMobile, fatherMobile);

        }

        protected void submitBtn0_Click(object sender, EventArgs e)
        {

        }
    }
}
