using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenAI_API;
using OpenAI_API.Chat;

class Program
{
	public static void WriteToJsonFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
	{
		TextWriter writer = null;
		try
		{
			var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite);
			writer = new StreamWriter(filePath, append);
			writer.Write(contentsToWriteToFile);
		}
		finally
		{
			if (writer != null)
				writer.Close();
		}
	}
	static async Task Main(string[] args)
	{
		string path = Console.ReadLine();
		var files = Directory.EnumerateFiles(path).ToArray();
		List<JsonData> logs = new List<JsonData>();

		OutputPayload output = new OutputPayload();

		int progress = 0;
		int total = files.Length;
		foreach (var file in files)
		{
			logs.Add(JsonParser.TryParseJsonFile(file));
			DataAnalyzer.AnalizeSession(logs[logs.Count - 1].Sessions[0], output);
			progress++;
			Console.WriteLine($"{progress} / {total}");
		}
		DataAnalyzer.AnalizeTopics(logs, output);
		output.UserStats.UserSatisfaction /= 1;
		WriteToJsonFile<OutputPayload>("bin.json", output);
	}
}
