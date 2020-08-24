namespace OefeningSalarisApp
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
            this.cbWerknemers = new System.Windows.Forms.ComboBox();
            this.gbWerknemerGegevens = new System.Windows.Forms.GroupBox();
            this.lblTypeContract = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSalaris = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLandVanHerkomst = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBedrijven = new System.Windows.Forms.ComboBox();
            this.btnNieuweWerknemer = new System.Windows.Forms.Button();
            this.btnVerwijderWerknemer = new System.Windows.Forms.Button();
            this.gbWerknemerGegevens.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbWerknemers
            // 
            this.cbWerknemers.FormattingEnabled = true;
            this.cbWerknemers.Location = new System.Drawing.Point(12, 115);
            this.cbWerknemers.Name = "cbWerknemers";
            this.cbWerknemers.Size = new System.Drawing.Size(191, 21);
            this.cbWerknemers.TabIndex = 0;
            this.cbWerknemers.SelectedIndexChanged += new System.EventHandler(this.cbWerknemers_SelectedIndexChanged);
            // 
            // gbWerknemerGegevens
            // 
            this.gbWerknemerGegevens.Controls.Add(this.btnVerwijderWerknemer);
            this.gbWerknemerGegevens.Controls.Add(this.lblTypeContract);
            this.gbWerknemerGegevens.Controls.Add(this.label3);
            this.gbWerknemerGegevens.Controls.Add(this.lblSalaris);
            this.gbWerknemerGegevens.Controls.Add(this.label2);
            this.gbWerknemerGegevens.Controls.Add(this.label1);
            this.gbWerknemerGegevens.Controls.Add(this.lblLandVanHerkomst);
            this.gbWerknemerGegevens.Location = new System.Drawing.Point(12, 142);
            this.gbWerknemerGegevens.Name = "gbWerknemerGegevens";
            this.gbWerknemerGegevens.Size = new System.Drawing.Size(191, 101);
            this.gbWerknemerGegevens.TabIndex = 1;
            this.gbWerknemerGegevens.TabStop = false;
            this.gbWerknemerGegevens.Text = "Gegevens";
            // 
            // lblTypeContract
            // 
            this.lblTypeContract.AutoSize = true;
            this.lblTypeContract.Location = new System.Drawing.Point(116, 42);
            this.lblTypeContract.Name = "lblTypeContract";
            this.lblTypeContract.Size = new System.Drawing.Size(35, 13);
            this.lblTypeContract.TabIndex = 7;
            this.lblTypeContract.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type Contract :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSalaris
            // 
            this.lblSalaris.AutoSize = true;
            this.lblSalaris.Location = new System.Drawing.Point(116, 29);
            this.lblSalaris.Name = "lblSalaris";
            this.lblSalaris.Size = new System.Drawing.Size(35, 13);
            this.lblSalaris.TabIndex = 5;
            this.lblSalaris.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salaris :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Land van herkomst :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLandVanHerkomst
            // 
            this.lblLandVanHerkomst.AutoSize = true;
            this.lblLandVanHerkomst.Location = new System.Drawing.Point(116, 16);
            this.lblLandVanHerkomst.Name = "lblLandVanHerkomst";
            this.lblLandVanHerkomst.Size = new System.Drawing.Size(35, 13);
            this.lblLandVanHerkomst.TabIndex = 2;
            this.lblLandVanHerkomst.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bedrijf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Werknemer";
            // 
            // cbBedrijven
            // 
            this.cbBedrijven.FormattingEnabled = true;
            this.cbBedrijven.Location = new System.Drawing.Point(12, 25);
            this.cbBedrijven.Name = "cbBedrijven";
            this.cbBedrijven.Size = new System.Drawing.Size(191, 21);
            this.cbBedrijven.TabIndex = 4;
            this.cbBedrijven.SelectedIndexChanged += new System.EventHandler(this.cbBedrijven_SelectedIndexChanged);
            // 
            // btnNieuweWerknemer
            // 
            this.btnNieuweWerknemer.Enabled = false;
            this.btnNieuweWerknemer.Location = new System.Drawing.Point(12, 52);
            this.btnNieuweWerknemer.Name = "btnNieuweWerknemer";
            this.btnNieuweWerknemer.Size = new System.Drawing.Size(191, 23);
            this.btnNieuweWerknemer.TabIndex = 5;
            this.btnNieuweWerknemer.Text = "Nieuwe werknemer toevoegen";
            this.btnNieuweWerknemer.UseVisualStyleBackColor = true;
            this.btnNieuweWerknemer.Click += new System.EventHandler(this.btnNieuweWerknemer_Click);
            // 
            // btnVerwijderWerknemer
            // 
            this.btnVerwijderWerknemer.Location = new System.Drawing.Point(3, 72);
            this.btnVerwijderWerknemer.Name = "btnVerwijderWerknemer";
            this.btnVerwijderWerknemer.Size = new System.Drawing.Size(182, 23);
            this.btnVerwijderWerknemer.TabIndex = 6;
            this.btnVerwijderWerknemer.Text = "Verwijder werknemer";
            this.btnVerwijderWerknemer.UseVisualStyleBackColor = true;
            this.btnVerwijderWerknemer.Visible = false;
            this.btnVerwijderWerknemer.Click += new System.EventHandler(this.btnVerwijderWerknemer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 298);
            this.Controls.Add(this.btnNieuweWerknemer);
            this.Controls.Add(this.cbBedrijven);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbWerknemerGegevens);
            this.Controls.Add(this.cbWerknemers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbWerknemerGegevens.ResumeLayout(false);
            this.gbWerknemerGegevens.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWerknemers;
        private System.Windows.Forms.GroupBox gbWerknemerGegevens;
        private System.Windows.Forms.Label lblSalaris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLandVanHerkomst;
        private System.Windows.Forms.Label lblTypeContract;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBedrijven;
        private System.Windows.Forms.Button btnNieuweWerknemer;
        private System.Windows.Forms.Button btnVerwijderWerknemer;
    }
}

