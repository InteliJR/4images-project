### Introdução
Este manual tem como objetivo fornecer um guia detalhado para aprender React, desde os fundamentos básicos até tópicos avançados. O roadmap está dividido em várias seções, cada uma abordando um conjunto específico de conceitos e práticas. 

### 1. Conceitos Fundamentais

**1.1. O que é React?**

React é uma biblioteca JavaScript desenvolvida para construir interfaces de usuário (UIs) de forma eficiente e modular. Ela facilita a criação de componentes reutilizáveis que podem gerenciar seu próprio estado, permitindo a construção de interfaces complexas a partir de blocos simples e isolados.
- Criação: React foi criado pelo Facebook e lançado publicamente em 2013. Jordan Walke, um engenheiro de software do Facebook, é creditado pela sua criação.
- Motivação: A principal motivação para o desenvolvimento do React foi a necessidade de simplificar o processo de construção de UIs dinâmicas e de alto desempenho, especialmente em aplicações web onde a atualização eficiente do DOM (Document Object Model) é crucial.

- Componentização: Facilita a reutilização de código e Promove uma organização mais clara e modular do código.

- Virtual DOM: Melhor desempenho em atualização e renderização de UIs e Reduz o número de manipulações diretas do DOM real, economizando tempo e recursos.

**1.2. Configuração do Ambiente**
- **Node.js**: Instale a última versão do Node.js e npm (gerenciador de pacotes do Node). <a href="https://nodejs.org/dist/v20.14.0/node-v20.14.0-x64.msi">Link para download aqui</a>
- **React App Utilizando Vite**: Ferramenta utilizada para facilitar a inicialização de um projeto.
  ```bash
  npm create vite@latest
  cd "nome do app"
  npm i
  npm run dev
  ```
- **Editor de Código**: VSCode é uma escolha popular.

**1.3. JSX**
- Sintaxe: JSX permite misturar código JavaScript com tags HTML-like. Isso significa que você pode escrever elementos HTML dentro de um arquivo JavaScript, proporcionando uma experiência de desenvolvimento mais intuitiva, especialmente para quem está acostumado com HTML.

- Exemplo:
  ```jsx
  const element = <h1>Hello, world!</h1>;
  ```

  Neste exemplo:

  `const element` é uma declaração de variável em JavaScript.
  
  `<h1>Hello, world!</h1>` é uma tag JSX que se assemelha a uma tag HTML.

### 2. Componentes

**2.1. Componentes Funcionais**
- Definição: Os componentes funcionais são a base para construir interfaces no React. Eles são simplesmente funções JavaScript que retornam elementos React. Esses elementos são o que o React irá renderizar na tela.
  ```jsx
    // Importando o React (necessário para usar JSX)
    import React from 'react';

    // Definição de um componente funcional chamado 'Welcome'
    // Este componente aceita 'props' como seu argumento e retorna um elemento JSX
    function Welcome(props) {
    // Acessando a propriedade 'name' passada para o componente
    // e usando-a dentro de uma tag <h1> para exibir uma mensagem de boas-vindas
    return <h1>Olá, {props.name}!</h1>;
    }

    // Uso do componente 'Welcome' em outro componente ou aplicativo
    // Aqui, estamos passando a propriedade 'name' com o valor 'Mundo'
    // O resultado será a renderização do texto "Olá, Mundo!" na tela
    function App() {
    return <Welcome name="Mundo" />;
    }

    // Exportando o componente 'App' para que possa ser usado em outras partes do aplicativo
    export default App;
    ```

**2.2. Componentes de Classe**
- Definição: Componentes de classe são uma forma mais tradicional de declarar componentes no React. Eles são definidos estendendo a classe `React.Component` e criam uma instância de um componente que mantém o estado e pode ter vários métodos de ciclo de vida para gerenciar esse estado e reagir a eventos do ciclo de vida do componente.
    ```jsx
    // Importando o React e o componente base
    import React from 'react';

    // Definição de um componente de classe chamado 'Welcome'
    // Este componente herda de 'React.Component'
    class Welcome extends React.Component {
        // O método 'render' é obrigatório em componentes de classe
        // e é usado para retornar o elemento JSX que será renderizado
        render() {
            // Acessando a propriedade 'name' passada para o componente
            // e usando-a dentro de uma tag <h1> para exibir uma mensagem de boas-vindas
            return <h1>Olá, {this.props.name}</h1>;
        }
    }

    // Uso do componente 'Welcome' em outro componente ou aplicativo
    // Aqui, estamos passando a propriedade 'name' com o valor 'Mundo'
    // O resultado será a renderização do texto "Olá, Mundo!" na tela
    function App() {
        return <Welcome name="Mundo" />;
    }

    // Exportando o componente 'App' para que possa ser usado em outras partes do aplicativo
    export default App;
    ```

