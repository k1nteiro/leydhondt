using K5Logger;

namespace K5DHondt.LeyDHondtApp.Utils
{
    /// <summary>
    /// Clase de utilidades de identidad corporativa
    /// </summary>
    public static class CorporativeUtility
    {

        /// <summary>
        /// Aplica la identidad corporativa al control recibido como parámetro
        /// </summary>
        /// <param name="input">Control al que aplicar la identidad corporativa</param>
        public static void CorporatizeControl(Control input)
        {
            try
            {
                // Se modifican las propiedades deseadas
                input.ForeColor = Properties.Settings.Default.ForeColor_First;
                input.BackColor = Properties.Settings.Default.BackColor_First;
            }
            catch (Exception ex)
            {
                TextLogger.LogIn("CorporativeUtility.CorporatizeControl()", TextLogger.LEVEL.ERROR);
                TextLogger.LogError(ex);
                TextLogger.LogOut("CorporativeUtility.CorporatizeControl()", TextLogger.LEVEL.ERROR);
            }
        }

    }
}
