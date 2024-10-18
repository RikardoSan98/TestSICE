using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using TestSICEForm.Clases.Genericos;

namespace TestSICEForm.Clases.DB
{
    public class Peaje
    {
        public static bool Insert(XMLs.Peaje peaje, out int idRow)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Constantes.strConnDB))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "INSERT INTO [dbo].[tblPeajes] \r\n" +
                        "(\r\n\t" +
                        "[numeroConsecutivoEnvio],\r\n\t" +
                        "[numeroRegistros],\r\n\t" +
                        "[horaEnvio],\r\n\t" +
                        "[fechaEnvio]\r\n" +
                        ")\r\n" +
                        "VALUES\r\n" +
                        "(\r\n\t" +
                        "@numeroConsecutivoEnvio,\r\n\t" +
                        "@numeroRegistros,\r\n\t" +
                        "@horaEnvio,\r\n\t" +
                        "@fechaEnvio\r\n" +
                        ");\r\n" +
                        "SELECT SCOPE_IDENTITY();";

                    DateTime fechaEnvio = DateTime.ParseExact(peaje.Fecha_envio, "dd-MM-yyyy", null);

                    cmd.Parameters.AddWithValue("@numeroConsecutivoEnvio", peaje.Numero_consecutivo_envio);
                    cmd.Parameters.AddWithValue("@numeroRegistros", peaje.Numero_registros);
                    cmd.Parameters.AddWithValue("@horaEnvio", peaje.Hora_envio);
                    cmd.Parameters.AddWithValue("@fechaEnvio", fechaEnvio);

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
