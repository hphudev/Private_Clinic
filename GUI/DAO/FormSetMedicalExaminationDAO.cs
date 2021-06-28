using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class FormSetMedicalExaminationDAO
    {
        public static async Task<List<PatientPhu>> LoadForm(DateTime date)
        {
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader reader = Data.ReadData(
                "ctkb, benhnhan", 
                connection, 
                $"where ctkb.mabenhnhan = benhnhan.mabenhnhan " +
                $"and DAY(ngaykhambenh) = '{date.Day.ToString()}'" +
                $"and MONTH(ngaykhambenh) = '{date.Month.ToString()}'" +
                $"and YEAR(ngaykhambenh) = '{date.Year.ToString()}'",
                "benhnhan.mabenhnhan, hoten, gioitinh, ngaysinh, diachi");
            List<PatientPhu> list = new List<PatientPhu>();
            while (reader.HasRows)
            {
                if (!reader.Read())
                {
                    break;
                }
                PatientPhu patient = new PatientPhu(
                    reader.GetString(0), 
                    reader.GetString(1),
                    reader.GetString(2),
                    DateTime.Parse(reader.GetDateTime(3).ToString()),
                    reader.GetString(4));
                list.Add(patient);
            }
            Data.CloseConnection(ref connection);
            return list;
        }

        public static async Task<List<TypeSick>> GetTypeSicks()
        {
            List<TypeSick> typeSicks = new List<TypeSick>();
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader reader = Data.ReadData(
                "benh",
                connection,
                "",
                "*");
            while (reader.HasRows)
            {
                if (!reader.Read())
                    break;
                TypeSick typeSick = new TypeSick(
                    reader.GetString(0),
                    reader.GetString(1));
                typeSicks.Add(typeSick);
            }
            Data.CloseConnection(ref connection);
            return typeSicks;
        }

        public static async Task<string> GetIdTypeSick(string typeSickName)
        {
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader reader = Data.ReadData(
                "benh",
                connection,
                $"where tenbenh = N'{typeSickName}'",
                "mabenh");
            if (reader.HasRows && reader.Read())
            {
                string tmp =  reader.GetString(0);
                Data.CloseConnection(ref connection);
                return tmp;
            }
            else
            {
                Data.CloseConnection(ref connection);
                return null;
            }
        }

        public static async void DeleteDetailMedical(PatientPhu patient, DateTime date)
        {
            Data.DeleteData(
                "ctkb",
                $"where mabenhnhan = N'{patient.Id}' " +
                $"and DAY(ngaykhambenh) = '{date.Day.ToString()}'" +
                $"and MONTH(ngaykhambenh) = '{date.Month.ToString()}'" +
                $"and YEAR(ngaykhambenh) = '{date.Year.ToString()}'");
        }

        public static async Task<List<MedicinePhu>> GetMedicines()
        {
            List<MedicinePhu> medicines = new List<MedicinePhu>();
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader reader = Data.ReadData(
                "thuoc",
                connection,
                "",
                "*");
            while (reader.HasRows)
            {
                if (!reader.Read())
                {
                    Data.CloseConnection(ref connection);
                    break;
                }
                MedicinePhu medicine = new MedicinePhu(
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetInt32(3),
                    reader.GetString(5),
                    reader.GetInt32(6),
                    reader.GetInt32(2),
                    reader.GetInt32(4));
                medicines.Add(medicine);
            }
            Data.CloseConnection(ref connection);
            return medicines;
        }

        public static async Task<MedicinePhu> GetMedical(string medicalName)
        {
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader reader = Data.ReadData(
                "thuoc",
                connection,
                $"where tenthuoc = N'{medicalName}'",
                "*");
            if (reader.HasRows && reader.Read())
            {
                MedicinePhu medicine = new MedicinePhu(
                     reader.GetString(0),
                     reader.GetString(1),
                     reader.GetInt32(3),
                     reader.GetString(5),
                     reader.GetInt32(6),
                     reader.GetInt32(2),
                     reader.GetInt32(4));
                Data.CloseConnection(ref connection);
                return medicine;
            }
            Data.CloseConnection(ref connection);
            return null;
        }

        public static async Task<List<UseWayPhu>> GetUseWays()
        {
            List<UseWayPhu> useWays = new List<UseWayPhu>();
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader reader = Data.ReadData(
                "cachdung",
                connection,
                "",
                "*");
            while (reader.HasRows)
            {
                if (!reader.Read())
                    break;
                UseWayPhu useWay = new UseWayPhu(
                    reader.GetString(0),
                    reader.GetString(1));
                useWays.Add(useWay);
            }
            Data.CloseConnection(ref connection);
            return useWays;
        }

        public static async Task<String> GetUnitName(string idUnit)
        {
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader reader = Data.ReadData(
                "donvitinh",
                connection,
                $"where madonvitinh = N'{idUnit}'",
                "tendonvitinh");
            if (reader.HasRows && reader.Read())
            {
                string name = reader.GetString(0);
                Data.CloseConnection(ref connection);
                return name;
            }
            Data.CloseConnection(ref connection);
            return null;
        }

        public static async Task<UseWayPhu> GetUseWay(string useWayName)
        {
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader reader = Data.ReadData(
                "cachdung",
                connection,
                $"where tencachdung = N'{useWayName}'",
                "*");
            if (reader.HasRows && reader.Read())
            {
                UseWayPhu useWay = new UseWayPhu(
                    reader.GetString(0),
                    reader.GetString(1)) ;
                Data.CloseConnection(ref connection);
                return useWay;
            }
            Data.CloseConnection(ref connection);
            return null;
        }

        public static async Task<DetailExam> GetDetailExam(string idPatient, DateTime date)
        {
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader reader = Data.ReadData(
                "ctkb",
                connection,
                $"where ctkb.mabenhnhan =  N'{idPatient}'" +
                $"and DAY(ngaykhambenh) = '{date.Day.ToString()}'" +
                $"and MONTH(ngaykhambenh) = '{date.Month.ToString()}'" +
                $"and YEAR(ngaykhambenh) = '{date.Year.ToString()}'",
                "*");
            if (reader.HasRows && reader.Read())
            {
                DetailExam detailExam = new DetailExam(
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetDateTime(2));
                Data.CloseConnection(ref connection);
                return detailExam;
            }
            Data.CloseConnection(ref connection);
            return null;
        }

        public static async Task<int> CountDetailExam()
        {
            int count = await Data.Calculate(
                "count",
                "*",
                "ctkb",
                "");
            return count;
        }

        public static async Task<int> CountPatientExam()
        {
            int count = await Data.Calculate(
                "count",
                "*",
                "phieukb",
                "");
            return count;
        }

        public static async Task<int> CountDetailPatientExam()
        {
            int count = await Data.Calculate(
                "count",
                "*",
                "ctphieukb",
                "");
            return count;
        }

        public static void AddDetailExam(DetailExam detailExam)
        {
            Data.AddData(
                "ctkb",
                $"N'{detailExam.Id}', N'{detailExam.IdPatient}', N'{detailExam.SickDay.ToString("yyyy-MM-dd")}'");
        }

        public static void AddPatientExam(PatientExam patientExam)
        {
            Data.AddData(
                "phieukb",
                $"N'{patientExam.Id}', N'{patientExam.Id_detail}', N'{patientExam.SignalSick}', N'{patientExam.IdTypeSick}'");
        }

        public static async void AddDetailPatientExam(DetailPatientExam detailPatientExam)
        {
            await Task.Factory.StartNew(() =>
            {
                Data.AddData(
                "CTPHIEUKB",
                $"N'{detailPatientExam.Id}'," +
                $"N'{detailPatientExam.IdPatientExam}'," +
                $"N'{detailPatientExam.IdMedical}'," +
                $"N'{detailPatientExam.MedicalNum}'," +
                $"N'{detailPatientExam.IdUseWay}'," +
                $"N'{detailPatientExam.Money}'");
            });
            
        }
    }
}
