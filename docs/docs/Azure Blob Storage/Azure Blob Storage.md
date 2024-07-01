# Azure Blob Storage

## Visão Geral

Azure Blob Storage é um serviço de armazenamento de objetos altamente escalável e seguro oferecido pela Microsoft Azure. Ele é projetado para armazenar grandes volumes de dados não estruturados, como imagens, vídeos, documentos e backups. Blob Storage é ideal para aplicativos que precisam de armazenamento de dados em larga escala, alta disponibilidade e acessibilidade global.

## Motivos para Escolher Azure Blob Storage

### 1. **Escalabilidade e Desempenho**

- **Alta Escalabilidade**: Azure Blob Storage pode armazenar petabytes de dados, permitindo que você escale suas necessidades de armazenamento conforme o crescimento do seu projeto.
- **Desempenho Otimizado**: Oferece latência baixa e alta taxa de transferência para operações de leitura e escrita, garantindo que os dados estejam disponíveis rapidamente.

### 2. **Custo-Efetividade**

- **Modelos de Preço Flexíveis**: Pague apenas pelo que você usar com a opção de armazenamento baseado em camadas (Hot, Cool, Archive), que permite otimizar os custos de acordo com a frequência de acesso aos dados.
- **Redução de Custos de Armazenamento**: Opções de armazenamento em camadas permitem economizar armazenando dados acessados com menos frequência em camadas de custo mais baixo.

### 3. **Segurança e Conformidade**

- **Criptografia de Dados**: Os dados são criptografados em repouso e em trânsito, garantindo a proteção contra acessos não autorizados.
- **Conformidade**: Azure Blob Storage cumpre com várias normas de conformidade, como GDPR, ISO/IEC 27001, HIPAA, entre outras, facilitando o atendimento às exigências legais e regulamentares.

### 4. **Alta Disponibilidade e Durabilidade**

- **Replicação Geográfica**: Oferece replicação geográfica com múltiplas opções de redundância (LRS, GRS, RA-GRS, ZRS) para garantir alta disponibilidade e durabilidade dos dados.
- **SLA de 99.999999999%**: Garante uma durabilidade elevada com um SLA (Service Level Agreement) de onze noves para a durabilidade dos objetos armazenados.

### 5. **Facilidade de Integração**

- **APIs e SDKs**: Suporte abrangente a APIs RESTful e SDKs para várias linguagens de programação, facilitando a integração com aplicações novas e existentes.
- **Compatibilidade com Serviços Azure**: Integra-se perfeitamente com outros serviços Azure, como Azure Functions, Azure CDN, e Azure Data Lake, ampliando as capacidades do seu projeto.

## Casos de Uso

### 1. **Armazenamento de Imagens e Vídeos**

- Ideal para armazenar grandes volumes de imagens e vídeos usados por aplicações web e móveis.
- Oferece suporte a armazenamentos de mídia em formatos não estruturados com fácil recuperação e distribuição global.

### 2. **Backup e Arquivamento**

- Usado para armazenar backups de dados críticos e arquivos históricos com a segurança e a durabilidade necessárias.
- Facilita a recuperação de desastres e continuidade de negócios com soluções de backup confiáveis.

### 3. **Big Data e Análise**

- Serve como repositório de dados para grandes volumes de dados que necessitam de processamento e análise.
- Integrado com ferramentas de análise como Azure Data Lake Analytics, Azure HDInsight, e Azure Databricks.

## Como utilizar
Fonte: [Quickstart: Azure Blob Storage client library for .NET](https://learn.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-dotnet?tabs=visual-studio%2Cmanaged-identity%2Croles-azure-portal%2Csign-in-azure-cli%2Cidentity-visual-studio&pivots=blob-storage-quickstart-scratch)

**Criação do blob storage através do portal azure**

1. Acesse o seu [portal azure](https://portal.azure.com/#home).
2. Clique na opção **Criar recurso**.
3. Crie uma **Conta de armazenamento**.
4. Preencha os dados solicitados (as informações são simples, é basiamente ligar sua assinatura à conta e adicionar um nome para ela).
5. Após criar sua conta, vá na opção **Armazenamento de dados** e selecione **Contêineres**.
6. Crie seu container para armazenar seus arquivos.
7. Tudo certo! Você já consegue subir seus "blobs" para esse container diretamente pelo Portal Azure.

**Integração com sua aplicação ASP.NET**

1. Crie seu projeto através do Visual Studio.
2. Vá na opção **Solution Explorer**, clique em **Dependencies** e depois na opção **Manage NuGet Packages** para abrir o gerenciador de pacotes do ASP.NET.
3. Instale o **Azure.Storage.Blobs**
4. Instale também o pactoe **Azure.Identity** por questões de segurança.
5. No portal da Azure, vá para sua conta de armazenamento e selecione a opção **Access control (IAM)** do menu lateral esquerdo.
6. Na página Controle de acesso (IAM), selecione a guia **Atribuições de função**.
7. Selecione **+ Add** no menu superior e, em seguida, **Add role assignment** no menu suspenso.
8. Em **Assign access to** selecione Usuário, grupo ou entidade de serviço e, em seguida, escolha **+ Select members**.
9. Na caixa de diálogo, pesquise seu nome de usuário do Microsoft Entra (geralmente seu endereço de e-mail user@domain) e, em seguida, escolha **Select** na parte inferior da caixa de diálogo.
10. Selecione **Review +** atribuir para ir para a página final e, em seguida, **Review +** atribuir novamente para concluir o processo.

**Código de exemplo com algumas funcionalidades do Blob Storage retirados da documentação oficial da Azure:**

```csharp
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Identity;

// TODO: Replace <storage-account-name> with your actual storage account name
var blobServiceClient = new BlobServiceClient(
        new Uri("https://<storage-account-name>.blob.core.windows.net"),
        new DefaultAzureCredential());

//Create a unique name for the container
string containerName = "quickstartblobs" + Guid.NewGuid().ToString();

// Create the container and return a container client object
BlobContainerClient containerClient = await blobServiceClient.CreateBlobContainerAsync(containerName);

// Create a local file in the ./data/ directory for uploading and downloading
string localPath = "data";
Directory.CreateDirectory(localPath);
string fileName = "quickstart" + Guid.NewGuid().ToString() + ".txt";
string localFilePath = Path.Combine(localPath, fileName);

// Write text to the file
await File.WriteAllTextAsync(localFilePath, "Hello, World!");

// Get a reference to a blob
BlobClient blobClient = containerClient.GetBlobClient(fileName);

Console.WriteLine("Uploading to Blob storage as blob:\n\t {0}\n", blobClient.Uri);

// Upload data from the local file
await blobClient.UploadAsync(localFilePath, true);

Console.WriteLine("Listing blobs...");

// List all blobs in the container
await foreach (BlobItem blobItem in containerClient.GetBlobsAsync())
{
    Console.WriteLine("\t" + blobItem.Name);
}

// Download the blob to a local file
// Append the string "DOWNLOADED" before the .txt extension 
// so you can compare the files in the data directory
string downloadFilePath = localFilePath.Replace(".txt", "DOWNLOADED.txt");

Console.WriteLine("\nDownloading blob to\n\t{0}\n", downloadFilePath);

// Download the blob's contents and save it to a file
await blobClient.DownloadToAsync(downloadFilePath);

// Clean up
Console.Write("Press any key to begin clean up");
Console.ReadLine();

Console.WriteLine("Deleting blob container...");
await containerClient.DeleteAsync();

Console.WriteLine("Deleting the local source and downloaded files...");
File.Delete(localFilePath);
File.Delete(downloadFilePath);

Console.WriteLine("Done");
```


