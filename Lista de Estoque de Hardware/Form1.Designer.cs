namespace Lista_de_Estoque_de_Hardware
{
    partial class Form1
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkIBM = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkQbex = new System.Windows.Forms.CheckBox();
            this.chkDell = new System.Windows.Forms.CheckBox();
            this.npdQtd = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.npdID = new System.Windows.Forms.NumericUpDown();
            this.dtgTabela = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSelectID = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(139, 109);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(125, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da peça";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            // 
            // chkIBM
            // 
            this.chkIBM.AutoSize = true;
            this.chkIBM.Location = new System.Drawing.Point(44, 80);
            this.chkIBM.Name = "chkIBM";
            this.chkIBM.Size = new System.Drawing.Size(84, 17);
            this.chkIBM.TabIndex = 4;
            this.chkIBM.Text = "IBM Lenovo";
            this.chkIBM.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Compatibilidade";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkQbex);
            this.panel1.Controls.Add(this.chkDell);
            this.panel1.Controls.Add(this.chkIBM);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(59, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 207);
            this.panel1.TabIndex = 6;
            // 
            // chkQbex
            // 
            this.chkQbex.AutoSize = true;
            this.chkQbex.Location = new System.Drawing.Point(44, 154);
            this.chkQbex.Name = "chkQbex";
            this.chkQbex.Size = new System.Drawing.Size(55, 17);
            this.chkQbex.TabIndex = 7;
            this.chkQbex.Text = "QBEX";
            this.chkQbex.UseVisualStyleBackColor = true;
            // 
            // chkDell
            // 
            this.chkDell.AutoSize = true;
            this.chkDell.Location = new System.Drawing.Point(44, 117);
            this.chkDell.Name = "chkDell";
            this.chkDell.Size = new System.Drawing.Size(44, 17);
            this.chkDell.TabIndex = 6;
            this.chkDell.Text = "Dell";
            this.chkDell.UseVisualStyleBackColor = true;
            // 
            // npdQtd
            // 
            this.npdQtd.Location = new System.Drawing.Point(139, 166);
            this.npdQtd.Name = "npdQtd";
            this.npdQtd.Size = new System.Drawing.Size(44, 20);
            this.npdQtd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // npdID
            // 
            this.npdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdID.Location = new System.Drawing.Point(139, 51);
            this.npdID.Name = "npdID";
            this.npdID.Size = new System.Drawing.Size(44, 24);
            this.npdID.TabIndex = 9;
            // 
            // dtgTabela
            // 
            this.dtgTabela.AllowUserToAddRows = false;
            this.dtgTabela.AllowUserToDeleteRows = false;
            this.dtgTabela.AllowUserToOrderColumns = true;
            this.dtgTabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTabela.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dtgTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTabela.Location = new System.Drawing.Point(295, 135);
            this.dtgTabela.Name = "dtgTabela";
            this.dtgTabela.ReadOnly = true;
            this.dtgTabela.Size = new System.Drawing.Size(523, 284);
            this.dtgTabela.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(103, 425);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(116, 47);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnSelectID
            // 
            this.btnSelectID.Location = new System.Drawing.Point(189, 48);
            this.btnSelectID.Name = "btnSelectID";
            this.btnSelectID.Size = new System.Drawing.Size(116, 30);
            this.btnSelectID.TabIndex = 12;
            this.btnSelectID.Text = "Visualisar por ID";
            this.btnSelectID.UseVisualStyleBackColor = true;
            this.btnSelectID.Click += new System.EventHandler(this.btnSelectID_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(103, 503);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 47);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Alterar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(491, 425);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(120, 47);
            this.btnSelectAll.TabIndex = 14;
            this.btnSelectAll.Text = "Visualisar todos";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(842, 562);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelectID);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtgTabela);
            this.Controls.Add(this.npdID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.npdQtd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkIBM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkQbex;
        private System.Windows.Forms.CheckBox chkDell;
        private System.Windows.Forms.NumericUpDown npdQtd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown npdID;
        private System.Windows.Forms.DataGridView dtgTabela;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnSelectID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSelectAll;
    }
}

