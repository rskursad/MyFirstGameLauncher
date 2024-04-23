using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    internal class Remember
    {
        private string _remember;
        private LoginScreen loginscreen = (LoginScreen)Application.OpenForms["LoginScreen"];


        public void SetRemember(string rem)
        {

            _remember = rem;
        }
        public string GetRemember()
        {
            return this._remember;
        }
    }
}
