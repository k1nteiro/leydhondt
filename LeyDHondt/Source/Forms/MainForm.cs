﻿using LeyDHondt.Utils;
using System;
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
            /// Textos
            this.lblTitle.Text = Properties.Settings.Default.Title;
            this.lblFooter.Text = Properties.Settings.Default.Footer;

            // Se aplica la identidad corporativa al control
            CorporativeUtility.CorporatizeControl(lblTitle);
            CorporativeUtility.CorporatizeControl(lblFooter);

            // HACK Quinteiro: permitir ocultar el Footer si no hay mensaje en los settings
        }

        #endregion Private Methdos


    }
}
