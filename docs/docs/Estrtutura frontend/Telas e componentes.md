## Documento de Desenvolvimento de Componentes e Telas

Este documento serve como um guia para o desenvolvimento de componentes e telas do projeto em React utilizando Styled Components. Abaixo, cada componente e tela é detalhado com sua descrição e orientações para desenvolvimento. No final, é apresentada a estrutura de pastas a ser seguida.

---

## **Componentes**

### 1. **NavBar**
   - **Descrição:** Componente de navegação principal do site, presente em todas as páginas, exceto as de login e cadastro.
   - **Desenvolvimento:** 
     - **Entradas:** Nenhuma.
     - **Saídas:** Nenhuma.
     - **Instruções:** O componente deve incluir links para as principais seções do site (Início, Coleções, Curtidas e Transações), uma barra de pesquisa integrada, um ícone de perfil e a logo da empresa. Os links devem redirecionar o usuário para suas respectivas lojas. O ícone de usuário deve abrir um modal com as opções: Perfil e Sair (caso esteja cadastrado) ou Cadastro e Login (caso não esteja cadastrado). O ícone da empresa deve redirecionar para a Home Page. A barra de pesquisa é um componente separado.



### 2. **Barra de Pesquisa**
   - **Descrição:** Campo de input para o usuário buscar por imagens ou coleções, retornando resultados para a pesquisa.
   - **Desenvolvimento:**
     - **Entradas:** Uma string (texto digitado pelo usuário).
     - **Saídas:** Resultados filtrados (array de objetos de imagens/coleções) ou uma mensagem de 'nenhum resultado encontrado'.
     - **Instruções:** O componente deve ser integrado com o backend para filtrar os resultados conforme o usuário digita. Deve receber o input como texto, fazer as requisições para o backend e retornar os resultados mais adequados ou informar que não há resultados.



### 3. **Footer**
   - **Descrição:** Rodapé do site, com um texto que convida o usuário para um possível contato com o Admin.
   - **Desenvolvimento:** 
     - **Entradas:** Nenhuma.
     - **Saídas:** Nenhuma.
     - **Instruções:** O rodapé deve conter texto e um ícone do WhatsApp que redireciona o usuário para o WhatsApp do admin.


### 4. **Botão**
   - **Descrição:** Botão genérico reutilizável em diversas partes da aplicação.
   - **Desenvolvimento:**
     - **Entradas:** Uma string (texto do botão) e uma função (callback para a ação do botão).
     - **Saídas:** Nenhuma.
     - **Instruções:** O botão deve suportar diferentes funcionalidades (submit, redirecionar, etc.), estados (ativo, desativado, pressionado, hover) e estilos (personalizar tamanho, texto e cores).


### 5. **Filtro**
   - **Descrição:** Componente que permite ao usuário filtrar imagens por categorias, cores, etc.
   - **Desenvolvimento:**
     - **Entradas:** Uma string (nome do filtro).
     - **Saídas:** Uma string (valor do filtro aplicado).
     - **Instruções:** O filtro deve funcionar de maneira semelhante a um botão. Ele deve ser estilizado de acordo com as personalizações e retornar uma string que será usada para filtrar os resultados posteriormente.



### 6. **Botão com Link**
   - **Descrição:** Botão que faz parte do menu suspenso.
   - **Desenvolvimento:** 
     - **Entradas:** Uma string (texto do botão) e uma string (URL de redirecionamento).
     - **Saídas:** Nenhuma.
     - **Instruções:** O botão deve ter um efeito de hover e, ao ser clicado, redirecionar o usuário para a rota especificada.



### 7. **Texto Link**
   - **Descrição:** Links textuais que redirecionam o usuário para diferentes seções do site.
   - **Desenvolvimento:** 
     - **Entradas:** Uma string (texto do link) e uma string (URL de redirecionamento).
     - **Saídas:** Nenhuma.
     - **Instruções:** O link deve ser estilizado para se diferenciar de texto normal e ter estados de hover adequados.



### 8. **Filtros de Imagens**
   - **Descrição:** Filtros visuais aplicáveis às imagens exibidas (e.g., preto e branco, sépia).
   - **Desenvolvimento:**
     - **Entradas:** Nenhuma.
     - **Saídas:** Nenhuma.
     - **Instruções:** Os filtros devem ter um efeito de hover, mas não precisam de interação; eles servem apenas para exemplificar o filtro aplicado à imagem atual.


Aqui está o documento atualizado com as imagens convertidas para o formato Markdown e com tamanhos ajustados conforme especificado:

