namespace CircusTrein
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDierGroot = new System.Windows.Forms.RadioButton();
            this.rbPlant = new System.Windows.Forms.RadioButton();
            this.rbDierMiddel = new System.Windows.Forms.RadioButton();
            this.rbDierKlein = new System.Windows.Forms.RadioButton();
            this.rbVlees = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxDierNaam = new System.Windows.Forms.TextBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.lbLijst = new System.Windows.Forms.ListBox();
            this.lbTrein = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWagon = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDierGroot);
            this.groupBox1.Controls.Add(this.rbPlant);
            this.groupBox1.Controls.Add(this.rbDierMiddel);
            this.groupBox1.Controls.Add(this.rbDierKlein);
            this.groupBox1.Controls.Add(this.rbVlees);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbxDierNaam);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dier Gegevens:";
            // 
            // rbDierGroot
            // 
            this.rbDierGroot.AutoSize = true;
            this.rbDierGroot.Location = new System.Drawing.Point(124, 120);
            this.rbDierGroot.Name = "rbDierGroot";
            this.rbDierGroot.Size = new System.Drawing.Size(48, 17);
            this.rbDierGroot.TabIndex = 6;
            this.rbDierGroot.TabStop = true;
            this.rbDierGroot.Text = "Goot";
            this.rbDierGroot.UseVisualStyleBackColor = true;
            // 
            // rbPlant
            // 
            this.rbPlant.AutoSize = true;
            this.rbPlant.Location = new System.Drawing.Point(6, 97);
            this.rbPlant.Name = "rbPlant";
            this.rbPlant.Size = new System.Drawing.Size(67, 17);
            this.rbPlant.TabIndex = 5;
            this.rbPlant.TabStop = true;
            this.rbPlant.Text = "Planteter";
            this.rbPlant.UseVisualStyleBackColor = true;
            // 
            // rbDierMiddel
            // 
            this.rbDierMiddel.AutoSize = true;
            this.rbDierMiddel.Location = new System.Drawing.Point(124, 97);
            this.rbDierMiddel.Name = "rbDierMiddel";
            this.rbDierMiddel.Size = new System.Drawing.Size(80, 17);
            this.rbDierMiddel.TabIndex = 5;
            this.rbDierMiddel.TabStop = true;
            this.rbDierMiddel.Text = "Middelgroot";
            this.rbDierMiddel.UseVisualStyleBackColor = true;
            // 
            // rbDierKlein
            // 
            this.rbDierKlein.AutoSize = true;
            this.rbDierKlein.Location = new System.Drawing.Point(124, 74);
            this.rbDierKlein.Name = "rbDierKlein";
            this.rbDierKlein.Size = new System.Drawing.Size(48, 17);
            this.rbDierKlein.TabIndex = 4;
            this.rbDierKlein.TabStop = true;
            this.rbDierKlein.Text = "Klein";
            this.rbDierKlein.UseVisualStyleBackColor = true;
            // 
            // rbVlees
            // 
            this.rbVlees.AutoSize = true;
            this.rbVlees.Location = new System.Drawing.Point(6, 74);
            this.rbVlees.Name = "rbVlees";
            this.rbVlees.Size = new System.Drawing.Size(69, 17);
            this.rbVlees.TabIndex = 4;
            this.rbVlees.TabStop = true;
            this.rbVlees.Text = "Vleeseter";
            this.rbVlees.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dier Naam:";
            // 
            // txbxDierNaam
            // 
            this.txbxDierNaam.Location = new System.Drawing.Point(6, 36);
            this.txbxDierNaam.Name = "txbxDierNaam";
            this.txbxDierNaam.Size = new System.Drawing.Size(140, 20);
            this.txbxDierNaam.TabIndex = 0;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(12, 172);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(118, 84);
            this.btnVoegToe.TabIndex = 1;
            this.btnVoegToe.Text = "Voeg Dier Toe aan de Lijst!";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(136, 172);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(118, 84);
            this.btnTrain.TabIndex = 2;
            this.btnTrain.Text = "Begin met Trein!";
            this.btnTrain.UseVisualStyleBackColor = true;
            // 
            // lbLijst
            // 
            this.lbLijst.FormattingEnabled = true;
            this.lbLijst.Location = new System.Drawing.Point(260, 32);
            this.lbLijst.Name = "lbLijst";
            this.lbLijst.Size = new System.Drawing.Size(193, 225);
            this.lbLijst.TabIndex = 3;
            // 
            // lbTrein
            // 
            this.lbTrein.FormattingEnabled = true;
            this.lbTrein.Location = new System.Drawing.Point(658, 32);
            this.lbTrein.Name = "lbTrein";
            this.lbTrein.Size = new System.Drawing.Size(193, 225);
            this.lbTrein.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // lbWagon
            // 
            this.lbWagon.FormattingEnabled = true;
            this.lbWagon.Location = new System.Drawing.Point(459, 32);
            this.lbWagon.Name = "lbWagon";
            this.lbWagon.Size = new System.Drawing.Size(193, 225);
            this.lbWagon.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 264);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbWagon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTrein);
            this.Controls.Add(this.lbLijst);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTrain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbxDierNaam;
        private System.Windows.Forms.RadioButton rbDierGroot;
        private System.Windows.Forms.RadioButton rbPlant;
        private System.Windows.Forms.RadioButton rbDierMiddel;
        private System.Windows.Forms.RadioButton rbDierKlein;
        private System.Windows.Forms.RadioButton rbVlees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.ListBox lbLijst;
        private System.Windows.Forms.ListBox lbTrein;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbWagon;
        private System.Windows.Forms.Label label4;
    }
}

