# Analise Palavra Chaves com Power BI no ASP.NET Core
[![NPM](https://img.shields.io/npm/l/react)](https://github.com/wlusbar/Analise-Palavra-Chaves-com-Power-BI-no-asp-net/blob/master/LICENSE)

## Sobre o Projeto
O projeto trata-se de uma página WEB MVP de analise dos trabalhos universitários utilizando Power BI.
Foi desenvolvido uma API ASP.NET Core 2.1 que disponibiliza as palavras chaves em um end point autenticado e renderiza em tela os resultados consumidos da análise dos dados feita no Power BI.

### Layout Responsivo no Mobile
##### Acesso a página de cadastro de novos trabalhos via Mobile
![Tela de Cadastro de novos trabalhos](https://github.com/wlusbar/assets/blob/main/AnaliseDePalavrasChaves/TelaCadastroTrabalhoMobile.png)

### Layout no Navegador
##### Essa imagem é de acesso a página Home que contém informações sobre curso.
![Pagina Home no navegador](https://github.com/wlusbar/assets/blob/main/AnaliseDePalavrasChaves/Home.png)

##### Essa imagem é o acesso a listagem dos trabalhos que contém informações resumidas dos trabalhos e link de detalhamento de cada TCC.
![Pagina de Listagem de trabalhos](https://github.com/wlusbar/assets/blob/main/AnaliseDePalavrasChaves/ListagemDeTrabalhos.png)

##### Ilustra o acesso detalhado de cada trabalho realizado.
![Tela de acesso ao trabalho](https://github.com/wlusbar/assets/blob/main/AnaliseDePalavrasChaves/TelaDoRegistro.png)


### Gráficos Análisados na aplicação
Os dados coletados dos TCC’s no período de Fevereiro de 2012 a Julho de 2018. Durante a construção do conteúdo a ser analisado, foram levantados os assuntos a serem abordados para os relatórios gerados na ferramenta Power BI. 
A coleta de dados foi feita identificando: título do trabalho, autor (aluno), orientador, resumo e palavras-chave. No início da coleta de dados foi possível perceber duas situação. Um em que os trabalhos apresentavam palavras-chave e outro em que os trabalho não apresentavam palavras-chave. Nos anos de 2013 a 2017 a não utilização de palavras-chave se mostrou alta, sendo 21 TCC’s que não apresenta palavras-chave.

##### Trabalhos que não continham palavras chaves por ano.
Gráfico 1: TCCs que não contém palavras-chave por ano.
![Trabalhos que não contém palavras chaves](https://github.com/wlusbar/assets/blob/main/AnaliseDePalavrasChaves/GraficosTrabalhosQueNaoContemPalavrasChaves.png)

Durante a análise dos dados foi identificado que alguns TCCs não possuíam palavras-chave. Com isso, foram realizada duas etapas diferentes para coleta das palavras-chave. No primeiro são analisados os trabalhos com as palavras-chave atribuídas pelos autores mostradas no Gráfico 1. Na segunda etapa foi atribuída palavras-chave aos trabalho que não possuía, retiradas do título e dos resumos, mostradas no Gráfico 2. 

##### Grafico 1: Palavras-Chave abordadas pelos alunos.
![Palavras chaves mais abordadas criadas](https://github.com/wlusbar/assets/blob/main/AnaliseDePalavrasChaves/GraficosPalavrasChavesMaisAbordadas.png)

##### Grafico 2: Palavras Chaves criadas, durante análise dos trabalhos.
![Palavras chaves mais abordadas em trabalhos que não continha as palavras destacadas](https://github.com/wlusbar/assets/blob/main/AnaliseDePalavrasChaves/GraficoPalavrasChavesCriadasMaisAbordadas.png)

##### Trabalhos que não contém palavras-chave por ano.
No Gráfico 3, foram demonstrados os processos mais utilizados pelos alunos para construção do seu tema.
![Processos mais utilizados nos TCCs](https://github.com/wlusbar/assets/blob/main/AnaliseDePalavrasChaves/ProcessosUtilizadosNosTCCs.png)

## Tecnologias Utilizadas
- ASP.NET Core 2.1 - Visual Studio Pro 2017 (x64)
- SQL Server 2014
- Excel
- SQL Data tools Integration Services (SSIS)
- Microsoft Power BI
  
## Autor
- Wellington Luiz

  https://www.linkedin.com/in/wellingtonluizsb/

## Agradecimentos
Este desenvolvimento foi realizado para demostrar o TCC para a Análise dos Trabalhos de Conclusão de Curso de  Sistema de Informação de Contagem
, com dados dos TCC’s no período de Fevereiro de 2012 a Julho de 2018 fornecidos pela PUC Minas. 
