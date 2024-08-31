## Documento de Desenvolvimento de Componentes e Telas

Este documento serve como um guia para o desenvolvimento de componentes e telas do projeto em React utilizando Styled Components. Abaixo, cada componente e tela é detalhado com sua descrição e orientações para desenvolvimento. No final, é apresentada a estrutura de pastas a ser seguida.

---

## **Componentes**

### 1. **NavBar**
   - **Descrição:** Componente de navegação principal do site, presente em todas as páginas.
   - **Desenvolvimento:** Deve incluir links para as principais seções do site (Início, Coleções, Curtidas e Transações), uma barra de pesquisa integrada, um Ícone de perfil e a Logo da empresa.

### 2. **Barra de Pesquisa**
   - **Descrição:** Campo de input para o usuário buscar por imagens ou coleções.
   - **Desenvolvimento:** Integrar com o backend para filtrar resultados conforme o usuário digita.

### 3. **Footer**
   - **Descrição:** Rodapé do site, com links para páginas de termos de serviço, política de privacidade, redes sociais, etc.
   - **Desenvolvimento:** Estático, mas deve ser responsivo.

### 4. **Botão**
   - **Descrição:** Botão genérico reutilizável em diversas partes da aplicação.
   - **Desenvolvimento:** Deve suportar diferentes estados (ativo, desativado, pressionado) e estilos (personalizar tamanho, texto e cores).

### 5. **Filtro**
   - **Descrição:** Componentes que permitem ao usuário filtrar imagens por categorias, cores, etc.
   - **Desenvolvimento:** Um componente semelhante ao botão que vai ter somente um nome, que permitirá o sistema de busca ser dinâmico.

### 6. **Botão com Link**
   - **Descrição:** Botão que está em um menu suspenso.
   - **Desenvolvimento:** Ele possui hover.

### 7. **Texto Link**
   - **Descrição:** Links textuais que redirecionam o usuário para diferentes seções do site.
   - **Desenvolvimento:** Estilizar para diferenciar de texto normal e implementar estados de hover.

### 8. **Filtros de Imagens**
   - **Descrição:** Filtros visuais aplicáveis às imagens exibidas (e.g., preto e branco, sépia).

### 9. **Inputs**
   - **Descrição:** Campos de entrada de texto, números, e outros dados.
   - **Desenvolvimento:** Diferentes tipos de inputs (text, password, email) com estilos e validações específicas.

### 10. **Esferas de Progresso**
   - **Descrição:** Indicadores circulares de progresso para mostrar o status de uma tarefa ou carregamento.
   - **Desenvolvimento:** Deve ser animado e capaz de receber diferentes valores para indicar o progresso.

### 11. **Dropdown**
   - **Descrição:** Menu suspenso que exibe uma lista de opções ao ser clicado.
   - **Desenvolvimento:** Deve suportar seleção única ou múltipla, com possibilidade de estilização personalizada.

### 12. **Modal Genérico**
   - **Descrição:** Componente de janela modal reutilizável para diferentes contextos.
   - **Desenvolvimento:** Implementar com fundo escurecido e suporte para diversos tamanhos e tipos de conteúdo.

### 13. **Card Foto**
   - **Descrição:** Cartão que exibe uma foto com opções de descrição e download.
   - **Desenvolvimento:** Estilizar para que seja responsivo e incluíra botões para download e visualização de detalhes.

### 14. **Card Pedido**
   - **Descrição:** Cartão que exibe detalhes de um pedido realizado pelo usuário.
   - **Desenvolvimento:** Incluir informações como data do pedido, status, e botão para detalhes.

### 15. **Card Plano**
   - **Descrição:** Cartão que exibe informações sobre os planos de assinatura.
   - **Desenvolvimento:** Deve incluir detalhes como preço, benefícios e opção para selecionar o plano.

### 16. **Card Coleção**
   - **Descrição:** Cartão que exibe uma coleção de imagens, com opção para visualização completa.
   - **Desenvolvimento:** Deve ser clicável e exibir uma pré-visualização das imagens da coleção.

---

## **Modais**

### 1. **Modal Imagem Selecionada**
   - **Descrição:** Modal que exibe uma imagem selecionada, com opções de download e descrição.
   - **Desenvolvimento:** Deve incluir um botão para fechar o modal e ser responsivo.

