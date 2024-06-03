## Visão Geral
O projeto 4images utiliza um modelo de banco de dados relacional para gerenciar dados e os relacionamentos entre as entidades de dados de forma eficiente. Este modelo é representado por meio de uma coleção de tabelas, cada uma cumprindo um papel específico dentro da estrutura geral do banco de dados. As seções a seguir descrevem o propósito e a estrutura de cada tabela dentro do esquema do banco de dados.

## Importância da Modelagem de Dados

A modelagem de dados é uma etapa essencial no desenvolvimento de um projeto, pois visa transformar uma ideia conceitual em algo que possa ser traduzido em termos computacionais. Assim como no planejamento de uma viagem onde se define o que levar, o roteiro e o meio de transporte, no desenvolvimento de um projeto é crucial planejar todas as etapas, especialmente a usabilidade e a estruturação do banco de dados. Técnicas de modelagem de dados ajudam a garantir que a estrutura do banco de dados seja adequada para atender às necessidades do projeto, facilitando o gerenciamento e o acesso aos dados de maneira eficiente e segura.  

![Modegem do Banco de Dados 4images](/img/modelagemDb4images.png)
## Análise do Esquema do Banco de Dados

### Tabela de Usuários
**Nome da Tabela:** `users`

- **Descrição:** Armazena informações dos usuários, incluindo detalhes de autenticação e histórico de transações.
- **Colunas:**
  - `id` (bigint, PK): Identificador único para cada usuário.
  - `fullname` (varchar): Nome completo do usuário.
  - `username` (varchar): Nome de usuário escolhido.
  - `email` (varchar): Endereço de email do usuário.
  - `password` (varchar): Senha do usuário.
  - `signature` (enum): Tipo de assinatura do usuário.
  - `n_transc_last_month` (bigint): Número de transações realizadas pelo usuário no último mês.
  - `date_first_transac` (datetime): Data da primeira transação do usuário.

### Tabela de Curtidas de Usuário
**Nome da Tabela:** `user_curtida_img`

- **Descrição:** Registra quais usuários curtiram imagens específicas e o horário da curtida.
- **Colunas:**
  - `id` (bigint, PK): Identificador único para cada registro.
  - `FK_user` (bigint, FK): Chave estrangeira referenciando a tabela `users`.
  - `FK_img` (bigint, FK): Chave estrangeira referenciando a tabela `blobs`.
  - `time_it_was_liked` (datetime): Data e hora em que a curtida foi feita.

### Tabela de Transações
**Nome da Tabela:** `transactions`

- **Descrição:** Registra todas as transações de compra realizadas pelos usuários.
- **Colunas:**
  - `id` (bigint, PK): Identificador único para cada transação.
  - `FK_users` (bigint, FK): Chave estrangeira referenciando a tabela `users`.
  - `file` (varchar): Arquivo associado à transação.
  - `price` (bigint): Preço da transação.
  - `date` (datetime): Data da transação.

### Tabela de Assinaturas
**Nome da Tabela:** `signatures`

- **Descrição:** Gerencia as assinaturas dos usuários, incluindo o tipo e a duração de cada assinatura.
- **Colunas:**
  - `id` (bigint, PK): Identificador único para cada assinatura.
  - `FK_user` (bigint, FK): Chave estrangeira referenciando a tabela `users`.
  - `type` (enum): Tipo de assinatura.
  - `date_start` (datetime): Data de início da assinatura.
  - `date_end` (datetime): Data de término da assinatura.

### Tabela de Blobs
**Nome da Tabela:** `blobs`

- **Descrição:** Armazena metadados sobre as imagens, incluindo identificadores de armazenamento na nuvem e estatísticas de uso.
- **Colunas:**
  - `id` (bigint, PK): Identificador único para cada blob.
  - `id_blob` (bigint): Identificador para a localização de armazenamento na nuvem.
  - `name` (varchar): Nome da imagem.
  - `n_downloads` (bigint): Número de vezes que a imagem foi baixada.
  - `n_like` (bigint): Número de curtidas que a imagem recebeu.
  - `description` (varchar): Descrição da imagem.

### Tabela de Downloads de Arquivos
**Nome da Tabela:** `file_downloads`

- **Descrição:** Acompanha os downloads de arquivos pelos usuários para fins administrativos e limites de download.
- **Colunas:**
  - `id` (bigint, PK): Identificador único para cada registro de download.
  - `file` (varchar): Nome do arquivo baixado.
  - `date` (datetime): Data do download.
  - `n_downloads` (bigint): Número de downloads do arquivo.
  - `FK_transaction` (bigint, FK): Chave estrangeira referenciando a tabela `transactions`.
  - `FK_signature` (bigint, FK): Chave estrangeira referenciando a tabela `signatures`.

### Tabela de Coleções
**Nome da Tabela:** `collections`

- **Descrição:** Organiza imagens em coleções, que podem ser vendidas como um conjunto.
- **Colunas:**
  - `id` (bigint, PK): Identificador único para cada coleção.
  - `FK_image` (bigint, FK): Chave estrangeira referenciando a tabela `blobs`.
  - `name` (varchar): Nome da coleção.
  - `price` (bigint): Preço da coleção.
  - `n_images` (bigint): Número de imagens na coleção.
  - `n_likes` (bigint): Número de curtidas que a coleção recebeu.
