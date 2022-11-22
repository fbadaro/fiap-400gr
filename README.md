# Projeto de Solu��o FIAP - Startup 400gramas

### Integrantes
* Fabio Badaro
* William Dias

### Pr� Requisitos do Trabalho

#### **Aplica��o Web** 
* Para nosso projeto, desenvolvemos API's de comunica��o ao qual o dispositivo mobile dos usu�rios ir� se comunicar para fazer as solicita��es.
* Os projetos de API e Core est�o feitos com .net6 (https://dotnet.microsoft.com/en-us/download/dotnet/6.0).
* ORM que est� sendo usado no projeto para fazer a abstra��o com a base de dados � o Entity Framwework (https://learn.microsoft.com/en-us/aspnet/entity-framework).
* Os projetos se encontram dentro do caminho ./api/src/services.
* Dentro da pasta Files cont�m o arquivo .json com toda documenta��o da API para ser importada para o Postman (https://www.postman.com/) e pronta para utiliza��o, tamb�m h� uma documenta��o da API funcionando.


#### **Aplica��o Mobile**
* Para nosso projeto, pensando em um �nico c�digo base e deploy para multiplos dispositivos, utilizamos o Flutter (https://flutter.dev/) para desenvolvimento.
* Foi realizado toda a montagem da arquitetura do Flutter no projeto.
* O projeto se encontra dentro do caminho ./app.


#### **Integra��o entre os sistemas**
* A integra��o entre os sistemas se dar� pelas API's disponibilizadas.


### Configura��o
Na raiz do projeto se encontra o arquivo docker-compose-local.yaml com toda a configura��o para subir os containers do projeto + os containers de infraestrutura como banco de dados, e respectivamente tamb�m toda a configura��o.

Tamb�m est� desenvolvido nos projetos de API's os Seeds inicias com todo o Schema do banco de dados, n�o sendo assim necess�rio nenhuma execu��o de scripts SQL ou Migrations.

Para subir a infraestrutura dos projetos executar o comando `docker compose -f .\docker-compose-local.yaml up -d` na raiz do projeto.

O projeto de API subir� no endere�o: https://localhost:5701/swagger/index.html, o projeto esta rodando com a configura��o de SSL e no momento de subir a infraestrutura � gerado os certificados locais para a API, mas n�o v�lidos, sendo assim quando abrir no browser ser� necess�rio avan�ar selecionando a op��o de confiar na abertura do site.

### Considera��es
No momento de subir nossa infraestrutura verifique se n�o existe algum container local utilizando alguma configura��o de porta que possa estar no docker-compose do projeto.