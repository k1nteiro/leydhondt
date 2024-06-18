namespace LeyDHondt.Forms
{
    partial class MainForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tbpGeneral = new System.Windows.Forms.TabPage();
            this.tbpMesas = new System.Windows.Forms.TabPage();
            this.tbpRecuento = new System.Windows.Forms.TabPage();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.Gray;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(785, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "*******";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFooter
            // 
            this.lblFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFooter.BackColor = System.Drawing.Color.Gray;
            this.lblFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.Black;
            this.lblFooter.Location = new System.Drawing.Point(0, 411);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(785, 50);
            this.lblFooter.TabIndex = 1;
            this.lblFooter.Text = "*******";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tbpGeneral);
            this.tcMain.Controls.Add(this.tbpMesas);
            this.tcMain.Controls.Add(this.tbpRecuento);
            this.tcMain.Location = new System.Drawing.Point(12, 62);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(760, 335);
            this.tcMain.TabIndex = 2;
            // 
            // tbpGeneral
            // 
            this.tbpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tbpGeneral.Name = "tbpGeneral";
            this.tbpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGeneral.Size = new System.Drawing.Size(752, 309);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.lblTitle);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tbpGeneral;
        private System.Windows.Forms.TabPage tbpMesas;
        private System.Windows.Forms.TabPage tbpRecuento;
    }
}