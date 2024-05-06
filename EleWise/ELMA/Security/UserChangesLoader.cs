// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.UserChangesLoader
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  /// <summary>
  /// Компонент загрузки изменений по пользователям <see cref="T:EleWise.ELMA.Security.Models.IUser" /> и всем наследникам
  /// </summary>
  [Component]
  public class UserChangesLoader : EntityChangesLoader
  {
    internal static UserChangesLoader UFLKMnDhwerxNvpVK7H;

    /// <summary>
    /// Поддерживается ли тип сущности данной точкой расширения
    /// </summary>
    /// <param name="typeUid">Идентификатор типа сущности</param>
    /// <returns><c>true</c>, если поддерживается</returns>
    public override bool IsTypeSupported(Guid typeUid)
    {
      int num = 4;
      ClassMetadata classMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (InterfaceActivator.LoadMetadata<EleWise.ELMA.Security.Models.IUser>() != classMetadata)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 1 : 1;
              continue;
            }
            goto label_7;
          case 3:
            if (classMetadata == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 4:
            classMetadata = UserChangesLoader.QoS8bHDOrgJwTMncO2l(typeUid, true, true) as ClassMetadata;
            num = 3;
            continue;
          default:
            goto label_8;
        }
      }
label_6:
      return UserChangesLoader.BtDbOODT2U003Yudkp0(InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>(), (object) classMetadata, true);
label_7:
      return true;
label_8:
      return false;
    }

    public UserChangesLoader()
    {
      UserChangesLoader.NCjZ3FDF7K5vOHpntMe();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object QoS8bHDOrgJwTMncO2l([In] Guid obj0, [In] bool obj1, [In] bool obj2) => (object) MetadataLoader.LoadMetadata(obj0, obj1, obj2);

    internal static bool BtDbOODT2U003Yudkp0([In] Guid obj0, [In] object obj1, [In] bool obj2) => MetadataLoader.IsBaseClass(obj0, (ClassMetadata) obj1, obj2);

    internal static bool vmeUcbDBWhGxfAgglZS() => UserChangesLoader.UFLKMnDhwerxNvpVK7H == null;

    internal static UserChangesLoader aXuI57DpY7LLNk13vqp() => UserChangesLoader.UFLKMnDhwerxNvpVK7H;

    internal static void NCjZ3FDF7K5vOHpntMe() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
