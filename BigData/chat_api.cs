using OpenAI_API;
using OpenAI_API.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Chatbot 
{
	public static Chatbot Instance { get; private set; } = new Chatbot("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");
	public Chatbot(string key) 
	{
		_api = new OpenAIAPI(key);
	}
	public void BeginConversation() 
	{
		_convo = _api.Chat.CreateConversation();
	}
	public void UserInput(string message) 
	{
		_convo.AppendUserInput(message);
	}
	public string Response() 
	{
		return _convo.GetResponseFromChatbotAsync().Result;
	}

	private Conversation _convo = null;
	private OpenAIAPI _api = null;
}