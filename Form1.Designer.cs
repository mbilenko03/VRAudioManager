﻿namespace VRAudioManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.defaultAudio = new System.Windows.Forms.TextBox();
            this.defaultMicrophone = new System.Windows.Forms.TextBox();
            this.VRAudio = new System.Windows.Forms.TextBox();
            this.VRMicrophone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.keyBind = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.autoToggle = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Default = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.VR = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.defaultAudio, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.defaultMicrophone, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.VRAudio, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.VRMicrophone, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(267, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 105);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // defaultAudio
            // 
            this.defaultAudio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.defaultAudio.Location = new System.Drawing.Point(62, 32);
            this.defaultAudio.Name = "defaultAudio";
            this.defaultAudio.Size = new System.Drawing.Size(100, 20);
            this.defaultAudio.TabIndex = 0;
            // 
            // defaultMicrophone
            // 
            this.defaultMicrophone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.defaultMicrophone.Location = new System.Drawing.Point(176, 32);
            this.defaultMicrophone.Name = "defaultMicrophone";
            this.defaultMicrophone.Size = new System.Drawing.Size(100, 20);
            this.defaultMicrophone.TabIndex = 1;
            // 
            // VRAudio
            // 
            this.VRAudio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VRAudio.Location = new System.Drawing.Point(62, 74);
            this.VRAudio.Name = "VRAudio";
            this.VRAudio.Size = new System.Drawing.Size(100, 20);
            this.VRAudio.TabIndex = 2;
            // 
            // VRMicrophone
            // 
            this.VRMicrophone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VRMicrophone.Location = new System.Drawing.Point(176, 74);
            this.VRMicrophone.Name = "VRMicrophone";
            this.VRMicrophone.Size = new System.Drawing.Size(100, 20);
            this.VRMicrophone.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "VR";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Microphone";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Default";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Audio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.keyBind, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(610, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(196, 26);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // keyBind
            // 
            this.keyBind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.keyBind.Location = new System.Drawing.Point(101, 3);
            this.keyBind.Name = "keyBind";
            this.keyBind.ReadOnly = true;
            this.keyBind.Size = new System.Drawing.Size(92, 20);
            this.keyBind.TabIndex = 0;
            this.keyBind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyBind_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Key Bind";
            // 
            // autoToggle
            // 
            this.autoToggle.AutoSize = true;
            this.autoToggle.Location = new System.Drawing.Point(467, 174);
            this.autoToggle.Name = "autoToggle";
            this.autoToggle.Size = new System.Drawing.Size(84, 17);
            this.autoToggle.TabIndex = 4;
            this.autoToggle.Text = "Auto Toggle";
            this.autoToggle.UseVisualStyleBackColor = true;
            this.autoToggle.CheckedChanged += new System.EventHandler(this.autoToggle_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(267, 191);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(284, 176);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Process List";
            // 
            // Default
            // 
            this.Default.Location = new System.Drawing.Point(630, 47);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(75, 23);
            this.Default.TabIndex = 7;
            this.Default.Text = "Default";
            this.Default.UseVisualStyleBackColor = true;
            this.Default.Click += new System.EventHandler(this.Default_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // VR
            // 
            this.VR.Location = new System.Drawing.Point(711, 47);
            this.VR.Name = "VR";
            this.VR.Size = new System.Drawing.Size(75, 23);
            this.VR.TabIndex = 8;
            this.VR.Text = "VR";
            this.VR.UseVisualStyleBackColor = true;
            this.VR.Click += new System.EventHandler(this.VR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 434);
            this.Controls.Add(this.VR);
            this.Controls.Add(this.Default);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.autoToggle);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VRAudioManager";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox defaultAudio;
        private System.Windows.Forms.TextBox defaultMicrophone;
        private System.Windows.Forms.TextBox VRAudio;
        private System.Windows.Forms.TextBox VRMicrophone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox keyBind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox autoToggle;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Default;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button VR;
    }
}