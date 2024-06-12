# Arquitetura IT

## Visão Geral

A "Arquitetura IT" do nosso projeto é projetada para fornecer uma visão clara e detalhada de como os componentes da aplicação interagem entre si, desde a interface do usuário até o backend e o banco de dados. Esta arquitetura é representada visualmente para facilitar a compreensão do fluxo de informações e ações dos usuários, além de destacar pontos críticos de segurança.

<div align="center">
    <p><b>Figura 1 </b>- Arquitetura IT [visão geral] </p>
    <p>aqui vai uma imagem</p>
    <p>Fonte: Elaboração dos autores</p>
</div>

## Componentes Principais

### Interface do Usuário de Baixa Fidelidade (Frontend)

- **Componentes Visuais de Baixa Fidelidade**: A aplicação apresenta componentes visuais de baixa fidelidade que ajudam a mapear o que o usuário vê e interage. Isso inclui telas de login, cadastro, visualização de imagens, etc.
- **Interações do Usuário**: As ações dos usuários, como cliques em imagens, são mapeadas visualmente para entender as solicitações feitas ao backend.

### Backend

- **Serviços de API**: O backend da aplicação consiste em serviços de API que recebem solicitações do frontend e as processam. Essas APIs gerenciam a lógica de negócios e interagem com os bancos de dados.
- **Gerenciamento de Sessão**: O backend gerencia as sessões de usuários para garantir que apenas usuários autenticados possam realizar certas ações.

### Bancos de Dados

- **Banco de Dados Relacional**: Utilizado para armazenar dados estruturados, como informações de usuários, transações, e outras entidades que requerem relações complexas e consultas SQL.
- **Banco de Dados Não Relacional**: Utilizado para armazenar dados não estruturados, como imagens e vídeos. Este banco de dados oferece flexibilidade e escalabilidade para grandes volumes de dados.

### Segurança

- **Pontos de fragilidade da aplicação**: A partir da arquitetura, como cada uma de suas etapas são mapeadas quanto ao fluxo de informações e dados, é possível definir alguns pontos aonde serão necessários métodos e formas mais seguros de garantir a segurança dessas informações, sendo esse um componente de vital importância para a solução.

### Fluxo de informações

O fluxo de informações e das causas e consequências para cada evento da aplicação é um dos pontos fortes da arquitetura IT, através desse mapeamento conseguimos saber com antecedência quais features e processos teremos que desenvolver em consequência de outros anteriores, assim tornando o desenvolvimento mais sólido e focado. Abaixo, segue um exemplo de como essa visão é feita em conjunto com a arquitetura:

<div align="center">
    <p><b>Figura 2 </b>- Arquitetura IT [visão específica] </p>
    <p>Fonte: Elaboração dos autores</p>
</div>

**Visualização do usuário** - Tela principal, com algumas opções em um menu superior, uma barra de pesquisa e uma série de imagens dispostas em formato de galeria. As imagens são clicáveis.  

**Requisições feitas ao backend** - Para exibir cada uma dessas imagens, foi necessário enviar um pedido ao backend da solução para que ele acesse o banco de dados relacional que contém as referências para puxar as imagens do armazenamento em blobs (NoSQL) essas imagens foram retornadas e carregadas na home de forma otimizada através do uso de uma CDN (Content Delivery Network).  

**Banco de dados** - Nesse cenários foram utilizados dois tipos de banco de dados, o relacional para manter as informações e referências das imagens e o não relacional para armazenar os arquivos de imagens em si. Ademais, nessa mesma página também há o acesso à base de dados dos usuários.

**Segurança** - Anteriormente, para que o respectivo usuário possa acessar essa página, ele teve que realizar todo um processo de cadastro, autenticação e validação, o que o deu permissão por baixo dos panos para poder atuar na plataforma com maior liberdade via tokens de validação. Além disso, o processo de segurança está mapeado tanto na segurança do armazenamento de dados dentro das bases relacionais e não relacionais, quanto no trânsito das informações. Em adição, a arquitetura também mapeia a segurança necessária nas rotas do backend e contra possíveis injeções de SQL.

**Ações do usuário** - No caso dessa tela, o usuário pode clicar tanto no seu ícone de perfil, o que o redireciona para sua tela de perfil que contém outros relacionamentos com outras partes da aplicação. Outra ação que pode ser feita é a de clicar em uma imagem da aplicação, o que o leva para um modal que vai exibir informações mais específicas sobre a imagem, além da possibilidade de efetuar a compra da mesma, assim continuando a arquitetura com outras questões de segurança e integração com um sistema de pagamentos.

Esse foi somente um exemplo de como os aspectos e relacionamentos da aplicação podem ser mapeados de forma simples e visual através da arquitetura IT. Por meio dessa ferramenta é possível tornar o processo de desenvolvimento mais focado e dedicado para resolver os desafios apresentados pelo cliente.

## Medidas de Segurança

Como enfatizado anteriormente, questões de segurança são de suma importância para garantir o bom funcionamento da aplicação devido seu dados importantes que serão armazenados e utilizados. Sendo assim, seguem alguns dos principais pontos de segurança mapeados dentro do escopo da arquitetura.

### Pontos Críticos de Segurança

Na arquitetura, existem pontos destacados como críticos para a segurança. Estas áreas são representadas por quadrados vermelhos e incluem:

- **Autenticação e Autorização**:
    - **Descrição**: Garantir que apenas usuários autenticados possam acessar certas funcionalidades.
    - **Medidas**: Implementação de OAuth 2.0, verificação de tokens JWT, etc.

- **Transmissão de Dados Sensíveis**:
    - **Descrição**: Proteção durante a transmissão de dados sensíveis entre o frontend e o backend.
    - **Medidas**: Criptografia TLS/SSL para todas as comunicações.

- **Armazenamento Seguro de Dados**:
    - **Descrição**: Proteção dos dados armazenados no banco de dados.
    - **Medidas**: Criptografia de dados em repouso, políticas de acesso restritas, backup e recuperação de dados.

- **Prevenção de Ataques de Injeção**:
    - **Descrição**: Prevenção de ataques como SQL Injection.
    - **Medidas**: Validação e sanitização de entrada, uso de ORM para interações com o banco de dados.

- **Monitoramento e Logging**:
    - **Descrição**: Monitoramento contínuo de atividades suspeitas e logging de eventos.
    - **Medidas**: Implementação de ferramentas de monitoramento e sistemas de logging robustos.

## Conclusão

A "Arquitetura IT" proporciona uma estrutura clara e eficiente para o desenvolvimento e operação da nossa aplicação. Com uma combinação de componentes visuais, backend robusto e banco de dados eficiente, além de medidas de segurança rigorosas, estamos bem equipados para fornecer uma aplicação segura, escalável e fácil de manter. Esta arquitetura não só facilita o entendimento das interações do usuário, mas também fortalece nosso processo de desenvolvimento com uma base sólida e focada em um design de segurança limpo e eficiente.