## **Componentes**

### 9. **Inputs**
   - **Descrição:** Campos de entrada de texto, números e outros dados.
   - **Desenvolvimento:**
     - **Entradas:** Variáveis de string, número ou outros tipos de dados, dependendo do tipo de input (text, password, email).
     - **Saídas:** O valor inserido pelo usuário.
     - **Instruções:** Os inputs devem ser estilizados de acordo com o design e incluir validações específicas para cada tipo.


### 10. **Esferas de Progresso**
   - **Descrição:** Indicadores circulares de progresso para mostrar o status de uma tarefa ou carregamento.
   - **Desenvolvimento:**
     - **Entradas:** Um número (percentual de progresso).
     - **Saídas:** Nenhuma.
     - **Instruções:** O componente deve ser animado e capaz de receber diferentes valores para indicar o progresso.


### 11. **Dropdown**
   - **Descrição:** Menu suspenso que exibe uma lista de opções ao ser clicado.
   - **Desenvolvimento:**
     - **Entradas:** Um array de strings (opções do dropdown).
     - **Saídas:** A opção selecionada (string).
     - **Instruções:** O componente deve suportar seleção única ou múltipla, com possibilidade de estilização personalizada.


### 12. **Modal Genérico**
   - **Descrição:** Componente de janela modal reutilizável para diferentes contextos.
   - **Desenvolvimento:**
     - **Entradas:** Uma string (título do modal) e um array de objetos (conteúdo do modal).
     - **Saídas:** Nenhuma.
     - **Instruções:** Implementar suporte para diversos tamanhos e tipos de conteúdo.

### 13. **Card Foto**
   - **Descrição:** Cartão que exibe uma foto com opções de descrição e download.
   - **Desenvolvimento:**
     - **Entradas:** Um objeto contendo uma imagem e uma string (descrição).
     - **Saídas:** Nenhuma.
     - **Instruções:** Deve haver suporte para visualização e download da imagem.

### 14. **Card Pedido**
   - **Descrição:** Cartão que exibe informações de um pedido realizado pelo usuário.
   - **Desenvolvimento:**
     - **Entradas:** Um objeto com os dados do pedido (ID, data, status, etc.).
     - **Saídas:** Nenhuma.
     - **Instruções:** O cartão deve exibir informações de status e ter um link para mais detalhes.

### 15. **Card Plano**
   - **Descrição:** Cartão que exibe detalhes sobre um plano de assinatura.
   - **Desenvolvimento:**
     - **Entradas:** Um objeto com detalhes do plano (nome, preço, benefícios).
     - **Saídas:** Nenhuma.
     - **Instruções:** Deve incluir opções para seleção do plano e exibir todos os benefícios de forma clara.

### 16. **Card Coleção**
   - **Descrição:** Cartão que exibe uma coleção de imagens com uma breve descrição.
   - **Desenvolvimento:**
     - **Entradas:** Um objeto com informações da coleção (nome, número de itens, imagem).
     - **Saídas:** Nenhuma.
     - **Instruções:** Deve permitir que o usuário clique para ver mais detalhes sobre a coleção.

---

## **Modais**

### 1. **Modal Imagem Selecionada**
   - **Descrição:** Modal que exibe uma imagem selecionada, com opções de download e descrição.
   - **Desenvolvimento:**
     - **Entradas:** Um objeto contendo a URL da imagem, a descrição, e um booleano indicando se o modal deve estar aberto.
     - **Saídas:** Nenhuma.
     - **Instruções:** Deve incluir um botão para fechar o modal, ser responsivo para diferentes tamanhos de tela, e permitir o download da imagem exibida.

   ![Modal Imagem Selecionada](assets/ModalImagem.png)

### 2. **Modal Plano**
   - **Descrição:** Modal que exibe informações detalhadas sobre os planos de assinatura, permitindo a seleção e confirmação do plano.
   - **Desenvolvimento:**
     - **Entradas:** Um objeto contendo os detalhes do plano (nome, preço, benefícios), e um booleano indicando se o modal deve estar aberto.
     - **Saídas:** Um objeto contendo as informações do plano selecionado quando o botão de confirmação for clicado.
     - **Instruções:** Deve incluir um botão de confirmação, ser responsivo, e suportar diferentes tipos de plano. O modal deve fechar automaticamente após a confirmação.

   ![Modal Plano](assets/ModalAssinaturas.png)

---

## **Telas**

### **Usuário**

