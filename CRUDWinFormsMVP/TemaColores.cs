using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWinFormsMVP
{
    public class TemaColores
    {
        public static Color dataGridView;
        public static Color PanelBotones;
        public static Color BarraTitulo;
        public static Color TextBusqueda;
        public static Color FuenteIconos;
        public static Font TipoFuente;


        //Colores Defecto
        private static readonly Color dataGridViewD = Color.FromArgb(59, 17, 27);
        private static readonly Color PanelBotonesD = Color.FromArgb(122, 35, 56);
        private static readonly Color BarraTituloD = Color.FromArgb(186, 54, 85);
        private static readonly Color TextBusquedaD = Color.FromArgb(250, 73, 115);
        private static readonly Color FuenteIconosD = Color.White;
        private static readonly Font TipoFuenteD = TipoFuente = new Font("Verdana", 5, FontStyle.Bold);

        //Tema Morado
        private static readonly Color dataGridViewM = Color.FromArgb(92, 36, 97);
        private static readonly Color PanelBotonesM = Color.FromArgb(94, 65, 97);
        private static readonly Color BarraTituloM = Color.FromArgb(164, 64, 173);
        private static readonly Color TextBusquedaM = Color.FromArgb(223, 154, 230);
        private static readonly Color FuenteIconosM = Color.White;
        private static readonly Font TipoFuenteM = TipoFuente = new Font("Verdana", 15, FontStyle.Regular);

        //Tema Verde
        private static readonly Color dataGridViewV = Color.FromArgb(71, 102, 0);
        private static readonly Color PanelBotonesV = Color.FromArgb(121, 173, 0);
        private static readonly Color BarraTituloV = Color.FromArgb(157, 224, 0);
        private static readonly Color TextBusquedaV = Color.FromArgb(181, 230, 63);
        private static readonly Color FuenteIconosV = Color.White;
        private static readonly Font TipoFuenteV = TipoFuente = new Font("Verdana", 15, FontStyle.Underline);

        //Tema Celeste
        private static readonly Color dataGridViewC = Color.FromArgb(35, 94, 97);
        private static readonly Color PanelBotonesC = Color.FromArgb(74, 101, 102);
        private static readonly Color BarraTituloC = Color.FromArgb(115, 156, 158);
        private static readonly Color TextBusquedaC = Color.FromArgb(164, 221, 224);
        private static readonly Color FuenteIconosC = Color.White;
        private static readonly Font TipoFuenteC = TipoFuente = new Font("Verdana", 11, FontStyle.Italic);

        //Tema Acua
        private static readonly Color dataGridViewA = Color.FromArgb(17, 47, 51);
        private static readonly Color PanelBotonesA = Color.FromArgb(33, 92, 99);
        private static readonly Color BarraTituloA = Color.FromArgb(37, 115, 125);
        private static readonly Color TextBusquedaA = Color.FromArgb(58, 162, 176);
        private static readonly Color FuenteIconosA = Color.White;
        private static readonly Font TipoFuenteA = TipoFuente = new Font("Verdana", 14, FontStyle.Italic);

        //Tema Naranja
        private static readonly Color dataGridViewN = Color.FromArgb(51, 35, 3);
        private static readonly Color PanelBotonesN = Color.FromArgb(99, 68, 6);
        private static readonly Color BarraTituloN = Color.FromArgb(125, 85, 4);
        private static readonly Color TextBusquedaN = Color.FromArgb(181, 124, 11);
        private static readonly Color FuenteIconosN = Color.White;
        private static readonly Font TipoFuenteN = TipoFuente = new Font("Verdana", 20, FontStyle.Bold);

        //tema Blue
        private static readonly Color dataGridViewB = Color.FromArgb(15, 6, 51);
        private static readonly Color PanelBotonesB = Color.FromArgb(30, 11, 99);
        private static readonly Color BarraTituloB = Color.FromArgb(35, 10, 125);
        private static readonly Color TextBusquedaB = Color.FromArgb(55, 20, 179);
        private static readonly Color FuenteIconosB = Color.White;
        private static readonly Font TipoFuenteB = TipoFuente = new Font("Arial", 15, FontStyle.Underline);

        //SeleccionarColores
        #region -> Metodos
        public static void ElegirTema(string Tema)
        {
            if (Tema == "Defecto")
            {
                dataGridView = dataGridViewD;
                PanelBotones = PanelBotonesD;
                BarraTitulo = BarraTituloD;
                TextBusqueda = TextBusquedaD;
                FuenteIconos = FuenteIconosD;
                TipoFuente = TipoFuenteD;
            }
            if (Tema == "Morado")
            {
                dataGridView = dataGridViewM;
                PanelBotones = PanelBotonesM;
                BarraTitulo = BarraTituloM;
                TextBusqueda = TextBusquedaM;
                FuenteIconos = FuenteIconosM;
                TipoFuente = TipoFuenteM;
            }
            if (Tema == "Verde")
            {
                dataGridView = dataGridViewV;
                PanelBotones = PanelBotonesV;
                BarraTitulo = BarraTituloV;
                TextBusqueda = TextBusquedaV;
                FuenteIconos = FuenteIconosV;
                TipoFuente = TipoFuenteV;
            }
            if (Tema == "Celeste")
            {
                dataGridView = dataGridViewC;
                PanelBotones = PanelBotonesC;
                BarraTitulo = BarraTituloC;
                TextBusqueda = TextBusquedaC;
                FuenteIconos = FuenteIconosC;
                TipoFuente = TipoFuenteC;
            }
            if (Tema == "Acua")
            {
                dataGridView = dataGridViewA;
                PanelBotones = PanelBotonesA;
                BarraTitulo = BarraTituloA;
                TextBusqueda = TextBusquedaA;
                FuenteIconos = FuenteIconosA;
                TipoFuente = TipoFuenteA;
            }

            if (Tema == "Naranja")
            {
                dataGridView = dataGridViewN;
                PanelBotones = PanelBotonesN;
                BarraTitulo = BarraTituloN;
                TextBusqueda = TextBusquedaN;
                FuenteIconos = FuenteIconosN;
                TipoFuente = TipoFuenteN;
            }

            if (Tema == "Azul")
            {
                dataGridView = dataGridViewB;
                PanelBotones = PanelBotonesB;
                BarraTitulo = BarraTituloB;
                TextBusqueda = TextBusquedaB;
                FuenteIconos = FuenteIconosB;
                TipoFuente = TipoFuenteB;
            }
        }
        #endregion
    }
}
