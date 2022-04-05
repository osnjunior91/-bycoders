# Bycoders Teste
## Teste para desenvolvedor na empresa Bycoders

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)


## Features

- Importar arquivo de texto com os registros.
- Interpretar dados formatandos os para o sistema.
- Exibir lista de dados importados com dados por loja e saldo.
- Possuir testes automatizados.
- Possuir documentacao da API



## Tech

Tecnologias e conceitos usados :

- [.NetCore](https://dotnet.microsoft.com/en-us/learn/dotnet/hello-world-tutorial/install) - Backend!
- [ReactJs](https://reactjs.org/) - Frontend
- [EF Core](https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli) - Conexao com banco de dados.
- [Sql Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) - Banco de dados
- [Material Ui](https://mui.com/pt/) - Componentes de tela.
- [Axios](https://github.com/axios/axios) - Requisicoes Http
- [Swagger](https://swagger.io/) - Documentar Api

## Instalacao

### Clonar Repositorio
Basta clonar o repositório normalmente pelo GitHub, ou como arquivo .zip.

### Rodar Migration

-Insira dos dados do seu banco sql na connection string dentro do arquivo **appsettings.json** no projeto **Bycoders.Api**.
-Agora selecione o projeto **Bycoders.Domain**.
-Execute os seguintes comandos:
```sh
Add-Migration InitialCreate
update-database
```
Apos isso seu banco deve ficar com a seguinte estrutura:
![strong text](https://github.com/osnjunior91/-bycoders/blob/main/images/FinalDatabase.png?raw=true)
> Note: Deve se verificar se a tabela TypeTransactions foi populada corretamente.

### Instalar dependencias do portal
-Acessar pasta **\-bycoders\bycoders-site**.
-Rodar o comando
```sh
npm install
```
-Aguardar a instalacao dos pacotes

## Executar aplicacao
### Executar Api
Basta definir o projeto **Bycoders.Api** como principal, e executar usando o IIS. Apos executar aparecera a tela do Swagger contendo a documentacao da api, como na imagem:

![strong text](https://github.com/osnjunior91/-bycoders/blob/main/images/swagger.png?raw=true)

### Executar Web Site
-Acessar pasta **\-bycoders\bycoders-site**.
-Definir no arquivo **-bycoders\bycoders-site\src\services\axios\index.js** o endereco base da api
-Rodar o comando
```sh
npm start
```

## Usar a aplicacao
- Para acesso aos sistema devem ser usados as credenciais:

    | Propriedade | Valor |
    | ------ | ------ |
    | User/Email | **admin** |
    | Password | **admin**  |
- O metodo de carregar o arquivo necessita de autenticacao para funcionar, mas os de visualizar nao.
- Os testes possuem diversos casos, e foram feitos visando as principais rotinas da aplicacao.
## License

MIT

**Free Software!**

[//]: # (These are reference links used in the body of this note and get stripped out when the markdown processor does its job. There is no need to format nicely because it shouldn't be seen. Thanks SO - http://stackoverflow.com/questions/4823468/store-comments-in-markdown-syntax)

   [dill]: <https://github.com/joemccann/dillinger>
   [git-repo-url]: <https://github.com/joemccann/dillinger.git>
   [john gruber]: <http://daringfireball.net>
   [df1]: <http://daringfireball.net/projects/markdown/>
   [markdown-it]: <https://github.com/markdown-it/markdown-it>
   [Ace Editor]: <http://ace.ajax.org>
   [node.js]: <http://nodejs.org>
   [Twitter Bootstrap]: <http://twitter.github.com/bootstrap/>
   [jQuery]: <http://jquery.com>
   [@tjholowaychuk]: <http://twitter.com/tjholowaychuk>
   [express]: <http://expressjs.com>
   [AngularJS]: <http://angularjs.org>
   [Gulp]: <http://gulpjs.com>

   [PlDb]: <https://github.com/joemccann/dillinger/tree/master/plugins/dropbox/README.md>
   [PlGh]: <https://github.com/joemccann/dillinger/tree/master/plugins/github/README.md>
   [PlGd]: <https://github.com/joemccann/dillinger/tree/master/plugins/googledrive/README.md>
   [PlOd]: <https://github.com/joemccann/dillinger/tree/master/plugins/onedrive/README.md>
   [PlMe]: <https://github.com/joemccann/dillinger/tree/master/plugins/medium/README.md>
   [PlGa]: <https://github.com/RahulHP/dillinger/blob/master/plugins/googleanalytics/README.md>
