### O que é?  
O Docker é um software de código aberto usado para implantar aplicativos dentro de containers virtuais. A conteinerização permite que vários aplicativos funcionem em diferentes ambientes complexos. Por exemplo, o Docker permite executar o WordPress em sistemas Windows, Linux e macOS, sem problemas.

### Por que usar o Docker?  
A ideia do Docker é separar a sua aplicação em containers. Containers são pacotes contendo tudo que é necessário para uma aplicação: código, bibliotecas e dependências. A compartimentalização surgiu primeiro através das máquinas virtuais, mas a diferença é que os containers do Docker utilizam a mesma CPU, RAM, etc.

### Características do Docker
- Docker reduz o tamanho do desenvolvimento fornecendo uma parte menor do sistema operacional através de contêineres.
- Facilita o trabalho em projetos por diferentes equipes com a ajuda de contêineres.
- Containers Docker podem ser implantados em qualquer lugar, seja em máquinas físicas, virtuais ou na nuvem.
- Os containers Docker são leves, facilitando sua escalabilidade.

### Vantagens do Docker
- Utiliza menos memória em comparação com outras soluções.
- Não requer um sistema operacional completo para executar um aplicativo.
- Contêineres executam mais rapidamente do que outras Máquinas Virtuais.
- É leve e permite o compartilhamento de contêineres através de repositórios remotos.
- Usa dependências para reduzir os riscos.

### Desvantagens do Docker
- A complexidade aumenta devido à camada de abstração.
- Difícil de gerenciar um grande número de contêineres.

### Como o Docker funciona?

- **Cliente Docker:** o principal componente para criar, gerenciar e executar aplicativos em container. O cliente Docker é o principal método de controle do servidor Docker por meio de uma ILC, como Prompt de Comando (Windows) ou Terminal (macOS, Linux).
- **Servidor Docker:** também conhecido como o daemon do Docker. Ele aguarda as solicitações da API REST feitas pelo cliente Docker e gerencia imagens e containers.
- **Imagens do Docker:** instrua o servidor Docker com os requisitos sobre como criar um container Docker. As imagens podem ser baixadas de sites como Docker Hub. A criação de uma imagem personalizada também é possível — para isso, os usuários precisam criar um Dockerfile e passá-lo para o servidor. Vale a pena notar que o Docker não limpa nenhuma imagem não utilizada, então os usuários precisam excluir dados de imagem eles mesmos, antes que acabe com muitas delas.
- **Registro do Docker:** um aplicativo do lado do servidor de código aberto usado para hospedar e distribuir imagens do Docker. O registro é extremamente útil para armazenar imagens localmente e manter controle total sobre elas. Como alternativa, os usuários podem acessar o Docker Hub mencionado acima – o maior repositório mundial de imagens do Docker.

<!-- Inserir uma imagem -->
![Texto Alternativo](/img/docker-desenho.png)

### Conclusão
- Docker é uma ferramenta de desenvolvimento de software que permite empacotar e executar aplicativos dentro de máquinas virtuais em um servidor.
- É amplamente utilizado para criar e testar aplicativos antes de implantá-los em servidores reais.
- Permite que organizações testem e implantem rapidamente seus aplicativos com recursos mínimos.
- Facilita o empacotamento e atualização de aplicativos em qualquer servidor, independentemente de sua configuração de hardware.

### Passo a passo para criar uma aplicação ASP.NET containizada com Docker

1. **Instale o Docker Desktop:**
   Se você ainda não tiver o Docker instalado, baixe e instale o Docker Desktop para Windows no [site oficial do Docker](https://www.docker.com/products/docker-desktop).

2. **Certifique-se de que o seu projeto ASP.NET está pronto para ser contêinerizado:**
   Certifique-se de que seu projeto ASP.NET Web API está funcionando corretamente localmente.

3. **Adicione suporte ao Docker ao seu projeto:**
   No Visual Studio, clique com o botão direito no seu projeto ASP.NET e selecione "Adicionar" -> "Docker Support".

4. **Escolha o tipo de contêiner:**
   Na janela "Adicionar suporte ao Docker", você pode escolher o tipo de contêiner. Selecione "Windows" ou "Linux", dependendo do ambiente de execução desejado.

5. **Aguarde o Visual Studio configurar o suporte ao Docker:**
   O Visual Studio configurará automaticamente o projeto para funcionar com o Docker. Isso incluirá a criação de arquivos Dockerfile e docker-compose.

6. **Personalize o arquivo Dockerfile (opcional):**
   Dependendo das necessidades do seu projeto, você pode querer personalizar o Dockerfile gerado pelo Visual Studio. Por exemplo, você pode adicionar dependências adicionais ou configurar variáveis de ambiente.

7. **Construa a imagem Docker:**
   No Visual Studio, clique com o botão direito no projeto e selecione "Publicar" -> "Docker". Isso iniciará o processo de construção da imagem Docker.

8. **Execute o contêiner:**
   Depois que a imagem for construída com sucesso, você pode executá-la como um contêiner Docker. Você pode fazer isso usando o Visual Studio ou usando o Docker CLI.

9. **Teste o contêiner:**
   Uma vez que o contêiner esteja em execução, teste o seu ASP.NET Web API para garantir que esteja funcionando corretamente dentro do contêiner Docker.

10. **Distribua e implante seu contêiner (opcional):**
    Se desejar distribuir ou implantar seu contêiner em outros ambientes, você pode fazer isso transferindo a imagem Docker para um registro de contêiner (como Docker Hub) e implantando-a em um ambiente de produção.