**2.3. Props**
- Definição: Props são argumentos passados para componentes React, funcionando como parâmetros de uma função. Elas permitem que dados sejam transferidos de um componente pai para um componente filho, facilitando a comunicação e o reuso de componentes.
- Passagem de dados: Props são passadas do componente pai para o filho, permitindo que o filho renderize dados dinâmicos fornecidos pelo pai. Elas são essenciais para a criação de componentes interativos e reutilizáveis.
  ```jsx
    function Welcome(props) {
    // Renderiza "Olá, Sara!" quando o componente 'Welcome' é utilizado
    return <h1>Olá, {props.name}!</h1>;
    }

    function App() {
    // O componente 'App' passa a prop 'name' com o valor 'Sara' para 'Welcome'
    return <Welcome name="Sara" />;
    }
  ```

**2.4. State**
- Definição: O state (estado) é um conjunto de dados que determina o comportamento e a aparência de um componente em um determinado momento. O state é gerenciado dentro do componente (diferente das props, que são passadas para o componente) e pode ser alterado ao longo do tempo, geralmente em resposta a ações do usuário ou eventos do sistema.
- Estado: O state é privado e totalmente controlado pelo componente. Quando o state de um componente é alterado, o componente responde renderizando-se novamente com os novos dados.
  ```jsx
    class Clock extends React.Component {
    // O construtor é o local onde você inicializa o estado do componente
    constructor(props) {
        super(props);
        // 'state' é um objeto onde você pode armazenar propriedades
        this.state = { date: new Date() };
    }

    // O método 'render' é chamado para renderizar o componente
    render() {
        // Acessa o estado atual usando 'this.state'
        return (
        <div>
            <h1>Olá, mundo!</h1>
            <h2>Agora são {this.state.date.toLocaleTimeString()}.</h2>
        </div>
        );
    }
    }
  ```

**2.5. Ciclo de Vida**
- Métodos: Os métodos de ciclo de vida são funções especiais em componentes de classe do React que são chamadas automaticamente durante as fases de montagem, atualização e desmontagem do componente. Eles são usados para executar código em momentos específicos do processo de vida do componente.
- componentDidMount: Chamado imediatamente após o componente ser inserido na árvore do DOM.
- componentDidUpdate: Chamado imediatamente após a atualização do componente, mas não para a primeira renderização.
- componentWillUnmount: Chamado imediatamente antes de um componente ser destruído e removido do DOM.- Exemplo:
  ```jsx
    class Clock extends React.Component {
    constructor(props) {
        super(props);
        this.state = { date: new Date() };
    }

    // 'componentDidMount' é usado para configurar um temporizador após o componente ser renderizado
    componentDidMount() {
        this.timerID = setInterval(
        () => this.tick(),
        1000 // Atualiza o componente a cada segundo
        );
    }

    // 'componentWillUnmount' é usado para limpar o temporizador antes do componente ser removido do DOM
    componentWillUnmount() {
        clearInterval(this.timerID);
    }

    // 'tick' é um método personalizado que atualiza o estado com a hora atual
    tick() {
        this.setState({
        date: new Date()
        });
    }

    render() {
        return (
        <div>
            <h1>Olá, mundo!</h1>
            <h2>Agora são {this.state.date.toLocaleTimeString()}.</h2>
        </div>
        );
    }
    }
  ```

Vamos simplificar a seção sobre Hooks para focar nos tópicos de definição, uso e exemplo expandido:


### 3. Hooks

Hooks no React são funções especiais que permitem que você "ancore" em recursos do estado e ciclo de vida do React a partir de componentes funcionais. Eles foram introduzidos na versão 16.8 para permitir que os componentes funcionais gerenciassem o estado e efeitos colaterais, que antes só eram possíveis em componentes de classe. Os Hooks mais comuns são o `useState` para gerenciar o estado local de um componente e o `useEffect` para operar efeitos colaterais, como chamadas de API ou subscrições. Eles são essenciais para escrever componentes funcionais concisos e reutilizáveis, mantendo a lógica relacionada agrupada e clara.

**3.1. useState**
- **Definição**: `useState` é um Hook que permite adicionar o estado do React a componentes funcionais. Ele retorna um par de valores: o estado atual e uma função que atualiza esse estado.
- **Uso**: Utilize `useState` quando precisar manter valores que devem persistir entre as renderizações do componente.
- **Exemplo Expandido**:
  ```jsx
  import React, { useState } from 'react';

  function Counter() {
    // Declara uma nova variável de estado, que chamaremos de 'count'
    // 'setCount' é a função que usaremos para atualizar o 'count'
    const [count, setCount] = useState(0);

    return (
      <div>
        <p>Você clicou {count} vezes</p>
        <button onClick={() => setCount(count + 1)}>
          Clique aqui
        </button>
      </div>
    );
  }
  ```

