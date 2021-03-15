﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EWSApplication.DataLayers;
using EWSApplication.DataLayers.Common;
using EWSApplication.Entities.DBContext;
namespace EWSApplication.BussinessLayers
{
    public class SystemBLL
    {
        private static SystemDAL SysDal = new SystemDAL();
        public static UserAccount System_Login(string userName, string password)
        {
            return SysDal.Login(userName, password);
        }
        public static List<StructureAccountToRender> System_GetListInfoAccount()
        {
            return SysDal.GetListInfoAccount();
        }
        public static bool System_CreateNewAccount(UserAccount acc)
        {
            return SysDal.CreateNewAccount(acc);
        }
        public static bool System_DeteleNewAccount(int userid)
        {
            return SysDal.DeteleNewAccount(userid);
        }
    }
}
