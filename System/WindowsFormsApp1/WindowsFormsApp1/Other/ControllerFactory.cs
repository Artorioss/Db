using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.IControllers;
using WindowsFormsApp1.Modeles;

namespace WindowsFormsApp1.Other
{
    //Абстрактная фабрика
    internal class ControllerFactory : AbstractFactoryControllers
    {
        //public CommodityExpertController createCommodityExpertController(IDbModel model)
        //{
        //    return new CommodityExpertController(model);
        //}

        //public GeneralController createGeneralController(IDbModel model)
        //{
        //    return new GeneralController(model);
        //}

        //public ManagerController createManagerController(IDbModel model)
        //{
        //    return new ManagerController(model);
        //}


        public AuthorizationController createAuthorizationController(IDbModel model) 
        {
            return new AuthorizationController(model, this);
        }

        public IController createSessionController(IDbModel model, User sessionUser)
        {
            switch (sessionUser.employee.jobTitle.id) 
            {
                case 1:
                    return new GeneralController(model);
                case 5:
                    return new ManagerController(model);
                default:
                    return new CommodityExpertController(model);
            }
        }
    }
}
