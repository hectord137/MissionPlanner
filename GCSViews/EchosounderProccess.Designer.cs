namespace MissionPlanner.GCSViews
{
    partial class EchosounderProccess
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.TXT_InData = new System.Windows.Forms.TextBox();
            this.TXT_OutData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.myButton2 = new MissionPlanner.Controls.MyButton();
            this.myButton3 = new MissionPlanner.Controls.MyButton();
            this.SuspendLayout();
            // 
            // myButton1
            // 
            this.myButton1.Location = new System.Drawing.Point(407, 103);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(75, 23);
            this.myButton1.TabIndex = 0;
            this.myButton1.Text = "Browser";
            this.myButton1.TextColor = System.Drawing.Color.White;
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // TXT_InData
            // 
            this.TXT_InData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TXT_InData.Location = new System.Drawing.Point(39, 106);
            this.TXT_InData.Name = "TXT_InData";
            this.TXT_InData.Size = new System.Drawing.Size(362, 20);
            this.TXT_InData.TabIndex = 1;
            // 
            // TXT_OutData
            // 
            this.TXT_OutData.Location = new System.Drawing.Point(39, 164);
            this.TXT_OutData.Name = "TXT_OutData";
            this.TXT_OutData.Size = new System.Drawing.Size(362, 20);
            this.TXT_OutData.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NMEA Raw Input File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Output Folder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Echosounder Data Converter";
            // 
            // myButton2
            // 
            this.myButton2.Location = new System.Drawing.Point(407, 164);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(75, 23);
            this.myButton2.TabIndex = 6;
            this.myButton2.Text = "Browser";
            this.myButton2.TextColor = System.Drawing.Color.White;
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // myButton3
            // 
            this.myButton3.Location = new System.Drawing.Point(39, 199);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(75, 23);
            this.myButton3.TabIndex = 7;
            this.myButton3.Text = "Process";
            this.myButton3.TextColor = System.Drawing.Color.White;
            this.myButton3.UseVisualStyleBackColor = true;
            this.myButton3.Click += new System.EventHandler(this.myButton3_Click);
            // 
            // EchosounderProccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_OutData);
            this.Controls.Add(this.TXT_InData);
            this.Controls.Add(this.myButton1);
            this.Name = "EchosounderProccess";
            this.Size = new System.Drawing.Size(1341, 732);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MyButton myButton1;
        private System.Windows.Forms.TextBox TXT_InData;
        private System.Windows.Forms.TextBox TXT_OutData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controls.MyButton myButton2;
        private Controls.MyButton myButton3;
    }
}
