using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whizdom_Training.PageObjects
{
    internal class Loginpageobj
    {
        public string loginlink_xpath = "//a[@href='/login']";
        public string logoutlink_xpath = "//a[@href='/logout']";
        public string loginusername_xpath = "//input[@id='Email']";
        public string loginpassword_xpath = "//input[@id='Password']";
        public string loginbutton_xpath = "//input[contains(@value,'Log')]";
    }
}
