# take-blip-desafio-tecnico-GitHubAPI-chatbot
<h2>Repositório destinado ao desafio de consumir uma API do GitHub dos repositórios da Take Blip para criação de chatbot.</h2>

Neste projeto foi desenvolvida uma API em ASP.NET Core que busca por meio da API do GitHub **os 5 repositórios de linguagem C# mais antigos da Take Blip,
ordenados de forma crescente por data de criação**.

Esse projeto desafio abranje os seguintes tópicos:

* Setup inicial de projeto com o Visual Studio 2019;
* Criação de modelo de dados e ViewModel;
* Criação de classes de ação, abstração e contrato (Controllers, Interfaces, Services e Repositórios);
* Integração do repositório com a API pública do GitHub;
* Criação de serviço para realizar a filtragem e ordenação da lista de repositórios de retorno (json) requerida pelo desafio;
* Implantação da API pública na nuvem através do Heroku.

Ação da API do GitHub usada para listar repositórios para a organização especificada:

´´´´´
|GET| /orgs/{org}/repos
´´´´´

Link da API pública takeblip-chatbot-githubapi:

´´´´´
https://takeblip-chatbot-githubapi.herokuapp.com/api/TakeBlip
´´´´´



