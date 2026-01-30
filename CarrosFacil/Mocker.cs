using System;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarrosFacil
{
    public static class UniversalMocker
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        private static Random _rnd = new Random();

        public static void Iniciar(Form mainForm)
        {
            RegisterHotKey(mainForm.Handle, 88, 0x0000, 0x78); // F9
            Application.AddMessageFilter(new HotKeyFilter());
        }

        private class HotKeyFilter : IMessageFilter
        {
            public bool PreFilterMessage(ref Message m)
            {
                if (m.Msg == 0x0312)
                {
                    MockNoFormAtivo();
                    return true;
                }
                return false;
            }
        }

        public static void MockNoFormAtivo()
        {
            Form form = Form.ActiveForm;
            if (form == null) return;

            string nomeForm = form.Name.ToLower();

            foreach (Control c in form.Controls)
                PreencherRecursivo(c, nomeForm);
        }

        private static void PreencherRecursivo(Control c, string form)
        {
            if (c.HasChildren)
                foreach (Control filho in c.Controls)
                    PreencherRecursivo(filho, form);

            if (!c.Enabled || (c is TextBoxBase tb && tb.ReadOnly)) return;

            try { InjetarDado(c, form); } catch { }
        }

        private static void InjetarDado(Control c, string form)
        {
            string nome = c.Name.ToLower();

            switch (c)
            {
                case TextBox txt:
                    if (!string.IsNullOrWhiteSpace(txt.Text)) return;
                    txt.Text = GerarTextoPorContexto(form, nome);
                    break;

                case MaskedTextBox m:
                    if (m.MaskFull) return;
                    m.Text = GerarMascaraPorContexto(form, nome, m.Mask);
                    break;

                case ComboBox cb:
                    if (cb.Items.Count > 0)
                        cb.SelectedIndex = _rnd.Next(0, cb.Items.Count);
                    break;

                case NumericUpDown num:
                    num.Value = _rnd.Next((int)num.Minimum, (int)num.Maximum + 1);
                    break;

                case DateTimePicker dt:
                    dt.Value = DateTime.Today.AddYears(-_rnd.Next(18, 60));
                    break;
            }
        }
        private static string GerarTextoPorContexto(string form, string campo)
        {
            // ================= FUNCIONARIO =================
            if (form.Contains("funcionario"))
            {
                if (campo.Contains("nome")) return NomeCompleto();

                if (campo.Contains("email")) return Email();

                if (campo.Contains("endereco"))
                {
                    string[] ruas = {
                "Rua das Flores", "Av. Paulista", "Rua XV de Novembro", "Av. Brasil",
                "Rua Afonso Pena", "Rua Sete de Setembro", "Av. Atlântica",
                "Rua dos Andradas", "Av. Getúlio Vargas", "Rua Bela Vista",
                "Rua Dom Pedro I", "Av. Independência", "Rua Ceará",
                "Av. Amazonas", "Rua Maranhão"
            };
                    return ruas[_rnd.Next(ruas.Length)];
                }

                if (campo.Contains("numero")) return _rnd.Next(10, 9999).ToString();

                if (campo.Contains("bairro"))
                {
                    string[] bairros = {
                "Centro", "Jardim América", "Copacabana", "Savassi", "Moema",
                "Barra da Tijuca", "Boa Viagem", "Asa Sul", "Meireles",
                "Aldeota", "Batel", "Trindade", "Pituba", "Tatuapé", "Icaraí"
            };
                    return bairros[_rnd.Next(bairros.Length)];
                }

                if (campo.Contains("cidade"))
                {
                    string[] cidades = {
                "São Paulo", "Rio de Janeiro", "Belo Horizonte", "Curitiba",
                "Porto Alegre", "Salvador", "Recife", "Fortaleza", "Brasília",
                "Goiânia", "Campinas", "Florianópolis", "Vitória", "Manaus", "Natal"
            };
                    return cidades[_rnd.Next(cidades.Length)];
                }

                if (campo.Contains("salario")) return Dinheiro(1800, 15000);

                if (campo.Contains("usuario"))
                {
                    string[] bases = {
                "func", "colab", "user", "staff", "emp", "worker", "team",
                "membro", "operador", "assist", "gestor", "adm", "tec", "suporte", "dev"
            };
                    return bases[_rnd.Next(bases.Length)] + _rnd.Next(10, 999);
                }

                if (campo.Contains("senha"))
                {
                    string[] senhas = {
                "123456", "senha123", "abc@123", "qwe789", "zxc456",
                "admin123", "teste@1", "pass2024", "carros@1", "facil123",
                "user@123", "login@1", "segura@9", "acesso@7", "mock@123"
            };
                    return senhas[_rnd.Next(senhas.Length)];
                }
            }

            // ================= CLIENTE =================
            if (form.Contains("cliente"))
            {
                if (campo.Contains("nome")) return NomeCompleto();
                if (campo.Contains("email")) return Email();

                if (campo.Contains("endereco"))
                {
                    string[] ruas = {
                "Av. Brasil", "Rua das Palmeiras", "Rua do Comércio", "Av. Central",
                "Rua São João", "Rua das Acácias", "Av. Beira Mar", "Rua Aurora",
                "Rua da Paz", "Av. Kennedy", "Rua Paraíso", "Rua Horizonte",
                "Av. Santos Dumont", "Rua Progresso", "Rua União"
            };
                    return ruas[_rnd.Next(ruas.Length)];
                }

                if (campo.Contains("numero")) return _rnd.Next(1, 5000).ToString();

                if (campo.Contains("bairro"))
                {
                    string[] bairros = {
                "Centro", "Boa Vista", "Liberdade", "Vila Nova", "Jardim Europa",
                "Industrial", "São José", "Nova Esperança", "Santa Luzia",
                "São Cristóvão", "Planalto", "Alvorada", "Candeias", "São Pedro", "Universitário"
            };
                    return bairros[_rnd.Next(bairros.Length)];
                }

                if (campo.Contains("cidade"))
                {
                    string[] cidades = {
                "São Paulo", "Rio de Janeiro", "Curitiba", "Salvador", "Fortaleza",
                "Recife", "Belém", "São Luís", "João Pessoa", "Maceió",
                "Aracaju", "Teresina", "Palmas", "Cuiabá", "Campo Grande"
            };
                    return cidades[_rnd.Next(cidades.Length)];
                }

                if (campo.Contains("usuario")) return "cliente" + _rnd.Next(1000);
                if (campo.Contains("senha")) return "cli@" + _rnd.Next(1000);

                if (campo.Contains("complemento"))
                {
                    string[] comp = {
                "Apto 101", "Casa fundos", "Bloco B", "Sala 3", "Cobertura",
                "Fundos", "Lado esquerdo", "Casa 2", "Anexo", "Sobreloja",
                "Bloco C", "Loja 1", "Próximo à portaria", "Casa azul", "Ap 202"
            };
                    return comp[_rnd.Next(comp.Length)];
                }
            }

            // ================= VEICULO =================
            if (form.Contains("veiculo"))
            {
                if (campo.Contains("placa")) return Placa();
                if (campo.Contains("chassi")) return "9BWZZZ377VT00" + _rnd.Next(10000, 99999);
                if (campo.Contains("ano")) return _rnd.Next(2010, DateTime.Now.Year).ToString();
                if (campo.Contains("preco")) return Dinheiro(20000, 120000);
                if (campo.Contains("estoque")) return _rnd.Next(1, 20).ToString();
            }

            // ================= CARGO =================
            if (form.Contains("cargo"))
            {
                if (campo.Contains("nome"))
                {
                    string[] cargos = {
                "Gerente", "Vendedor", "Supervisor", "Diretor", "Assistente",
                "Analista", "Coordenador", "Caixa", "Consultor", "Técnico",
                "Administrador", "Recepcionista", "Estoquista", "Financeiro", "RH"
            };
                    return cargos[_rnd.Next(cargos.Length)];
                }

                if (campo.Contains("observacao"))
                {
                    string[] obs = {
                "Cargo administrativo", "Função comercial", "Área operacional",
                "Responsável pela equipe", "Atendimento ao público",
                "Gestão de estoque", "Suporte interno", "Área financeira",
                "Controle de vendas", "Função estratégica",
                "Apoio gerencial", "Backoffice", "Relacionamento com clientes",
                "Função técnica", "Cargo de liderança"
            };
                    return obs[_rnd.Next(obs.Length)];
                }
            }

            // ================= CARACTERISTICA =================
            if (form.Contains("caracteristica"))
            {
                if (campo.Contains("nome"))
                {
                    string[] caracs = {
                "Ar Condicionado", "Direção Hidráulica", "Vidro Elétrico",
                "Trava Elétrica", "Airbag", "ABS", "Central Multimídia",
                "Sensor de Ré", "Câmera de Ré", "Teto Solar",
                "Bancos de Couro", "Piloto Automático", "Farol de Neblina",
                "Rodas de Liga", "Computador de Bordo"
            };
                    return caracs[_rnd.Next(caracs.Length)];
                }

                if (campo.Contains("observacao"))
                {
                    string[] obs = {
                "Item de conforto", "Acessório de segurança", "Opcional de fábrica",
                "Melhora dirigibilidade", "Tecnologia embarcada",
                "Item premium", "Versão topo de linha", "Adicional esportivo",
                "Mais conforto ao dirigir", "Recurso moderno",
                "Ajuda em manobras", "Estilo diferenciado",
                "Melhor visibilidade", "Detalhe estético", "Funcionalidade extra"
            };
                    return obs[_rnd.Next(obs.Length)];
                }
            }

            // ================= MARCA =================
            if (form.Contains("marca") && campo.Contains("nome"))
            {
                string[] marcas = {
            "Toyota", "Honda", "Ford", "Chevrolet", "Volkswagen",
            "Hyundai", "Nissan", "Renault", "Fiat", "Jeep",
            "Peugeot", "Citroën", "Mitsubishi", "Kia", "BMW"
        };
                return marcas[_rnd.Next(marcas.Length)];
            }

            // ================= MODELO =================
            if (form.Contains("modelo") && campo.Contains("nome"))
            {
                string[] modelos = {
            "Corolla", "Civic", "Onix", "HB20", "Gol",
            "Compass", "Renegade", "Argo", "Cronos", "Kwid",
            "Tracker", "T-Cross", "Fit", "City", "Sentra"
        };
                return modelos[_rnd.Next(modelos.Length)];
            }

            // ================= VENDA =================
            if (form.Contains("venda"))
            {
                if (campo.Contains("valortotal")) return Dinheiro(30000, 150000);
                if (campo.Contains("quantidade")) return _rnd.Next(1, 5).ToString();
                if (campo.Contains("produto")) return "Veículo " + _rnd.Next(100, 999);
            }

            return "MOCK" + _rnd.Next(10000);
        }

        private static string GerarMascaraPorContexto(string form, string campo, string mask)
        {
            if (campo.Contains("cpf")) return Cpf();
            if (campo.Contains("rg")) return _rnd.Next(1000000, 9999999).ToString();
            if (campo.Contains("telefone")) return Telefone();
            if (campo.Contains("cep")) return $"{_rnd.Next(10000, 99999)}-{_rnd.Next(100, 999)}";

            return GerarNumerosMascara(mask);
        }
        private static string NomeCompleto()
        {
            string[] n = {
    "Lucas", "Mariana", "João", "Ana", "Carlos",
    "Fernanda", "Rafael", "Juliana", "Bruno", "Camila",
    "Diego", "Patrícia", "Gustavo", "Larissa", "Felipe"
};

            string[] s = {
    "Silva", "Souza", "Oliveira", "Costa", "Pereira",
    "Rodrigues", "Almeida", "Nascimento", "Lima", "Araújo",
    "Fernandes", "Carvalho", "Gomes", "Martins", "Rocha"
};

            return $"{n[_rnd.Next(n.Length)]} {s[_rnd.Next(s.Length)]}";
        }

        private static string Email() => $"user{_rnd.Next(1000)}@email.com";

        private static string Dinheiro(int min, int max)
            => (_rnd.Next(min, max) + _rnd.NextDouble()).ToString("F2");

        private static string Telefone()
            => $"({_rnd.Next(11, 99)}) 9{_rnd.Next(1000, 9999)}-{_rnd.Next(1000, 9999)}";

        private static string Placa()
            => $"{Letra()}{Letra()}{Letra()}{_rnd.Next(0, 10)}{Letra()}{_rnd.Next(0, 10)}{_rnd.Next(0, 10)}";

        private static string Letra() => ((char)_rnd.Next('A', 'Z' + 1)).ToString();

        private static string Cpf()
        {
            int[] n = new int[9];
            for (int i = 0; i < 9; i++) n[i] = _rnd.Next(0, 10);

            int d1 = 0;
            for (int i = 0; i < 9; i++) d1 += n[i] * (10 - i);
            d1 = (d1 * 10) % 11; if (d1 == 10) d1 = 0;

            int d2 = 0;
            for (int i = 0; i < 9; i++) d2 += n[i] * (11 - i);
            d2 += d1 * 2;
            d2 = (d2 * 10) % 11; if (d2 == 10) d2 = 0;

            return string.Concat(n) + d1 + d2;
        }

        private static string GerarNumerosMascara(string mask)
        {
            string r = "";
            foreach (char c in mask)
                r += c == '0' ? _rnd.Next(0, 10).ToString() : c.ToString();
            return r;
        }
    }
}
