﻿namespace ICT4Participation.Forms
{
    partial class Form_Shedule
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
            this.dg_schedule = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_schedule
            // 
            this.dg_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_schedule.Location = new System.Drawing.Point(64, 83);
            this.dg_schedule.Name = "dg_schedule";
            this.dg_schedule.RowTemplate.Height = 24;
            this.dg_schedule.Size = new System.Drawing.Size(583, 281);
            this.dg_schedule.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_back.Location = new System.Drawing.Point(446, 384);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(177, 56);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // Form_Shedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(723, 513);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dg_schedule);
            this.Name = "Form_Shedule";
            this.Text = "Form_Shedule";
            ((System.ComponentModel.ISupportInitialize)(this.dg_schedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_schedule;
        private System.Windows.Forms.Button btn_back;
    }
}