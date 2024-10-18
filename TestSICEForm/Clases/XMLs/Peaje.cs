using System.Xml.Serialization;

namespace TestSICEForm.Clases.XMLs
{
    [XmlRoot(ElementName = "Peaje")]
    public partial class Peaje
    {
        private int numero_consecutivo_envio;
        private int numero_registros;
        private string hora_envio;
        private string fecha_envio;
        private PeajeRegistro[] registro;

        [XmlElement("Numero_consecutivo_envio")]
        public int Numero_consecutivo_envio { get => numero_consecutivo_envio; set => numero_consecutivo_envio = value; }
        [XmlElement("Numero_registros")]
        public int Numero_registros { get => numero_registros; set => numero_registros = value; }
        [XmlElement("Hora_envio")]
        public string Hora_envio { get => hora_envio; set => hora_envio = value; }
        [XmlElement("Fecha_envio")]
        public string Fecha_envio { get => fecha_envio; set => fecha_envio = value; }
        [XmlElement("Registro")]
        public PeajeRegistro[] Registro { get => registro; set => registro = value; }
    }

    public partial class PeajeRegistro
    {
        private string numero_TAG;
        private int concesion;
        private int tipo_TAG;
        private string iUT;
        private int categoria;
        private int categoria_Cobrada;
        private int categoria_Detectada;
        private int status;
        private string hora_peaje;
        private string fecha_peaje;
        private decimal importe_peaje;
        private int numero_Reenvio;
        private PeajeRegistroRuta ruta;

        [XmlElement("Numero_TAG")]
        public string Numero_TAG { get => numero_TAG; set => numero_TAG = value; }
        [XmlElement("Concesion")]
        public int Concesion { get => concesion; set => concesion = value; }
        [XmlElement("Tipo_TAG")]
        public int Tipo_TAG { get => tipo_TAG; set => tipo_TAG = value; }
        [XmlElement("IUT")]
        public string IUT { get => iUT; set => iUT = value; }
        [XmlElement("Categoria")]
        public int Categoria { get => categoria; set => categoria = value; }
        [XmlElement("Categoria_Cobrada")]
        public int Categoria_Cobrada { get => categoria_Cobrada; set => categoria_Cobrada = value; }
        [XmlElement("Categoria_Detectada")]
        public int Categoria_Detectada { get => categoria_Detectada; set => categoria_Detectada = value; }
        [XmlElement("Status")]
        public int Status { get => status; set => status = value; }
        [XmlElement("Hora_peaje")]
        public string Hora_peaje { get => hora_peaje; set => hora_peaje = value; }
        [XmlElement("Fecha_peaje")]
        public string Fecha_peaje { get => fecha_peaje; set => fecha_peaje = value; }
        [XmlElement("Importe_peaje")]
        public decimal Importe_peaje { get => importe_peaje; set => importe_peaje = value; }
        [XmlElement("Numero_Reenvio")]
        public int Numero_Reenvio { get => numero_Reenvio; set => numero_Reenvio = value; }
        [XmlElement("Ruta")]
        public PeajeRegistroRuta Ruta { get => ruta; set => ruta = value; }
    }

    public partial class PeajeRegistroRuta
    {
        private int entrada;
        private int salida;
        private int sentido;

        [XmlElement("Entrada")]
        public int Entrada { get => entrada; set => entrada = value; }
        [XmlElement("Salida")]
        public int Salida { get => salida; set => salida = value; }
        [XmlElement("Sentido")]
        public int Sentido { get => sentido; set => sentido = value; }
    }
}
