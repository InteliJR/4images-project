

# Requisitos Funcionais

Requisitos funcionais são especificações detalhadas do comportamento do sistema ou o que o sistema deve fazer. Eles descrevem as funções que um sistema deve executar, como processos, informações a serem manipuladas, funcionalidade a ser fornecida por interfaces específicas e comportamento em resposta a entradas específicas ou condições em seu ambiente de operação. Em outras palavras, os requisitos funcionais definem “o que” o sistema deve fazer para atender às necessidades e expectativas do usuário.

## Requisitos dos usuários

## Requisitos do administrador

## Requisitos de imagem
| Nº RF | Requisito | Descrição | Prioridade |
|-------|-----------|-----------|------------|
| RF1   | Os administradores devem ter a capacidade de adicionar novas imagens ao sistema tanto através do site quanto por meio de arquivos CSV, seja individualmente ou em lotes. | 5 |
| RF2   | Os administradores devem ter a capacidade de excluir imagens do sistema | 5 |
| RF3   | Os administradores devem poder alterar as inforamções associadas às imagens como título, descrição, tags, especificações de uso, etc. | 5 |
| RF4   | O usuário deve ter a capacidade de comprar (Desde a escolha da imagem até o processo de pagamento) uma imagem | 5 |
| RF5   | O usuário deve ter a capacidade baixar uma imagem no especificações escolhidas | 5 |
| RF6   | O usuário deve ter a capacidade curtir uma imagem | 2 | 
| RF7   | O sistema deve redimensionar automaticamente as imagens para sua visualização adequada no frontend, garantindo uma experiência de usuário consistente. | 5 | 
| RF8   | O sistema deve redimensionar automaticamente as imagens para sua visualização adequada no frontend, garantindo uma experiência de usuário consistente. | 5 | 
| RF9   | Todas as imagens visualizadas no frontend devem ser exibidas com uma marca d'água, protegendo os direitos autorais e a propriedade intelectual. | 5 | 

## Requisitos de assinatura
| Nº RF | Requisito | Descrição | Prioridade |
|-------|-----------|-----------|------------|
| RF1   | O sistema deve oferecer diferentes tipos de assinaturas, cada uma com um número específico de downloads permitidos e opções de manipulação do tempo entre os downloads. | 4 |
| RF2   | Os usuários devem poder contratar uma assinatura mensal, concedendo acesso aos recursos e benefícios associados à sua escolha de plano. | 4 |
| RF3   | Os usuários devem poder atualizar os seus planos de assinatura | 3 |


## Requisitos de segurança

| Nº RF | Requisito | Descrição | Prioridade |
|-------|-----------|-----------|------------|
| RF1   | Autenticação de todos os usuários | Dado a necessidade de segurança tanto das imagens da aplicação quanto das transações realizadas dentro da plataforma, é necessário que a aplicação realize autenticação dos usuários para que eles possam ter acesso aos serviços fornecidos, para usuários não autenticados a aplicação não permitirá ações que possam comprometer a integridade dos dados e dos outros clientes. | 5 |
| RF2   | Suporte a múltiplos métodos de autenticação | É necessário garantir que os usuários possam fazer o processo de autenticação de formas diversas tais quais: o cadastro padrão da aplicação, autenticação de dois fatores e autenticação por meio de terceiros como conta do Google e de redes sociais. | 4 |
| RF3   | Integridade dos diferentes níveis de acesso | Considerando a característica da aplicação de possuir diferentes tipos e níveis de assinatura, é de suma importância que os níveis de acesso para cada usuário sejam bem definidos e protegidos para garantir que imagens do cliente não possam ter sua integridade violada. Ademais, é de suma importância garantir que apenas o usuário administrador possa ter interações mais complexas com esses dados audiovisuais. | 5 |
| RF4   | Criptografia de informações confidenciais | É de suma importância garantir que informações confidenciais e/ou sensíveis sejam criptografadas em seu armazenamento e enquanto estiverem em trânsito, assim garantindo sua segurança mesmo sob caso de acesso indevido. | 4 |
| RF5   | Uso de protocolos de comunicação seguros | O uso de protocolos de comunicação seguros como o HTTPS é de vital importância para qualquer aplicação por garantir a integridade e segurança do transporte de dados no ambiente web. | 4 |
| RF6   | Restrição de acesso a informações confidenciais | Dado a natureza de múltiplas assinaturas e da existência de um administrador, é importante garantir que existam restrições de acesso às informações da aplicação, assim garantindo a integração do sistema | 5 |
| RF7   | Detecção e registro de alterações nos dados | O registro das alterações nos dados é uma boa prática para uma estrutura de banco de dados para garantir que as modificações possam ser monitoradas e validadas. | 3 |
| RF8   | Recuperação de dados em caso de perda ou corrupção | É importante garantir que seja possível recuperar informações do banco de dados caso ocorra algum tipo de corrupção dos dados. Em geral, isso é feito através do registro dos dados em tabelas de backup e registros de logs | 3 |
| RF9  | Prevenção de ataques de injeção de SQL | Sendo o injection uma das falhas de segurança mais comuns em aplicações web segundo o OWASP, sendo assim, é de suma importância adicionar verificações tanto no frontend quanto no backend para evitar que comandos SQL e JavaScript possam ser injetados na aplicação. | 5 |


