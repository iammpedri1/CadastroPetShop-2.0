# Cadastro PetShop

Windows Form para gerenciar donos e animais de um pet shop usando MySQL.

## Funcionalidades

- Login de usuários com senha verificada por BCrypt.
- Menu principal com saudação ao usuário conectado.
- Cadastro, consulta, alteração e exclusão de donos.
- Cadastro, consulta, alteração e exclusão de pets associados a um dono.
- Pesquisa de pets pelo nome do animal ou do dono.
- Seleção e visualização de uma foto do pet durante o uso do formulário. A foto não é gravada no banco de dados.
- Relatório dos pets de um dono.
- Relatório da quantidade de pets por espécie.
- Validação de CPF, e-mail, telefone brasileiro e CEP no cadastro de donos.

## Requisitos

- Windows.
- .NET 10 SDK com suporte a Windows Forms.
- MySQL Server e banco `petshop_tecnico`.
- Tabelas do banco criadas com as colunas usadas pelo aplicativo. O repositório não contém um script SQL de criação do banco.

## Executar no Visual Studio

1. Abra `CadastroPetShop.slnx` ou `CadastroPetShop.sln`.
2. Defina `CadastroPetShop` como projeto de inicialização, se necessário.
3. Configure a conexão MySQL nos arquivos que a utilizam.

A aplicação abre primeiro a tela de login. Para acessar o sistema, deve existir um usuário na tabela `usuarios` com uma senha armazenada em formato BCrypt.

## Banco de dados

O código espera encontrar, entre outras usadas nas consultas, as tabelas e colunas abaixo:

- `usuarios`: `usuario`, `senha_hash`.
- `donos`: `id_dono`, `cpf`, `nome`, `telefone`, `email`, `endereco` (o formulário apresenta esse último campo como CEP).
- `pets`: `id_pet`, `id_dono`, `nome`, `idade`, `porte`, `sexo`, `vacina_raiva`, `especie`, `cor`, `raca`, `castrado`, `doencas`.

A relação entre pets e donos é feita por `pets.id_dono` e `donos.id_dono`.

## Conexão

A conexão local é configurada no código C# do login, dos formulários e dos relatórios. Ajuste servidor, banco, usuário e senha conforme a instalação local do MySQL. Não publique senhas reais no repositório.
