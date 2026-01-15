# Coding Tracker

A simple console app for tracking coding sessions. Start a timer, log sessions manually, review history by date ranges, and view a 30-day activity heatmap.

## Features

- **Track sessions in real time** using a built-in stopwatch.
- **Log sessions manually** with validated start/end times.
- **Review history** for all sessions or a filtered date range (yesterday, last 7 days, last 30 days, or custom dates).
- **Visual activity heatmap** for the previous 30 days.
- **Local SQLite storage** for sessions.

## Tech Stack

- **.NET 10** console application
- **SQLite** with **Dapper** for data access
- **Spectre.Console** for rich terminal UI

## Getting Started

### Prerequisites

- .NET SDK 10.0 or later

### Configure the database

The SQLite database path is configured in `appsettings.json`:

```json
{
  "Database": {
    "ConnectionString": "coding_Tracker.db"
  }
}
```

Update the connection string if you want the database stored elsewhere.

### Run the app

From the repo root:

```bash
dotnet run --project "Coding Tracker/Coding Tracker"
```

## Usage Overview

- **Start Coding Session**
  - Choose **Start Timer** to track time automatically.
  - Choose **Enter Time Manually** to log a past session.
- **View Sessions**
  - View all sessions or filter by a specific date range.
- **View Previous 30 Day Activity Heatmap**
  - See a quick visual summary of recent activity.

## Running Tests

```bash
dotnet test "Coding Tracker/Coding_Tracker.Tests"
```

## Project Structure

```
Coding Tracker/
├── Coding Tracker/           # Application source
├── Coding_Tracker.Tests/     # Test project
└── Coding Tracker.slnx
```

## Notes

- Sessions are stored in a local SQLite database file.
- The database schema is created automatically on first run.
