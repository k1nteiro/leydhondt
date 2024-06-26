namespace LeyDHondt.Source.UserControls
{
    partial class ucTabControl
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tbpGeneral = new System.Windows.Forms.TabPage();
            this.tbpMesas = new System.Windows.Forms.TabPage();
            this.tbpRecuento = new System.Windows.Forms.TabPage();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tbpGeneral);
            this.tcMain.Controls.Add(this.tbpMesas);
            this.tcMain.Controls.Add(this.tbpRecuento);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(480, 305);
            this.tcMain.TabIndex = 3;
            // 
            // tbpGeneral
            // 
            this.tbpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tbpGeneral.Name = "tbpGeneral";
            this.tbpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGeneral.Size = new System.Drawing.Size(472, 279);
            this.tbpGeneral.TabIndex = 0;
            this.tbpGeneral.Text = "General";
            this.tbpGeneral.ToolTipText = "Página general";
            this.tbpGeneral.UseVisualStyleBackColor = true;
            // 
            // tbpMesas
            // 
            this.tbpMesas.Location = new System.Drawing.Point(4, 22);
            this.tbpMesas.Name = "tbpMesas";
            this.tbpMesas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMesas.Size = new System.Drawing.Size(752, 309);
            this.tbpMesas.TabIndex = 1;
            this.tbpMesas.Text = "Mesas";
            this.tbpMesas.ToolTipText = "Editor de mesas electorales";
            this.tbpMesas.UseVisualStyleBackColor = true;
            // 
            // tbpRecuento
            // 
            this.tbpRecuento.Location = new System.Drawing.Point(4, 22);
            this.tbpRecuento.Name = "tbpRecuento";
            this.tbpRecuento.Size = new System.Drawing.Size(752, 309);
            this.tbpRecuento.TabIndex = 2;
            this.tbpRecuento.Text = "Recuento";
            this.tbpRecuento.ToolTipText = "Editor del recuento de votos";
            this.tbpRecuento.UseVisualStyleBackColor = true;
            // 
            // ucTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMain);
            this.Name = "ucTabControl";
            this.Size = new System.Drawing.Size(480, 305);
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tbpGeneral;
        private System.Windows.Forms.TabPage tbpMesas;
        private System.Windows.Forms.TabPage tbpRecuento;
    }
}
