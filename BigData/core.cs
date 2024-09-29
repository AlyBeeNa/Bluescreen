using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Text.Json.Nodes;
using System.Text.Json;


//User Sentiment
//Trends
//Types of questions
[System.Serializable]
public class ChatbotStatistics 
{
	public uint TotalResponses;

	public uint StraightResponses;
	public uint RepetitiveResponses;
	public uint MisinterpretedQueries;
	public uint ShallowResponses;
	public uint UnnecessaryDetails;
	public uint ClarificationsRequests;

	public uint InapropriateResponses;
}
[System.Serializable]
public class UserStatistics 
{
	public List<Message> InaproprtiateQueries = new();
	public uint InapropriateQueriesCount;
	public uint RepeatedQueries;
	public uint ShallowQueries;

	public float UserSatisfaction;
	public List<string> TrendingTopics = new();
	public List<string> TrendingQuestions = new();

	public uint TotalQueries;
}

[System.Serializable]
public class OutputPayload 
{
	public ChatbotStatistics BotStats = new ChatbotStatistics();
	public UserStatistics UserStats = new UserStatistics();
}

public class Message
{
	public DateTime Timestamp { get; set; }
	public string MessageText { get; set; } // Renamed to avoid conflict with class name
	public string Role { get; set; }
}

public class ChatSession
{
	public string SessionId { get; set; }
	public DateTime Timestamp { get; set; }
	public List<Message> Messages { get; set; } = new List<Message>();
}

public class JsonData
{
	public string ClientId { get; set; }
	public string UserId { get; set; }
	public string Name { get; set; }
	public string ContextSummary { get; set; }
	public List<ChatSession> Sessions { get; set; } = new List<ChatSession>();
}

public class JsonParser
{
	public static JsonData TryParseJsonFile(string path)
	{
		if (!File.Exists(path))
		{
			Console.WriteLine($"Could not open json file: {path}");
			return null;
		}
		string jsonString = File.ReadAllText(path);
		JObject j = JObject.Parse(jsonString);

		JsonData data = new JsonData();
		data.ClientId = (string)j["client_id"];
		data.UserId = (string)j["user_id"];
		data.Name = (string)j["name"];
		data.ContextSummary = (string)j["char_session"];
		var sessions = (j["chat_sessions"] as JObject).Properties();
		foreach (var v in sessions) 
		{
			ChatSession s = new ChatSession();
			s.SessionId = v.Name;
			s.Timestamp = (DateTime)v.Value["timestamp"];
			var messages = (JArray)v.Value["messages"];
			foreach (var msg in messages) 
			{
				Message m = new Message();
				m.Timestamp = (DateTime)msg["timestamp"];
				m.MessageText = (string)msg["message"];
				m.Role = (string)msg["role"];
				s.Messages.Add(m);
			}
			data.Sessions.Add(s);
		}
		return data;
	}

	public static void JsonDataSummary(JsonData data)
	{
		if (data == null)
		{
			Console.WriteLine("No data to summarize.");
			return;
		}

		Console.WriteLine($"Client: {data.ClientId}");
		Console.WriteLine($"User: {data.UserId}");
		Console.WriteLine($"Name: {data.Name}");
		Console.WriteLine($"Summary: {data.ContextSummary}");

		foreach (var session in data.Sessions)
		{
			Console.WriteLine($"\tSessionID: {session.SessionId}");
			Console.WriteLine($"\tMessageCount: {session.Messages.Count}");
			Console.WriteLine($"\tTimestamp: {session.Timestamp}");
			Console.WriteLine();
		}
	}
}
public struct IssueDescriptor 
{
	public IssueDescriptor(string title, string id, string desc) { this.Title = title; this.ID = id; this.Description = desc; }
	public string Title;
	public string ID;
	public string Description;