1. **Tela Inicial**
   **Descrição:** Página principal do usuário com acesso rápido a coleções, imagens recomendadas, e filtros.
   ![Tela Inicial](assets/Usuario%20Tela%20Inicial.png)

2. **Tela Perfil**
   **Descrição:** Exibe informações do perfil do usuário, como nome, email, e planos de assinatura.
   ![Tela Perfil](assets/Usuario%20Tela%20Perfil.png)

3. **Tela Editar Perfil**
   **Descrição:** Permite ao usuário editar suas informações pessoais, como nome, email e foto de perfil.
   ![Tela Editar Perfil](assets/Usuario%20Tela%20Editar%20Perfil.png)

4. **Tela Pagamentos**
   **Descrição:** Exibe histórico de pagamentos, detalhes de transações, e opções de métodos de pagamento.
   ![Tela Pagamentos](assets/Usuario%20Tela%20Pagamentos.png)

5. **Tela Imagem Adquirida**
   **Descrição:** Mostra detalhes das imagens compradas pelo usuário, com opção para download.
   ![Tela Imagem Adquirida](assets/Usuario%20Tela%20Imagem%20Adquirida.png)

6. **Tela Pedidos**
   **Descrição:** Lista de pedidos realizados pelo usuário, com detalhes e status de cada um.
   ![Tela Pedidos](assets/Usuario%20Tela%20Pedidos.png)

7. **Tela Imagens Curtidas**
   **Descrição:** Exibe as imagens que o usuário marcou como curtidas, com opções para organizá-las ou adquirir.
   ![Tela Imagens Curtidas](assets/Usuario%20Tela%20Imagens%20Curtidas.png)

8. **Tela Coleções**
   **Descrição:** Página onde o usuário pode visualizar e gerenciar suas coleções de imagens.
   ![Tela Coleções](assets/Usuario%20Tela%20Colecoes.png)

9. **Tela Dúvidas**
   **Descrição:** Página FAQ para ajudar o usuário com perguntas frequentes e suporte.
   ![Tela Dúvidas](assets/Usuario%20Tela%20Duvidas.png)

### **Login**

1. **Tela Cadastro Infos**
   **Descrição:** Página para o usuário cadastrar suas informações pessoais ao criar uma conta.
   ![Tela Cadastro Infos](assets/Login%20Tela%20Cadastro%20Infos.png)

2. **Tela Cadastro Verificação**
   **Descrição:** Tela de verificação para confirmação do email ou telefone após o cadastro.
   ![Tela Cadastro Verificação](assets/Login%20Tela%20Cadastro%20Verificacao.png)

3. **Tela Cadastro Assinatura**
   **Descrição:** Permite ao usuário escolher um plano de assinatura durante o cadastro.
   ![Tela Cadastro Assinatura](assets/Login%20Tela%20Cadastro%20Assinatura.png)

4. **Tela Login**
   **Descrição:** Página para login do usuário, com campos para email e senha.
   ![Tela Login](assets/Login%20Tela%20Login-1.png)

5. **Tela Login Esqueceu a Senha**
   **Descrição:** Página para recuperação de senha, com envio de link de recuperação por email.
   ![Tela Login Esqueceu a Senha](assets/Login%20Tela%20Login%20Esqueceu%20a%20Senha.png)

### **Admin**

1. **Tela Inicial**
   **Descrição:** Dashboard inicial do administrador, com visão geral das atividades.
   ![Tela Inicial](assets/AdminTelaInicial.png)

2. **Tela Adicionar Fotos**
   **Descrição:** Interface para upload de novas imagens à plataforma, com categorização e tags.
   ![Tela Adicionar Fotos](assets/AdminTelaAdicionarFotos.png)

3. **Tela Dashboard**
   **Descrição:** Exibe gráficos e estatísticas sobre o uso da plataforma e desempenho de vendas.
   ![Tela Dashboard](assets/AdminTelaDashboard.png)

4. **Tela Assinaturas**
   **Descrição:** Gerenciamento de planos de assinatura, com opções para editar ou criar novos planos.
   ![Tela Assinaturas](assets/AdminTelaAssinaturas.png)

5. **Tela Criar Assinatura**
   **Descrição:** Interface específica para criação de novos planos de assinatura.
   ![Tela Criar Assinatura](assets/AdminTelaCriarAssinatura.png)

6. **Tela Editar Assinatura**
   **Descrição:** Página para editar detalhes de um plano de assinatura existente.
   ![Tela Editar Assinatura](assets/AdminTelaEditarAssinatura.png)

