import os

# Configurações de Exclusão
# Adicione termos parciais aqui. O script converte tudo para minúsculo antes de comparar.
TERMOS_IGNORADOS = ['consultas', 'relatorios', 'relatórios', 'consulta', 'relatorio']

# Nome da pasta alvo
PASTA_ALVO = 'Forms'

# Nome do arquivo de saída
ARQUIVO_SAIDA = 'contexto_completo.txt'

def contem_termo_ignorado(nome):
    """Verifica se o nome do arquivo ou pasta contém termos proibidos."""
    nome_lower = nome.lower()
    for termo in TERMOS_IGNORADOS:
        if termo in nome_lower:
            return True
    return False

def encontrar_pasta_forms(diretorio_inicial):
    """Busca recursivamente pela pasta 'Forms'."""
    print(f"🔍 Procurando pela pasta '{PASTA_ALVO}' a partir de: {diretorio_inicial}...")
    
    for raiz, diretorios, arquivos in os.walk(diretorio_inicial):
        # Verifica se 'Forms' está na lista de diretórios atuais (case-insensitive para Windows)
        # Se seu sistema for Linux e a pasta for estritamente 'Forms', use: if PASTA_ALVO in diretorios:
        dirs_lower = {d.lower(): d for d in diretorios}
        
        if PASTA_ALVO.lower() in dirs_lower:
            caminho_real = os.path.join(raiz, dirs_lower[PASTA_ALVO.lower()])
            print(f"✅ Pasta '{PASTA_ALVO}' encontrada em: {caminho_real}")
            return caminho_real
            
    return None

def ler_arquivo(caminho_arquivo):
    """Tenta ler o arquivo com diferentes codificações."""
    encodings = ['utf-8', 'latin-1', 'cp1252']
    
    for enc in encodings:
        try:
            with open(caminho_arquivo, 'r', encoding=enc) as f:
                return f.read()
        except UnicodeDecodeError:
            continue
        except Exception as e:
            return f"[Erro ao ler arquivo: {e}]"
    
    return "[Arquivo binário ou codificação desconhecida - Ignorado]"

def capturar_contexto():
    diretorio_base = os.getcwd()
    caminho_forms = encontrar_pasta_forms(diretorio_base)
    
    if not caminho_forms:
        print(f"❌ A pasta '{PASTA_ALVO}' não foi encontrada em nenhum subdiretório.")
        return

    print("🚀 Iniciando captura de contexto (ignorando Consultas e Relatórios)...")
    
    conteudo_total = []
    arquivos_processados = 0
    arquivos_ignorados = 0

    for raiz, diretorios, arquivos in os.walk(caminho_forms):
        # 1. Filtrar Diretórios (modifica a lista 'diretorios' in-place para impedir que o os.walk entre neles)
        # Removemos pastas que contenham os termos ignorados
        diretorios[:] = [d for d in diretorios if not contem_termo_ignorado(d)]
        
        for arquivo in arquivos:
            # 2. Filtrar Arquivos
            if contem_termo_ignorado(arquivo):
                arquivos_ignorados += 1
                continue
            
            # Ignora o próprio script ou o arquivo de saída se estiverem dentro da pasta
            if arquivo == ARQUIVO_SAIDA or arquivo.endswith('.py'):
                continue

            caminho_completo = os.path.join(raiz, arquivo)
            texto_arquivo = ler_arquivo(caminho_completo)
            
            # Se for identificado como binário, pula
            if "Arquivo binário" in texto_arquivo:
                continue

            # Formatação do Contexto
            header = f"\n{'='*60}\nARQUIVO: {caminho_completo}\n{'='*60}\n"
            conteudo_total.append(header + texto_arquivo + "\n")
            arquivos_processados += 1
            print(f"  -> Lendo: {arquivo}")

    # Salvar resultado
    if conteudo_total:
        with open(ARQUIVO_SAIDA, 'w', encoding='utf-8') as f:
            f.write("".join(conteudo_total))
        print(f"\n✨ Concluído! \n📂 Arquivos lidos: {arquivos_processados} \n🚫 Ignorados: {arquivos_ignorados}")
        print(f"📄 O contexto foi salvo em: {os.path.abspath(ARQUIVO_SAIDA)}")
    else:
        print("\n⚠️ Nenhum arquivo válido encontrado dentro da pasta Forms.")

if __name__ == "__main__":
    capturar_contexto()