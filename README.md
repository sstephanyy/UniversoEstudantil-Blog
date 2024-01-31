# Blog ASP.NET Core MVC com Entity Framework, SQL Server, Bootstrap e Identity Role

Este projeto é um blog desenvolvido em ASP.NET Core MVC, incorporando tecnologias como Entity Framework, SQL Server, Bootstrap CSS e Identity. Ele oferece um ambiente robusto para gerenciamento de conteúdo, incluindo funcionalidades de CRUD, Repository Pattern e autenticação/autorização com diferentes níveis de acesso.

## Recursos Principais

### 1. CRUD Completo:
- Execute operações de criação, leitura, atualização e exclusão de postagens do blog de forma intuitiva.

### 2. Repository Pattern:
- Implementação do padrão de repositório para organização eficiente do código e manipulação de dados.
- Facilita a manutenção e extensibilidade do sistema.

### 3. Bootstrap CSS:
- Design responsivo e atraente, proporcionando uma experiência de usuário agradável em diferentes dispositivos.

### 4. Identity Role para Autenticação e Autorização:
- Utilização do ASP.NET Identity para autenticação de usuários.
- Atribuição de roles como Admin, Gerente e Usuário para controle granular de autorização.

## Níveis de Acesso

### 1. Admin:
- Acesso total ao sistema.
- Pode criar, editar e excluir postagens.
- Gerencia usuários e atribui funções.

### 2. Gerente:
- Pode visualizar e editar todas as postagens.
- Sem permissão para gerenciar usuários ou funções.

### 3. Usuário:
- Pode visualizar postagens existentes.
- Sem permissão para editar ou excluir postagens.

## Configuração

1. **Clone o Repositório:**
   ```bash
   git clone https://seu-repositorio.git
   cd nome-do-projeto
