namespace PetrolPump_Management_System
{
    partial class Supplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SuppliersList = new System.Windows.Forms.DataGridView();
            this.supIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrolPumpDBDataSet1 = new PetrolPump_Management_System.PetrolPumpDBDataSet1();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SupNameTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.petrolPumpDBDataSet = new PetrolPump_Management_System.PetrolPumpDBDataSet();
            this.petrolPumpDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.supplierTblTableAdapter = new PetrolPump_Management_System.PetrolPumpDBDataSet1TableAdapters.SupplierTblTableAdapter();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDBDataSet1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDBDataSetBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SuppliersList
            // 
            this.SuppliersList.AllowUserToResizeColumns = false;
            this.SuppliersList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SuppliersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SuppliersList.AutoGenerateColumns = false;
            this.SuppliersList.BackgroundColor = System.Drawing.Color.Gray;
            this.SuppliersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SuppliersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SuppliersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SuppliersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SuppliersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supIdDataGridViewTextBoxColumn,
            this.supNameDataGridViewTextBoxColumn,
            this.supPhoneDataGridViewTextBoxColumn,
            this.supAddDataGridViewTextBoxColumn});
            this.SuppliersList.DataSource = this.supplierTblBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SuppliersList.DefaultCellStyle = dataGridViewCellStyle3;
            this.SuppliersList.GridColor = System.Drawing.Color.WhiteSmoke;
            this.SuppliersList.Location = new System.Drawing.Point(342, 162);
            this.SuppliersList.Name = "SuppliersList";
            this.SuppliersList.ReadOnly = true;
            this.SuppliersList.Size = new System.Drawing.Size(893, 530);
            this.SuppliersList.TabIndex = 44;
            this.SuppliersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SuppliersList_CellContentClick);
            // 
            // supIdDataGridViewTextBoxColumn
            // 
            this.supIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supIdDataGridViewTextBoxColumn.DataPropertyName = "SupId";
            this.supIdDataGridViewTextBoxColumn.HeaderText = "SupId";
            this.supIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.supIdDataGridViewTextBoxColumn.Name = "supIdDataGridViewTextBoxColumn";
            this.supIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supNameDataGridViewTextBoxColumn
            // 
            this.supNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supNameDataGridViewTextBoxColumn.DataPropertyName = "SupName";
            this.supNameDataGridViewTextBoxColumn.HeaderText = "SupName";
            this.supNameDataGridViewTextBoxColumn.Name = "supNameDataGridViewTextBoxColumn";
            this.supNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supPhoneDataGridViewTextBoxColumn
            // 
            this.supPhoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supPhoneDataGridViewTextBoxColumn.DataPropertyName = "SupPhone";
            this.supPhoneDataGridViewTextBoxColumn.HeaderText = "SupPhone";
            this.supPhoneDataGridViewTextBoxColumn.Name = "supPhoneDataGridViewTextBoxColumn";
            this.supPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supAddDataGridViewTextBoxColumn
            // 
            this.supAddDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supAddDataGridViewTextBoxColumn.DataPropertyName = "SupAdd";
            this.supAddDataGridViewTextBoxColumn.HeaderText = "SupAdd";
            this.supAddDataGridViewTextBoxColumn.Name = "supAddDataGridViewTextBoxColumn";
            this.supAddDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierTblBindingSource
            // 
            this.supplierTblBindingSource.DataMember = "SupplierTbl";
            this.supplierTblBindingSource.DataSource = this.petrolPumpDBDataSet1;
            // 
            // petrolPumpDBDataSet1
            // 
            this.petrolPumpDBDataSet1.DataSetName = "PetrolPumpDBDataSet1";
            this.petrolPumpDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(294, 162);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 530);
            this.panel4.TabIndex = 62;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Crimson;
            this.panel5.Location = new System.Drawing.Point(227, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 311);
            this.panel5.TabIndex = 4;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(34, 511);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 38);
            this.SaveBtn.TabIndex = 61;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(33, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 54;
            this.label5.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(429, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supplier Management";
            // 
            // AddressTb
            // 
            this.AddressTb.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTb.Location = new System.Drawing.Point(38, 395);
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(205, 85);
            this.AddressTb.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(33, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 52;
            this.label4.Text = "Phone";
            // 
            // PhoneTb
            // 
            this.PhoneTb.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTb.Location = new System.Drawing.Point(38, 296);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(205, 33);
            this.PhoneTb.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(33, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "Name";
            // 
            // SupNameTb
            // 
            this.SupNameTb.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupNameTb.Location = new System.Drawing.Point(38, 201);
            this.SupNameTb.Name = "SupNameTb";
            this.SupNameTb.Size = new System.Drawing.Size(205, 33);
            this.SupNameTb.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(11, 16, 11, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 87);
            this.panel1.TabIndex = 45;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PetrolPump_Management_System.Properties.Resources.staff;
            this.pictureBox1.Location = new System.Drawing.Point(497, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PetrolPump_Management_System.Properties.Resources.back_to_log_in;
            this.pictureBox2.Location = new System.Drawing.Point(211, 636);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 90;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // petrolPumpDBDataSet
            // 
            this.petrolPumpDBDataSet.DataSetName = "PetrolPumpDBDataSet";
            this.petrolPumpDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petrolPumpDBDataSetBindingSource
            // 
            this.petrolPumpDBDataSetBindingSource.DataSource = this.petrolPumpDBDataSet;
            this.petrolPumpDBDataSetBindingSource.Position = 0;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 87);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1255, 25);
            this.fillByToolStrip.TabIndex = 91;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // supplierTblTableAdapter
            // 
            this.supplierTblTableAdapter.ClearBeforeFill = true;
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.DarkBlue;
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Location = new System.Drawing.Point(153, 511);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(90, 38);
            this.Edit.TabIndex = 92;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.DarkBlue;
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(34, 577);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(90, 38);
            this.Delete.TabIndex = 93;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.DarkBlue;
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(153, 577);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(90, 38);
            this.Clear.TabIndex = 94;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 717);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SuppliersList);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SupNameTb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDBDataSet1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDBDataSetBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SuppliersList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SupNameTb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource petrolPumpDBDataSetBindingSource;
        private PetrolPumpDBDataSet petrolPumpDBDataSet;
        private PetrolPumpDBDataSet1 petrolPumpDBDataSet1;
        private System.Windows.Forms.BindingSource supplierTblBindingSource;
        private PetrolPumpDBDataSet1TableAdapters.SupplierTblTableAdapter supplierTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supAddDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Clear;
    }
}