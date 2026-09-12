# PvZ Fusion Unlimited Mod

A **LemonLoader** mod for **Plants vs. Zombies: Fusion** that adds:
- ✅ **Unlimited Suns** (999,999 suns always available)
- ✅ **No Cooldown** (Plants/cards ready instantly)

## 🚀 Quick Start (GitHub Codespaces)

### Step 1: Open Codespaces
1. Go to your repo: https://github.com/portal704/PvZ-Fusion-Unlimited-Mod
2. Click **<> Code** (green button)
3. Select **Codespaces** tab
4. Click **Create codespace on main**
5. Wait for it to load (takes ~2 min)

### Step 2: Build the Mod in Codespaces

Run these commands in the terminal:

```bash
# Navigate to project
cd PvZ-Fusion-Unlimited-Mod

# Restore dependencies
dotnet restore

# Build the DLL
dotnet build --configuration Release
```

The compiled DLL will be at:
```
bin/Release/net6.0/PvZFusionUnlimitedMod.dll
```

### Step 3: Download the DLL

1. In Codespaces file explorer (left sidebar), navigate to `bin/Release/net6.0/`
2. Right-click `PvZFusionUnlimitedMod.dll`
3. Click **Download**
4. Save it to your device

### Step 4: Install in PvZ Fusion

1. **Locate PvZ Fusion game folder:**
   - If on Android: Use a file manager app to find the game directory
   - If on PC: Right-click game in Steam → Manage → Browse local files

2. **Find the LemonMods folder** (if it doesn't exist, create it):
   ```
   PvZFusion_GameFolder/LemonMods/
   ```

3. **Place the DLL there:**
   ```
   PvZFusion_GameFolder/LemonMods/PvZFusionUnlimitedMod.dll
   ```

4. **Launch PvZ Fusion** with LemonLoader

✅ **Mod is now active!** You'll have unlimited suns and no cooldowns.

---

## 📋 Requirements

- **.NET 6.0 SDK** (installed in Codespaces automatically)
- **LemonLoader** installed on PvZ Fusion
- **Harmony library** (included via NuGet)

---

## 🔧 Features

### Unlimited Suns
- Players start with 999,999 suns
- Sun consumption is blocked
- Sun cap is removed

### No Cooldown
- All plants are instantly ready to use
- Plant cards have 0 cooldown
- Card cooldown system is disabled

---

## 📝 Troubleshooting

**DLL not loading?**
- Ensure LemonLoader is installed in PvZ Fusion
- Check that the DLL is in the `LemonMods/` folder
- Try restarting the game

**Build fails in Codespaces?**
- Run `dotnet restore` first
- Check that .NET 6.0 is installed: `dotnet --version`
- Make sure you're in the project directory

**Game crashes after installing?**
- Remove the DLL from `LemonMods/`
- Check that you're using the correct version of PvZ Fusion
- Try updating LemonLoader

---

## 🛠️ Customization

Want to change the unlimited suns value? Edit `src/Main.cs`:

```csharp
__instance.currentSuns = 999999;  // Change this number
```

Want to add more features? Add more patch methods in the `src/Main.cs` file!

---

## ⚖️ License

This mod is provided as-is for personal use. Respect the original PvZ Fusion creators.

---

## 📞 Support

Having issues? Check:
- LemonLoader GitHub: https://github.com/Lemon-Mods/LemonLoader
- PvZ Fusion modding Discord: (check community servers)
