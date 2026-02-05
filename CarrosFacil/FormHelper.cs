using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CarrosFacil
{
    public class FormHelper
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// Permite arrastar qualquer formulário ou controle.
        /// </summary>
        /// <param name="handle">O Handle do formulário (this.Handle)</param>
        public static void MoverForm(IntPtr handle)
        {
            ReleaseCapture();
            SendMessage(handle, 0x112, 0xf012, 0);
        }

        #region Validações de Teclado (KeyPress)

        /// <summary>
        /// Permite apenas números inteiros no TextBox.
        /// </summary>
        public static void ApenasNumeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Validação completa para valores decimais (monetários).
        /// </summary>
        public static void ValidarDecimal(TextBox sender, KeyPressEventArgs e)
        {
            // Char 08: BACKSPACE
            if (e.KeyChar == (char)8) return;

            // números
            if (char.IsDigit(e.KeyChar))
            {
                // se já tem vírgula, bloquear mais de 2 casas decimais
                if (sender.Text.Contains(","))
                {
                    int posVirgula = sender.Text.IndexOf(",");
                    int casas = sender.Text.Length - posVirgula - 1;

                    if (sender.SelectionStart > posVirgula && casas >= 2)
                    {
                        e.Handled = true;
                        return;
                    }
                }
                return;
            }

            // "." ou ","
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // não deixa começar com "." ou ","
                if (sender.Text.Length == 0)
                {
                    e.Handled = true;
                    return;
                }

                // bloqueia 2 virgulas ou ponto após virgula
                if (sender.Text.Contains(","))
                {
                    e.Handled = true;
                    return;
                }

                // não deixa separador logo depois de outro separador
                char ultimo = sender.Text[sender.Text.Length - 1];
                if (ultimo == '.' || ultimo == ',')
                {
                    e.Handled = true;
                    return;
                }

                return;
            }

            // Se chegou até aqui = Letras não permitidas que não cairam no IF. Bloqueia.
            e.Handled = true;
        }
        #endregion

        #region Conversão Segura

        public static decimal ParaDecimal(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return 0;

            // Remove pontos de milhar e garante que a vírgula seja o separador decimal
            decimal.TryParse(texto.Trim(), NumberStyles.Number, new CultureInfo("pt-BR"), out decimal resultado);
            return resultado;
        }

        public static int ParaInt(string texto)
        {
            int.TryParse(texto, out int resultado);
            return resultado;
        }
        #endregion
    }
}