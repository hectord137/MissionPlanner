namespace MissionPlanner.GCSViews.ConfigurationView
{
    partial class Config_wifi
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
            this.comboInterfaz = new System.Windows.Forms.ComboBox();
            this.ComboRed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnconnect = new MissionPlanner.Controls.MyButton();
            this.SuspendLayout();
            // 
            // comboInterfaz
            // 
            this.comboInterfaz.FormattingEnabled = true;
            this.comboInterfaz.Location = new System.Drawing.Point(98, 33);
            this.comboInterfaz.Name = "comboInterfaz";
            this.comboInterfaz.Size = new System.Drawing.Size(228, 21);
            this.comboInterfaz.TabIndex = 0;
            // 
            // ComboRed
            // 
            this.ComboRed.FormattingEnabled = true;
            this.ComboRed.Location = new System.Drawing.Point(98, 66);
            this.ComboRed.Name = "ComboRed";
            this.ComboRed.Size = new System.Drawing.Size(228, 21);
            this.ComboRed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Interfaz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(98, 97);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(228, 20);
            this.txtpass.TabIndex = 6;
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(251, 138);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(75, 23);
            this.btnconnect.TabIndex = 8;
            this.btnconnect.Text = "Conectar";
            this.btnconnect.TextColor = System.Drawing.Color.White;
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // Config_wifi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 173);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboRed);
            this.Controls.Add(this.comboInterfaz);
            this.Name = "Config_wifi";
            this.Text = "Config_wifi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboInterfaz;
        private System.Windows.Forms.ComboBox ComboRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpass;
        private Controls.MyButton btnconnect;
    }
}