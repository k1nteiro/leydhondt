using LeyDHondt.Utils;
using System;
using System.Windows.Forms;

namespace LeyDHondt.Forms
{
    /// <summary>
    /// Formulario principal del aplicativo
    /// </summary>
    public partial class MainForm : Form
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Events

        /// <summary>
        /// Método que controla el evento Load del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            initialize();
        }

        #endregion Events

        #region Private Methdos

        /// <summary>
        /// Método que realiza las funciones básicas para la inicialización del formulario
        /// </summary>
        private void initialize()
        {
            /// Textos
            this.Text = Properties.Settings.Default.Title;
            this.lblTitle.Text = Properties.Settings.Default.Title;
            this.lblFooter.Text = Properties.Settings.Default.Footer;

            // Se aplica la identidad corporativa al control
            CorporativeUtility.CorporatizeControl(lblTitle);
            CorporativeUtility.CorporatizeControl(lblFooter);
        }

        #endregion Private Methdos

    }
}
