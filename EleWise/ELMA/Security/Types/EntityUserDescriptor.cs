// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Types.EntityUserDescriptor
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Security.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Types
{
  /// <summary>Дескриптор для типа "Сущность-&gt;Пользователь"</summary>
  public class EntityUserDescriptor : EntitySubTypeDescriptor<EleWise.ELMA.Security.Models.IUser>
  {
    private static readonly Guid UserEntityUid;
    internal static EntityUserDescriptor PFcG4Aavn06c0vhPUII;

    /// <summary>Тип настроек</summary>
    public override Type SettingsType => EntityUserDescriptor.cPryNHaJ2N5XJO1ug3i(__typeref (EntityUserSettings));

    /// <summary>Уникальный идентификатор сущности</summary>
    protected override Guid EntityUid => EntityUserDescriptor.UserEntityUid;

    public override TypeSettings CreateSettingsForFilterProperty(
      PropertyMetadata propertyMetadata)
    {
      object forFilterProperty;
      EntityUserDescriptor.lE3XLAae6J5HB9VHI1A((object) (EntityUserSettings) (forFilterProperty = EntityUserDescriptor.b2RAJAaIdi6lyt4Cclr((object) this, (object) propertyMetadata)), true);
      return (TypeSettings) forFilterProperty;
    }

    public EntityUserDescriptor()
    {
      EntityUserDescriptor.rc3ntIanBGQZyTkAPtW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EntityUserDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            EntityUserDescriptor.UserEntityUid = new Guid((string) EntityUserDescriptor.P4mo2oaLNMluoeMUGDt(1245871191 - 2145700088 ^ -899813047));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static Type cPryNHaJ2N5XJO1ug3i([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object b2RAJAaIdi6lyt4Cclr([In] object obj0, [In] object obj1) => (object) __nonvirtual (((EntityDescriptor) obj0).CreateSettingsForFilterProperty((PropertyMetadata) obj1));

    internal static void lE3XLAae6J5HB9VHI1A([In] object obj0, bool value) => ((EntityUserSettings) obj0).ShowBlock = value;

    internal static bool feSYkqaqH4GtXGa05vr() => EntityUserDescriptor.PFcG4Aavn06c0vhPUII == null;

    internal static EntityUserDescriptor cCJyKwaggreLpTRP1RY() => EntityUserDescriptor.PFcG4Aavn06c0vhPUII;

    internal static void rc3ntIanBGQZyTkAPtW() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static object P4mo2oaLNMluoeMUGDt(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
