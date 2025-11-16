using OpenAI;
using OpenAI.Chat;
using System.ClientModel;

OpenAIClient client = new OpenAIClient(new ApiKeyCredential(Environment.GetEnvironmentVariable("AI:OpenAI:ApiKey")));
ChatClient chatService = client.GetChatClient("gpt-4o-mini-preview");

var result = await chatService.CompleteChatAsync("What was yesterday's weather?");
Console.WriteLine(result.Value);