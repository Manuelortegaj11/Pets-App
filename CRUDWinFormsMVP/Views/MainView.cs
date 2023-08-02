using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWinFormsMVP.Views
{
    public partial class MainView : Form,IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnPets.Click += delegate { ShowPetView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowPetView;
        public event EventHandler ShowOwnerView;
        public event EventHandler ShowVetsView;

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void btnPets_Click(object sender, EventArgs e)
        {

        }

        private void MainView_Load_1(object sender, EventArgs e)
        {
            TemaColores.ElegirTema("Morado");
            panel1.BackColor = TemaColores.PanelBotones;
            btnPets.Font= TemaColores.TipoFuente;
             //= TemaColores.dataGridView;
        }

    }
}