7. **Tela Relatório de Vendas**
   **Descrição:** Exibe relatórios detalhados sobre as vendas realizadas na plataforma.
   ![Tela Relatório de Vendas](assets/AdminTelaRelatorioVendas.png)

8. **Tela Coleções**
   **Descrição:** Gerenciamento de coleções de imagens, com opções para criar ou editar coleções.
   ![Tela Coleções](assets/AdminTelaColecoes.png)

9. **Tela Criar Coleções**
   **Descrição:** Interface para criar uma nova coleção de imagens.
   ![Tela Criar Coleções](assets/AdminTelaCriarColecoes.png)

10. **Tela Criar Coleção (a partir de seleção do feed)**
    **Descrição:** Permite ao administrador criar uma coleção selecionando imagens diretamente do feed.
    ![Tela Criar Coleção (a partir de seleção do feed)](assets/AdminTelaCriarColecao.png)

11. **Tela Coleção Selecionada**
    **Descrição:** Detalhes de uma coleção específica, com opções para editar ou adicionar imagens.
    ![Tela Coleção Selecionada](assets/AdminTelaColecaoSelecionada.png)

12. **Tela Adicionar Imagens à Coleção (a partir da coleção)**
    **Descrição:** Interface para adicionar novas imagens a uma coleção existente.
    ![Tela Adicionar Imagens à Coleção (a partir da coleção)](assets/AdminTelaAdicionarImagensColecao.png)

13. **Tela Adicionar Imagens à Coleções (a partir do feed)**
    **Descrição:** Similar à anterior, mas permite adicionar imagens a várias coleções a partir do feed.
    ![Tela Adicionar Imagens à Coleções (a partir do feed)](assets/AdminTelaAdicionarImagensColecoes.png)


---

## **Estrutura de Pastas**

A estrutura de pastas deve ser modular e organizada, facilitando a manutenção e desenvolvimento simultâneo por várias pessoas. Segue uma sugestão de estrutura:

