using System;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace CarrosFacil
{
    public static class UniversalMocker
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        private static Random _rnd = new Random();

        // Inicializa o atalho F9 globalmente
        public static void Iniciar(Form mainForm)
        {
            RegisterHotKey(mainForm.Handle, 88, 0x0000, 0x78); // F9
            Application.AddMessageFilter(new HotKeyFilter());
        }

        private class HotKeyFilter : IMessageFilter
        {
            public bool PreFilterMessage(ref Message m)
            {
                if (m.Msg == 0x0312) { MockNoFormAtivo(); return true; }
                return false;
            }
        }

        public static void MockNoFormAtivo()
        {
            // Busca o form que está na frente agora
            Form activeForm = Form.ActiveForm ?? Application.OpenForms.Cast<Form>().LastOrDefault(f => f.Visible);
            if (activeForm == null) return;

            PreencherRecursivo(activeForm.Controls);
        }

        private static void PreencherRecursivo(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c.HasChildren) PreencherRecursivo(c.Controls);
                if (!c.Enabled || (c is TextBoxBase tb && tb.ReadOnly)) continue;

                try { InjetarDado(c); } catch { }
            }
        }

        private static void InjetarDado(Control c)
        {
            string n = c.Name.ToLower();
            string idUnico = _rnd.Next(100, 999).ToString();

            switch (c)
            {
                case TextBox txt:
                    if (!string.IsNullOrEmpty(txt.Text)) break;

                    // --- BLOCO PRIORITÁRIO: SÓ NÚMEROS ---
                    // Se o nome do campo tiver qualquer uma dessas palavras, NUNCA coloca letras
                    if (n.Contains("estoque") || n.Contains("quantidade") || n.Contains("qtde") || n.Contains("unidade"))
                    {
                        txt.Text = _rnd.Next(1, 50).ToString();
                    }
                    else if (n.Contains("tempo") || n.Contains("uso") || n.Contains("meses") || n.Contains("dias"))
                    {
                        txt.Text = _rnd.Next(1, 24).ToString(); // Ex: 1 a 24 meses de uso
                    }
                    else if (n.Contains("ano"))
                    {
                        txt.Text = _rnd.Next(2010, 2024).ToString();
                    }
                    else if (n.Contains("km") || n.Contains("quilometragem"))
                    {
                        txt.Text = _rnd.Next(0, 150000).ToString();
                    }
                    else if (n.Contains("valor") || n.Contains("preco") || n.Contains("venda") || n.Contains("compra") || n.Contains("custo"))
                    {
                        txt.Text = _rnd.Next(15000, 90000).ToString("F2");
                    }
                    else if (n.Contains("lucro") || n.Contains("desconto") || n.Contains("porcentagem"))
                    {
                        txt.Text = _rnd.Next(0, 30).ToString();
                    }

                    // --- BLOCO SECUNDÁRIO: TEXTOS ---
                    else if (n.Contains("nome") || n.Contains("modelo") || n.Contains("descricao"))
                    {
                        txt.Text = $"MOCK_AUTO_{idUnico}";
                    }
                    else if (n.Contains("placa"))
                    {
                        txt.Text = $"ABC{_rnd.Next(1, 9)}J{_rnd.Next(10, 99)}";
                    }
                    else if (n.Contains("email"))
                    {
                        txt.Text = $"teste_{idUnico}@mock.com";
                    }
                    else
                    {
                        // Se não caiu em nada acima, manda um texto simples mas sem o prefixo "DADO" 
                        // para não poluir se for um campo curto
                        txt.Text = idUnico;
                    }
                    break;

                case MaskedTextBox m:
                    if (m.MaskFull) break;
                    // Força números em qualquer máscara que não esteja preenchida
                    m.Text = _rnd.Next(1000, 9999).ToString() + _rnd.Next(1000, 9999).ToString();
                    break;

                case ComboBox cb:
                    if (cb.Items.Count > 0) cb.SelectedIndex = _rnd.Next(0, cb.Items.Count);
                    break;

                case NumericUpDown num:
                    num.Value = _rnd.Next((int)num.Minimum, (int)num.Maximum);
                    break;
            }
        }

        private static string GerarCpfFalso()
        {
            int n = _rnd.Next(100, 999);
            return $"{n}{n}{n}{_rnd.Next(10, 99)}";
        }
    }
}