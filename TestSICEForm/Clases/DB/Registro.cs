using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace TestSICEForm.Clases.DB
{
    public class Registro
    {
        public static bool Insert(XMLs.PeajeRegistro registro, int idPeaje, out int idRow)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Constantes.strConnDB))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "INSERT INTO [dbo].[tblRegistros]\r\n" +
                        "(\r\n" +
                        "[idPeaje],\r\n\t" +
                        "[numeroTAG],\r\n\t" +
                        "[concesion],\r\n\t" +
                        "[tipoTAG],\r\n\t" +
                        "[IUT],\r\n\t" +
                        "[categoria],\r\n\t" +
                        "[categoriaCobrada],\r\n\t" +
                        "[categoriaDetectada],\r\n\t" +
                        "[status],\r\n\t" +
                        "[horaPeaje],\r\n\t" +
                        "[fechaPeaje],\r\n\t" +
                        "[importePeaje],\r\n\t" +
                        "[numeroReenvio]\r\n\t" +
                        ")\r\n" +
                        "VALUES\r\n" +
                        "(\r\n" +
                        "@idPeaje,\r\n\t" +
                        "@numeroTAG,\r\n\t" +
                        "@concesion,\r\n\t" +
                        "@tipoTAG,\r\n\t" +
                        "@IUT,\r\n\t" +
                        "@categoria,\r\n\t" +
                        "@categoriaCobrada,\r\n\t" +
                        "@categoriaDetectada,\r\n\t" +
                        "@status,\r\n\t" +
                        "@horaPeaje,\r\n\t" +
                        "@fechaPeaje,\r\n\t" +
                        "@importePeaje,\r\n\t" +
                        "@numeroReenvio\r\n\t" +
                        ");\r\n" +
                        "SELECT SCOPE_IDENTITY();";

                    DateTime fechaPeaje = DateTime.ParseExact(registro.Fecha_peaje, "dd-MM-yyyy", null);

                    cmd.Parameters.AddWithValue("@idPeaje", idPeaje);
                    cmd.Parameters.AddWithValue("@numeroTAG", registro.Numero_TAG);
                    cmd.Parameters.AddWithValue("@concesion", registro.Concesion);
                    cmd.Parameters.AddWithValue("@tipoTAG", registro.Tipo_TAG);
                    cmd.Parameters.AddWithValue("@IUT", registro.IUT);
                    cmd.Parameters.AddWithValue("@categoria", registro.Categoria);
                    cmd.Parameters.AddWithValue("@categoriaCobrada", registro.Categoria_Cobrada);
                    cmd.Parameters.AddWithValue("@categoriaDetectada", registro.Categoria_Detectada);
                    cmd.Parameters.AddWithValue("@status", registro.Status);
                    cmd.Parameters.AddWithValue("@horaPeaje", registro.Hora_peaje);
                    cmd.Parameters.AddWithValue("@fechaPeaje", fechaPeaje);
                    cmd.Parameters.AddWithValue("@importePeaje", registro.Importe_peaje);
                    cmd.Parameters.AddWithValue("@numeroReenvio", registro.Numero_Reenvio);

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