**3.2. useEffect**
- **Definição**: `useEffect` é um Hook que gerencia efeitos colaterais em componentes funcionais. É usado para operações como carregar dados, inscrições ou alterações manuais no DOM.
- **Uso**: Use `useEffect` para encapsular código que tem efeitos colaterais, que seriam colocados em métodos de ciclo de vida em componentes de classe.
- **Exemplo Expandido**:
  ```jsx
  import React, { useState, useEffect } from 'react';

  function Example() {
    const [count, setCount] = useState(0);

    // Similar a componentDidMount e componentDidUpdate:
    useEffect(() => {
      // Atualiza o título do documento usando a API do navegador
      document.title = `Você clicou ${count} vezes`;
    }, [count]); // Apenas re-executa o efeito se 'count' mudar

    return (
      <div>
        <p>Você clicou {count} vezes</p>
        <button onClick={() => setCount(count + 1)}>
          Clique aqui
        </button>
      </div>
    );
  }
  ```

**3.3. Custom Hooks**
- **Definição**: Custom Hooks são funções que permitem reutilizar lógica de estado e efeitos colaterais entre vários componentes.
- **Uso**: Crie Custom Hooks quando você identificar que a mesma lógica está sendo repetida em diferentes componentes.
- **Exemplo Expandido**:
  ```jsx
  import React, { useState, useEffect } from 'react';

  // Um Custom Hook é uma função JavaScript que começa com 'use'
  function useCustomHook() {
    const [someState, setSomeState] = useState(null);

    // Adicione toda a lógica que você deseja reutilizar aqui
    // ...

    return someState;
  }

  // Você pode usar seu Custom Hook como qualquer outro Hook
  function Example() {
    const someState = useCustomHook();
    // ...
  }
  ```

### 4. Roteamento

O roteamento no React é o processo de navegação entre diferentes partes (ou "rotas") de uma aplicação web sem a necessidade de recarregar a página. Isso é alcançado usando bibliotecas de roteamento como `react-router-dom`, que permitem definir rotas em sua aplicação React. Cada rota é associada a um componente React, que é renderizado quando o usuário navega para um determinado caminho URL. Por exemplo, você pode ter uma rota `/home` que renderiza um componente `HomePage` e uma rota `/about` que renderiza um `AboutPage`. O roteamento no React mantém a interface do usuário sincronizada com a URL, permitindo uma experiência de navegação fluida e eficiente, semelhante a uma aplicação de página única (SPA).

**4.1. React Router**
- **Definição**: React Router é uma biblioteca de roteamento padrão para React. Ela permite a implementação de navegação dinâmica em uma aplicação web de página única (SPA).

- **Instalação**: Para começar a usar o React Router, você precisa instalar o pacote `react-router-dom` usando o gerenciador de pacotes npm.
  ```bash
  npm install react-router-dom
  ```

- **Configuração Básica**: A configuração básica do React Router envolve a criação de um componente `Router` que define o mapeamento entre os caminhos de URL e os componentes React correspondentes.
  ```jsx
  import React from 'react';
  import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';

  // Componentes de página que você criou
  import Home from './Home';
  import About from './About';

  function App() {
    return (
      // O componente 'Router' envolve todos os componentes que precisam de roteamento
      <Router>
        {/* 'Switch' é usado para agrupar 'Route's e garantir que apenas um deles seja renderizado */}
        <Switch>
          {/* 'Route' define o caminho e o componente que deve ser renderizado */}
          <Route path="/about">
            <About />
          </Route>
          {/* O caminho '/' geralmente corresponde à página inicial */}
          <Route path="/">
            <Home />
          </Route>
        </Switch>
      </Router>
    );
  }

  export default App;
  ```

- **Dicas**:
  - **`<Switch>`**: Garante que apenas a primeira rota correspondente seja renderizada.
  - **`<Route>`**: Define o mapeamento entre o caminho da URL e o componente.
  - **`exact`**: Adicione a propriedade `exact` a `<Route>` para evitar que rotas mais específicas sejam ignoradas.

### 5. Estado Global

**5.1. Context API**
- **Definição**: A Context API é uma ferramenta do React que permite compartilhar dados globalmente entre componentes, sem a necessidade de passar props manualmente em todos os níveis da árvore de componentes.
- **Criação de contexto**:
  ```jsx
  // Criação de um novo contexto
  const MyContext = React.createContext(valorInicial);
  ```
