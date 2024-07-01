### O que é Azure?

&emsp;A Microsoft Azure é uma plataforma de computação em nuvem que fornece uma ampla gama de serviços para desenvolvimento, gerenciamento e hospedagem de aplicações. Oferecendo infraestrutura como serviço (IaaS), plataforma como serviço (PaaS) e software como serviço (SaaS), Azure permite que empresas de todos os tamanhos criem, implantem e gerenciem aplicativos de maneira eficiente e segura. Azure suporta diversas linguagens de programação, ferramentas e estruturas, tornando-a uma solução flexível e poderosa para atender às necessidades específicas de cada projeto.

### Serviços Utilizados no Projeto

O projeto irá utilizar vários serviços da Azure para garantir desempenho, escalabilidade e segurança. Os serviços principais incluem Azure Blob Storage, Azure Kubernetes Service (AKS) e Azure SQL Database.

#### Azure Blob Storage

&emsp;Azure Blob Storage é um serviço de armazenamento de objetos que permite armazenar grandes quantidades de dados não estruturados, como documentos, vídeos e imagens. No contexto deste projeto, Azure Blob Storage será utilizado para armazenar as fotos carregadas pelo administrador. Este serviço oferece alta disponibilidade, durabilidade e segurança, garantindo que as fotos sejam sempre acessíveis e protegidas contra perda de dados. Além disso, Blob Storage suporta acesso baseado em políticas, permitindo que apenas usuários autorizados possam visualizar ou baixar as fotos.

#### Azure Kubernetes Service (AKS)

&emsp;Azure Kubernetes Service (AKS) é um serviço gerenciado que simplifica a implementação, o gerenciamento e as operações de Kubernetes. Kubernetes é um sistema de orquestração de contêineres que automatiza a implantação, o dimensionamento e o gerenciamento de aplicativos em contêineres. AKS será utilizado para gerenciar a aplicação web do projeto, garantindo que ela possa escalar facilmente para atender à demanda variável dos usuários. Com AKS, é possível distribuir automaticamente o tráfego e balancear a carga entre várias instâncias da aplicação, melhorando a resiliência e o desempenho.

#### Azure SQL Database

&emsp;Azure SQL Database é um serviço de banco de dados relacional baseado na nuvem, construído sobre a tecnologia SQL Server da Microsoft. Ele oferece escalabilidade automática, backup automático, alta disponibilidade e segurança avançada. No projeto, Azure SQL Database será utilizado para armazenar todas as informações relacionadas aos usuários, transações e metadados das fotos. A capacidade de escalabilidade do serviço garante que o banco de dados possa crescer conforme a aplicação expande, enquanto os recursos de segurança protegem os dados contra acessos não autorizados.

### Por que Azure é Boa para o Projeto?

&emsp;A escolha da Azure para este projeto é baseada em vários benefícios que a plataforma oferece:

1. **Integração Completa**: Azure fornece uma integração completa com a linguagem C# e a plataforma .NET, facilitando o desenvolvimento e a gestão do projeto.
2. **Escalabilidade e Flexibilidade**: Com serviços como AKS e Azure SQL Database, a aplicação pode facilmente escalar para atender ao crescimento da base de usuários e à demanda por mais recursos.
3. **Segurança**: Azure oferece robustas funcionalidades de segurança, incluindo autenticação multi-fator, criptografia de dados e conformidade com diversos padrões de segurança, garantindo que os dados do projeto estejam sempre protegidos.
4. **Alta Disponibilidade**: Azure garante alta disponibilidade dos serviços, minimizando o tempo de inatividade e garantindo que a aplicação esteja sempre acessível para os usuários.
5. **Gestão Simplificada**: Serviços gerenciados como AKS e Azure SQL Database reduzem a complexidade da gestão de infraestrutura, permitindo que a equipe se concentre no desenvolvimento de funcionalidades da aplicação.