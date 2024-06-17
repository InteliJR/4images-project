

# Requisitos Funcionais

Requisitos funcionais são especificações detalhadas do comportamento do sistema ou o que o sistema deve fazer. Eles descrevem as funções que um sistema deve executar, como processos, informações a serem manipuladas, funcionalidade a ser fornecida por interfaces específicas e comportamento em resposta a entradas específicas ou condições em seu ambiente de operação. Em outras palavras, os requisitos funcionais definem “o que” o sistema deve fazer para atender às necessidades e expectativas do usuário.

| Nº RF | Requisito | Descrição | Prioridade | Tipo |
|-------|-----------|-----------|------------| ---- |
| RF01   | Login do usuário na plataforma| O usuário deve conseguir se conectar à plataforma utilizando o login e senha que ele cadastrou. | 5 | 
| RF02   | Recuperação de senha | O usuário deve conseguir recuperar a sua senha da plataforma através de seu email cadastrado e receber um email com a autenticação para mudar a senha. | 4 |
| RF03   | Compra de Imagem | O usuário deve ser capaz de comprar uma imagem com o tamanho de sua escolha, selecionando o tamanho desejado e adicionando a imagem ao carrinho de compras. | 4 |
| RF04   | Pagamento Online | O usuário deve ser capaz de fazer o pagamento de forma online, utilizando os padrões de mercado, como cartão de crédito ou PayPal. | 4 |
| RF05   | Visualização de Imagens na Página Inicial | O usuário deve ser capaz de visualizar algumas imagens na página inicial, organizadas por categorias ou destaques. | 3 |
| RF06   | Visualização Detalhada de Imagem | O usuário deve ser capaz de visualizar uma imagem de perto, ampliando-a e vendo informações adicionais, como título, descrição e autor. | 3 |
| RF07   | Curtir Imagem | O usuário deve ser capaz de curtir uma imagem, adicionando-a à sua lista de imagens favoritas ou marcando-a como interessante. | 3 |
| RF08   | Solicitação de Fotos | O sistema deve garantir que o usuário possa abrir solicitações de fotos para o usuário administrador, descrevendo o tipo de imagem desejada e fornecendo informações de contato. | 4 |
| RF09   | Pesquisa de Imagens | O usuário deve ser capaz de pesquisar por uma imagem, utilizando palavras-chave ou filtros, para encontrar imagens específicas que atendam às suas necessidades. | 4 |
| RF10  | Registro de Usuário | O usuário deve ser capaz de se registrar na plataforma fornecendo informações básicas como nome, email e senha. | 5 |
| RF11  | Perfil de Usuário | O usuário deve ser capaz de acessar e editar seu perfil, incluindo informações como nome, endereço de email e preferências. | 5 |
| RF12  | Histórico de Compras | O usuário deve ser capaz de visualizar um histórico de suas compras anteriores. | 2 |
| RF13  | Download de Imagens em Diferentes Resoluções | O usuário deve ser capaz de escolher a resolução da imagem no momento do download, conforme o nível de sua compra ou assinatura. | 3 |
| RF14  | Suporte ao Cliente | O usuário deve ser capaz de acessar uma seção de suporte ao cliente para obter ajuda ou informações adicionais. | 2 |
| RF01 | Adição de Imagens | O sistema deve garantir que o admin possa adicionar imagens ao banco de dados, tanto individualmente quanto em lotes. | 5 |
| RF02 | Exclusão de Imagens | O sistema deve garantir que o admin possa deletar imagens do banco de dados. | 5 |
| RF03 | Visualização de Transações | O sistema deve garantir que o admin possa visualizar transações feitas pelos seus usuários clientes através de uma tabela com essas informações. | 4 |
| RF04 | Alteração de Descrição de Imagens | O administrador pode alterar as informações que as imagens contenham, como descrição, tags, entre outros. | 3 |
| RF05 | Alteração de Preço de Imagens | O administrador pode alterar o preço das imagens sempre que necessário. | 4 |
| RF06 | Relatórios de Vendas | O sistema deve gerar relatórios de vendas, incluindo métricas como receitas por período, imagens mais vendidas e análise de tendências. | 3 |
| RF07 | Gestão de Categorias | O administrador deve ser capaz de criar, editar e excluir categorias de imagens para melhor organização do conteúdo. | 3 |
| RF08 | Configuração de Promoções | O administrador deve ser capaz de criar e gerenciar promoções e descontos para imagens ou assinaturas. | 3 |
| RF09 | Suporte ao Cliente | O administrador deve ser capaz de acessar e responder às solicitações de suporte dos usuários. | 3 |
| RF10 | Gestão de Assinaturas | O administrador deve ser capaz de visualizar e gerenciar assinaturas dos usuários, incluindo atualizações, cancelamentos e renovações. | 2 |
| RF11 | Exportação de Dados | O administrador deve ser capaz de exportar dados de usuários, transações e imagens para relatórios externos ou análise. | 2 |
| RF01 | Login do usuário na plataforma | Os administradores devem ter a capacidade de adicionar novas imagens ao sistema tanto através do site quanto por meio de arquivos CSV, seja individualmente ou em lotes. | 5 |
| RF02 | Recuperação de senha | O usuário deve conseguir recuperar a sua senha da plataforma através de seu email cadastrado e receber um email com a autenticação para mudar a senha | 4 |
| RF03 | Compra de Imagem | O usuário deve ser capaz de comprar uma imagem com o tamanho de sua escolha, selecionando o tamanho desejado. | 5
| RF04 | Pagamento Online | O usuário deve ser capaz de fazer o pagamento de forma online, utilizando os padrões de mercado, como cartão de crédito ou PayPal. | 5
|RF05 | Visualização de Imagens na Página Inicial | O usuário deve ser capaz de visualizar algumas imagens na página inicial, organizadas por categorias ou destaques. | 5
| RF06 | Visualização Detalhada de Imagem | O usuário deve ser capaz de visualizar uma imagem de perto, ampliando-a e vendo informações adicionais, como título, descrição e preço. | 5
| RF07 | Curtir Imagem | O usuário deve ser capaz de curtir uma imagem, adicionando-a à sua lista de imagens favoritas ou marcando-a como interessante. | 3
| RF08 | Solicitação de Fotos | O sistema deve garantir que o usuário possa abrir solicitações de fotos para o usuário administrador, descrevendo o tipo de imagem desejada e fornecendo informações de contato. | 3
| RF09 | Pesquisa de Imagens | O usuário deve ser capaz de pesquisar por uma imagem, utilizando palavras-chave ou filtros, para encontrar imagens específicas que atendam às suas necessidades. | 4
| RF1   | O sistema deve oferecer diferentes tipos de assinaturas, cada uma com um número específico de downloads permitidos e opções de manipulação do tempo entre os downloads. | 4 |
| RF2   | Os usuários devem poder contratar uma assinatura mensal, concedendo acesso aos recursos e benefícios associados à sua escolha de plano. | 4 |
| RF3   | Os usuários devem poder atualizar os seus planos de assinatura | 3 |
| RF1   | Autenticação de todos os usuários | Dado a necessidade de segurança tanto das imagens da aplicação quanto das transações realizadas dentro da plataforma, é necessário que a aplicação realize autenticação dos usuários para que eles possam ter acesso aos serviços fornecidos, para usuários não autenticados a aplicação não permitirá ações que possam comprometer a integridade dos dados e dos outros clientes. | 5 |
| RF2   | Suporte a múltiplos métodos de autenticação | É necessário garantir que os usuários possam fazer o processo de autenticação de formas diversas tais quais: o cadastro padrão da aplicação, autenticação de dois fatores e autenticação por meio de terceiros como conta do Google e de redes sociais. | 4 |
| RF3   | Integridade dos diferentes níveis de acesso | Considerando a característica da aplicação de possuir diferentes tipos e níveis de assinatura, é de suma importância que os níveis de acesso para cada usuário sejam bem definidos e protegidos para garantir que imagens do cliente não possam ter sua integridade violada. Ademais, é de suma importância garantir que apenas o usuário administrador possa ter interações mais complexas com esses dados audiovisuais. | 5 |
| RF4   | Criptografia de informações confidenciais | É de suma importância garantir que informações confidenciais e/ou sensíveis sejam criptografadas em seu armazenamento e enquanto estiverem em trânsito, assim garantindo sua segurança mesmo sob caso de acesso indevido. | 4 |
| RF5   | Uso de protocolos de comunicação seguros | O uso de protocolos de comunicação seguros como o HTTPS é de vital importância para qualquer aplicação por garantir a integridade e segurança do transporte de dados no ambiente web. | 4 |
| RF6   | Restrição de acesso a informações confidenciais | Dado a natureza de múltiplas assinaturas e da existência de um administrador, é importante garantir que existam restrições de acesso às informações da aplicação, assim garantindo a integração do sistema | 5 |
| RF7   | Detecção e registro de alterações nos dados | O registro das alterações nos dados é uma boa prática para uma estrutura de banco de dados para garantir que as modificações possam ser monitoradas e validadas. | 3 |
| RF8   | Recuperação de dados em caso de perda ou corrupção | É importante garantir que seja possível recuperar informações do banco de dados caso ocorra algum tipo de corrupção dos dados. Em geral, isso é feito através do registro dos dados em tabelas de backup e registros de logs | 3 |
| RF9  | Prevenção de ataques de injeção de SQL | Sendo o injection uma das falhas de segurança mais comuns em aplicações web segundo o OWASP, sendo assim, é de suma importância adicionar verificações tanto no frontend quanto no backend para evitar que comandos SQL e JavaScript possam ser injetados na aplicação. | 5 |
| RF10 | Controle de Sessão | A aplicação deve implementar um controle de sessão seguro para gerenciar a autenticação contínua do usuário durante sua interação com a plataforma, garantindo que a sessão expire após um período de inatividade ou logout. | 4 |
| RF11 | Proteção contra Brute Force | É necessário implementar mecanismos de proteção contra ataques de força bruta, como limitar o número de tentativas de login e bloquear temporariamente contas após várias tentativas fracassadas. | 2 |