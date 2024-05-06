// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Extensions.ExternalMembershipSettingsExtension
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Security.Settings;
using EleWise.ELMA.Services;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Extensions
{
  /// <summary>
  /// Расширение настроек модуля авторизации IExternalMembershipModule
  /// </summary>
  public static class ExternalMembershipSettingsExtension
  {
    private static ExternalMembershipSettingsExtension tT0g46qv9Qq6unudqK1;

    /// <summary>
    /// Модуль авторизации для которого применяются эти настройки
    /// </summary>
    /// <param name="settings"></param>
    /// <returns></returns>
    public static IExternalMembershipModule Module(
      this IExternalMembershipModuleSettings settings)
    {
      return (IExternalMembershipModule) ExternalMembershipSettingsExtension.QUIEcOqImJgr45cN6eG((object) Locator.GetServiceNotNull<IExternalMembershipManager>(), ExternalMembershipSettingsExtension.CypZXgqJOGKqnMRdCcn((object) settings));
    }

    internal static Guid CypZXgqJOGKqnMRdCcn([In] object obj0) => ((IExternalMembershipModuleSettings) obj0).ModuleUid;

    internal static object QUIEcOqImJgr45cN6eG([In] object obj0, Guid moduleUid) => (object) ((IExternalMembershipManager) obj0).GetModule(moduleUid);

    internal static bool OKctACqqWMItWcuurTr() => ExternalMembershipSettingsExtension.tT0g46qv9Qq6unudqK1 == null;

    internal static ExternalMembershipSettingsExtension y5CdQqqgMbtKIh4GHTx() => ExternalMembershipSettingsExtension.tT0g46qv9Qq6unudqK1;
  }
}
