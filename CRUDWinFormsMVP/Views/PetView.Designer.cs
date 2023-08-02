
namespace CRUDWinFormsMVP.Views
{
    partial class PetView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetView));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePetList = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabPagePetDetail = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPetColour = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPetType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPetId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPagePetDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(232, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel administrativo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 69);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(851, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPagePetList);
            this.tabControl1.Controls.Add(this.tabPagePetDetail);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 12F);
            this.tabControl1.Location = new System.Drawing.Point(0, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(892, 403);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPagePetList
            // 
            this.tabPagePetList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPagePetList.Controls.Add(this.dataGridView);
            this.tabPagePetList.Controls.Add(this.btnDelete);
            this.tabPagePetList.Controls.Add(this.btnEdit);
            this.tabPagePetList.Controls.Add(this.btnAddNew);
            this.tabPagePetList.Controls.Add(this.btnSearch);
            this.tabPagePetList.Controls.Add(this.txtSearch);
            this.tabPagePetList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePetList.Location = new System.Drawing.Point(4, 27);
            this.tabPagePetList.Name = "tabPagePetList";
            this.tabPagePetList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePetList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPagePetList.Size = new System.Drawing.Size(884, 372);
            this.tabPagePetList.TabIndex = 0;
            this.tabPagePetList.Text = "Lista de mascotas";
            this.tabPagePetList.UseVisualStyleBackColor = true;
            this.tabPagePetList.Click += new System.EventHandler(this.tabPagePetList_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(24, 63);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(737, 301);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(831, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "🗑️";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(767, 102);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(42, 43);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "🔧";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.Location = new System.Drawing.Point(721, 30);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(40, 30);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "➕";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(495, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "🔎 Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(24, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(465, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // tabPagePetDetail
            // 
            this.tabPagePetDetail.BackColor = System.Drawing.Color.Transparent;
            this.tabPagePetDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPagePetDetail.BackgroundImage")));
            this.tabPagePetDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPagePetDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagePetDetail.Controls.Add(this.btnCancel);
            this.tabPagePetDetail.Controls.Add(this.btnSave);
            this.tabPagePetDetail.Controls.Add(this.label6);
            this.tabPagePetDetail.Controls.Add(this.txtPetColour);
            this.tabPagePetDetail.Controls.Add(this.label5);
            this.tabPagePetDetail.Controls.Add(this.txtPetType);
            this.tabPagePetDetail.Controls.Add(this.label4);
            this.tabPagePetDetail.Controls.Add(this.txtPetName);
            this.tabPagePetDetail.Controls.Add(this.label3);
            this.tabPagePetDetail.Controls.Add(this.txtPetId);
            this.tabPagePetDetail.Font = new System.Drawing.Font("Verdana", 12F);
            this.tabPagePetDetail.Location = new System.Drawing.Point(4, 27);
            this.tabPagePetDetail.Name = "tabPagePetDetail";
            this.tabPagePetDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePetDetail.Size = new System.Drawing.Size(884, 372);
            this.tabPagePetDetail.TabIndex = 1;
            this.tabPagePetDetail.Text = "Detalles";
            this.tabPagePetDetail.Click += new System.EventHandler(this.tabPagePetDetail_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(502, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 44);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel 🚫";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(346, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 44);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save ✅";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(493, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Color:";
            // 
            // txtPetColour
            // 
            this.txtPetColour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPetColour.Location = new System.Drawing.Point(497, 148);
            this.txtPetColour.Name = "txtPetColour";
            this.txtPetColour.Size = new System.Drawing.Size(109, 27);
            this.txtPetColour.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo de Mascota:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtPetType
            // 
            this.txtPetType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPetType.Location = new System.Drawing.Point(497, 95);
            this.txtPetType.Name = "txtPetType";
            this.txtPetType.Size = new System.Drawing.Size(183, 27);
            this.txtPetType.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre:";
            // 
            // txtPetName
            // 
            this.txtPetName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPetName.Location = new System.Drawing.Point(317, 148);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(154, 27);
            this.txtPetName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pet ID:";
            // 
            // txtPetId
            // 
            this.txtPetId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPetId.Location = new System.Drawing.Point(317, 95);
            this.txtPetId.Name = "txtPetId";
            this.txtPetId.ReadOnly = true;
            this.txtPetId.Size = new System.Drawing.Size(154, 27);
            this.txtPetId.TabIndex = 6;
            this.txtPetId.Text = "0";
            // 
            // PetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PetView";
            this.Text = "PetView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePetList.ResumeLayout(false);
            this.tabPagePetList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPagePetDetail.ResumeLayout(false);
            this.tabPagePetDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePetList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabPagePetDetail;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPetColour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPetType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPetId;
        private System.Windows.Forms.Button btnClose;
    }
}