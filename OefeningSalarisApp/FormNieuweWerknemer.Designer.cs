namespace OefeningSalarisApp
{
    partial class FormNieuweWerknemer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.rbBediende = new System.Windows.Forms.RadioButton();
            this.rbProgrammeur = new System.Windows.Forms.RadioButton();
            this.cbLandVanHerkomst = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numBrutoLoon = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numBrutoLoon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Land van herkomst";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bruto : ";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(53, 6);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(139, 20);
            this.tbNaam.TabIndex = 4;
            // 
            // rbBediende
            // 
            this.rbBediende.AutoSize = true;
            this.rbBediende.Checked = true;
            this.rbBediende.Location = new System.Drawing.Point(12, 98);
            this.rbBediende.Name = "rbBediende";
            this.rbBediende.Size = new System.Drawing.Size(70, 17);
            this.rbBediende.TabIndex = 8;
            this.rbBediende.TabStop = true;
            this.rbBediende.Text = "Bediende";
            this.rbBediende.UseVisualStyleBackColor = true;
            // 
            // rbProgrammeur
            // 
            this.rbProgrammeur.AutoSize = true;
            this.rbProgrammeur.Location = new System.Drawing.Point(105, 98);
            this.rbProgrammeur.Name = "rbProgrammeur";
            this.rbProgrammeur.Size = new System.Drawing.Size(87, 17);
            this.rbProgrammeur.TabIndex = 9;
            this.rbProgrammeur.Text = "Programmeur";
            this.rbProgrammeur.UseVisualStyleBackColor = true;
            // 
            // cbLandVanHerkomst
            // 
            this.cbLandVanHerkomst.FormattingEnabled = true;
            this.cbLandVanHerkomst.Location = new System.Drawing.Point(15, 45);
            this.cbLandVanHerkomst.Name = "cbLandVanHerkomst";
            this.cbLandVanHerkomst.Size = new System.Drawing.Size(177, 21);
            this.cbLandVanHerkomst.TabIndex = 10;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 121);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(117, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numBrutoLoon
            // 
            this.numBrutoLoon.Location = new System.Drawing.Point(72, 72);
            this.numBrutoLoon.Name = "numBrutoLoon";
            this.numBrutoLoon.Size = new System.Drawing.Size(120, 20);
            this.numBrutoLoon.TabIndex = 13;
            // 
            // FormNieuweWerknemer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 156);
            this.Controls.Add(this.numBrutoLoon);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbLandVanHerkomst);
            this.Controls.Add(this.rbProgrammeur);
            this.Controls.Add(this.rbBediende);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNieuweWerknemer";
            this.Text = "FormNieuweWerknemer";
            this.Load += new System.EventHandler(this.FormNieuweWerknemer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBrutoLoon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.RadioButton rbBediende;
        private System.Windows.Forms.RadioButton rbProgrammeur;
        private System.Windows.Forms.ComboBox cbLandVanHerkomst;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numBrutoLoon;
    }
}