﻿using System.Reflection;
using FirstPersonHider.Properties;
using MelonLoader;


[assembly: AssemblyVersion(AssemblyInfoParams.Version)]
[assembly: AssemblyFileVersion(AssemblyInfoParams.Version)]
[assembly: AssemblyInformationalVersion(AssemblyInfoParams.Version)]
[assembly: AssemblyTitle(nameof(FirstPersonHider))]
[assembly: AssemblyCompany(AssemblyInfoParams.Author)]
[assembly: AssemblyProduct(nameof(FirstPersonHider))]

[assembly: MelonInfo(
    typeof(FirstPersonHider.FirstPersonHider),
    nameof(FirstPersonHider),
    AssemblyInfoParams.Version,
    AssemblyInfoParams.Author,
    downloadLink: "https://github.com/kafeijao/Kafe_CVR_Mods"
)]
[assembly: MelonGame("Alpha Blend Interactive", "ChilloutVR")]
[assembly: MelonPlatform(MelonPlatformAttribute.CompatiblePlatforms.WINDOWS_X64)]
[assembly: MelonPlatformDomain(MelonPlatformDomainAttribute.CompatibleDomains.MONO)]
[assembly: MelonColor(ConsoleColor.Green)]
[assembly: MelonAuthorColor(ConsoleColor.DarkYellow)]

namespace FirstPersonHider.Properties;
internal static class AssemblyInfoParams {
    public const string Version = "1.0.0";
    public const string Author = "kafeijao";
}

