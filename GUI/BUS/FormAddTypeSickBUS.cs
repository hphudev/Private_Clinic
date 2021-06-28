using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    static public class FormAddTypeSickBUS
    {
        public static async Task<bool> CheckExistTypeSick(string typeSickName)
        {
            string idTypeSick = await DAO.FormAddTypeSickDAO.GetIdTypeSick(typeSickName);
            return idTypeSick != null;
        }

        public static async Task<int> CountTypeSick()
        {
            return await DAO.FormAddTypeSickDAO.CountTypeSick();
        }

        public static async void AddTypeSick(TypeSick typeSick)
        {
            await Task.Factory.StartNew(() => { 
                DAO.FormAddTypeSickDAO.AddTypeSick(typeSick);
                Thread.Sleep(1000);
            });
        }
    }
}
