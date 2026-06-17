# CoconaSample (.NET 9)

A simple .NET 9 console application using Cocona to demonstrate command-based execution with Dependency Injection.

## Features

- .NET 9 Console Application
- Cocona Command Framework
- Dependency Injection
- Multiple Commands
- Easy debugging using launch profiles
- Suitable for:
  - Scheduled Jobs
  - Cron Jobs
  - Autosys Jobs
  - Kubernetes CronJobs
  - DevOps Utilities

---

## Project Structure

```text
CoconaSample
├── Commands
│   └── AppCommands.cs
├── Services
│   ├── CleanupService.cs
│   ├── EmailService.cs
│   └── ReportService.cs
├── Properties
│   └── launchSettings.json
├── Program.cs
├── CoconaSample.csproj
└── README.md
```

---

## Prerequisites

- .NET 9 SDK

Verify installation:

```bash
dotnet --version
```

---

## Restore Packages

```bash
dotnet restore
```

---

## Build

```bash
dotnet build
```

---

## Run Commands

### Cleanup

```bash
dotnet run -- cleanup
```

Output:

```text
Running cleanup...
```

---

### Generate Report

```bash
dotnet run -- generate-report -d 2026-06-16
```

Output:

```text
Generating report for 2026-06-16
```

---

### Send Email

```bash
dotnet run -- send-email -r user@test.com
```

Output:

```text
Sending email to user@test.com
```

---

## View Available Commands

```bash
dotnet run -- --help
```

Example Output:

```text
Commands:
  cleanup
  generate-report
  send-email
```

---

## Visual Studio Debugging

Example launchSettings.json:

```json
{
  "profiles": {
    "Cleanup": {
      "commandName": "Project",
      "commandLineArgs": "cleanup"
    },
    "GenerateReport": {
      "commandName": "Project",
      "commandLineArgs": "generate-report -d 2026-06-16"
    },
    "SendEmail": {
      "commandName": "Project",
      "commandLineArgs": "send-email -r user@test.com"
    }
  }
}
```

Select the desired profile and press **F5**.

---

## Creating New Commands

Add a command method to AppCommands.cs:

```csharp
[Command("archive")]
public async Task Archive()
{
    await _archiveService.RunAsync();
}
```

Run:

```bash
dotnet run -- archive
```

---

## Scheduler Example

One executable can execute multiple jobs.

```bash
myapp cleanup
myapp archive
myapp customer-sync
myapp send-notifications
```

Examples:

### Autosys

```bash
myapp archive
```

### Kubernetes CronJob

```yaml
args:
  - customer-sync
```

### Jenkins

```bash
./myapp send-notifications
```

This allows a single Docker image and executable to support many scheduled jobs.

---

## Publish

Create a self-contained executable:

```bash
dotnet publish -c Release
```

Published output:

```text
bin/
└── Release/
    └── net9.0/
        └── publish/
```

Run:

```bash
CoconaSample.exe cleanup
```

or

```bash
./CoconaSample cleanup
```

---

## Technologies

- .NET 9
- Cocona
- Microsoft Dependency Injection
- C#

---

## License

Sample project for learning and demonstration purposes.
