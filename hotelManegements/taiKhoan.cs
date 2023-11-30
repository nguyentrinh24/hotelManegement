using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManegements
{
    public class taiKhoan
    {
        private string _name;
        private string _passWord;
        public taiKhoan() { }
        public taiKhoan(string name, string passWord)
        {
            this._name = name;
            this._passWord = passWord;
        }

        public string Name { get => _name; set => _name = value; }
        public string PassWord { get => _passWord; set => _passWord = value; }
    }
}
