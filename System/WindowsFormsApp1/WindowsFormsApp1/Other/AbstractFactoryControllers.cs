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
    internal interface AbstractFactoryControllers
    {
        IController createSessionController(IDbModel model, User sessionUser);
        //CommodityExpertController createCommodityExpertController(IDbModel model);
        //GeneralController createGeneralController(IDbModel model);
        //ManagerController createManagerController(IDbModel model);
        AuthorizationController createAuthorizationController(IDbModel model);
    }
}