### 2. **Modal Assinaturas**
   - **Descrição:** Modal para assinaturas do usuário, com opções para assinar ou não.

### 3. **Modal Alterar Senha**
   - **Descrição:** Modal que permite ao usuário alterar sua senha.
   - **Desenvolvimento:** Deve incluir campos de input para a senha atual e nova senha, com validação.

---

## **Telas**

### **Usuário**

1. **Tela Inicial**
   - **Descrição:** Página principal do usuário com acesso rápido a coleções, imagens recomendadas, e filtros.

2. **Tela Perfil**
   - **Descrição:** Exibe informações do perfil do usuário, como nome, email, e planos de assinatura.

3. **Tela Editar Perfil**
   - **Descrição:** Permite ao usuário editar suas informações pessoais, como nome, email e foto de perfil.

4. **Tela Pagamentos**
   - **Descrição:** Exibe histórico de pagamentos, detalhes de transações, e opções de métodos de pagamento.

5. **Tela Imagem Adquirida**
   - **Descrição:** Mostra detalhes das imagens compradas pelo usuário, com opção para download.

6. **Tela Pedidos**
   - **Descrição:** Lista de pedidos realizados pelo usuário, com detalhes e status de cada um.

7. **Tela Imagens Curtidas**
   - **Descrição:** Exibe as imagens que o usuário marcou como curtidas, com opções para organizá-las ou adquirir.

8. **Tela Coleções**
   - **Descrição:** Página onde o usuário pode visualizar e gerenciar suas coleções de imagens.

9. **Tela Dúvidas**
   - **Descrição:** Página FAQ para ajudar o usuário com perguntas frequentes e suporte.

### **Login**

1. **Tela Cadastro Infos**
   - **Descrição:** Página para o usuário cadastrar suas informações pessoais ao criar uma conta.

2. **Tela Cadastro Verificação**
   - **Descrição:** Tela de verificação para confirmação do email ou telefone após o cadastro.

3. **Tela Cadastro Assinatura**
   - **Descrição:** Permite ao usuário escolher um plano de assinatura durante o cadastro.

4. **Tela Login**
   - **Descrição:** Página para login do usuário, com campos para email e senha.

5. **Tela Login Esqueceu a Senha**
   - **Descrição:** Página para recuperação de senha, com envio de link de recuperação por email.

### **Admin**

1. **Tela Inicial**
   - **Descrição:** Dashboard inicial do administrador, com visão geral das atividades.

2. **Tela Adicionar Fotos**
   - **Descrição:** Interface para upload de novas imagens à plataforma, com categorização e tags.

3. **Tela Dashboard**
   - **Descrição:** Exibe gráficos e estatísticas sobre o uso da plataforma e desempenho de vendas.

4. **Tela Assinaturas**
   - **Descrição:** Gerenciamento de planos de assinatura, com opções para editar ou criar novos planos.

5. **Tela Criar Assinatura**
   - **Descrição:** Interface específica para criação de novos planos de assinatura.

6. **Tela Editar Assinatura**
   - **Descrição:** Página para editar detalhes de um plano de assinatura existente.

7. **Tela Relatório de Vendas**
   - **Descrição:** Exibe relatórios detalhados sobre as vendas realizadas na plataforma.

8. **Tela Coleções**
   - **Descrição:** Gerenciamento de coleções de imagens, com opções para criar ou editar coleções.

9. **Tela Criar Coleções**
   - **Descrição:** Interface para criar uma nova coleção de imagens.

10. **Tela Criar Coleção (a partir de seleção do feed)**
    - **Descrição:** Permite ao administrador criar uma coleção selecionando imagens diretamente do feed.

11. **Tela Coleção Selecionada**
    - **Descrição:** Detalhes de uma coleção específica, com opções para editar ou adicionar imagens.

12. **Tela Adicionar Imagens à Coleção (a partir da coleção)**
    - **Descrição:** Interface para adicionar novas imagens a uma coleção existente.

13. **Tela Adicionar Imagens à Coleções (a partir do feed)**
    - **Descrição:** Similar à anterior, mas permite adicionar imagens a várias coleções a partir do feed.

