using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Modeles;

namespace WindowsFormsApp1.IControllers.TypesСontrollers
{
    public abstract class AccessController : IController
    {
        protected FormAuthorization formAuthorization;
        protected IDbModel model;
        public void closeView()
        {
            formAuthorization.Close();
        }
    }
}
