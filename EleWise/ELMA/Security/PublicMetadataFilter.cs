// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.PublicMetadataFilter
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models.API;
using EleWise.ELMA.Services.Public;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  [Component]
  internal class PublicMetadataFilter : IPublicMetadataFilter
  {
    private static readonly Guid PublicApplication;
    private static readonly Guid PublicApplicationToken;
    private static readonly Guid PublicClientSession;
    private static readonly Guid PublicClientCacheToken;
    private static PublicMetadataFilter kxaN3BUuWYtwSu1BoCK;

    static PublicMetadataFilter()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            PublicMetadataFilter.PublicApplication = InterfaceActivator.UID<IPublicApplication>();
            num = 5;
            continue;
          case 2:
            PublicMetadataFilter.Kfw1TEUK3PFWuWD9y9O();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            PublicMetadataFilter.PublicClientSession = InterfaceActivator.UID<IPublicClientSession>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 0 : 0;
            continue;
          case 5:
            PublicMetadataFilter.PublicApplicationToken = InterfaceActivator.UID<IPublicApplicationToken>();
            num = 4;
            continue;
          default:
            PublicMetadataFilter.PublicClientCacheToken = InterfaceActivator.UID<IPublicClientCacheToken>();
            num = 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Функция фильтрации метаданных</summary>
    public Func<IMetadata, bool> Filter => new Func<IMetadata, bool>(PublicMetadataFilter.FilterMetadata);

    private static bool FilterMetadata(object md)
    {
      int num = 3;
      EntityMetadata entityMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!PublicMetadataFilter.ACGyFjURBTjTY9ub2Lv(PublicMetadataFilter.MgxCwgUUJ0QGChvoPNm((object) entityMetadata), PublicMetadataFilter.PublicApplicationToken))
            {
              num = 4;
              continue;
            }
            goto case 5;
          case 2:
            if (entityMetadata == null)
            {
              num = 7;
              continue;
            }
            goto case 6;
          case 3:
            entityMetadata = md as EntityMetadata;
            num = 2;
            continue;
          case 4:
            goto label_12;
          case 5:
            if (PublicMetadataFilter.MgxCwgUUJ0QGChvoPNm((object) entityMetadata) != PublicMetadataFilter.PublicClientSession)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0 ? 0 : 0;
              continue;
            }
            goto label_12;
          case 6:
            if (PublicMetadataFilter.ACGyFjURBTjTY9ub2Lv(PublicMetadataFilter.MgxCwgUUJ0QGChvoPNm((object) entityMetadata), PublicMetadataFilter.PublicApplication))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 1 : 1;
              continue;
            }
            goto label_12;
          case 7:
            goto label_13;
          default:
            goto label_11;
        }
      }
label_11:
      return PublicMetadataFilter.ACGyFjURBTjTY9ub2Lv(entityMetadata.Uid, PublicMetadataFilter.PublicClientCacheToken);
label_12:
      return false;
label_13:
      return true;
    }

    public PublicMetadataFilter()
    {
      PublicMetadataFilter.Kfw1TEUK3PFWuWD9y9O();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void Kfw1TEUK3PFWuWD9y9O() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool eWptewUwjdcEMxSxLub() => PublicMetadataFilter.kxaN3BUuWYtwSu1BoCK == null;

    internal static PublicMetadataFilter ftRsiIUbKXE12G2MBlb() => PublicMetadataFilter.kxaN3BUuWYtwSu1BoCK;

    internal static Guid MgxCwgUUJ0QGChvoPNm([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool ACGyFjURBTjTY9ub2Lv([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;
  }
}