14. **Tela Dúvidas**
   - **Descrição:** Página de perguntas frequentes para o administrador.

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
│   │   ├── NavBar.styled.js
│   │   └── NavBar.test.jsx
│   ├── Footer/
│   │   ├── Footer.jsx
│   │   ├── Footer.styled.js
│   │   └── Footer.test.jsx
│   ├── Button/
│   │   ├── Button.jsx
│   │   ├── Button.styled.js
│   │   └── Button.test.jsx
│   ├── Dropdown/
│   │   ├── Dropdown.jsx
│   │   ├── Dropdown.styled.js
│   │   └── Dropdown.test.jsx
│   ├── SearchBar/
│   │   ├── SearchBar.jsx
│   │   ├── SearchBar.styled.js
│   │   └── SearchBar.test.jsx
│   ├── Filters/
│   │   ├── Filters.jsx
│   │   ├── Filters.styled.js
│   │   └── Filters.test.jsx
│   ├── ProgressCircles/
│   │   ├── ProgressCircles.jsx
│   │   ├── ProgressCircles.styled.js
│   │   └── ProgressCircles.test.jsx
│   ├── ImageCard/
│   │   ├── ImageCard.jsx
│   │   ├── ImageCard.styled.js
│   │   └── ImageCard.test.jsx
│   ├── OrderCard/
│   │   ├── OrderCard.jsx
│   │   ├── OrderCard.styled.js
│   │   └── OrderCard.test.jsx
│   ├── PlanCard/
│   │   ├── PlanCard.jsx
│   │   ├── PlanCard.styled.js
│   │   └── PlanCard.test.jsx
│   ├── CollectionCard/
│   │   ├── CollectionCard.jsx
│   │   ├── CollectionCard.styled.js
│   │   └── CollectionCard.test.jsx
│   ├── TextLink/
│   │   ├── TextLink.jsx
│   │   ├── TextLink.styled.js
│   │   └── TextLink.test.jsx
│   ├── InputField/
│   │   ├── InputField.jsx
│   │   ├── InputField.styled.js
│   │   └── InputField.test.jsx
│   └── LinkButton/
│       ├── LinkButton.jsx
│       ├── LinkButton.styled.js
│       └── LinkButton.test.jsx
│
├── modals/                     # Componentes de modal
│   ├── GenericModal/
│   │   ├── GenericModal.jsx
│   │   ├── GenericModal.styled.js
│   │   └── GenericModal.test.jsx
│   ├── ImageModal/
│   │   ├── ImageModal.jsx
│   │   ├── ImageModal.styled.js
│   │   └── ImageModal.test.jsx
│   ├── SubscriptionModal/
│   │   ├── SubscriptionModal.jsx
│   │   ├── SubscriptionModal.styled.js
│   │   └── SubscriptionModal.test.jsx
│   └── ChangePasswordModal/
│       ├── ChangePasswordModal.jsx
│       ├── ChangePasswordModal.styled.js
│       └── ChangePasswordModal.test.jsx
│
├── pages/                      # Páginas da aplicação
│   ├── User/
│   │   ├── HomePage/
│   │   │   ├── HomePage.jsx
│   │   │   ├── HomePage.styled.js
│   │   │   └── HomePage.test.jsx
│   │   ├── ProfilePage/
│   │   │   ├── ProfilePage.jsx
│   │   │   ├── ProfilePage.styled.js
│   │   │   └── ProfilePage.test.jsx
│   │   ├── EditProfilePage/
│   │   │   ├── EditProfilePage.jsx
│   │   │   ├── EditProfilePage.styled.js
│   │   │   └── EditProfilePage.test.jsx
│   │   ├── PaymentsPage/
│   │   │   ├── PaymentsPage.jsx
│   │   │   ├── PaymentsPage.styled.js
│   │   │   └── PaymentsPage.test.jsx
│   │   ├── AcquiredImagePage/
│   │   │   ├── AcquiredImagePage.jsx
│   │   │   ├── AcquiredImagePage.styled.js
│   │   │   └── AcquiredImagePage.test.jsx
│   │   ├── OrdersPage/
│   │   │   ├── OrdersPage.jsx
│   │   │   ├── OrdersPage.styled.js
│   │   │   └── OrdersPage.test.jsx
│   │   ├── LikedImagesPage/
│   │   │   ├── LikedImagesPage.jsx
│   │   │   ├── LikedImagesPage.styled.js
│   │   │   └── LikedImagesPage.test.jsx
│   │   ├── CollectionsPage/
│   │   │   ├── CollectionsPage.jsx
│   │   │   ├── CollectionsPage.styled.js
│   │   │   └── CollectionsPage.test.jsx
│   │   └── FaqPage/
│   │       ├── FaqPage.jsx
│   │       ├── FaqPage.styled.js
│   │       └── FaqPage.test.jsx
│   │
│   ├── Login/
│   │   ├── SignUpInfoPage/
│   │   │   ├── SignUpInfoPage.jsx
│   │   │   ├── SignUpInfoPage.styled.js
│   │   │   └── SignUpInfoPage.test.jsx
│   │   ├── SignUpVerificationPage/
│   │   │   ├── SignUpVerificationPage.jsx
│   │   │   ├── SignUpVerificationPage.styled.js
│   │   │   └── SignUpVerificationPage.test.jsx
│   │   ├── SubscriptionSignUpPage/
│   │   │   ├── SubscriptionSignUpPage.jsx
│   │   │   ├── SubscriptionSignUpPage.styled.js
│   │   │   └── SubscriptionSignUpPage.test.jsx
│   │   ├── LoginPage/
│   │   │   ├── LoginPage.jsx
│   │   │   ├── LoginPage.styled.js
│   │   │   └── LoginPage.test.jsx
│   │   └── ForgotPasswordPage/
│   │       ├── ForgotPasswordPage.jsx
│   │       ├── ForgotPasswordPage.styled.js
│   │       └── ForgotPasswordPage.test.jsx
│   │
│   └── Admin/
│       ├── AdminHomePage/
│       │   ├── AdminHomePage.jsx
│       │   ├── AdminHomePage.styled.js
│       │   └── AdminHomePage.test.jsx
│       ├── AddPhotosPage/
│       │   ├── AddPhotosPage.jsx
│       │   ├── AddPhotosPage.styled.js
│       │   └── AddPhotosPage.test.jsx
│       ├── DashboardPage/
│       │   ├── DashboardPage.jsx
│       │   ├── DashboardPage.styled.js
│       │   └── DashboardPage.test.jsx
│       ├── SubscriptionsPage/
│       │   ├── SubscriptionsPage.jsx
│       │   ├── SubscriptionsPage.styled.js
│       │   └── SubscriptionsPage.test.jsx
│       ├── CreateSubscriptionPage/
│       │   ├── CreateSubscriptionPage.jsx
│       │   ├── CreateSubscriptionPage.styled.js
│       │   └── CreateSubscriptionPage.test.jsx
│       ├── EditSubscriptionPage/
│       │   ├── EditSubscriptionPage.jsx
│       │   ├── EditSubscriptionPage.styled.js
│       │   └── EditSubscriptionPage.test.jsx
│       ├── SalesReportPage/
│       │   ├── SalesReportPage.jsx
│       │   ├── SalesReportPage.styled.js
│       │   └── SalesReportPage.test.jsx
│       ├── CollectionsPage/
│       │   ├── CollectionsPage.jsx
│       │   ├── CollectionsPage.styled.js
│       │   └── CollectionsPage.test.jsx
│       ├── CreateCollectionPage/
│       │   ├── CreateCollectionPage.jsx
│       │   ├── CreateCollectionPage.styled.js
│       │   └── CreateCollectionPage.test.jsx
│       ├── SelectedCollectionPage/
│       │   ├── SelectedCollectionPage.jsx
│       │   ├── SelectedCollectionPage.styled.js
│       │   └── SelectedCollectionPage.test.jsx
│       ├── AddImagesToCollectionPage/
│       │   ├── AddImagesToCollectionPage.jsx
│       │   ├── AddImagesToCollectionPage.styled.js
│       │   └── AddImagesToCollectionPage.test.jsx
│       └── AddImagesToCollectionsFromFeedPage/
│           ├── AddImagesToCollectionsFromFeedPage.jsx
│           ├── AddImagesToCollectionsFromFeedPage.styled.js
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