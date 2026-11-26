# CarrosFacil — Projeto do curso TI - Senac

Projeto desenvolvido em C# utilizando Windows Forms e MariaDB durante o curso de TI do Senac.

## Como iniciar?

### 1. Baixe o projeto

- Acesse a seção [Releases](../../releases/latest) deste repositório.
- Baixe o arquivo `CarrosFacil.zip` e extraia.

### 2. Baixe o MariaDB Server

- Acesse a [página de download do MariaDB Server 12.3.4](https://mariadb.com/docs/platform/post-download/mariadb-server-12.3.4).
- Baixe a versão Windows x64 no formato ZIP.
- Extraia o conteúdo na pasta do projeto e renomeia pasta para `mariadb-portable`.

### 3. Veja se a estrutura do projeto está correta

```text
CarrosFacil/
├── mariadb-portable/
│   ├── bin/
│   ├── lib/
│   └── share/
├── banco-projeto.sql
├── Iniciar.bat
└── demais arquivos do projeto
```

### 4. Execute o projeto

Execute o arquivo `Iniciar.bat`.

O script vai:

- Iniciar o banco de dados na porta 3306 (padrão)
- Importar o banco-projeto.sql
- Abrir o CarrosFacil.exe

## Tecnologias utilizadas

- C#
- Windows Forms
- MariaDB
- SQL

## Finalidade

Projeto criado para aprender a base sobre C#, Winforms e MariaDb
