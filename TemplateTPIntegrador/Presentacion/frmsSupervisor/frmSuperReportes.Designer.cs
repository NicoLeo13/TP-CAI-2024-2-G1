﻿namespace Presentacion.frmsSupervisor
{
    partial class frmSuperReportes
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
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelAdmUsersAlta = new System.Windows.Forms.Panel();
            this.SuperReportes = new System.Windows.Forms.Label();
            this.panelAdmUsersAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Teal;
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(2);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(14, 450);
            this.panelSide.TabIndex = 66;
            // 
            // panelAdmUsersAlta
            // 
            this.panelAdmUsersAlta.Controls.Add(this.SuperReportes);
            this.panelAdmUsersAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmUsersAlta.Location = new System.Drawing.Point(14, 0);
            this.panelAdmUsersAlta.Margin = new System.Windows.Forms.Padding(2);
            this.panelAdmUsersAlta.Name = "panelAdmUsersAlta";
            this.panelAdmUsersAlta.Size = new System.Drawing.Size(786, 46);
            this.panelAdmUsersAlta.TabIndex = 68;
            // 
            // SuperReportes
            // 
            this.SuperReportes.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuperReportes.Location = new System.Drawing.Point(2, 7);
            this.SuperReportes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SuperReportes.Name = "SuperReportes";
            this.SuperReportes.Size = new System.Drawing.Size(566, 32);
            this.SuperReportes.TabIndex = 7;
            this.SuperReportes.Text = "Panel de Supervisor - Reportes";
            // 
            // frmSuperReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAdmUsersAlta);
            this.Controls.Add(this.panelSide);
            this.Name = "frmSuperReportes";
            this.Text = "frmSuperReportes";
            this.panelAdmUsersAlta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelAdmUsersAlta;
        private System.Windows.Forms.Label SuperReportes;
    }
}