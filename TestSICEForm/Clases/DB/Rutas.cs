using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace TestSICEForm.Clases.DB
{
    public class Rutas
    {
        public static bool Insert(XMLs.PeajeRegistroRuta ruta, int idPeaje, int idRegistro, out int idRow)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Constantes.strConnDB))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "INSERT INTO [dbo].[tblRutas]\r\n" +
                        "(\r\n" +
                        "[idPeaje],\r\n\t" +
                        "[idRegistro],\r\n\t" +
                        "[entrada],\r\n\t" +
                        "[salida],\r\n\t" +
                        "[sentido]\r\n\t" +
                        ")\r\n" +
                        "VALUES\r\n" +
                        "(\r\n" +
                        "@idPeaje,\r\n\t" +
                        "@idRegistro,\r\n\t" +
                        "@entrada,\r\n\t" +
                        "@salida,\r\n\t" +
                        "@sentido\r\n\t" +
                        ");\r\n" +
                        "SELECT SCOPE_IDENTITY();";

                    cmd.Parameters.AddWithValue("@idPeaje", idPeaje);
                    cmd.Parameters.AddWithValue("@idRegistro", idRegistro);
                    cmd.Parameters.AddWithValue("@entrada", ruta.Entrada);
                    cmd.Parameters.AddWithValue("@salida", ruta.Salida);
                    cmd.Parameters.AddWithValue("@sentido", ruta.Sentido);

                    return Int32.TryParse(cmd.ExecuteScalar()?.ToString(), out idRow);
                }
            }
            catch (Exception err)
            {
                StackTrace st = new StackTrace(err, true);
                StackFrame frame = st.GetFrame(st.FrameCount - 1);
                int line = frame.GetFileLineNumber();
                MessageBox.Show("Message: " + err.Message + ".\r\nFile: " + frame.GetFileName() + ".\r\nMethod: " + frame.GetMethod() + ".\r\nLine:" + line.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                idRow = 0;
                return false;
            }
        }
    }
}
