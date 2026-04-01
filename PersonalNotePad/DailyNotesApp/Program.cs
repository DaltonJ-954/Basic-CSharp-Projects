using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace DailyNotesApp
{
    public enum Priority
    {
        Low,
        Medium,
        High,
        Urgent
    }

    public class OpenAIRequest
    {
        public string Model { get; set; } = "gpt-3.5-turbo";
        public List<Message> Messages { get; set; } = [];
        public int maxTokens { get; set; } = 500;
    }

    public class Message
    {
        public string Role { get; set; } = "";
        public string Content { get; set; } = "";
    }

    public class OpenAIResponse
    {
        public List<Choice> Choices { get; set; } = [];
    }

    public class Choice
    {
        public Message Message { get; set; } = new Message();
    }

    public class Note
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Category { get; set; } = "General";
        public Priority Priority { get; set; }
        public DateTime Time { get; set; }
        public DateTime Date { get; set; }

        public Note()
        {
            Date = DateTime.Today;
        }

        public override string ToString()
        {
            return $"{Time:HH:mm} - [{Priority}] {Category}: {Title}\n  {Description}";
        }
    }

    class Program
    {
        private static readonly List<Note> notes = [];
        private static readonly string dataFile = "daily_notes.txt";

        static async Task Main(string[] args)
        {
            LoadNotes();

            Console.WriteLine("=== Daily Notes App ===");
            Console.WriteLine("Plan your day ahead with organized notes!\n");

            bool running = true;
            while (running)
            {
                ShowMenu();
                string choice = Console.ReadLine()?.Trim() ?? "";

                switch (choice)
                {
                    case "1":
                        AddNote();
                        break;
                    case "2":
                        ViewNotes();
                        break;
                    case "3":
                        ViewNotesByCategory();
                        break;
                    case "4":
                        ViewNotesByPriority();
                        break;
                    case "5":
                        DeleteNote();
                        break;
                    case "6":
                        await AskAIAssistant();
                        break;
                    case "7":
                        SaveNotes();
                        Console.WriteLine("Notes saved successfully!");
                        break;
                    case "8":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            SaveNotes();
            Console.WriteLine("Goodbye!");
        }

        static void ShowMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add a new note");
            Console.WriteLine("2. View all notes for today");
            Console.WriteLine("3. View notes by category");
            Console.WriteLine("4. View notes by priority");
            Console.WriteLine("5. Delete a note");
            Console.WriteLine("6. Ask AI Assistant");
            Console.WriteLine("7. Save notes");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");
        }

        static void AddNote()
        {
            Console.Clear();
            Console.WriteLine("=== Add New Note ===");

            var note = new Note();

            Console.Write("Title: ");
            note.Title = Console.ReadLine() ?? "";

            Console.Write("Description: ");
            note.Description = Console.ReadLine() ?? "";

            Console.Write("Category (e.g., Work, Personal, Health): ");
            note.Category = Console.ReadLine() ?? "General";

            Console.Write("Priority (Low/Medium/High/Urgent): ");
            string priorityInput = Console.ReadLine()?.ToLower() ?? "medium";
            note.Priority = priorityInput switch
            {
                "low" => Priority.Low,
                "medium" => Priority.Medium,
                "high" => Priority.High,
                "urgent" => Priority.Urgent,
                _ => Priority.Medium
            };

            Console.Write("Time (HH:mm, press Enter for now): ");
            string timeInput = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(timeInput))
            {
                note.Time = DateTime.Now;
            }
            else
            {
                if (TimeSpan.TryParse(timeInput, out TimeSpan time))
                {
                    note.Time = DateTime.Today.Add(time);
                }
                else
                {
                    Console.WriteLine("Invalid time format. Using current time.");
                    note.Time = DateTime.Now;
                }
            }

            notes.Add(note);
            Console.WriteLine("Note added successfully!");
        }

        static void ViewNotes()
        {
            Console.WriteLine("=== Today's Notes ===");

            var todaysNotes = notes.Where(n => n.Date.Date == DateTime.Today)
                                  .OrderBy(n => n.Time)
                                  .ToList();

            if (todaysNotes.Count == 0)
            {
                Console.WriteLine("No notes for today.");
                return;
            }

            foreach (var note in todaysNotes)
            {
                Console.WriteLine("---");
                Console.WriteLine(note.ToString());
            }
        }

        static void ViewNotesByCategory()
        {
            Console.Clear();
            Console.WriteLine("=== Notes by Category ===");

            var categories = notes.Where(n => n.Date.Date == DateTime.Today)
                                 .GroupBy(n => n.Category)
                                 .OrderBy(g => g.Key);

            foreach (var categoryGroup in categories)
            {
                Console.WriteLine($"\n--- {categoryGroup.Key} ---");
                foreach (var note in categoryGroup.OrderBy(n => n.Time))
                {
                    Console.WriteLine($"  {note.Time:HH:mm} [{note.Priority}] {note.Title}");
                }
            }

            if (!categories.Any())
            {
                Console.WriteLine("No notes for today.");
            }
        }

        static void ViewNotesByPriority()
        {
            Console.Clear();
            Console.WriteLine("=== Notes by Priority ===");

            var priorities = notes.Where(n => n.Date.Date == DateTime.Today)
                                 .GroupBy(n => n.Priority)
                                 .OrderByDescending(g => g.Key);

            foreach (var priorityGroup in priorities)
            {
                Console.WriteLine($"\n--- {priorityGroup.Key} Priority ---");
                foreach (var note in priorityGroup.OrderBy(n => n.Time))
                {
                    Console.WriteLine($"  {note.Time:HH:mm} [{priorityGroup.Key}] {note.Title}");
                }
            }

            if (!priorities.Any())
            {
                Console.WriteLine("No notes for today.");
            }
        }

        static void DeleteNote()
        {
            Console.Clear();
            Console.WriteLine("=== Delete Note ===");

            var todaysNotes = notes.Where(n => n.Date.Date == DateTime.Today)
                                  .OrderBy(n => n.Time)
                                  .ToList();

            if (todaysNotes.Count == 0)
            {
                Console.WriteLine("No notes to delete.");
                return;
            }

            Console.WriteLine("Today's notes:");
            for (int i = 0; i < todaysNotes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todaysNotes[i].Time:HH:mm} - {todaysNotes[i].Title}");
            }

            Console.Write("Enter the number of the note to delete (0 to cancel): ");
            if (int.TryParse(Console.ReadLine() ?? "", out int index) && index > 0 && index <= todaysNotes.Count)
            {
                notes.Remove(todaysNotes[index - 1]);
                Console.WriteLine("Note deleted successfully!");
            }
            else
            {
                Console.WriteLine("Invalid selection or cancelled.");
            }
        }

        static async Task AskAIAssistant()
        {
            Console.Clear();
            Console.WriteLine("=== AI Assistant ===");
            Console.WriteLine("Ask me anything! I'll help you get information you need.\n");

            Console.Write("What would you like to know? ");
            string question = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(question))
            {
                Console.WriteLine("No question asked.");
                return;
            }

            Console.WriteLine("\nThinking...");

            try
            {
                string? apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
                if (string.IsNullOrEmpty(apiKey))
                {
                    Console.WriteLine("❌ OpenAI API key not found!");
                    Console.WriteLine("To use AI features, set your OPENAI_API_KEY environment variable:");
                    Console.WriteLine("1. Get an API key from https://platform.openai.com/api-keys");
                    Console.WriteLine("2. Set environment variable: set OPENAI_API_KEY=your_key_here");
                    Console.WriteLine("3. Or create a .env file with: OPENAI_API_KEY=your_key_here");
                    return;
                }

                string response = await GetAIResponse(question, apiKey);
                Console.WriteLine("\n🤖 AI Response:");
                Console.WriteLine(response);

                Console.Write("\nWould you like to save this as a note? (y/n): ");
                string saveChoice = Console.ReadLine()?.ToLower() ?? "n";

                if (saveChoice == "y" || saveChoice == "yes")
                {
                    var note = new Note
                    {
                        Title = $"AI: {question.Substring(0, Math.Min(30, question.Length))}{(question.Length > 30 ? "..." : "")}",
                        Description = response,
                        Category = "AI Research",
                        Priority = Priority.Medium,
                        Time = DateTime.Now
                    };
                    notes.Add(note);
                    Console.WriteLine("Note saved successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error getting AI response: {ex.Message}");
                Console.WriteLine("Make sure your API key is valid and you have internet connection.");
            }
        }

        static async Task<string> GetAIResponse(string question, string apiKey)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            var request = new OpenAIRequest
            {
                Messages =
                    [
                        new Message { Role = "user", Content = question }
                    ]
            };

            var response = await client.PostAsJsonAsync("https://api.openai.com/v1/chat/completions", request);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"API request failed: {response.StatusCode}");
            }

            var result = await response.Content.ReadFromJsonAsync<OpenAIResponse>();
            return result?.Choices?.FirstOrDefault()?.Message?.Content ?? "No response received.";
        }

        static void SaveNotes()
        {
            try
            {
                using StreamWriter writer = new(dataFile);
                foreach (var note in notes)
                {
                    writer.WriteLine($"{note.Date:yyyy-MM-dd}|{note.Time:HH:mm}|{note.Title}|{note.Description}|{note.Category}|{note.Priority}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving notes: {ex.Message}");
            }
        }

        static void LoadNotes()
        {
            if (!File.Exists(dataFile)) return;

            try
            {
                notes.Clear();
                string[] lines = File.ReadAllLines(dataFile);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 6)
                    {
                        var note = new Note
                        {
                            Date = DateTime.Parse(parts[0]),
                            Time = DateTime.Parse($"{parts[0]} {parts[1]}"),
                            Title = parts[2],
                            Description = parts[3],
                            Category = parts[4],
                            Priority = Enum.Parse<Priority>(parts[5])
                        };
                        notes.Add(note);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading notes: {ex.Message}");
            }
        }
    }
}
