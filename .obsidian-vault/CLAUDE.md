# Project

This project will download and show the housing price paid information for England.
There will be a service which downloads, Initially,  the yearly data file from the UK Land Registry (https://price-paid-data.publicdata.landregistry.gov.uk/pp-YYYY.csv). Data is added to the current years file on a monthly basis, so there should be a scheduled task to download the current years file each month.
The Price Paid data will be stored in a PostgresDB.
The data will be accessible to a client via a Azure Function Open API Rest API.
A client will be written to get the data from the Rest API and display the information a Points on a LeafletJS Map display.
Due to the size of the information the client should never request all of the information, Instead the user can select from a series of filters to reduce the data set. These filters should be By Year, By  PostCode and By Property Category.
The client doesn't necessarily know either the years that are selectable or the property types available, so there should be a list for each. The post code file should accept any valid UK postcode WHOLE or PART.

## Tech Stack

| Layer          | Tool                                 |
| -------------- | ------------------------------------ |
| Note Vault     | Obsidian (Local Markdown Files)      |
| Editor         | Visual Studio Code                   |
| AI Assistant   | GitHub Copilot (Claude-powered)      |
| Web App (demo) | Next.js                              |
| Server App     | C#, .Net, Azure Function, PostgresDB |
| Deployment     | Runs locally;                        |

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
|--\Tests - BDD ([reqnrole](https://reqnroll.net/) unit tests)
|Project-Name.sln - Solution file

