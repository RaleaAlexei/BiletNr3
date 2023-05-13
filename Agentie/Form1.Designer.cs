namespace Agentie
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSalariu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btInsereaza = new System.Windows.Forms.Button();
            this.dgwAngajati = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btSterge = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btModifica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAngajati)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(12, 71);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 23);
            this.tbNume.TabIndex = 2;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(12, 115);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(100, 23);
            this.tbPrenume.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenume";
            // 
            // tbSalariu
            // 
            this.tbSalariu.Location = new System.Drawing.Point(12, 159);
            this.tbSalariu.Name = "tbSalariu";
            this.tbSalariu.Size = new System.Drawing.Size(100, 23);
            this.tbSalariu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salariul";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(12, 27);
            this.tbId.MaxLength = 13;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 23);
            this.tbId.TabIndex = 1;
            this.tbId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitOnly_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id";
            // 
            // btInsereaza
            // 
            this.btInsereaza.Location = new System.Drawing.Point(118, 104);
            this.btInsereaza.Name = "btInsereaza";
            this.btInsereaza.Size = new System.Drawing.Size(100, 23);
            this.btInsereaza.TabIndex = 5;
            this.btInsereaza.Text = "Insereaza";
            this.btInsereaza.UseVisualStyleBackColor = true;
            this.btInsereaza.Click += new System.EventHandler(this.btInsereaza_Click);
            // 
            // dgwAngajati
            // 
            this.dgwAngajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAngajati.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgwAngajati.Location = new System.Drawing.Point(12, 188);
            this.dgwAngajati.Name = "dgwAngajati";
            this.dgwAngajati.RowTemplate.Height = 25;
            this.dgwAngajati.Size = new System.Drawing.Size(410, 201);
            this.dgwAngajati.TabIndex = 15;
            this.dgwAngajati.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAngajati_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Salariu Maxim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSterge
            // 
            this.btSterge.Location = new System.Drawing.Point(118, 133);
            this.btSterge.Name = "btSterge";
            this.btSterge.Size = new System.Drawing.Size(100, 23);
            this.btSterge.TabIndex = 6;
            this.btSterge.Text = "Sterge";
            this.btSterge.UseVisualStyleBackColor = true;
            this.btSterge.Click += new System.EventHandler(this.btSterge_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Pentru stergere, este nevoie doar de id.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Pentru modificare, introduceti id-ul, apoi datele noi";
            // 
            // btModifica
            // 
            this.btModifica.Location = new System.Drawing.Point(118, 159);
            this.btModifica.Name = "btModifica";
            this.btModifica.Size = new System.Drawing.Size(100, 23);
            this.btModifica.TabIndex = 20;
            this.btModifica.Text = "Modifica";
            this.btModifica.UseVisualStyleBackColor = true;
            this.btModifica.Click += new System.EventHandler(this.btModifica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 401);
            this.Controls.Add(this.btModifica);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btSterge);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwAngajati);
            this.Controls.Add(this.btInsereaza);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSalariu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAngajati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btInsereaza;
        private DataGridView dgwAngajati;
        public TextBox tbNume;
        public TextBox tbPrenume;
        public TextBox tbSalariu;
        public TextBox tbId;
        private Button button1;
        private Button btSterge;
        private Label label5;
        private Label label6;
        private Button btModifica;
    }
}