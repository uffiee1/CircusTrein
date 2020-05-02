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
            this.txbxDierNaam = new System.Windows.Forms.TextBox();
            this.rbDierGroot = new System.Windows.Forms.RadioButton();
            this.rbPlant = new System.Windows.Forms.RadioButton();
            this.rbDierMiddel = new System.Windows.Forms.RadioButton();
            this.rbDierKlein = new System.Windows.Forms.RadioButton();
            this.rbVlees = new System.Windows.Forms.RadioButton();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.lbAnimal = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbTrain = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbxDierNaam);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dier Naam:";
            // 
            // txbxDierNaam
            // 
            this.txbxDierNaam.Location = new System.Drawing.Point(6, 20);
            this.txbxDierNaam.Name = "txbxDierNaam";
            this.txbxDierNaam.Size = new System.Drawing.Size(140, 20);
            this.txbxDierNaam.TabIndex = 0;
            // 
            // rbDierGroot
            // 
            this.rbDierGroot.AutoSize = true;
            this.rbDierGroot.Location = new System.Drawing.Point(158, 19);
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
            this.rbPlant.Location = new System.Drawing.Point(139, 19);
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
            this.rbDierMiddel.Location = new System.Drawing.Point(66, 19);
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
            this.rbDierKlein.Location = new System.Drawing.Point(6, 19);
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
            this.rbVlees.Location = new System.Drawing.Point(36, 19);
            this.rbVlees.Name = "rbVlees";
            this.rbVlees.Size = new System.Drawing.Size(69, 17);
            this.rbVlees.TabIndex = 4;
            this.rbVlees.TabStop = true;
            this.rbVlees.Text = "Vleeseter";
            this.rbVlees.UseVisualStyleBackColor = true;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(12, 190);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(118, 67);
            this.btnVoegToe.TabIndex = 1;
            this.btnVoegToe.Text = "Voeg Dier Toe aan de Lijst!";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(136, 190);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(118, 67);
            this.btnTrain.TabIndex = 2;
            this.btnTrain.Text = "Begin met Trein!";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // lbAnimal
            // 
            this.lbAnimal.FormattingEnabled = true;
            this.lbAnimal.Location = new System.Drawing.Point(260, 32);
            this.lbAnimal.Name = "lbAnimal";
            this.lbAnimal.Size = new System.Drawing.Size(193, 225);
            this.lbAnimal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dieren Lijst:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trein:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbVlees);
            this.groupBox2.Controls.Add(this.rbPlant);
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 52);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dier Soort:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbDierKlein);
            this.groupBox3.Controls.Add(this.rbDierMiddel);
            this.groupBox3.Controls.Add(this.rbDierGroot);
            this.groupBox3.Location = new System.Drawing.Point(12, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 52);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dier Grootte:";
            // 
            // lbTrain
            // 
            this.lbTrain.FormattingEnabled = true;
            this.lbTrain.Location = new System.Drawing.Point(469, 32);
            this.lbTrain.Name = "lbTrain";
            this.lbTrain.Size = new System.Drawing.Size(193, 225);
            this.lbTrain.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 266);
            this.Controls.Add(this.lbTrain);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAnimal);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTrain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.ListBox lbAnimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbTrain;
    }
}

