// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.ProfilePermissionDescriptor
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Класс для представления связи между правами доступа типа и правами доступа профайлера типа
  /// </summary>
  public class ProfilePermissionDescriptor
  {
    internal static ProfilePermissionDescriptor AjM2k9YjcXRdT8WAc6C;

    /// <summary>Конструктор</summary>
    /// <param name="permission">Привлегия</param>
    /// <param name="profilePermission">Привилегия профайлера типа</param>
    public ProfilePermissionDescriptor(Permission permission, Permission profilePermission)
    {
      ProfilePermissionDescriptor.KUIcujYZgGIbNprNv4T();
      // ISSUE: explicit constructor call
      this.\u002Ector(permission, profilePermission, (Type) null);
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Конструктор</summary>
    /// <param name="permission">Привилегия</param>
    /// <param name="profilePermission">Привилегия профайлера типа</param>
    /// <param name="profileType">Тип профайлера</param>
    public ProfilePermissionDescriptor(
      Permission permission,
      Permission profilePermission,
      Type profileType)
    {
      ProfilePermissionDescriptor.KUIcujYZgGIbNprNv4T();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ProfileType = profileType;
            num = 3;
            continue;
          case 2:
            this.Permission = permission;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_3;
          default:
            this.ProfilePermission = profilePermission;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public Permission Permission
    {
      get => this.\u003CPermission\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CPermission\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public Permission ProfilePermission
    {
      get => this.\u003CProfilePermission\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CProfilePermission\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Тип профайлера</summary>
    public Type ProfileType
    {
      get => this.\u003CProfileType\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CProfileType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    internal static void KUIcujYZgGIbNprNv4T() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool R9W80JYNPIhW3M0sPuA() => ProfilePermissionDescriptor.AjM2k9YjcXRdT8WAc6C == null;

    internal static ProfilePermissionDescriptor ENgqy6Y0JRe1JKh8OHO() => ProfilePermissionDescriptor.AjM2k9YjcXRdT8WAc6C;
  }
}
