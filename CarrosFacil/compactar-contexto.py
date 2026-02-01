import os

def consolidar_projeto():
    # Nome do arquivo de saída
    output_file = "contexto-geral.txt"
    
    # Extensões de arquivos que queremos incluir
    extensions_to_include = ('.cs', '.xaml', '.csproj', '.sln', '.json', '.xml', '.css', '.js')
    
    # Pastas que devem ser ignoradas
    dirs_to_exclude = {'bin', 'obj', '.vs', '.git', 'Properties', 'node_modules', 'publish'}

    print(f"Gerando {output_file}...")

    with open(output_file, 'w', encoding='utf-8') as f_out:
        for root, dirs, files in os.walk('.'):
            # Filtra pastas ignoradas
            dirs[:] = [d for d in dirs if d not in dirs_to_exclude]

            for file in files:
                if file.endswith(extensions_to_include) and file != output_file:
                    file_path = os.path.join(root, file)
                    
                    try:
                        with open(file_path, 'r', encoding='utf-8') as f_in:
                            content = f_in.read()
                            
                            # Escreve o cabeçalho do arquivo para a IA identificar
                            f_out.write("\n" + "="*50 + "\n")
                            f_out.write(f"ARQUIVO: {file_path}\n")
                            f_out.write("="*50 + "\n\n")
                            
                            f_out.write(content)
                            f_out.write("\n")
                            
                        print(f"Incluído: {file_path}")
                    except Exception as e:
                        print(f"Erro ao ler {file_path}: {e}")

    print(f"\nConcluído! O arquivo {output_file} foi gerado com sucesso.")

if __name__ == "__main__":
    consolidar_projeto()