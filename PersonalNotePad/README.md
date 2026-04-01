# Daily Notes App

A simple console application to help you organize your daily notes and plan your day ahead.

## Features

- **📝 Add Notes**: Create notes with title, description, category, priority, and specific times
- **👀 View Options**: See all notes, group by category, or sort by priority
- **🗑️ Delete Notes**: Remove notes you no longer need
- **🤖 AI Assistant**: Ask questions and get AI-powered responses (requires OpenAI API key)
- **💾 Persistent Storage**: Notes automatically save to a file and load on startup
- **🎯 Priority System**: Low, Medium, High, and Urgent priority levels
- **📊 Categories**: Organize notes by Work, Personal, Health, etc.

## How to Use

1. **Run the Application**:
   ```bash
   cd DailyNotesApp
   dotnet run
   ```

2. **Menu Options**:
   - **1. Add a new note**: Create a new note with all details
   - **2. View all notes for today**: See today's notes in chronological order
   - **3. View notes by category**: Group notes by their categories
   - **4. View notes by priority**: Sort notes by priority level
   - **5. Delete a note**: Remove a specific note
   - **6. Ask AI Assistant**: Get help with questions and research
   - **7. Save notes**: Manually save notes (auto-saved on exit)
   - **8. Exit**: Close the application

## AI Assistant Setup

To use the AI Assistant feature:

1. **Get an OpenAI API Key**:
   - Visit https://platform.openai.com/api-keys
   - Create a new API key

2. **Set Environment Variable**:
   ```bash
   # Windows PowerShell
   $env:OPENAI_API_KEY="your_api_key_here"

   # Windows Command Prompt
   set OPENAI_API_KEY=your_api_key_here

   # Or create a .env file in the project directory:
   # OPENAI_API_KEY=your_api_key_here
   ```

3. **Use the AI Assistant**:
   - Choose option 6 from the menu
   - Ask any question you need help with
   - The AI response can be saved as a note for future reference

## Note Structure

Each note contains:
- **Title**: Brief name of the note
- **Description**: Detailed information
- **Category**: Grouping (e.g., Work, Personal, Health)
- **Priority**: Importance level (Low, Medium, High, Urgent)
- **Time**: When the note applies (defaults to current time)
- **Date**: Automatically set to today

## Data Storage

Notes are stored in a `daily_notes.txt` file in the same directory as the executable. The format is:
```
Date|Time|Title|Description|Category|Priority
```

## Example Usage

1. Start the app
2. Choose option 1 to add a note
3. Enter: "Team Meeting" as title
4. Enter: "Discuss Q1 goals and project timeline" as description
5. Enter: "Work" as category
6. Enter: "High" as priority
7. Enter: "14:00" as time
8. View your notes with option 2

## AI Example

1. Choose option 6 (Ask AI Assistant)
2. Ask: "What are some healthy breakfast ideas?"
3. AI provides response with suggestions
4. Choose to save as a note in "Personal" category

## Requirements

- .NET 9.0 or later
- Internet connection (for AI features)
- OpenAI API key (optional, for AI features)
- Windows/Linux/macOS

## Building

```bash
dotnet build
```

## Running

```bash
dotnet run
```