using System.Collections;
using System.Collections.Generic;
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
