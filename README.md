# Developer Console Toggle - Forage Wizard

A lightweight BepInEx plugin for *Forage Wizard* that restores the ability to toggle the hidden Developer Console using a simple hotkey. 

## 🎮 Features
* **Developer Console:** Press the ``` ` ``` / BackTick / Tilde key (The '~' key under your ESC button) in-game after loading a save file to expose the Developer Console UI
* **Seamless Integration:** Runs non-destructively in the background and safely waits until you load into a save file before attaching to the user interface.

## 🛠️ Requirements
* [BepInEx 6.0.0+ (IL2CPP)](https://builds.bepinex.dev/projects/bepinex_be)
* Forage Wizard ([Steam](https://store.steampowered.com/app/3868320/Forage_Wizard/))

## 📥 Installation

**For Players:**
1. Ensure you have BepInEx installed for Forage Wizard.
2. Download the latest `ForageWizard-DeveloperConsole.zip` from the [Releases](../../releases) tab.
3. Extract the ZIP file directly into your main Forage Wizard game directory. The folders will automatically merge and place the plugin in the correct location. Or you can manually extract the DLL file from the `BepInEx/plugins` folder in the ZIP file and manually place it in the game's `BepInEx/plugins` folder
4. Launch the game, load your save, and press `` ` ``!

## 💻 Build Instructions

If you would like to compile this plugin from scratch, follow these steps:

1. Download and install the [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).
2. Create a new project folder on your machine and open a Terminal or PowerShell window inside that directory
3. Install the BepInEx templates by running:
   `dotnet new install BepInEx.Templates@2.0.0-be.4 --nuget-source https://nuget.bepinex.dev/v3/index.json`
4. Generate the base plugin structure by running:
   `dotnet new bep6plugin_unity_il2cpp -n DeveloperConsoleToggle`
5. Navigate into the newly created `DeveloperConsoleToggle` folder. Open the `DeveloperConsoleToggle.csproj` file in a text editor and replace its entire contents with the `.csproj` file provided in this repository
6. **Important:** Edit the `<GameDir>` element within the `.csproj` file to match the exact installation path of your game
7. Replace the generated `Plugin.cs` file with the version from this repository
8. Clean the build environment by running:
   `dotnet clean`
9. Compile the plugin by running:
   `dotnet build`
   *(Note: The initial build will take some time as it interops the IL2CPP game assemblies).*
10. Once finished, navigate to `bin/Debug/net6.0/` inside your project folder to find your compiled `DeveloperConsoleToggle.dll`
11. Copy this `.dll` into your game's `BepInEx/plugins/` directory. You have successfully built the plugin from scratch!

## 📄 License
This project is open-source and available under the MIT License.
