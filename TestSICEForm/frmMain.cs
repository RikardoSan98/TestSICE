using ClosedXML.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using TestSICEForm.Clases.Genericos;
using TestSICEForm.Clases.XMLs;

namespace TestSICEForm
{
    public partial class frmMain : Form
    {
        List<Peaje> lsPeajes;

        public frmMain()
        {
            InitializeComponent();
            lsPeajes = new List<Peaje>();
            Clases.DB.Genericos.EmptyTables();
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            LoadXMLsToDatabase();
        }

        private void frmMain_Shown(object sender, System.EventArgs e)
        {
            executePregunta1();
            executePregunta2();
            executePregunta3();
            executePregunta4();
            executePregunta5();
            executePregunta6();
        }

        private void btnExportar_Click(object sender, System.EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    try
                    {
                        string path = fbd.SelectedPath;
                        string fullPath = $"{path}\\Respuestas excel.xlsx";
                        XLWorkbook workbook = new XLWorkbook();
                        workbook.Worksheets.Add(dgvPregunta1.DataSource as DataTable, "Pregunta 1");
                        workbook.Worksheets.Add(dgvPregunta2.DataSource as DataTable, "Pregunta 2");
                        workbook.Worksheets.Add(dgvPregunta3.DataSource as DataTable, "Pregunta 3");
                        workbook.Worksheets.Add(dgvPregunta4.DataSource as DataTable, "Pregunta 4");
                        workbook.Worksheets.Add(dgvPregunta5.DataSource as DataTable, "Pregunta 5");
                        workbook.Worksheets.Add(dgvPregunta6.DataSource as DataTable, "Pregunta 6");
                        workbook.SaveAs(fullPath);

                        string argument = "/select, \"" + fullPath + "\\\"";
                        Process.Start("explorer.exe", argument);
                    }
                    catch (Exception err)
                    {
                        StackTrace st = new StackTrace(err, true);
                        StackFrame frame = st.GetFrame(st.FrameCount - 1);
                        int line = frame.GetFileLineNumber();
                        MessageBox.Show("Message: " + err.Message + ".\r\nFile: " + frame.GetFileName() + ".\r\nMethod: " + frame.GetMethod() + ".\r\nLine:" + line.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadXMLsToDatabase()
        {
            ResourceSet resourceSet = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            var xmls = resourceSet.Cast<DictionaryEntry>();
            foreach (DictionaryEntry entry in xmls)
            {
                if (!(entry.Value is string)) break;

                Peaje peaje = FuncionesGenericas.getClassPeajeFromXML(entry.Value?.ToString());

                lsPeajes.Add(peaje);
            }

            foreach (Peaje peaje in lsPeajes.OrderBy(x => x.Numero_consecutivo_envio))
            {
                int idPeaje;
                if (Clases.DB.Peaje.Insert(peaje, out idPeaje))
                {
                    foreach (PeajeRegistro registro in peaje.Registro)
                    {
                        int idRegistro;
                        if (Clases.DB.Registro.Insert(registro, idPeaje, out idRegistro))
                        {
                            Clases.DB.Rutas.Insert(registro.Ruta, idPeaje, idRegistro, out _);
                        }
                    }
                }
            }
        }

        private void executePregunta1()
        {
            dgvPregunta1.DataSource = Clases.DB.Genericos.getPregunta1();
        }

        private void executePregunta2()
        {
            dgvPregunta2.DataSource = Clases.DB.Genericos.getPregunta2();
        }

        private void executePregunta3()
        {
            dgvPregunta3.DataSource = Clases.DB.Genericos.getPregunta3();
        }

        private void executePregunta4()
        {
            dgvPregunta4.DataSource = Clases.DB.Genericos.getPregunta4();
        }

        private void executePregunta5()
        {
            dgvPregunta5.DataSource = Clases.DB.Genericos.getPregunta5();
        }

        private void executePregunta6()
        {
            dgvPregunta6.DataSource = Clases.DB.Genericos.getPregunta6();
        }
    }
}
