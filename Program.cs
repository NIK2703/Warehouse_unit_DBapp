using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;


namespace Warehouse_unit_DBapp
{

    static class Program
    {
        

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseRepository.initConnection();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());   
        }
    }

    static class DatabaseRepository
    {
        public static SqlConnection con;

        public static void initConnection(){
            con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.ConString;
        }

        public static void insertNewMaterial(String name, Double quantity, String measure_unit, String provider)
        {
            con.Open();

            SqlCommand proc = new SqlCommand("get_last_material_id", con);
            proc.Connection = con;
            proc.CommandType = System.Data.CommandType.StoredProcedure;
            Int32 materialLastId = (Int32)proc.ExecuteScalar();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandText = "INSERT INTO Materials(material_ID, m_name, m_quantity, m_measure_unit, m_provider) VALUES ("+ (materialLastId + 1) +" ,'" + name +
                    "', " + quantity + ", '" + measure_unit + "', '" + provider + "');";
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                Console.Out.WriteLine("Ошибка ввода данных");
            }
            con.Close();
        }

        public static List<Object[]> getMaterialsEnum()
        {
            List<Object[]> materialsEnum = new List<Object[]>();

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandText = "SELECT material_ID, m_name, m_measure_unit FROM Materials;";
                SqlDataReader sdr =  cmd.ExecuteReader();
                while (sdr.Read())
                {
                    materialsEnum.Add(new Object[] { sdr.GetInt32(0), sdr.GetString(1), sdr.GetString(2) });
                }
            }
            catch (SqlException)
            {
                Console.Out.WriteLine("Ошибка ввода данных");
            }
            con.Close();

            return materialsEnum;
        }

        public static void updateMaterialQuantity(Int32 id, Double addQuantity)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandText = "UPDATE Materials SET m_quantity = m_quantity + " + addQuantity + "WHERE material_ID = " + id + ";";
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                Console.Out.WriteLine("Ошибка ввода данных");
            }
            con.Close();
        }

        public static DataTable getMaterialsTable()
        {
            DataTable table = new DataTable();
            table.TableName = "Materials";
            table.Rows.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandText = "SELECT * FROM Materials;";
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
            }
            catch (SqlException)
            {
                Console.Out.WriteLine("Ошибка ввода данных");
            }
            con.Close();
            return table;
        }

        public static List<Object[]> getInvoiceList()
        {
            List<Object[]> list = new List<object[]>();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandText = "SELECT invoice_id, rp_name, i_issue_date FROM Invoice, Responsible_person WHERE Invoice.i_responsible_person_ID = Responsible_person.responsible_person_ID ;";
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    list.Add(new Object[] { sdr.GetInt32(0), sdr.GetString(1), sdr.GetDateTime(2) });
                } 
            }
            catch (SqlException)
            {
                Console.Out.WriteLine("Ошибка ввода данных");
            }
            con.Close();
            return list;
        }

        public static List<Object[]> getInvoiceLineList(Int32 invoice_ID)
        {
            List<Object[]> list = new List<object[]>();
            con.Open();
            SqlCommand cmd = new SqlCommand("Invoice_Line_Select", con);
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter
            {
                ParameterName = "@invoice_ID",
                Value = invoice_ID
            });
            try
            {
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    list.Add(new Object[] { sdr.GetString(0), sdr.GetDouble(1), sdr.GetString(2) });
                }
            }
            catch (SqlException)
            {
                Console.Out.WriteLine("Ошибка ввода данных");
            }
            con.Close();
            return list;
        }

        public static List<Object[]> getPersonEnum()
        {
            List<Object[]> personEnum = new List<Object[]>();

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandText = "SELECT responsible_person_ID, rp_name FROM Responsible_person;";
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    personEnum.Add(new Object[] { sdr.GetInt32(0), sdr.GetString(1) });
                }
            }
            catch (SqlException)
            {
                Console.Out.WriteLine("Ошибка ввода данных");
            }
            con.Close();

            return personEnum;
        }

        public static void addInvoice(Int32 personID, String issueDate, List<Object[]> invoiceLines) {
            con.Open();

            SqlCommand proc = new SqlCommand("get_last_invoice_id", con);
            proc.Connection = con;
            proc.CommandType = System.Data.CommandType.StoredProcedure;
            Int32 invoiceLastId = (Int32)proc.ExecuteScalar();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandText = "INSERT INTO Invoice(invoice_ID, i_responsible_person_ID, i_issue_date) VALUES (" + (invoiceLastId + 1) + ", "  +personID + ", '" + String.Join("/", issueDate.Split('.'))+"');";
                cmd.ExecuteNonQuery();
                foreach (Object[] o in invoiceLines)
                {
                    Console.Out.WriteLine("INSERT INTO Invoice_line(il_invoice_ID, il_material_ID, il_quantity) VALUES (" + (invoiceLastId + 1) + ", " + (Int32)o[0] + ", " + (Double)o[1] + ");");
                    cmd.CommandText = "INSERT INTO Invoice_line(il_invoice_ID, il_material_ID, il_quantity) VALUES (" + (invoiceLastId + 1) + ", " + (Int32)o[0] + ", " + (Double)o[1] + ");";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                Console.Out.WriteLine("Ошибка ввода данных");
            }
            con.Close();
        }

        public static bool executeSqlQuery(String query) {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                Console.Out.WriteLine("Ошибка ввода данных");
                con.Close();
                return false;
            }
            con.Close();

            return true;
        }

                /*public static void Insert(String TableName, String[] column, Object[] data)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandText = "INSERT INTO Materials(material_ID, m_name, m_quantity, m_measure_unit, m_provider) VALUES (11,'" + tbMaterialsNewName.Text +
                    "', " + Convert.ToDouble(tbMaterialsNewQuantity.Text) + ", '" + tbMaterialsNewMeasureUnit.Text + "', '" + tbMaterialsNewProvider.Text + "');";
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                Console.Out.WriteLine("Ошибка ввода данных");
            }
        }*/

    }
}
