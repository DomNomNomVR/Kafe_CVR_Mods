﻿using System.Reflection;
using Kafe.CVRUnverifiedModUpdaterPlugin;
using Kafe.CVRUnverifiedModUpdaterPlugin.Properties;
using MelonLoader;


[assembly: AssemblyVersion(AssemblyInfoParams.Version)]
[assembly: AssemblyFileVersion(AssemblyInfoParams.Version)]
[assembly: AssemblyInformationalVersion(AssemblyInfoParams.Version)]
[assembly: AssemblyTitle(nameof(CVRUnverifiedModUpdaterPlugin))]
[assembly: AssemblyCompany(AssemblyInfoParams.Author)]
[assembly: AssemblyProduct(nameof(CVRUnverifiedModUpdaterPlugin))]

[assembly: MelonInfo(
    typeof(CVRUnverifiedModUpdaterPlugin),
    nameof(Kafe.CVRUnverifiedModUpdaterPlugin),
    AssemblyInfoParams.Version,
    AssemblyInfoParams.Author,
    downloadLink: "https://github.com/kafeijao/Kafe_CVR_Mods"
)]
[assembly: MelonGame("Alpha Blend Interactive", "ChilloutVR")]
[assembly: MelonPlatform(MelonPlatformAttribute.CompatiblePlatforms.WINDOWS_X64)]
[assembly: MelonPlatformDomain(MelonPlatformDomainAttribute.CompatibleDomains.MONO)]
[assembly: MelonColor(ConsoleColor.Green)]
[assembly: MelonAuthorColor(ConsoleColor.DarkYellow)]

namespace Kafe.CVRUnverifiedModUpdaterPlugin.Properties;
internal static class AssemblyInfoParams {
    public const string Version = "0.0.1";
    public const string Author = "kafeijao";
}
