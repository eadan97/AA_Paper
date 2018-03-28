namespace AA_Paper
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.spnElements = new System.Windows.Forms.NumericUpDown();
            this.lstPermutaciones = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTiempoStartup = new System.Windows.Forms.Label();
            this.bgwGo = new System.ComponentModel.BackgroundWorker();
            this.lblTiempoPermutaciones = new System.Windows.Forms.Label();
            this.lblTiempoTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.spnElements)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de elementos:";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(12, 29);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // spnElements
            // 
            this.spnElements.Location = new System.Drawing.Point(132, 11);
            this.spnElements.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.spnElements.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnElements.Name = "spnElements";
            this.spnElements.Size = new System.Drawing.Size(83, 20);
            this.spnElements.TabIndex = 2;
            this.spnElements.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lstPermutaciones
            // 
            this.lstPermutaciones.FormattingEnabled = true;
            this.lstPermutaciones.Location = new System.Drawing.Point(236, 29);
            this.lstPermutaciones.Name = "lstPermutaciones";
            this.lstPermutaciones.Size = new System.Drawing.Size(348, 186);
            this.lstPermutaciones.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Permutaciones:";
            // 
            // lblTiempoStartup
            // 
            this.lblTiempoStartup.AutoSize = true;
            this.lblTiempoStartup.Location = new System.Drawing.Point(86, 16);
            this.lblTiempoStartup.Name = "lblTiempoStartup";
            this.lblTiempoStartup.Size = new System.Drawing.Size(13, 13);
            this.lblTiempoStartup.TabIndex = 5;
            this.lblTiempoStartup.Text = "0";
            // 
            // bgwGo
            // 
            this.bgwGo.WorkerReportsProgress = true;
            this.bgwGo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGo_DoWork);
            this.bgwGo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwGo_ProgressChanged);
            this.bgwGo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwGo_RunWorkerCompleted);
            // 
            // lblTiempoPermutaciones
            // 
            this.lblTiempoPermutaciones.AutoSize = true;
            this.lblTiempoPermutaciones.Location = new System.Drawing.Point(86, 29);
            this.lblTiempoPermutaciones.Name = "lblTiempoPermutaciones";
            this.lblTiempoPermutaciones.Size = new System.Drawing.Size(13, 13);
            this.lblTiempoPermutaciones.TabIndex = 6;
            this.lblTiempoPermutaciones.Text = "0";
            // 
            // lblTiempoTotal
            // 
            this.lblTiempoTotal.AutoSize = true;
            this.lblTiempoTotal.Location = new System.Drawing.Point(86, 42);
            this.lblTiempoTotal.Name = "lblTiempoTotal";
            this.lblTiempoTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTiempoTotal.TabIndex = 7;
            this.lblTiempoTotal.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Permutaciones:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "StartUp:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTiempoTotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTiempoPermutaciones);
            this.groupBox1.Controls.Add(this.lblTiempoStartup);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiempo en ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 250);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstPermutaciones);
            this.Controls.Add(this.spnElements);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Steinhaus–Johnson–Trotter";
            ((System.ComponentModel.ISupportInitialize)(this.spnElements)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.NumericUpDown spnElements;
        private System.Windows.Forms.ListBox lstPermutaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTiempoStartup;
        private System.ComponentModel.BackgroundWorker bgwGo;
        private System.Windows.Forms.Label lblTiempoPermutaciones;
        private System.Windows.Forms.Label lblTiempoTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

