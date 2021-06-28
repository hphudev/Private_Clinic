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
    static public class FormSetMedicalExaminationBUS
    {
        static public async Task<List<PatientPhu>> LoadForm(DateTime dateTime)
        {
            //Danh sách các vị trí xóa
            List<int> posDeleteList = new List<int>();
            //Danh sách các bệnh nhân đã và đang khám
            List<PatientPhu> patients = new List<PatientPhu>();
            //Lấy danh sách bệnh nhân đã và đang khám
            patients = await DAO.FormSetMedicalExaminationDAO.LoadForm(dateTime);
            //Lọc những bệnh nhân chưa khám
            int count = 0;
            foreach(var patient in patients)
            {
                count++;
                int countExam = await BUS.FormSetMedicalExaminationBUS.CountMedicalExam(patient, dateTime);
                if (countExam > 0)
                    posDeleteList.Add(count - 1);
            }
            int co = 0;
            foreach (var pos in posDeleteList)
            {
                patients.RemoveAt(pos - co);
                co++;
            }
            //Trả về kết quả
            return patients;
        }
        
        static public async Task<int> CountMedicalExam(PatientPhu patient, DateTime date)
        {
            int count = await Data.Calculate(
                "count",
                "*",
                "phieukb, ctkb",
                 $"where DAY(ngaykhambenh) = '{date.Day}'" +
                 $"and MONTH(ngaykhambenh) = '{date.Month}'" +
                 $"and YEAR(ngaykhambenh) = '{date.Year}'" +
                 $"and phieukb.mactkb = ctkb.mactkb and ctkb.mabenhnhan = '{patient.Id}'");
            return count;
        }
        
        static public async void DeleteDetailExam(PatientPhu patient, DateTime date)
        {
            DAO.FormSetMedicalExaminationDAO.DeleteDetailMedical(patient, date);
        }

        static public async Task<int> CountMedicalExam()
        {
            int count = await Data.Calculate(
                "count",
                "*",
                "phieukb",
                 "");
            return count;
        }

        static public async Task<List<TypeSick>> cbTypeSickApdapter()
        {
            List<TypeSick> typeSicks = new List<TypeSick>();
            return typeSicks = await DAO.FormSetMedicalExaminationDAO.GetTypeSicks();
        }

        static public async Task<bool> CheckTypeSickLeaveEvent(string typeSickName)
        {
            string idTypeSick = await FormSetMedicalExaminationDAO.GetIdTypeSick(typeSickName);
            return (idTypeSick != null);
        }
       
        static public async Task<List<MedicinePhu>> cbMedicalAdpater()
        {
            List<MedicinePhu> medicines = new List<MedicinePhu>();
            medicines = await DAO.FormSetMedicalExaminationDAO.GetMedicines();
            return medicines;
        }

        static public async Task<MedicinePhu> GetMedical(string medicalName)
        {
            return await DAO.FormSetMedicalExaminationDAO.GetMedical(medicalName);
        }

        static public async Task<List<UseWayPhu>> GetUseWays()
        {
            List<UseWayPhu> useWays = await DAO.FormAddUseWayDAO.GetUseWays();
            return useWays;
        }

        static public async Task<String> GetUnitName(string idUnit)
        {
            string unitName = await DAO.FormSetMedicalExaminationDAO.GetUnitName(idUnit);
            return unitName;
        }

        static public async Task<UseWayPhu> GetUseWay(string useWayName)
        {
            return await DAO.FormSetMedicalExaminationDAO.GetUseWay(useWayName);
        }

        static public async void SaveMedicalExam(PatientExam patientExam, DetailExam detailExam, List<MedicinePhu> medicines,
            List<UseWayPhu> useWays, List<int> medicalNums)
        {
            //int countDetailExam = await DAO.FormSetMedicalExaminationDAO.CountDetailExam() + 1;
            //string idDeTailExam = Support.IdAdapter("CTKB", countDetailExam, 5);
            //detailExam.Id = idDeTailExam;
            //DAO.FormSetMedicalExaminationDAO.AddDetailExam(detailExam);

            int countPatientExam = await DAO.FormSetMedicalExaminationDAO.CountPatientExam() + 1;
            string idPatientExam = Support.IdAdapter("PKB", countPatientExam, 5);
            patientExam.Id = idPatientExam;
            DAO.FormSetMedicalExaminationDAO.AddPatientExam(patientExam);

            int pos = -1;
            foreach(var medicine in medicines)
            {
                pos++;
                int countDetailPatientExam = await DAO.FormSetMedicalExaminationDAO.CountDetailPatientExam() + 1;
                string idDetailPatientExam = Support.IdAdapter("CTPKB", countDetailPatientExam, 5);
                DetailPatientExam detailPatientExam = new DetailPatientExam(
                    idDetailPatientExam,
                    idPatientExam,
                    medicine.ID,
                    medicalNums[pos],
                    useWays[pos].Id,
                    medicine.sellableUnitPrice * medicalNums[pos]);
                await Task.Factory.StartNew(() => {
                    DAO.FormSetMedicalExaminationDAO.AddDetailPatientExam(detailPatientExam);
                    Thread.Sleep(1000);
                });
            }
        }

        public static async Task<DetailExam> GetDetailExam(string idPatient, DateTime date)
        {
            return await DAO.FormSetMedicalExaminationDAO.GetDetailExam(idPatient, date);
        }
    }
}
