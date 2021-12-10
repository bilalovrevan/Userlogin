using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Userlogin
{
    internal class User
    {
        string username;
        string pwd;
       
        public string Username

        { 
                get { return username; } set
            {
                if (value.Length<5)
                {
                    throw new Exception("minimum 5 simvol olmalidir!");
                    
                }
                username = value; } }
        public string Password
        { get { return pwd; } set 
            { if(value.Length<8)
                {
                    throw new Exception("minimum 8 simvoldan ibaret olmalidir!");
                }
                    this.pwd = value; } }
             
    }
}
