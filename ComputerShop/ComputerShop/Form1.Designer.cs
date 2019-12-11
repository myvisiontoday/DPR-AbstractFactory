namespace ComputerShop
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobtnLaptop = new System.Windows.Forms.RadioButton();
            this.radiobtnDesktop = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiobtnSODIMM = new System.Windows.Forms.RadioButton();
            this.radiobtnDIMM = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radiobtneSATA = new System.Windows.Forms.RadioButton();
            this.radiobtnSATA = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dUpDnSATA = new System.Windows.Forms.DomainUpDown();
            this.dUpDneSATA = new System.Windows.Forms.DomainUpDown();
            this.dUpDnSODIMM = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dUpDnDIMM = new System.Windows.Forms.DomainUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(969, 702);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtnLaptop);
            this.groupBox1.Controls.Add(this.radiobtnDesktop);
            this.groupBox1.Location = new System.Drawing.Point(969, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 136);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose ";
            // 
            // radiobtnLaptop
            // 
            this.radiobtnLaptop.AutoSize = true;
            this.radiobtnLaptop.Location = new System.Drawing.Point(306, 56);
            this.radiobtnLaptop.Name = "radiobtnLaptop";
            this.radiobtnLaptop.Size = new System.Drawing.Size(109, 29);
            this.radiobtnLaptop.TabIndex = 5;
            this.radiobtnLaptop.TabStop = true;
            this.radiobtnLaptop.Text = "Laptop";
            this.radiobtnLaptop.UseVisualStyleBackColor = true;
            this.radiobtnLaptop.CheckedChanged += new System.EventHandler(this.radiobtnLaptop_CheckedChanged);
            // 
            // radiobtnDesktop
            // 
            this.radiobtnDesktop.AutoSize = true;
            this.radiobtnDesktop.Location = new System.Drawing.Point(26, 56);
            this.radiobtnDesktop.Name = "radiobtnDesktop";
            this.radiobtnDesktop.Size = new System.Drawing.Size(122, 29);
            this.radiobtnDesktop.TabIndex = 4;
            this.radiobtnDesktop.TabStop = true;
            this.radiobtnDesktop.Text = "Desktop";
            this.radiobtnDesktop.UseVisualStyleBackColor = true;
            this.radiobtnDesktop.CheckedChanged += new System.EventHandler(this.radiobtnDesktop_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dUpDnDIMM);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dUpDnSODIMM);
            this.groupBox2.Controls.Add(this.radiobtnSODIMM);
            this.groupBox2.Controls.Add(this.radiobtnDIMM);
            this.groupBox2.Location = new System.Drawing.Point(969, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 192);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Please select the RAM";
            // 
            // radiobtnSODIMM
            // 
            this.radiobtnSODIMM.AutoSize = true;
            this.radiobtnSODIMM.Location = new System.Drawing.Point(306, 56);
            this.radiobtnSODIMM.Name = "radiobtnSODIMM";
            this.radiobtnSODIMM.Size = new System.Drawing.Size(129, 29);
            this.radiobtnSODIMM.TabIndex = 5;
            this.radiobtnSODIMM.TabStop = true;
            this.radiobtnSODIMM.Text = "SODIMM";
            this.radiobtnSODIMM.UseVisualStyleBackColor = true;
            // 
            // radiobtnDIMM
            // 
            this.radiobtnDIMM.AutoSize = true;
            this.radiobtnDIMM.Location = new System.Drawing.Point(26, 56);
            this.radiobtnDIMM.Name = "radiobtnDIMM";
            this.radiobtnDIMM.Size = new System.Drawing.Size(99, 29);
            this.radiobtnDIMM.TabIndex = 4;
            this.radiobtnDIMM.TabStop = true;
            this.radiobtnDIMM.Text = "DIMM";
            this.radiobtnDIMM.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dUpDneSATA);
            this.groupBox3.Controls.Add(this.dUpDnSATA);
            this.groupBox3.Controls.Add(this.radiobtneSATA);
            this.groupBox3.Controls.Add(this.radiobtnSATA);
            this.groupBox3.Location = new System.Drawing.Point(969, 468);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 189);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select the storage";
            // 
            // radiobtneSATA
            // 
            this.radiobtneSATA.AutoSize = true;
            this.radiobtneSATA.Location = new System.Drawing.Point(306, 56);
            this.radiobtneSATA.Name = "radiobtneSATA";
            this.radiobtneSATA.Size = new System.Drawing.Size(110, 29);
            this.radiobtneSATA.TabIndex = 5;
            this.radiobtneSATA.TabStop = true;
            this.radiobtneSATA.Text = "eSATA";
            this.radiobtneSATA.UseVisualStyleBackColor = true;
            // 
            // radiobtnSATA
            // 
            this.radiobtnSATA.AutoSize = true;
            this.radiobtnSATA.Location = new System.Drawing.Point(26, 56);
            this.radiobtnSATA.Name = "radiobtnSATA";
            this.radiobtnSATA.Size = new System.Drawing.Size(98, 29);
            this.radiobtnSATA.TabIndex = 4;
            this.radiobtnSATA.TabStop = true;
            this.radiobtnSATA.Text = "SATA";
            this.radiobtnSATA.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(79, 128);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(779, 571);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Your device configuration.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Computer device details:";
            // 
            // dUpDnSATA
            // 
            this.dUpDnSATA.Items.Add("1");
            this.dUpDnSATA.Items.Add("2");
            this.dUpDnSATA.Items.Add("3");
            this.dUpDnSATA.Items.Add("4");
            this.dUpDnSATA.Location = new System.Drawing.Point(28, 119);
            this.dUpDnSATA.Name = "dUpDnSATA";
            this.dUpDnSATA.Size = new System.Drawing.Size(120, 31);
            this.dUpDnSATA.TabIndex = 12;
            this.dUpDnSATA.Text = "select";
            // 
            // dUpDneSATA
            // 
            this.dUpDneSATA.Items.Add("1");
            this.dUpDneSATA.Items.Add("2");
            this.dUpDneSATA.Location = new System.Drawing.Point(278, 119);
            this.dUpDneSATA.Name = "dUpDneSATA";
            this.dUpDneSATA.Size = new System.Drawing.Size(120, 31);
            this.dUpDneSATA.TabIndex = 13;
            this.dUpDneSATA.Text = "select";
            // 
            // dUpDnSODIMM
            // 
            this.dUpDnSODIMM.Items.Add("4");
            this.dUpDnSODIMM.Items.Add("8");
            this.dUpDnSODIMM.Items.Add("16");
            this.dUpDnSODIMM.Items.Add("32");
            this.dUpDnSODIMM.Location = new System.Drawing.Point(278, 125);
            this.dUpDnSODIMM.Name = "dUpDnSODIMM";
            this.dUpDnSODIMM.Size = new System.Drawing.Size(120, 31);
            this.dUpDnSODIMM.TabIndex = 12;
            this.dUpDnSODIMM.Text = "select";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "GB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "GB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "TB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "TB";
            // 
            // dUpDnDIMM
            // 
            this.dUpDnDIMM.Items.Add("4");
            this.dUpDnDIMM.Items.Add("8");
            this.dUpDnDIMM.Items.Add("16");
            this.dUpDnDIMM.Items.Add("32");
            this.dUpDnDIMM.Location = new System.Drawing.Point(28, 125);
            this.dUpDnDIMM.Name = "dUpDnDIMM";
            this.dUpDnDIMM.Size = new System.Drawing.Size(120, 31);
            this.dUpDnDIMM.TabIndex = 14;
            this.dUpDnDIMM.Text = "select";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 834);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobtnLaptop;
        private System.Windows.Forms.RadioButton radiobtnDesktop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radiobtnSODIMM;
        private System.Windows.Forms.RadioButton radiobtnDIMM;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radiobtneSATA;
        private System.Windows.Forms.RadioButton radiobtnSATA;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown dUpDnSODIMM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown dUpDneSATA;
        private System.Windows.Forms.DomainUpDown dUpDnSATA;
        private System.Windows.Forms.DomainUpDown dUpDnDIMM;
    }
}

