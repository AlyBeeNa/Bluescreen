# Chat Session Analyzer

## Overview
This project is a tool for analyzing chat session logs to extract useful statistics about both chatbot and user behavior. The tool processes multiple JSON files containing chat data and generates a summary of various statistics, including chatbot response quality, user satisfaction, and trending topics in conversations.

## Features
- Chatbot Analysis: Evaluates chatbot responses based on issues like misinterpretation, repetitive responses, and unnecessary details.
- User Analysis: Tracks user queries, inappropriate behavior, repeated queries, and overall satisfaction with the chatbot.
- Session Summary: Parses and summarizes multiple chat sessions, presenting insights into trending topics and session activity.
- Output: Generates a JSON file (bin.json) that contains the aggregated statistics and insights from all analyzed sessions.

## How it Works
1. The program reads a directory of JSON files containing chat session data.
    - After executing the exe file, the directory path must be specified.
2. For each file, it extracts and processes the chat data using the JsonParser and DataAnalyzer classes.
3. The chatbot's behavior is evaluated based on predefined issues such as:
    - Straight Responses
    - Repetitive Responses
    - Misinterpreted Queries
    - Shallow Responses
    - Inappropriate Responses
4. User statistics are also gathered, including:
    - Inappropriate Queries
    - Repeated Queries
    - Shallow Queries
5. The tool generates a report of user satisfaction and trending topics.

## Dependencies
- Newtonsoft.Json: For working with JSON data.
- System.Text.Json: An alternative JSON library used for parsing.
- OpenAI_API : A package for integrating OpenAI’s API (optional, as seen in the references).


## License
This project is licensed under the MIT License.
Feel free to adjust the content based on your needs or project specifics!