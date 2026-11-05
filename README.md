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

## Conexão

A conexão local é configurada no código C# do login, dos formulários e dos relatórios. Ajuste servidor, banco, usuário e senha conforme a instalação local do MySQL. Não publique senhas reais no repositório.