- **Provider e Consumer**:
  ```jsx
  // O 'Provider' envolve os componentes que precisam acessar os dados do contexto
  <MyContext.Provider value={/* algum valor */}>
    // Componentes dentro do Provider terão acesso ao valor do contexto
    <MyComponent />
  </MyContext.Provider>
  ```

**5.2. Redux**
- **Definição**: Redux é uma biblioteca para gerenciamento de estado previsível em aplicações JavaScript. Ela ajuda a manter o estado da aplicação em um único lugar e permite um fluxo de dados consistente.
- **Instalação**:
  ```bash
  // Instalação do Redux e React Redux
  npm install redux react-redux
  ```
- **Configuração básica**:
  ```jsx
  // Importação das funções necessárias do Redux e React Redux
  import { createStore } from 'redux';
  import { Provider } from 'react-redux';

  // Criação da 'store' com um 'reducer'
  const store = createStore(reducer);

  // O componente 'Provider' envolve a aplicação e passa a 'store' para os componentes
  function App() {
    return (
      <Provider store={store}>
        // Componentes dentro do Provider terão acesso à 'store' do Redux
        <MyComponent />
      </Provider>
    );
  }
  ```

- **Dicas**:
  - **Contexto vs Redux**: Use a Context API para estados simples e globais e prefira Redux para estados mais complexos e para grandes aplicações.
  - **Reducers**: São funções puras que recebem o estado atual e uma ação, e retornam um novo estado.
  - **Actions**: São objetos que representam uma intenção de mudança de estado e são enviados para os reducers.


### 6. Integração com APIs

**6.1. Fetch API**
- **Definição**: A Fetch API é uma maneira nativa do JavaScript para realizar requisições HTTP. É usada para solicitar recursos de uma API ou servidor.
- **Utilização**:
  ```jsx
  import React, { useState, useEffect } from 'react';

  function DataFetcher() {
    const [data, setData] = useState(null);

    useEffect(() => {
      // 'fetch' é chamado com a URL da API
      fetch('https://api.example.com/data')
        // A resposta é convertida para JSON
        .then(response => response.json())
        // O estado 'data' é atualizado com os dados recebidos
        .then(data => setData(data));
    }, []); // O array vazio indica que o efeito será executado apenas uma vez

    // Renderização dos dados ou de um estado de carregamento
    return (
      <div>
        {data ? <div>{/* renderização dos dados */}</div> : <p>Carregando...</p>}
      </div>
    );
  }
  ```

**6.2. Axios**
- **Definição**: Axios é uma biblioteca cliente HTTP baseada em promessas que funciona tanto no navegador quanto em node.js. É frequentemente usada para realizar requisições HTTP de forma mais conveniente.
- **Instalação**:
  ```bash
  npm install axios
  ```
- **Utilização**:
  ```jsx
  import React, { useState, useEffect } from 'react';
  import axios from 'axios';

  function DataFetcher() {
    const [data, setData] = useState(null);

    useEffect(() => {
      // 'axios.get' é chamado com a URL da API
      axios.get('https://api.example.com/data')
        // A resposta é automaticamente convertida para JSON
        .then(response => setData(response.data));
    }, []); // O array vazio indica que o efeito será executado apenas uma vez

    // Renderização dos dados ou de um estado de carregamento
    return (
      <div>
        {data ? <div>{/* renderização dos dados */}</div> : <p>Carregando...</p>}
      </div>
    );
  }
  ```

- **Dicas**:
  - **Erro de Rede**: Sempre trate erros de rede e respostas inesperadas para evitar que a aplicação quebre.
  - **Async/Await**: Você pode usar `async/await` para um código mais legível ao lidar com promessas.
  - **Headers e Tokens**: Se precisar enviar headers, como tokens de autenticação, tanto o Fetch quanto o Axios permitem configurá-los facilmente.

    ### 7. Boas Práticas e Padrões

    **7.1. Estrutura de Pastas**
    - Organização: Separação por funcionalidades ou tipos de arquivos.
    ```
    src/
        components/
        containers/
        services/
        utils/
    ```

    **7.2. Testes**
    - **Jest**: Testes unitários.
    - **React Testing Library**: Testes de componentes.
    ```bash
    npm install --save-dev @testing-library/react
    ```

    **7.3. Estilos**
    - **CSS Modules**:
    ```css
    /* styles.module.css */
    .myClass { color: red; }
    ```
    ```jsx
    import styles from './styles.module.css';
    <div className={styles.myClass}></div>
    ```
