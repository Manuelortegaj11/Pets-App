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
    public partial class PetView : Form, IPetView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        //Constructor
        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPagePetDetail);
            btnClose.Click += delegate { this.Close(); };

        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s,e) =>
            {
                if(e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            btnAddNew.Click += delegate 
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Add(tabPagePetDetail);
                tabPagePetDetail.Text = "Agregar nueva mascota";
            };
            btnEdit.Click += delegate 
            { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Add(tabPagePetDetail);
                tabPagePetDetail.Text = "Editar mascota";
            };

            btnDelete.Click += delegate 
            { 
 
                var result = MessageBox.Show("Estas seguro de eliminar?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            btnCancel.Click += delegate 
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.TabPages.Add(tabPagePetList);
            };
            btnSave.Click += delegate 
            { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful) 
                {
                    tabControl1.TabPages.Remove(tabPagePetDetail);
                    tabControl1.TabPages.Add(tabPagePetList);
                }
                MessageBox.Show(Message);
            };
        }

        //Properties
        public string PetId 
        { 
            get => txtPetId.Text; 
            set => txtPetId.Text = value; 
        }
        public string PetName 
        {
            get => txtPetName.Text; 
            set => txtPetName.Text = value; 
        }
        public string PetType 
        { 
            get => txtPetType.Text; 
            set => txtPetType.Text = value; 
        }
        public string PetColour
        {
            get => txtPetColour.Text;
            set => txtPetColour.Text = value;
        }
        public string SearchValue 
        { 
            get => txtSearch.Text; 
            set => txtSearch.Text = value; 
        }
        public bool IsEdit 
        { 
            get => isEdit; 
            set => isEdit = value; 
        }
        public bool IsSuccessful 
        {
            get => isSuccessful; 
            set => isSuccessful = value; 
        }
        public string Message 
        {
            get => message; 
            set => message = value;
        }

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        
        //Methods
        public void SetPetListBindingSource(BindingSource petList)
        {
            dataGridView.DataSource = petList;
        }
        //PATRON SINGLETON
        private static PetView instance;
        public static PetView getInstance( Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PetView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else if (instance.WindowState == FormWindowState.Minimized) instance.WindowState = FormWindowState.Normal;
            instance.BringToFront();
            return instance;
        }


        private void tabPagePetList_Click(object sender, EventArgs e)
        {
            tabPagePetList.BackColor = TemaColores.dataGridView;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            TemaColores.ElegirTema("Celeste");
            //panel1.BackColor = TemaColores.PanelBotones;
            //label1.ForeColor = TemaColores.FuenteIconos;
            //label1.Font = TemaColores.TipoFuente;
            tabPagePetList.BackColor = TemaColores.dataGridView;
            tabPagePetList.Font = TemaColores.TipoFuente;
            tabPagePetDetail.Font = TemaColores.TipoFuente;
            tabControl1.SendToBack();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPagePetDetail_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
