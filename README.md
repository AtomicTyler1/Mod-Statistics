# 📊 Mod Statistics
**A unified C# solution for tracking mod analytics across multiple platforms.**

Mod Statistics provides an easy-to-clone and highly customizable system to monitor your project's performance on **Thunderstore**, **Steam Workshop**, and **NexusMods**.

Please note this has support for github gists, github actions and also the need for API keys for **Steam** and **Nexus**

---

## 🚀 Quick Start

1. **Clone the Repository**: Get a local copy of the code.
2. **API Keys**: Ensure you have your API keys ready for the platforms you wish to track. 
   > **Note:** These keys are used strictly for endpoint verification. The application does not collect or share this data.
3. **Configure your Mods**: Edit the following JSON files to add or remove your mods:
   * `thunderstore.json`
   * `steam.json`
   * `nexusmods.json`
4. **Disable features:** Don't have any steam, thunderstore or nexus mods?
   * Find `Program.cs` and disable the 3 bools found at the top!
   * Set the ones you don't want to false!

> [!IMPORTANT]
> Keep the internal structure of the `.json` files exactly the same unless you plan to modify the C# source code yourself.

---

## 🛠 Features

* **Platform Versatility**: Unified tracking for Thunderstore, Steam Workshop, and NexusMods.
* **C#**: Built for performance and easy integration into existing .NET workflows.
* **JSON Configuration**: Simple, human-readable files for managing your mod list.

---

## 🐧 Linux Guide

To build a self-contained, single-file executable for Linux, run the following command:

```bash
dotnet publish -c Release -r linux-x64 --self-contained true /p:PublishSingleFile=true -o build && ./build/ModStatistics
```

**To Run**: Drag the generated executable from the build folder into your terminal!

## 🤝 Community & Support

If you run into issues or have questions, feel free to reach out:

* The discord server: https://discord.gg/PGf9aa9n2t
* Dm `@atomictyler` on discord!
* Visit my website: https://atomictyler.dev/