	public static List<IssueDescriptor> DefaultIssues = new List<IssueDescriptor>()
	{
		new IssueDescriptor(
			"Straight Responses", "straight_resp", "The response was concise and straightforward, missing the expected politeness and engaging style, which made it seem abrupt and potentially dismissive."),
		new IssueDescriptor("Repetitive Responses", "repet_resp", "Providing the same information multiple times in a conversation."),
		new IssueDescriptor("Misinterpreted Queries", "miss_query", "Failing to understand the intent or specifics of user questions."),
		new IssueDescriptor("Shallow Responses", "shallow_resp", "The assistant sometimes provides general information without specifying the exact legal provisions, which could lead to misunderstandings or incomplete information."),
		new IssueDescriptor("Unnecesarry Details", "unn_details", "The assistant continues to ask for more information even after sufficient context has been provided by the user. This can lead to frustration and does not advance the resolution of the issue."),
		new IssueDescriptor("Clarification Requests", "clar_request", "The assistant asks for clarification on questions that are already clear, such as asking about the costs of using the AI assistant when the user has explicitly inquired about it."),
		new IssueDescriptor("Inapropriate Responses", "in_res", "The assistant responds in an inapropriate way to the user's queries."),
		new IssueDescriptor("Repeated Queries", "rep_queries", "The user repeats the same query multiple times."),
		new IssueDescriptor("Shallow Queries", "shallow_queries", "The user gives shallow queries, which can't be interpreted correctly."),
		new IssueDescriptor("Inaproprite Query", "inn_query", "The user gived inapropriate queries which lead to unpredictible responses. These include sexual or erotic meanings.")
	};
	public static string GetQueryTemplate()
	{
		string query = "Analyze the following chat session and look out for the following things :\n";
		foreach (var i in IssueDescriptor.DefaultIssues)
			query += $"{i.Title} ( id = {i.ID} ) : {i.Description}\n";
		query += "I require the following outputs:\n" +
			"The detected issuesin the format :\n(D) <id> : <message_index>\n" +
			"The user's overall experience, a value from 0 to 1, in the format : (E) <value>\n";
		return query;
	}
}
public static class DataAnalyzer
{
	const uint MAX_TOKENS = 12500;
	const int AVERAGE_CHR_PER_TOKEN = 5;
	public static List<(uint from, uint to)> SplitSession(List<string> messages)
	{
		List<(uint, uint)> ranges = new List<(uint, uint)>();
		uint tokens = 0;
		uint idx_cursor = 0;
		for (int i = 0; i < messages.Count; ++i) 
		{
			int tks = messages[i].Length / AVERAGE_CHR_PER_TOKEN;
			tokens += (uint)tks;
			if (tokens > MAX_TOKENS) 
			{
				(uint from, uint to) range = new();
				range.from = idx_cursor;
				range.to = (uint)i + 1;
				if ((i & 1) == 0)
					range.to--;
				idx_cursor = range.to;
				ranges.Add(range);
			}
		}
		if (ranges.Count == 0)
			ranges.Add(new(0, (uint)messages.Count));
		return ranges;
	}
	delegate void value_callback(OutputPayload output);
	public static void AnalizeSession(ChatSession session, OutputPayload output) 
	{
		List<Message> filtered_messages = new List<Message>();
		//1st pass filter
		filtered_messages.Add(session.Messages[0]);
		for(int i = 1; i < session.Messages.Count; i++) 
		{
			Message m1 = session.Messages[i - 1];
			Message m2 = session.Messages[i];
			float dt = (float)(m1.Timestamp - m2.Timestamp).TotalSeconds;
			if (((m1.Role == m2.Role) && m1.Role == "user") && (m1.MessageText == m2.MessageText) && (dt < 0.1f))
				continue; 
			filtered_messages.Add(m2);
		}
		//2nd pass, construct the full messages
		List<string> built_messages = new();
		for (int i = 0; i < filtered_messages.Count; i++) 
		{
			var msg = filtered_messages[i];
			string message = $"role : {msg.Role}\ntimestamp : {msg.Timestamp}\nmessage : {msg.MessageText}\n\n";
			built_messages.Add(message);
		}
		//3rd pass, generate query
		string query = IssueDescriptor.GetQueryTemplate();

		var ranges = SplitSession(built_messages);

		Chatbot.Instance.BeginConversation();

		Dictionary<string, uint> anomalies = new();

		List<string> results = new();
		foreach (var range in ranges) 
		{
			string fquery = query;
			for (uint i = range.from; i < range.to; ++i)
				fquery += built_messages[(int)i] + "\n";
			try
			{
				Chatbot.Instance.UserInput(fquery);
				string result = Chatbot.Instance.Response();
				results.Add(result);
			}
			catch
			{
				Console.WriteLine("Failed Analisis. Connection Refused.");
			}
		}
		foreach(var result in results) 
		{
			using (StringReader reader = new StringReader(result)) 
			{
				for(string? r = reader.ReadLine(); r != null; r = reader.ReadLine()) 
				{
					int p = r.IndexOf("(D)");
					if (p != -1)
					{
						output.BotStats.TotalResponses++;
						string r2 = r.Substring(p + 3);
						string[] vs = r2.Split(':');
						if (vs.Length < 2)
							continue;
						string key = vs[0];
						if (!int.TryParse(vs[1], out int value))
							continue;
						key = Regex.Replace(key, @"\s+", "");
						if (!anomalies.ContainsKey(key))
							anomalies.Add(key, 1);
						else
							anomalies[key]++;
						Message target = session.Messages[Math.Min(value, session.Messages.Count() - 1)];
						if (key == "inn_query") 
							output.UserStats.InaproprtiateQueries.Add(target);
						if (target.Role == "user")
							output.UserStats.TotalQueries++;
					}
					else 
					{
						p = r.IndexOf("(E)");
						if (p != -1) 
						{
							string r2 = r.Substring(p+3);
							if (!float.TryParse(r2, out float value))
								continue;
							output.UserStats.UserSatisfaction += value;
						}
					}
				}
				
			}
		}
		foreach (var a in anomalies) 
		{
			switch(a.Key) 
			{
				case "straight_resp":
					output.BotStats.StraightResponses += a.Value;
					break;
				case "repet_resp":
					output.BotStats.RepetitiveResponses += a.Value;
					break;
				case "miss_query":
					output.BotStats.MisinterpretedQueries += a.Value;
					break;
				case "shallow_rasp":
					output.BotStats.ShallowResponses += a.Value;
					break;
				case "unn_details":
					output.BotStats.UnnecessaryDetails += a.Value;
					break;
				case "clar_request":
					output.BotStats.ClarificationsRequests += a.Value;
					break;
				case "in_res":
					output.BotStats.InapropriateResponses += a.Value;
					break;
				case "rep_queries":
					output.UserStats.RepeatedQueries += a.Value;
					break;
				case "shallow_queries":
					output.UserStats.ShallowQueries += a.Value;
					break;
				case "inn_query":
					output.UserStats.InapropriateQueriesCount += a.Value;
					break;
			}
		}
	}
	public static void AnalizeTopics(List<JsonData> objs, OutputPayload output) 
	{
		string query = "Select for the most common topics and order them by how frequent they are : \n";
		foreach (JsonData obj in objs)
			query += obj.ContextSummary + "\n";
		Chatbot.Instance.BeginConversation();
		Chatbot.Instance.UserInput(query);
		string result = Chatbot.Instance.Response();
		using (StringReader reader = new StringReader(result))
			for (string? line = reader.ReadLine(); line != null; line = reader.ReadLine())
				output.UserStats.TrendingTopics.Add(line);

	}
}