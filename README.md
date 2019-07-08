# DirectLine Bot Sample

Bot Framework v4 directline bot sample

This bot has been created using [Bot Framework](https://dev.botframework.com); to show how to create a directline client controller and utilize it in a customizable webchat.

## Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) version 2.1

  ```bash
  # determine dotnet version
  dotnet --version
  ```

- Directline Secret from a deployed web app bot or bot channels registration

## To try this sample

- Clone the repository

    ```bash
    git clone https://github.com/jwiley84/DirectLineBot.git
    ```

- In a terminal, navigate to `/JJDirectLineClient`
- Run the client controller from a terminal or from Visual Studio

  B) Or from Visual Studio

  - Launch Visual Studio
  - File -> Open -> Project/Solution
  - Navigate to `/JJDirectLineClient` folder
  - In the 'appsettings.json' file, replace "< YOUR-BOT-SECRET>" with the directline secret from Azure and save.
  - Select `JJDirectLineClient.csproj` file
  - Press `F5` to run the project

## Secret-Token exchange

While there are many mechanisms to invoke Web Chat on a client HTML page, one thing that is very important to do is to ensure you keep your DirectLine Secret a secret! The DirectLine Secret is as important as a database connection string and these sorts of things should never show up in HTML or even in the JavaScript that is running behind an HTML page.

## Deploy the client controller to Azure

Just as both the bot and the client controller are in the same solution here, you can deploy both a bot and a the controller to the same resource group in Azure. A deployed client controller is simply an .NET Core MVC application, and will be deployed as a standard webapp.

## Further reading

- [Bot Framework Documentation](https://docs.botframework.com)
- [Bot Basics](https://docs.microsoft.com/azure/bot-service/bot-builder-basics?view=azure-bot-service-4.0)
- [Activity processing](https://docs.microsoft.com/en-us/azure/bot-service/bot-builder-concept-activity-processing?view=azure-bot-service-4.0)
- [Azure Bot Service Introduction](https://docs.microsoft.com/azure/bot-service/bot-service-overview-introduction?view=azure-bot-service-4.0)
- [Azure Bot Service Documentation](https://docs.microsoft.com/azure/bot-service/?view=azure-bot-service-4.0)
- [.NET Core CLI tools](https://docs.microsoft.com/en-us/dotnet/core/tools/?tabs=netcore2x)
- [Azure CLI](https://docs.microsoft.com/cli/azure/?view=azure-cli-latest)
- [Azure Portal](https://portal.azure.com)
- [Language Understanding using LUIS](https://docs.microsoft.com/en-us/azure/cognitive-services/luis/)
- [Channels and Bot Connector Service](https://docs.microsoft.com/en-us/azure/bot-service/bot-concepts?view=azure-bot-service-4.0)
