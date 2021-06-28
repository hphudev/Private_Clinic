using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    static public class FormAddUseWayBUS
    {
        public static async void AddUseWay(UseWayPhu useWay)
        {
            int count = await CountUseWays() + 1;
            string id = Support.IdAdapter("CD", count, 2);
            useWay.Id = id;
            await Task.Factory.StartNew(() => { 
                DAO.FormAddUseWayDAO.AddUseWay(useWay);
                Thread.Sleep(1000);
            });
        }

        public static async Task<UseWayPhu> GetUseWay(string useWayName)
        {
            return await DAO.FormAddUseWayDAO.GetUseWay(useWayName);
        }

        public static async Task<int> CountUseWays()
        {
            return await DAO.FormAddUseWayDAO.CountUseWays();
        }
    }
}
