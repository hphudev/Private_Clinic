using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    static public class FormSetInvolkeDAO
    {
        public static async Task<List<PatientExam>> GetPatientExams(DateTime date, bool check)
        {
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader read = null;
            if (check)
            {
                read = Data.ReadData(
                "PHIEUKB, CTKB",
                connection,
                $"where PHIEUKB.MACTKB = CTKB.MACTKB" +
                $" and DAY(ngaykhambenh) = '{date.Day.ToString()}'" +
                $" and MONTH(ngaykhambenh) = '{date.Month.ToString()}'" +
                $" and YEAR(ngaykhambenh) = '{date.Year.ToString()}'",
                 "maphieukb, phieukb.mactkb, trieuchung, mabenh");
            }
            else
            {
                read = Data.ReadData(
                "PHIEUKB, CTKB",
                connection,
                $"where PHIEUKB.MACTKB = CTKB.MACTKB",
                 "maphieukb, phieukb.mactkb, trieuchung, mabenh");
            }
            List<PatientExam> patientExams = new List<PatientExam>();
            while (read != null && read.HasRows)
            {
                if (!read.Read())
                    break;
                PatientExam patientExam = new PatientExam(
                    read.GetString(0),
                    read.GetString(1),
                    read.GetString(2),
                    read.GetString(3));
                patientExams.Add(patientExam);
            }
            return patientExams;
        }

        public static async Task<List<PatientExam>> GetPatientExams(DetailExam detailExam, DateTime date, bool check)
        {
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader read = null;
            if (check)
            {
                read = Data.ReadData(
                "PHIEUKB, CTKB",
                connection,
                $"where PHIEUKB.MACTKB = CTKB.MACTKB" +
                $" and PHIEUKB.MAPHIEUKB = N'{detailExam.Id}'" +
                $" and DAY(ngaykhambenh) = '{date.Day.ToString()}'" +
                $" and MONTH(ngaykhambenh) = '{date.Month.ToString()}'" +
                $" and YEAR(ngaykhambenh) = '{date.Year.ToString()}'",
                "phieukb.maphieukb, phieukb.mactkb, phieukb.trieuchung, phieukb.mabenh");
            }
            else
            {
                read = Data.ReadData(
                "PHIEUKB, CTKB",
                connection,
                $"where PHIEUKB.MACTKB = CTKB.MACTKB",
                "phieukb.maphieukb, phieukb.mactkb, phieukb.trieuchung, phieukb.mabenh");
            }
            List<PatientExam> patientExams = new List<PatientExam>();
            while (read.HasRows)
            {
                if (!read.Read())
                    break;
                PatientExam patientExam = new PatientExam(
                    read.GetString(0),
                    read.GetString(1),
                    read.GetString(2),
                    read.GetString(3));
                patientExams.Add(patientExam);
            }
            return patientExams;
        }


        public static async Task<List<PatientExam>> GetPatientExams(string PatientName = null, string idPatientExam = null, DateTime date = new DateTime(), bool check = false)
        {
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader read = null;
            if (PatientName != null && idPatientExam != null)
            {
                if (check)
                {
                    read = Data.ReadData(
                    "PHIEUKB, CTKB, BENHNHAN",
                    connection,
                    $"where PHIEUKB.MACTKB = CTKB.MACTKB" +
                    $" and BENHNHAN.mabenhnhan = ctkb.mabenhnhan" +
                    $" and benhnhan.hoten = N'{PatientName}'" +
                    $" and phieukb.maphieukb = N'{idPatientExam}'" +
                    $" and DAY(ngaykhambenh) = '{date.Day.ToString()}'" +
                    $" and MONTH(ngaykhambenh) = '{date.Month.ToString()}'" +
                    $" and YEAR(ngaykhambenh) = '{date.Year.ToString()}'",
                    "phieukb.maphieukb, phieukb.mactkb, phieukb.trieuchung, phieukb.mabenh");
                }
                else
                {
                    read = Data.ReadData(
                    "PHIEUKB, CTKB, BENHNHAN",
                    connection,
                    $"where PHIEUKB.MACTKB = CTKB.MACTKB" +
                    $" and BENHNHAN.mabenhnhan = ctkb.mabenhnhan" +
                    $" and benhnhan.hoten = N'{PatientName}'" +
                    $" and phieukb.maphieukb = N'{idPatientExam}'",
                    "phieukb.maphieukb, phieukb.mactkb, phieukb.trieuchung, phieukb.mabenh");
                }
               

            }
            else if (PatientName != null)
            {
                if (check)
                {
                    read = Data.ReadData(
                    "PHIEUKB, CTKB, BENHNHAN",
                    connection,
                    $"where PHIEUKB.MACTKB = CTKB.MACTKB" +
                    $" and BENHNHAN.mabenhnhan = ctkb.mabenhnhan" +
                    $" and benhnhan.hoten = N'{PatientName}'" +
                    $" and DAY(ngaykhambenh) = '{date.Day.ToString()}'" +
                    $" and MONTH(ngaykhambenh) = '{date.Month.ToString()}'" +
                    $" and YEAR(ngaykhambenh) = '{date.Year.ToString()}'",
                "phieukb.maphieukb, phieukb.mactkb, phieukb.trieuchung, phieukb.mabenh");
                }
                else
                {
                    read = Data.ReadData(
                    "PHIEUKB, CTKB, BENHNHAN",
                    connection,
                    $"where PHIEUKB.MACTKB = CTKB.MACTKB" +
                    $" and BENHNHAN.mabenhnhan = ctkb.mabenhnhan" +
                    $" and benhnhan.hoten = N'{PatientName}'",
                    "phieukb.maphieukb, phieukb.mactkb, phieukb.trieuchung, phieukb.mabenh");
                }
                
            }
            else if (idPatientExam != null)
            {
                if (check)
                {
                    read = Data.ReadData(
                    "PHIEUKB, CTKB, BENHNHAN",
                    connection,
                    $"where PHIEUKB.MACTKB = CTKB.MACTKB" +
                    $" and BENHNHAN.mabenhnhan = ctkb.mabenhnhan" +
                    $" and phieukb.maphieukb = N'{idPatientExam}'" +
                    $" and DAY(ngaykhambenh) = '{date.Day.ToString()}'" +
                    $" and MONTH(ngaykhambenh) = '{date.Month.ToString()}'" +
                    $" and YEAR(ngaykhambenh) = '{date.Year.ToString()}'",
                    "phieukb.maphieukb, phieukb.mactkb, phieukb.trieuchung, phieukb.mabenh");
                }
                else
                {
                    read = Data.ReadData(
                    "PHIEUKB, CTKB, BENHNHAN",
                    connection,
                    $"where PHIEUKB.MACTKB = CTKB.MACTKB" +
                    $" and BENHNHAN.mabenhnhan = ctkb.mabenhnhan" +
                    $" and phieukb.maphieukb = N'{idPatientExam}'",
                    "phieukb.maphieukb, phieukb.mactkb, phieukb.trieuchung, phieukb.mabenh");
                }
                
            }
           
            List<PatientExam> patientExams = new List<PatientExam>();
            if (read != null)
            while (read.HasRows)
            {
                if (!read.Read())
                    break;
                PatientExam patientExam = new PatientExam(
                    read.GetString(0),
                    read.GetString(1),
                    read.GetString(2),
                    read.GetString(3));
                patientExams.Add(patientExam);
            }
            return patientExams;
        }

        static public async Task<List<PatientPhu>> GetPatients(string idPatientExam = null, DateTime date = new DateTime(), bool check = false)
        {
            List<PatientPhu> patients = new List<PatientPhu>();
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader reader;
            if (idPatientExam != null)
            {
                if (check)
                {
                    reader = Data.ReadData(
                    "benhnhan,  phieukb, ctkb",
                    connection,
                    $"where benhnhan.mabenhnhan = ctkb.mabenhnhan " +
                    $" and ctkb.mactkb = phieukb.mactkb" +
                    $" and phieukb.maphieukb = N'{idPatientExam}'" +
                    $" and DAY(ngaykhambenh) = '{date.Day.ToString()}'" +
                    $" and MONTH(ngaykhambenh) = '{date.Month.ToString()}'" +
                    $" and YEAR(ngaykhambenh) = '{date.Year.ToString()}'",
                    "benhnhan.mabenhnhan, benhnhan.hoten, benhnhan.gioitinh, benhnhan.ngaysinh, benhnhan.diachi");
                }
                else
                {
                    reader = Data.ReadData(
                    "benhnhan,  phieukb, ctkb",
                    connection,
                    $"where benhnhan.mabenhnhan = ctkb.mabenhnhan " +
                    $" and ctkb.mactkb = phieukb.mactkb" +
                    $" and phieukb.maphieukb = N'{idPatientExam}'" ,
                    "distinct benhnhan.mabenhnhan, benhnhan.hoten, benhnhan.gioitinh, benhnhan.ngaysinh, benhnhan.diachi");
                }
                
            }
            else
            {
                if (check)
                {
                    reader = Data.ReadData(
                    "benhnhan,  phieukb, ctkb",
                    connection,
                    $"where benhnhan.mabenhnhan = ctkb.mabenhnhan " +
                    $" and ctkb.mactkb = phieukb.mactkb" +
                    $" and DAY(ngaykhambenh) = '{date.Day.ToString()}'" +
                    $" and MONTH(ngaykhambenh) = '{date.Month.ToString()}'" +
                    $" and YEAR(ngaykhambenh) = '{date.Year.ToString()}'",
                    "benhnhan.mabenhnhan, benhnhan.hoten, benhnhan.gioitinh, benhnhan.ngaysinh, benhnhan.diachi");
                }
                else
                {
                    reader = Data.ReadData(
                    "benhnhan,  phieukb, ctkb",
                    connection,
                    $"where benhnhan.mabenhnhan = ctkb.mabenhnhan ",
                    "distinct benhnhan.mabenhnhan, benhnhan.hoten, benhnhan.gioitinh, benhnhan.ngaysinh, benhnhan.diachi");
                }
                
            }
            while (reader.HasRows)
            {
                if (!reader.Read())
                    break;
                PatientPhu patient = new PatientPhu(
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetDateTime(3),
                    reader.GetString(4));
                patients.Add(patient);
            }
            return patients;
        }

        static public async Task<int> CountInvolke(string idPatientExam)
        {
            return await Data.Calculate(
                "count",
                 "*",
                 "hoadon, phieukb, ctkb",
                 $"where phieukb.maphieukb = N'{idPatientExam}' " +
                 $"and phieukb.mactkb = ctkb.mactkb " +
                 $"and hoadon.mactkb = ctkb.mactkb");
        }

        static public async Task<List<DetailPatientExam>> GetDetailPatients(string idPatientExam)
        {
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader reader = Data.ReadData(
                "ctphieukb",
                connection,
                $"where maphieukb = N'{idPatientExam}'",
                "*");
            if (reader == null)
                return new List<DetailPatientExam>();
            List<DetailPatientExam> detailPatientExams = new List<DetailPatientExam>();
            while (reader.HasRows)
            {
                if (!reader.Read())
                    break;
                DetailPatientExam detailPatientExam = new DetailPatientExam(
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetInt32(3),
                    reader.GetString(4),
                    reader.GetInt32(5));
                detailPatientExams.Add(detailPatientExam);
            }
            return detailPatientExams;
        }

        static public async Task<MedicinePhu> GetMedicine(string idMedicine)
        {
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader reader = Data.ReadData(
                "thuoc",
                connection,
                $"where mathuoc = N'{idMedicine}'",
                "*");
            if (reader == null)
                return null;
            while (reader.HasRows)
            {
                if (!reader.Read())
                    break;
                MedicinePhu medicine = new MedicinePhu(
                     reader.GetString(0),
                     reader.GetString(1),
                     reader.GetInt32(3),
                     reader.GetString(5),
                     reader.GetInt32(6),
                     reader.GetInt32(2),
                     reader.GetInt32(4));
                return medicine;
            }
            return null;
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

        public static async Task<int> GetExamMoney()
        {
            SqlConnection connection = await Data.OpenConnection();
            SqlDataReader reader = Data.ReadData(
                "thamso",
                connection,
                $"where tenthamso = N'Tiền khám'",
                "*");
            if (reader == null)
                return -1;
            if (reader.HasRows && reader.Read())
            {
                return reader.GetInt32(1);
            }
            return -1;
        }

        public static void AddInvolke(Involke involke)
        {
            Data.AddData(
                "hoadon",
                $"N'{involke.Id}', N'{involke.IdDetailMedical}', {involke.ExamMoney}, {involke.SumMedicalMoney}, '{involke.TotalMoney}'");
        }

        public static async Task<int> CountInvolke()
        {
            return await Data.Calculate(
                "count",
                "*",
                "hoadon",
                "");
        }
    }
}
