
namespace ProjectManager
{
    partial class ListProjectItemControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblProjectDesc = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProjectName.Location = new System.Drawing.Point(86, 3);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(55, 19);
            this.lblProjectName.TabIndex = 1;
            this.lblProjectName.Text = "Name";
            this.lblProjectName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListProjectItemControl_MouseClick);
            this.lblProjectName.MouseEnter += new System.EventHandler(this.ListProjectItemControl_MouseEnter);
            // 
            // lblProjectDesc
            // 
            this.lblProjectDesc.AutoEllipsis = true;
            this.lblProjectDesc.AutoSize = true;
            this.lblProjectDesc.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProjectDesc.Location = new System.Drawing.Point(87, 28);
            this.lblProjectDesc.Name = "lblProjectDesc";
            this.lblProjectDesc.Size = new System.Drawing.Size(68, 16);
            this.lblProjectDesc.TabIndex = 2;
            this.lblProjectDesc.Text = "Description";
            this.lblProjectDesc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListProjectItemControl_MouseClick);
            this.lblProjectDesc.MouseEnter += new System.EventHandler(this.ListProjectItemControl_MouseEnter);
            // 
            // lblIcon
            // 
            this.lblIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblIcon.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIcon.ForeColor = System.Drawing.Color.Black;
            this.lblIcon.Location = new System.Drawing.Point(13, 3);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(50, 50);
            this.lblIcon.TabIndex = 3;
            this.lblIcon.Text = "💡";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListProjectItemControl_MouseClick);
            this.lblIcon.MouseEnter += new System.EventHandler(this.ListProjectItemControl_MouseEnter);
            // 
            // ListProjectItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.lblProjectDesc);
            this.Controls.Add(this.lblProjectName);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ListProjectItemControl";
            this.Size = new System.Drawing.Size(280, 55);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListProjectItemControl_MouseClick);
            this.MouseEnter += new System.EventHandler(this.ListProjectItemControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListProjectItemControl_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblProjectDesc;
        private System.Windows.Forms.Label lblIcon;
    }
}
