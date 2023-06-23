using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class userInfo
    {
        private string _username;
        private string _psw;

        public string username
        {
            set { _username = value; }
            get { return _username; }
        }
        public string psw
        {
            set { _psw = value; }
            get { return _psw; }
        }
    }
}

