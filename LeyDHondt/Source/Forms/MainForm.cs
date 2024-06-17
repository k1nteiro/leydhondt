using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeyDHondt.Forms
{
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
            this.lblTitle.Text = Settings.Default.Title;
        }

        #endregion Private Methdos

    }
}
