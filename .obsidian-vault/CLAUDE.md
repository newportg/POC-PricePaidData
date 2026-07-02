# Project

Short project description

## Tech Stack

|Layer | Tool |
|---|---|
| Note Vault | Obsidian (Local Markdown Files) |
| Editor | Visual Studio Code |
| AI Assistant | GitHub Copilot (Claude-powered)|
| Web App (demo) | Next.js |
| Server App | C# .Net |
| Deployment | Runs locally; |

## Current State

Initial

### Working

### Blocked / Broken

### Focus right now

### Key Decisons Made

These are settled. Do not reopen them without good reason.

* **GUI Language:** Typescript only - no plain Javascript files
* **GUI Framework:** Next.js LTS
* **GUI Styling:** Tailwind CSS v4
* **GUI Package Manager:** pnpm
* **APP Language:** C# - latest version
* **APP .NET:** Current LTS
* **APP Code Pattern:** Application coding should follow the principals of **Clean Coding** 
* **Note Vault:** Obsidian with plain Markdown - no proprietary plugins that break portability
* **AI Tooling:** GitHub Copilot (Claude) inside VS Code - not standalone chat.


### Directory Structure

These are settled. Do not reopen them without good reason.

\Project-Name
|--\Build - YML build scripts
|--\Deploy - YML deployment scripts
|--\Src
|----\Client - Javascript Web client
|----\Server - C# Server
|------\API - Azure Function (Open API)
|------\Domain - Business Logic / Rules
|------\Services - Third Party interfaces 
|--\Tests - BDD (reqnrole unit tests)
|Project-Name.sln - Solution file

