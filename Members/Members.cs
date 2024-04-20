using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    internal class Members
    {

        // Member - private field
        private string memberName;
        private string jobTitle;
        private int salery;

        //member - public field
        public int age;

        // member - property - exposes job Title safely - properties start with a captial letter
        public string JobTitle {
            get 
            { 
                return jobTitle;
            } 
            set 
            {
                jobTitle = value;
            } 
        }

        // public member Method - can be called from oother classes 
        public void Introducting(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();

            }else
            {
                Console.WriteLine("Hi my name is {0}, and my job title is {1}. I', {2} years old", memberName,jobTitle,age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salery is {0}", salery);
        }

        // member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salery = 60000;
            jobTitle = "Devoloper";
            Console.WriteLine("object created");
        }

        //member - finalizer - destructor
        ~Members()
        {
            // cleanup statments
            Console.WriteLine("Decostrauction of members object");
            Debug.Write("Destruction of Mebers object");
        }

        


    }
}
