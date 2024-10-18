using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace TestSICEForm.Clases.DB
{
    public class Genericos
    {
        public static bool EmptyTables()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Constantes.strConnDB))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "DELETE FROM [tblRutas];\r\n" +
                        "DELETE FROM [tblRegistros];\r\n" +
                        "DELETE FROM [tblPeajes];\r\n" +
                        "DBCC CHECKIDENT ('[tblRutas]', RESEED, 0);\r\n" +
                        "DBCC CHECKIDENT ('[tblRegistros]', RESEED, 0);\r\n" +
                        "DBCC CHECKIDENT ('[tblPeajes]', RESEED, 0);";

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception err)
            {
                StackTrace st = new StackTrace(err, true);
                StackFrame frame = st.GetFrame(st.FrameCount - 1);
                int line = frame.GetFileLineNumber();
                MessageBox.Show("Message: " + err.Message + ".\r\nFile: " + frame.GetFileName() + ".\r\nMethod: " + frame.GetMethod() + ".\r\nLine:" + line.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable getPregunta1()
        {
            return getDataTableFromQuery("SELECT COUNT(*) AS [Cruces totales] FROM [tblRegistros];");
        }

        public static DataTable getPregunta2()
        {
            return getDataTableFromQuery("SELECT SUM([importePeaje]) AS [Importe total] FROM [tblRegistros];");
        }

        public static DataTable getPregunta3()
        {
            string qry = "WITH cteRegistros AS (\r\n\t" +
                "SELECT \r\n\t\t" +
                "CONVERT(DATETIME, CONVERT(CHAR(8), [fechaPeaje], 112) + ' ' + CONVERT(CHAR(8), [horaPeaje], 108)) AS [fechaHoraPeaje]\r\n\t" +
                "FROM [tblRegistros]\r\n" +
                ")\r\n" +
                "SELECT DATEADD(HOUR, DATEDIFF(HOUR, 0, [fechaHoraPeaje]), 0) as [Horas del dia], COUNT(*) [Cruces por horas del dia]\r\n" +
                "FROM cteRegistros\r\n" +
                "GROUP BY DATEADD(HOUR, DATEDIFF(HOUR, 0, [fechaHoraPeaje]), 0)\r\n" +
                "ORDER BY DATEADD(HOUR, DATEDIFF(HOUR, 0, [fechaHoraPeaje]), 0);";
            return getDataTableFromQuery(qry);
        }

        public static DataTable getPregunta4()
        {
            return getDataTableFromQuery("SELECT [tipoTAG] AS [Tipo de TAG], COUNT(*) as [Cruces por tipo de TAG] FROM [tblRegistros] GROUP BY [tipoTAG] ORDER BY [tipoTAG];");
        }

        public static DataTable getPregunta5()
        {
            return getDataTableFromQuery("SELECT [categoriaCobrada] AS [Categoria cobrada], COUNT(*) as [Cruces por categoria cobrada] FROM [tblRegistros] GROUP BY [categoriaCobrada] ORDER BY [categoriaCobrada];");
        }

        public static DataTable getPregunta6()
        {
            return getDataTableFromQuery("SELECT [IUT], COUNT(*) AS [Discrepancias de categorias por IUT] FROM [tblRegistros] WHERE ([categoria] <> [categoriaCobrada]) OR ([categoria] <> [categoriaDetectada]) OR ([categoriaCobrada] <> [categoriaDetectada]) GROUP BY [IUT];");
        }

        public static DataTable getDataTableFromQuery(string qry)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Constantes.strConnDB))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = qry;
                    cmd.CommandTimeout = 0;

                    DataTable dt = new DataTable();
                    SqlDataAdapter a = new SqlDataAdapter(cmd);
                    a.Fill(dt);
                    return dt;
                }
            }
            catch (Exception err)
            {
                StackTrace st = new StackTrace(err, true);
                StackFrame frame = st.GetFrame(st.FrameCount - 1);
                int line = frame.GetFileLineNumber();
                MessageBox.Show("Message: " + err.Message + ".\r\nFile: " + frame.GetFileName() + ".\r\nMethod: " + frame.GetMethod() + ".\r\nLine:" + line.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }
    }
}
