// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.UserPropertyProcessMetadataExtension
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>
  /// Реализация точки расширения для обработки дополнительных данных пользователя
  /// </summary>
  [Component]
  internal sealed class UserPropertyProcessMetadataExtension : IAdditionalProcessMetadataExtension
  {
    private static readonly Guid UserEntityUid;
    private static readonly Guid OrgItemEntityUid;
    private static UserPropertyProcessMetadataExtension oSNC3JzWUShUMEDGK0c;

    /// <inheritdoc />
    public bool Check(IPropertyMetadata propertyMetadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (propertyMetadata == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 == 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return UserPropertyProcessMetadataExtension.tGbLhizy1O3WYMI4LyK(UserPropertyProcessMetadataExtension.VOtw1VzYY5S6Jy089T3((object) propertyMetadata), UserPropertyProcessMetadataExtension.UserEntityUid);
label_5:
      return false;
    }

    /// <inheritdoc />
    public void ProcessMetadata(
      IPropertyMetadata propertyMetadata,
      Guid currentModuleUid,
      DependencyServiceOptions options,
      Dictionary<Guid, EnumDependency> enumDependencies,
      Dictionary<Guid, EntityDependency> entityDependencies,
      Dictionary<Guid, DataClassDependency> dataClassDependencies)
    {
      IMetadata metadata = MetadataServiceContext.Service.GetMetadata(UserPropertyProcessMetadataExtension.OrgItemEntityUid);
      if (metadata == null)
        return;
      DependencyServiceHelper.ProcessMetadata(currentModuleUid, metadata, options, enumDependencies, entityDependencies, dataClassDependencies);
    }

    public UserPropertyProcessMetadataExtension()
    {
      UserPropertyProcessMetadataExtension.dZdBU9zVOtgBwdjfn0v();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static UserPropertyProcessMetadataExtension()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            UserPropertyProcessMetadataExtension.UserEntityUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--306199571 ^ 306216453));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 != 0 ? 3 : 3;
            continue;
          case 2:
            UserPropertyProcessMetadataExtension.dZdBU9zVOtgBwdjfn0v();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 != 0 ? 1 : 1;
            continue;
          case 3:
            UserPropertyProcessMetadataExtension.OrgItemEntityUid = new Guid((string) UserPropertyProcessMetadataExtension.dUEty0zlqlPD3F4Y8nr(-1958977588 ^ -1958997670));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static Guid VOtw1VzYY5S6Jy089T3([In] object obj0) => ((IPropertyMetadata) obj0).SubTypeUid;

    internal static bool tGbLhizy1O3WYMI4LyK([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool vHDai9zrkThbjWoHV0l() => UserPropertyProcessMetadataExtension.oSNC3JzWUShUMEDGK0c == null;

    internal static UserPropertyProcessMetadataExtension JeqPnEzS9NPsS3cX1Hc() => UserPropertyProcessMetadataExtension.oSNC3JzWUShUMEDGK0c;

    internal static void dZdBU9zVOtgBwdjfn0v() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static object dUEty0zlqlPD3F4Y8nr(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
