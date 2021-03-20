
namespace ProjectManager
{
    partial class MainPage
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
            this.listControl1 = new ProjectManager.SideBarControl();
            this.controlPatternForContent1 = new ProjectManager.ControlPatternForContent();
            this.SuspendLayout();
            // 
            // listControl1
            // 
            this.listControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.listControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listControl1.Location = new System.Drawing.Point(0, 0);
            this.listControl1.Name = "listControl1";
            this.listControl1.Size = new System.Drawing.Size(300, 489);
            this.listControl1.TabIndex = 0;
            // 
            // controlPatternForContent1
            // 
            this.controlPatternForContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPatternForContent1.Location = new System.Drawing.Point(300, 0);
            this.controlPatternForContent1.Name = "controlPatternForContent1";
            this.controlPatternForContent1.Size = new System.Drawing.Size(516, 489);
            this.controlPatternForContent1.TabIndex = 1;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.controlPatternForContent1);
            this.Controls.Add(this.listControl1);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(816, 489);
            this.ResumeLayout(false);

        }

        #endregion

        private SideBarControl listControl1;
        private ControlPatternForContent controlPatternForContent1;
    }
}
