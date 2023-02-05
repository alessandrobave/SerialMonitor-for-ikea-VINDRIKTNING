
namespace SerialMonitor
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.AvailablePortsBox = new System.Windows.Forms.ComboBox();
            this.LBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_155_g = new System.Windows.Forms.Label();
            this.LBL_155_a = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBL_OMS_g = new System.Windows.Forms.Label();
            this.LBL_OMS_a = new System.Windows.Forms.Label();
            this.LBL_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial port:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 186);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(449, 372);
            this.textBox2.TabIndex = 2;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(191, 16);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(91, 21);
            this.btn_Connect.TabIndex = 3;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // AvailablePortsBox
            // 
            this.AvailablePortsBox.FormattingEnabled = true;
            this.AvailablePortsBox.Location = new System.Drawing.Point(75, 15);
            this.AvailablePortsBox.Name = "AvailablePortsBox";
            this.AvailablePortsBox.Size = new System.Drawing.Size(111, 21);
            this.AvailablePortsBox.TabIndex = 4;
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL.Location = new System.Drawing.Point(20, 78);
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(242, 63);
            this.LBL.TabIndex = 1;
            this.LBL.Text = "--- μg/mc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "D.Lgs 13/08/2010 n° 155:";
            // 
            // LBL_155_g
            // 
            this.LBL_155_g.AutoSize = true;
            this.LBL_155_g.Location = new System.Drawing.Point(273, 91);
            this.LBL_155_g.Name = "LBL_155_g";
            this.LBL_155_g.Size = new System.Drawing.Size(181, 13);
            this.LBL_155_g.TabIndex = 1;
            this.LBL_155_g.Text = "massimo medio giornaliero: 25 μg/mc";
            // 
            // LBL_155_a
            // 
            this.LBL_155_a.AutoSize = true;
            this.LBL_155_a.Location = new System.Drawing.Point(273, 78);
            this.LBL_155_a.Name = "LBL_155_a";
            this.LBL_155_a.Size = new System.Drawing.Size(189, 13);
            this.LBL_155_a.TabIndex = 1;
            this.LBL_155_a.Text = "limite massimo medio annuo: 20 μg/mc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "OMS:";
            // 
            // LBL_OMS_g
            // 
            this.LBL_OMS_g.AutoSize = true;
            this.LBL_OMS_g.Location = new System.Drawing.Point(273, 140);
            this.LBL_OMS_g.Name = "LBL_OMS_g";
            this.LBL_OMS_g.Size = new System.Drawing.Size(181, 13);
            this.LBL_OMS_g.TabIndex = 1;
            this.LBL_OMS_g.Text = "massimo medio giornaliero: 15 μg/mc";
            // 
            // LBL_OMS_a
            // 
            this.LBL_OMS_a.AutoSize = true;
            this.LBL_OMS_a.Location = new System.Drawing.Point(273, 127);
            this.LBL_OMS_a.Name = "LBL_OMS_a";
            this.LBL_OMS_a.Size = new System.Drawing.Size(157, 13);
            this.LBL_OMS_a.TabIndex = 1;
            this.LBL_OMS_a.Text = "massimo medio annuo: 5 μg/mc";
            // 
            // LBL_status
            // 
            this.LBL_status.AutoSize = true;
            this.LBL_status.Location = new System.Drawing.Point(304, 21);
            this.LBL_status.Name = "LBL_status";
            this.LBL_status.Size = new System.Drawing.Size(73, 13);
            this.LBL_status.TabIndex = 1;
            this.LBL_status.Text = "Disconnected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 570);
            this.Controls.Add(this.AvailablePortsBox);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LBL);
            this.Controls.Add(this.LBL_OMS_a);
            this.Controls.Add(this.LBL_OMS_g);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBL_155_a);
            this.Controls.Add(this.LBL_155_g);
            this.Controls.Add(this.LBL_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bave VINDRIKTNING ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.ComboBox AvailablePortsBox;
        private System.Windows.Forms.Label LBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_155_g;
        private System.Windows.Forms.Label LBL_155_a;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBL_OMS_g;
        private System.Windows.Forms.Label LBL_OMS_a;
        private System.Windows.Forms.Label LBL_status;
    }
}

