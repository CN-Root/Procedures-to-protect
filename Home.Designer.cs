
namespace Procedures_to_protect
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.PS1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.information4 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.information3 = new System.Windows.Forms.Label();
            this.information2 = new System.Windows.Forms.Label();
            this.information1 = new System.Windows.Forms.Label();
            this.process_ps3 = new System.Windows.Forms.Label();
            this.process_ps1 = new System.Windows.Forms.Label();
            this.process_ps2 = new System.Windows.Forms.Label();
            this.PS2 = new System.Windows.Forms.Label();
            this.guardian = new System.Windows.Forms.Timer(this.components);
            this.PS3 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PS1
            // 
            this.PS1.AutoSize = true;
            this.PS1.Location = new System.Drawing.Point(9, 6);
            this.PS1.Name = "PS1";
            this.PS1.Size = new System.Drawing.Size(200, 17);
            this.PS1.TabIndex = 0;
            this.PS1.Text = "使用前请先手动开打需要保护的进程";
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Control;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Location = new System.Drawing.Point(12, 43);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(281, 23);
            this.textBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(299, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.information4);
            this.groupBox.Controls.Add(this.number);
            this.groupBox.Controls.Add(this.information3);
            this.groupBox.Controls.Add(this.information2);
            this.groupBox.Controls.Add(this.information1);
            this.groupBox.Controls.Add(this.process_ps3);
            this.groupBox.Controls.Add(this.process_ps1);
            this.groupBox.Controls.Add(this.process_ps2);
            this.groupBox.Location = new System.Drawing.Point(12, 68);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(360, 91);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            // 
            // information4
            // 
            this.information4.AutoSize = true;
            this.information4.Location = new System.Drawing.Point(66, 70);
            this.information4.Name = "information4";
            this.information4.Size = new System.Drawing.Size(39, 17);
            this.information4.TabIndex = 10;
            this.information4.Text = "NULL";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(6, 70);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(68, 17);
            this.number.TabIndex = 5;
            this.number.Text = "守护次数：";
            // 
            // information3
            // 
            this.information3.AutoSize = true;
            this.information3.Location = new System.Drawing.Point(66, 53);
            this.information3.Name = "information3";
            this.information3.Size = new System.Drawing.Size(39, 17);
            this.information3.TabIndex = 9;
            this.information3.Text = "NULL";
            // 
            // information2
            // 
            this.information2.AutoSize = true;
            this.information2.Location = new System.Drawing.Point(66, 36);
            this.information2.Name = "information2";
            this.information2.Size = new System.Drawing.Size(39, 17);
            this.information2.TabIndex = 8;
            this.information2.Text = "NULL";
            // 
            // information1
            // 
            this.information1.AutoSize = true;
            this.information1.Location = new System.Drawing.Point(66, 19);
            this.information1.Name = "information1";
            this.information1.Size = new System.Drawing.Size(39, 17);
            this.information1.TabIndex = 7;
            this.information1.Text = "NULL";
            // 
            // process_ps3
            // 
            this.process_ps3.AutoSize = true;
            this.process_ps3.Location = new System.Drawing.Point(6, 53);
            this.process_ps3.Name = "process_ps3";
            this.process_ps3.Size = new System.Drawing.Size(68, 17);
            this.process_ps3.TabIndex = 6;
            this.process_ps3.Text = "进程路径：";
            // 
            // process_ps1
            // 
            this.process_ps1.AutoSize = true;
            this.process_ps1.Location = new System.Drawing.Point(6, 19);
            this.process_ps1.Name = "process_ps1";
            this.process_ps1.Size = new System.Drawing.Size(64, 17);
            this.process_ps1.TabIndex = 5;
            this.process_ps1.Text = "进程PID：";
            // 
            // process_ps2
            // 
            this.process_ps2.AutoSize = true;
            this.process_ps2.Location = new System.Drawing.Point(6, 36);
            this.process_ps2.Name = "process_ps2";
            this.process_ps2.Size = new System.Drawing.Size(68, 17);
            this.process_ps2.TabIndex = 4;
            this.process_ps2.Text = "进程名称：";
            // 
            // PS2
            // 
            this.PS2.AutoSize = true;
            this.PS2.Location = new System.Drawing.Point(9, 24);
            this.PS2.Name = "PS2";
            this.PS2.Size = new System.Drawing.Size(297, 17);
            this.PS2.TabIndex = 4;
            this.PS2.Text = "请填写需要保护的进程文件名(不需要填写<.exe>后缀)";
            // 
            // guardian
            // 
            this.guardian.Tick += new System.EventHandler(this.guardian_Tick);
            // 
            // PS3
            // 
            this.PS3.AutoSize = true;
            this.PS3.Location = new System.Drawing.Point(246, 6);
            this.PS3.Name = "PS3";
            this.PS3.Size = new System.Drawing.Size(135, 17);
            this.PS3.TabIndex = 5;
            this.PS3.Text = "INS键 - 隐藏/显示 窗体";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.PS3);
            this.Controls.Add(this.PS2);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.PS1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进程守护";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PS1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label process_ps2;
        private System.Windows.Forms.Label process_ps1;
        private System.Windows.Forms.Label process_ps3;
        private System.Windows.Forms.Label information3;
        private System.Windows.Forms.Label information2;
        private System.Windows.Forms.Label information1;
        private System.Windows.Forms.Label PS2;
        private System.Windows.Forms.Timer guardian;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label information4;
        private System.Windows.Forms.Label PS3;
    }
}