
namespace ExeDataGridandNavBindingg
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.nohp = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.alamat = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            this.nim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nh = new System.Windows.Forms.Label();
            this.jk = new System.Windows.Forms.Label();
            this.am = new System.Windows.Forms.Label();
            this.nm = new System.Windows.Forms.Label();
            this.nomhs = new System.Windows.Forms.Label();
            this.prodiTIDataSet = new ExeDataGridandNavBindingg.ProdiTIDataSet();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter = new ExeDataGridandNavBindingg.ProdiTIDataSetTableAdapters.MahasiswaTableAdapter();
            this.mahasiswaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.mahasiswaBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 31);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // nohp
            // 
            this.nohp.AutoSize = true;
            this.nohp.BackColor = System.Drawing.Color.Transparent;
            this.nohp.ForeColor = System.Drawing.Color.White;
            this.nohp.Location = new System.Drawing.Point(204, 321);
            this.nohp.Name = "nohp";
            this.nohp.Size = new System.Drawing.Size(86, 17);
            this.nohp.TabIndex = 20;
            this.nohp.Text = "No. Telepon";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.BackColor = System.Drawing.Color.Transparent;
            this.gender.ForeColor = System.Drawing.Color.White;
            this.gender.Location = new System.Drawing.Point(204, 271);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(95, 17);
            this.gender.TabIndex = 19;
            this.gender.Text = "Jenis Kelamin";
            // 
            // alamat
            // 
            this.alamat.AutoSize = true;
            this.alamat.BackColor = System.Drawing.Color.Transparent;
            this.alamat.ForeColor = System.Drawing.Color.White;
            this.alamat.Location = new System.Drawing.Point(204, 224);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(124, 17);
            this.alamat.TabIndex = 18;
            this.alamat.Text = "Alamat Mahasiswa";
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.BackColor = System.Drawing.Color.Transparent;
            this.nama.ForeColor = System.Drawing.Color.White;
            this.nama.Location = new System.Drawing.Point(204, 172);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(118, 17);
            this.nama.TabIndex = 17;
            this.nama.Text = "Nama Mahasiswa";
            // 
            // nim
            // 
            this.nim.AutoSize = true;
            this.nim.BackColor = System.Drawing.Color.Transparent;
            this.nim.ForeColor = System.Drawing.Color.White;
            this.nim.Location = new System.Drawing.Point(204, 127);
            this.nim.Name = "nim";
            this.nim.Size = new System.Drawing.Size(99, 17);
            this.nim.TabIndex = 16;
            this.nim.Text = "No.Mahasiswa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(204, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Data Mahasiswa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nh
            // 
            this.nh.AutoSize = true;
            this.nh.BackColor = System.Drawing.Color.Transparent;
            this.nh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "PhoneMhs", true));
            this.nh.ForeColor = System.Drawing.Color.White;
            this.nh.Location = new System.Drawing.Point(441, 321);
            this.nh.Name = "nh";
            this.nh.Size = new System.Drawing.Size(86, 17);
            this.nh.TabIndex = 26;
            this.nh.Text = "No. Telepon";
            // 
            // jk
            // 
            this.jk.AutoSize = true;
            this.jk.BackColor = System.Drawing.Color.Transparent;
            this.jk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "Sex", true));
            this.jk.ForeColor = System.Drawing.Color.White;
            this.jk.Location = new System.Drawing.Point(441, 271);
            this.jk.Name = "jk";
            this.jk.Size = new System.Drawing.Size(95, 17);
            this.jk.TabIndex = 25;
            this.jk.Text = "Jenis Kelamin";
            // 
            // am
            // 
            this.am.AutoSize = true;
            this.am.BackColor = System.Drawing.Color.Transparent;
            this.am.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "AlamatMhs", true));
            this.am.ForeColor = System.Drawing.Color.White;
            this.am.Location = new System.Drawing.Point(441, 224);
            this.am.Name = "am";
            this.am.Size = new System.Drawing.Size(124, 17);
            this.am.TabIndex = 24;
            this.am.Text = "Alamat Mahasiswa";
            // 
            // nm
            // 
            this.nm.AutoSize = true;
            this.nm.BackColor = System.Drawing.Color.Transparent;
            this.nm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "NamaMhs", true));
            this.nm.ForeColor = System.Drawing.Color.White;
            this.nm.Location = new System.Drawing.Point(441, 172);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(118, 17);
            this.nm.TabIndex = 23;
            this.nm.Text = "Nama Mahasiswa";
            this.nm.Click += new System.EventHandler(this.nm_Click);
            // 
            // nomhs
            // 
            this.nomhs.AutoSize = true;
            this.nomhs.BackColor = System.Drawing.Color.Transparent;
            this.nomhs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "NIM", true));
            this.nomhs.ForeColor = System.Drawing.Color.White;
            this.nomhs.Location = new System.Drawing.Point(441, 127);
            this.nomhs.Name = "nomhs";
            this.nomhs.Size = new System.Drawing.Size(99, 17);
            this.nomhs.TabIndex = 22;
            this.nomhs.Text = "No.Mahasiswa";
            // 
            // prodiTIDataSet
            // 
            this.prodiTIDataSet.DataSetName = "ProdiTIDataSet";
            this.prodiTIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.prodiTIDataSet;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // mahasiswaBindingSource1
            // 
            this.mahasiswaBindingSource1.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource1.DataSource = this.prodiTIDataSet;
            // 
            // mahasiswaBindingSource2
            // 
            this.mahasiswaBindingSource2.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource2.DataSource = this.prodiTIDataSet;
            // 
            // mahasiswaBindingSource3
            // 
            this.mahasiswaBindingSource3.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource3.DataSource = this.prodiTIDataSet;
            // 
            // mahasiswaBindingSource4
            // 
            this.mahasiswaBindingSource4.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource4.DataSource = this.prodiTIDataSet;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(47, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.nh);
            this.Controls.Add(this.jk);
            this.Controls.Add(this.am);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.nomhs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nohp);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.nim);
            this.Controls.Add(this.bindingNavigator1);
            this.DoubleBuffered = true;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.Label nohp;
        public System.Windows.Forms.Label gender;
        public System.Windows.Forms.Label alamat;
        public System.Windows.Forms.Label nama;
        public System.Windows.Forms.Label nim;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label nh;
        public System.Windows.Forms.Label jk;
        public System.Windows.Forms.Label am;
        public System.Windows.Forms.Label nm;
        public System.Windows.Forms.Label nomhs;
        private ProdiTIDataSet prodiTIDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private ProdiTIDataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource4;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource1;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource2;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource3;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}