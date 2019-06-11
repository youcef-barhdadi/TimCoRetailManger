using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMWPFUserInterface.ViewModels
{
    public class LoginViewModel : Screen
    {

        private string _userName;
        private string _passWord;

        public string UserName
        {
            get { return _userName; }
            set
            {


                _userName = value;
                NotifyOfPropertyChange(() => UserName);

            }
        }

        public string PassWord
        {
            get { return _passWord; }
            set
            {
                _passWord = value;

                NotifyOfPropertyChange(() => PassWord);
                NotifyOfPropertyChange(() => CanLogIn);
                //CanLogIn(UserName, PassWord);
            }
        }


        public bool CanLogIn
        {
            get
            {
                if (UserName?.Length > 0 && PassWord?.Length > 0)
                {
                    return true;
                }
                return false;

            }

        }

        public void LogIn(string userName, string password)
        {
            //if (CanLogIn(userName, password))
            //{

            //}

        }




    }
}