```
src/
│
├── assets/                     # Arquivos estáticos como imagens, fontes, etc.
│   ├── images/
│   ├── fonts/
│   └── icons/
│
├── components/                 # Componentes reutilizáveis
│   ├── NavBar/
│   │   ├── NavBar.jsx
│   │   └── NavBar.test.jsx
│   ├── Footer/
│   │   ├── Footer.jsx
│   │   └── Footer.test.jsx
│   ├── Button/
│   │   ├── Button.jsx
│   │   └── Button.test.jsx
│   ├── Dropdown/
│   │   ├── Dropdown.jsx
│   │   └── Dropdown.test.jsx
│   ├── SearchBar/
│   │   ├── SearchBar.jsx
│   │   └── SearchBar.test.jsx
│   ├── Filters/
│   │   ├── Filters.jsx
│   │   └── Filters.test.jsx
│   ├── ProgressCircles/
│   │   ├── ProgressCircles.jsx
│   │   └── ProgressCircles.test.jsx
│   ├── ImageCard/
│   │   ├── ImageCard.jsx
│   │   └── ImageCard.test.jsx
│   ├── OrderCard/
│   │   ├── OrderCard.jsx
│   │   └── OrderCard.test.jsx
│   ├── PlanCard/
│   │   ├── PlanCard.jsx
│   │   └── PlanCard.test.jsx
│   ├── CollectionCard/
│   │   ├── CollectionCard.jsx
│   │   └── CollectionCard.test.jsx
│   ├── TextLink/
│   │   ├── TextLink.jsx
│   │   └── TextLink.test.jsx
│   ├── InputField/
│   │   ├── InputField.jsx
│   │   └── InputField.test.jsx
│   └── LinkButton/
│       ├── LinkButton.jsx
│       └── LinkButton.test.jsx
│
├── modals/                     # Componentes de modal
│   ├── GenericModal/
│   │   ├── GenericModal.jsx
│   │   └── GenericModal.test.jsx
│   ├── ImageModal/
│   │   ├── ImageModal.jsx
│   │   └── ImageModal.test.jsx
│   ├── SubscriptionModal/
│   │   ├── SubscriptionModal.jsx
│   │   └── SubscriptionModal.test.jsx
│   └── ChangePasswordModal/
│       ├── ChangePasswordModal.jsx
│       └── ChangePasswordModal.test.jsx
│
├── pages/                      # Páginas da aplicação
│   ├── User/
│   │   ├── HomePage/
│   │   │   ├── HomePage.jsx
│   │   │   └── HomePage.test.jsx
│   │   ├── ProfilePage/
│   │   │   ├── ProfilePage.jsx
│   │   │   └── ProfilePage.test.jsx
│   │   ├── EditProfilePage/
│   │   │   ├── EditProfilePage.jsx
│   │   │   └── EditProfilePage.test.jsx
│   │   ├── PaymentsPage/
│   │   │   ├── PaymentsPage.jsx
│   │   │   └── PaymentsPage.test.jsx
│   │   ├── AcquiredImagePage/
│   │   │   ├── AcquiredImagePage.jsx
│   │   │   └── AcquiredImagePage.test.jsx
│   │   ├── OrdersPage/
│   │   │   ├── OrdersPage.jsx
│   │   │   └── OrdersPage.test.jsx
│   │   ├── LikedImagesPage/
│   │   │   ├── LikedImagesPage.jsx
│   │   │   └── LikedImagesPage.test.jsx
│   │   ├── CollectionsPage/
│   │   │   ├── CollectionsPage.jsx
│   │   │   └── CollectionsPage.test.jsx
│   │   └── FaqPage/
│   │       ├── FaqPage.jsx
│   │       └── FaqPage.test.jsx
│   │
│   ├── Login/
│   │   ├── SignUpInfoPage/
│   │   │   ├── SignUpInfoPage.jsx
│   │   │   └── SignUpInfoPage.test.jsx
│   │   ├── SignUpVerificationPage/
│   │   │   ├── SignUpVerificationPage.jsx
│   │   │   └── SignUpVerificationPage.test.jsx
│   │   ├── SubscriptionSignUpPage/
│   │   │   ├── SubscriptionSignUpPage.jsx
│   │   │   └── SubscriptionSignUpPage.test.jsx
│   │   ├── LoginPage/
│   │   │   ├── LoginPage.jsx
│   │   │   └── LoginPage.test.jsx
│   │   └── ForgotPasswordPage/
│   │       ├── ForgotPasswordPage.jsx
│   │       └── ForgotPasswordPage.test.jsx
│   │
│   └── Admin/
│       ├── AdminHomePage/
│       │   ├── AdminHomePage.jsx
│       │   └── AdminHomePage.test.jsx
│       ├── AddPhotosPage/
│       │   ├── AddPhotosPage.jsx
│       │   └── AddPhotosPage.test.jsx
│       ├── DashboardPage/
│       │   ├── DashboardPage.jsx
│       │   └── DashboardPage.test.jsx
│       ├── SubscriptionsPage/
│       │   ├── SubscriptionsPage.jsx
│       │   └── SubscriptionsPage.test.jsx
│       ├── CreateSubscriptionPage/
│       │   ├── CreateSubscriptionPage.jsx
│       │   └── CreateSubscriptionPage.test.jsx
│       ├── EditSubscriptionPage/
│       │   ├── EditSubscriptionPage.jsx
│       │   └── EditSubscriptionPage.test.jsx
│       ├── SalesReportPage/
│       │   ├── SalesReportPage.jsx
│       │   └── SalesReportPage.test.jsx
│       ├── CollectionsPage/
│       │   ├── CollectionsPage.jsx
│       │   └── CollectionsPage.test.jsx
│       ├── CreateCollectionPage/
│       │   ├── CreateCollectionPage.jsx
│       │   └── CreateCollectionPage.test.jsx
│       ├── SelectedCollectionPage/
│       │   ├── SelectedCollectionPage.jsx
│       │   └── SelectedCollectionPage.test.jsx
│       ├── AddImagesToCollectionPage/
│       │   ├── AddImagesToCollectionPage.jsx
│       │   └── AddImagesToCollectionPage.test.jsx
│       └── AddImagesToCollectionsFromFeedPage/
│           ├── AddImagesToCollectionsFromFeedPage.jsx
│           └── AddImagesToCollectionsFromFeedPage.test.jsx
│
├── utils/                      # Funções utilitárias e helpers
│   ├── formatDate.js
│   └── api.js
│
├── hooks/                      # Custom hooks
│   ├── useFetch.js
│   └── useAuth.js
│
├── context/                    # Context API para gerenciamento de estado
│   ├── AuthContext.js
│   ├── CartContext.js
│   └── ThemeContext.js
│
├── services/                   # Serviços para chamadas de API
│   ├── authService.js
│   ├── userService.js
│   ├── productService.js
│   └── adminService.js
│
├── styles/                     # Estilos globais e temas
│   ├── GlobalStyle.js
│   └── theme.js
│
├── App.jsx                     # Componente principal da aplicação
├── index.js                    # Ponto de entrada da aplicação
└── setupTests.js               # Configuração para testes

```