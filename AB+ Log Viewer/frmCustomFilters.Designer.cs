﻿namespace AB__Log_Viewer
{
    partial class frmCustomFilters
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
               this.lbFilters = new System.Windows.Forms.ListBox();
               this.panel1 = new System.Windows.Forms.Panel();
               this.chkEnabled = new System.Windows.Forms.CheckBox();
               this.gbMatch = new System.Windows.Forms.GroupBox();
               this.btnBColor = new System.Windows.Forms.Button();
               this.chkBColor = new System.Windows.Forms.CheckBox();
               this.btnColor = new System.Windows.Forms.Button();
               this.chkColor = new System.Windows.Forms.CheckBox();
               this.chkVisible = new System.Windows.Forms.CheckBox();
               this.txtRegex = new System.Windows.Forms.TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.btnAdd = new System.Windows.Forms.Button();
               this.btnRemove = new System.Windows.Forms.Button();
               this.colorChooser = new System.Windows.Forms.ColorDialog();
               this.panel1.SuspendLayout();
               this.gbMatch.SuspendLayout();
               this.SuspendLayout();
               // 
               // lbFilters
               // 
               this.lbFilters.FormattingEnabled = true;
               this.lbFilters.Location = new System.Drawing.Point(12, 12);
               this.lbFilters.Name = "lbFilters";
               this.lbFilters.Size = new System.Drawing.Size(94, 134);
               this.lbFilters.TabIndex = 0;
               this.lbFilters.SelectedIndexChanged += new System.EventHandler(this.lbFilters_SelectedIndexChanged);
               // 
               // panel1
               // 
               this.panel1.Controls.Add(this.chkEnabled);
               this.panel1.Controls.Add(this.gbMatch);
               this.panel1.Controls.Add(this.txtRegex);
               this.panel1.Controls.Add(this.label2);
               this.panel1.Enabled = false;
               this.panel1.Location = new System.Drawing.Point(112, 12);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(183, 160);
               this.panel1.TabIndex = 1;
               // 
               // chkEnabled
               // 
               this.chkEnabled.AutoSize = true;
               this.chkEnabled.Location = new System.Drawing.Point(9, 33);
               this.chkEnabled.Name = "chkEnabled";
               this.chkEnabled.Size = new System.Drawing.Size(65, 17);
               this.chkEnabled.TabIndex = 5;
               this.chkEnabled.Text = "Enabled";
               this.chkEnabled.UseVisualStyleBackColor = true;
               this.chkEnabled.CheckedChanged += new System.EventHandler(this.chkEnabled_CheckedChanged);
               // 
               // gbMatch
               // 
               this.gbMatch.Controls.Add(this.btnBColor);
               this.gbMatch.Controls.Add(this.chkBColor);
               this.gbMatch.Controls.Add(this.btnColor);
               this.gbMatch.Controls.Add(this.chkColor);
               this.gbMatch.Controls.Add(this.chkVisible);
               this.gbMatch.Location = new System.Drawing.Point(3, 56);
               this.gbMatch.Name = "gbMatch";
               this.gbMatch.Size = new System.Drawing.Size(177, 101);
               this.gbMatch.TabIndex = 4;
               this.gbMatch.TabStop = false;
               this.gbMatch.Text = "Items that match";
               // 
               // btnBColor
               // 
               this.btnBColor.BackColor = System.Drawing.Color.White;
               this.btnBColor.Location = new System.Drawing.Point(85, 68);
               this.btnBColor.Name = "btnBColor";
               this.btnBColor.Size = new System.Drawing.Size(75, 23);
               this.btnBColor.TabIndex = 4;
               this.btnBColor.UseVisualStyleBackColor = false;
               this.btnBColor.Click += new System.EventHandler(this.btnBColor_Click);
               // 
               // chkBColor
               // 
               this.chkBColor.AutoSize = true;
               this.chkBColor.Location = new System.Drawing.Point(6, 71);
               this.chkBColor.Name = "chkBColor";
               this.chkBColor.Size = new System.Drawing.Size(77, 17);
               this.chkBColor.TabIndex = 3;
               this.chkBColor.Text = "Back color";
               this.chkBColor.UseVisualStyleBackColor = true;
               this.chkBColor.CheckedChanged += new System.EventHandler(this.chkBColor_CheckedChanged);
               // 
               // btnColor
               // 
               this.btnColor.BackColor = System.Drawing.Color.Black;
               this.btnColor.Location = new System.Drawing.Point(85, 40);
               this.btnColor.Name = "btnColor";
               this.btnColor.Size = new System.Drawing.Size(75, 23);
               this.btnColor.TabIndex = 2;
               this.btnColor.UseVisualStyleBackColor = false;
               this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
               // 
               // chkColor
               // 
               this.chkColor.AutoSize = true;
               this.chkColor.Location = new System.Drawing.Point(6, 44);
               this.chkColor.Name = "chkColor";
               this.chkColor.Size = new System.Drawing.Size(73, 17);
               this.chkColor.TabIndex = 1;
               this.chkColor.Text = "Text color";
               this.chkColor.UseVisualStyleBackColor = true;
               this.chkColor.CheckedChanged += new System.EventHandler(this.chkColor_CheckedChanged);
               // 
               // chkVisible
               // 
               this.chkVisible.AutoSize = true;
               this.chkVisible.Checked = true;
               this.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked;
               this.chkVisible.Location = new System.Drawing.Point(6, 19);
               this.chkVisible.Name = "chkVisible";
               this.chkVisible.Size = new System.Drawing.Size(56, 17);
               this.chkVisible.TabIndex = 0;
               this.chkVisible.Text = "Visible";
               this.chkVisible.UseVisualStyleBackColor = true;
               this.chkVisible.CheckedChanged += new System.EventHandler(this.chkVisible_CheckedChanged);
               // 
               // txtRegex
               // 
               this.txtRegex.Location = new System.Drawing.Point(56, 7);
               this.txtRegex.Name = "txtRegex";
               this.txtRegex.Size = new System.Drawing.Size(124, 20);
               this.txtRegex.TabIndex = 3;
               this.txtRegex.TextChanged += new System.EventHandler(this.txtRegex_TextChanged);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(9, 10);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(41, 13);
               this.label2.TabIndex = 2;
               this.label2.Text = "Regex:";
               // 
               // btnAdd
               // 
               this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
               this.btnAdd.Location = new System.Drawing.Point(12, 148);
               this.btnAdd.Name = "btnAdd";
               this.btnAdd.Size = new System.Drawing.Size(47, 23);
               this.btnAdd.TabIndex = 2;
               this.btnAdd.Text = "+";
               this.btnAdd.UseVisualStyleBackColor = true;
               this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
               // 
               // btnRemove
               // 
               this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnRemove.Location = new System.Drawing.Point(59, 148);
               this.btnRemove.Name = "btnRemove";
               this.btnRemove.Size = new System.Drawing.Size(47, 23);
               this.btnRemove.TabIndex = 2;
               this.btnRemove.Text = "-";
               this.btnRemove.UseVisualStyleBackColor = true;
               this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
               // 
               // colorChooser
               // 
               this.colorChooser.SolidColorOnly = true;
               // 
               // frmCustomFilters
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(306, 184);
               this.Controls.Add(this.btnRemove);
               this.Controls.Add(this.btnAdd);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.lbFilters);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.MaximizeBox = false;
               this.MinimizeBox = false;
               this.Name = "frmCustomFilters";
               this.ShowIcon = false;
               this.ShowInTaskbar = false;
               this.Text = "Custom Filters";
               this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomFilters_FormClosing);
               this.Load += new System.EventHandler(this.frmCustomFilters_Load);
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               this.gbMatch.ResumeLayout(false);
               this.gbMatch.PerformLayout();
               this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbFilters;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbMatch;
        private System.Windows.Forms.Button btnBColor;
        private System.Windows.Forms.CheckBox chkBColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.CheckBox chkColor;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.TextBox txtRegex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ColorDialog colorChooser;
        private System.Windows.Forms.CheckBox chkEnabled;
    }
}