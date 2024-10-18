using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using TestSICEForm.Clases.XMLs;

namespace TestSICEForm.Clases.Genericos
{
    public class FuncionesGenericas
    {
        public static Peaje getClassPeajeFromXML(string XML)
        {
            try
            {
                Peaje peaje = new Peaje();
                XmlSerializer serializer = new XmlSerializer(typeof(Peaje));
                using (TextReader reader = new StringReader(XML))
                {
                    return (Peaje)serializer.Deserialize(reader);
                }
            }
            catch (Exception err)
            {
                StackTrace st = new StackTrace(err, true);
                StackFrame frame = st.GetFrame(st.FrameCount - 1);
                int line = frame.GetFileLineNumber();
                MessageBox.Show("Message: " + err.Message + ".\r\nFile: " + frame.GetFileName() + ".\r\nMethod: " + frame.GetMethod() + ".\r\nLine:" + line.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
