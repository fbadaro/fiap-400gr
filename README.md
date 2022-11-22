# Projeto de Solução FIAP - Startup 400gramas

### Integrantes
* Fabio Badaro
* William Dias

### Pré Requisitos do Trabalho

#### **Aplicação Web** 
* Para nosso projeto, desenvolvemos API's de comunicação ao qual o dispositivo mobile dos usuários irá se comunicar para fazer as solicitações.
* Os projetos de API e Core estão feitos com .net6 (https://dotnet.microsoft.com/en-us/download/dotnet/6.0).
* ORM que está sendo usado no projeto para fazer a abstração com a base de dados é o Entity Framwework (https://learn.microsoft.com/en-us/aspnet/entity-framework).
* Os projetos se encontram dentro do caminho ./api/src/services.
* Dentro da pasta Files contém o arquivo .json com toda documentação da API para ser importada para o Postman (https://www.postman.com/) e pronta para utilização, também há uma documentação da API funcionando.


#### **Aplicação Mobile**
* Para nosso projeto, pensando em um único código base e deploy para multiplos dispositivos, utilizamos o Flutter (https://flutter.dev/) para desenvolvimento.
* Foi realizado toda a montagem da arquitetura do Flutter no projeto.
* O projeto se encontra dentro do caminho ./app.


#### **Integração entre os sistemas**
* A integração entre os sistemas se dará pelas API's disponibilizadas.


### Configuração
Na raiz do projeto se encontra o arquivo docker-compose-local.yaml com toda a configuração para subir os containers do projeto + os containers de infraestrutura como banco de dados, e respectivamente também toda a configuração.

Também está desenvolvido nos projetos de API's os Seeds inicias com todo o Schema do banco de dados, não sendo assim necessário nenhuma execução de scripts SQL ou Migrations.

Para subir a infraestrutura dos projetos executar o comando `docker compose -f .\docker-compose-local.yaml up -d` na raiz do projeto.

O projeto de API subirá no endereço: https://localhost:5701/swagger/index.html, o projeto esta rodando com a configuração de SSL e no momento de subir a infraestrutura é gerado os certificados locais para a API, mas não válidos, sendo assim quando abrir no browser será necessário avançar selecionando a opção de confiar na abertura do site.

### Considerações
No momento de subir nossa infraestrutura verifique se não existe algum container local utilizando alguma configuração de porta que possa estar no docker-compose do projeto.