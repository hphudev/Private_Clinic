using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Threading;

namespace BUS
{
    static public class FormSetInvolkeBUS
    {
        static public async Task<List<PatientExam>> GetPatientExams(string patientName = null, string idPatientExam = null, DateTime date = new DateTime(), bool check = false)
        {
            if (patientName != null && idPatientExam != null)
            {
                return await DAO.FormSetInvolkeDAO.GetPatientExams(patientName, idPatientExam, date, check);
            }
            else if (patientName != null)
            {
                return await DAO.FormSetInvolkeDAO.GetPatientExams(patientName, null, date, check);
            }
            else if (idPatientExam != null)
            {
                return await DAO.FormSetInvolkeDAO.GetPatientExams(null, idPatientExam, date, check);
            }
            else
            {
                return await DAO.FormSetInvolkeDAO.GetPatientExams(date, check);
            }
        }

        static public async Task<List<PatientPhu>> GetPatients(string idPatientExam, DateTime date, bool check)
        {
            return await DAO.FormSetInvolkeDAO.GetPatients(idPatientExam, date, check);
        }

        static public async Task<MedicinePhu> GetMedicine(string idMedicine)
        {
            return await DAO.FormSetInvolkeDAO.GetMedicine(idMedicine);
        }

        static public async Task<List<DetailPatientExam>> GetDetailPatientExams(string idPatientExam)
        {
            return await DAO.FormSetInvolkeDAO.GetDetailPatients(idPatientExam);
        }

        public static async Task<String> GetUnitName(string idUnit)
        {
            return await DAO.FormSetInvolkeDAO.GetUnitName(idUnit);
        }

        public static async Task<int> GetExamMoney()
        {
            return await DAO.FormSetInvolkeDAO.GetExamMoney();
        }

        public static async void AddInvolke(Involke involke)
        {
            await Task.Factory.StartNew(() => { 
                DAO.FormSetInvolkeDAO.AddInvolke(involke);
                Thread.Sleep(1000);
            });
        }

        public static async Task<int> CountInvolke()
        {
            return await DAO.FormSetInvolkeDAO.CountInvolke();
        }

    }
}
