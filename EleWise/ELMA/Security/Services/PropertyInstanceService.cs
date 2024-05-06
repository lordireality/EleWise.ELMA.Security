// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.PropertyInstanceService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Services
{
  [Service(Scope = ServiceScope.Application, Type = ComponentType.Server)]
  internal class PropertyInstanceService : IPropertyInstanceService
  {
    private static PropertyInstanceService m9d6OySUynnFFeS4bdS;

    public IEnumerable<IPropertyPermissionAdapter> Adapters { get; set; }

    public IEnumerable<IAbstractPropertyProfile> GetPropertyProfiles(
      IPropertyOwnerProfile owner)
    {
      return this.GetAdapterByOwner(owner).GetPropertyProfiles(owner);
    }

    public IPropertyMetadata GetPropertyMetadata(IAbstractPropertyProfile profile)
    {
      int num1 = 11;
      PropertyMetadata propertyMetadata1;
      IPropertyMetadata propertyMetadata2;
      while (true)
      {
        int num2 = num1;
        ClassMetadata classMetadata;
        EntityMetadata entityMetadata;
        IAbstractPropertyProfile profile1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              if (propertyMetadata2 != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c == 0 ? 4 : 0;
                continue;
              }
              goto label_13;
            case 3:
              if (entityMetadata == null)
              {
                num2 = 8;
                continue;
              }
              goto case 7;
            case 4:
              goto label_12;
            case 5:
              if (propertyMetadata1 != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 == 0 ? 0 : 1;
                continue;
              }
              goto label_7;
            case 6:
              classMetadata = this.GetClassMetadata(profile1);
              num2 = 9;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              propertyMetadata2 = entityMetadata.TableParts.OfType<IPropertyMetadata>().FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (property => PropertyInstanceService.\u003C\u003Ec__DisplayClass5_0.h9f8LSwjNUuOYIpPLlGQ(PropertyInstanceService.\u003C\u003Ec__DisplayClass5_0.Q3tDoewjjdpfiqb4RbXY((object) property), PropertyInstanceService.\u003C\u003Ec__DisplayClass5_0.lNyJ6nwj3j5HoCIRHly0((object) profile1))));
              num2 = 2;
              continue;
            case 8:
              goto label_13;
            case 9:
              if (classMetadata != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 != 0 ? 0 : 0;
                continue;
              }
              goto label_13;
            case 10:
              goto label_3;
            case 11:
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 10 : 6;
              continue;
            default:
              goto label_14;
          }
        }
label_3:
        profile1 = profile;
        num1 = 6;
        continue;
label_7:
        entityMetadata = classMetadata as EntityMetadata;
        num1 = 3;
        continue;
label_14:
        propertyMetadata1 = classMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
        {
          int num3 = 1;
          Guid guid;
          while (true)
          {
            switch (num3)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                guid = PropertyInstanceService.\u003C\u003Ec__DisplayClass5_0.hBmcPewji1O26NtpHHX0((object) p);
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 == 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
label_2:
          // ISSUE: reference to a compiler-generated method
          return guid.Equals(PropertyInstanceService.\u003C\u003Ec__DisplayClass5_0.lNyJ6nwj3j5HoCIRHly0((object) profile1));
        }));
        num1 = 5;
      }
label_6:
      return (IPropertyMetadata) propertyMetadata1;
label_12:
      PropertyMetadata propertyMetadata3 = new PropertyMetadata();
      PropertyInstanceService.cmBjcsSmIDgo36kAhjt((object) propertyMetadata3, PropertyInstanceService.hHUF9VSt8pfAB4jgS8v((object) propertyMetadata2));
      propertyMetadata3.DisplayName = (string) PropertyInstanceService.wAFSQoS6J7bRShL1EkM((object) propertyMetadata2);
      PropertyInstanceService.I6l2OKSkde67BMvKfkL((object) propertyMetadata3, propertyMetadata2.PropertyUid);
      PropertyInstanceService.UuLqSlSauF42wgHaHXI((object) propertyMetadata3, PropertyInstanceService.LBP8R7SD7k7Q8wKi7Sg((object) propertyMetadata2));
      return (IPropertyMetadata) propertyMetadata3;
label_13:
      return (IPropertyMetadata) null;
    }

    public IEntityMetadata GetMetadata(IAbstractPropertyProfile profile) => this.GetClassMetadata(profile) as IEntityMetadata;

    public IEnumerable<IPropertyMetadata> GetPropertyMetadataList(
      IPropertyOwnerProfile owner)
    {
      return this.GetAdapterByOwner(owner).GetPropertyMetadataList(owner);
    }

    public IAbstractPropertyProfile CreateProfile(
      IPropertyOwnerProfile owner,
      Guid propertyUid)
    {
      return this.GetAdapterByOwner(owner).CreateProfile(owner, propertyUid);
    }

    public void SaveProfiles(
      IPropertyOwnerProfile owner,
      IEnumerable<IAbstractPropertyProfile> profiles)
    {
      this.GetAdapterByOwner(owner).SaveProfiles(owner, profiles);
    }

    public bool IsTitleProperty(IAbstractPropertyProfile profile)
    {
      int num = 2;
      ClassMetadata classMetadata;
      Guid guid;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (classMetadata != null)
            {
              num = 4;
              continue;
            }
            goto label_3;
          case 2:
            classMetadata = this.GetClassMetadata(profile);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 1 : 1;
            continue;
          case 3:
            if (guid.Equals(PropertyInstanceService.xTt6DGSCqWXtvA3myeH((object) profile)))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 4:
            guid = PropertyInstanceService.dHUTQWSxRSqSR4qNRIM((object) classMetadata);
            num = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return true;
label_3:
      return false;
    }

    public Guid GetTitlePropertyGuid(IPropertyOwnerProfile owner)
    {
      int num = 2;
      ClassMetadata classMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (classMetadata == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            classMetadata = this.GetClassMetadata(owner);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return Guid.Empty;
label_6:
      return PropertyInstanceService.dHUTQWSxRSqSR4qNRIM((object) classMetadata);
    }

    public Guid GetHidePermissionId(IPropertyOwnerProfile owner) => PropertyInstanceService.KTntKNSiKOVIpydsa3q((object) this.GetAdapterByOwner(owner));

    public Guid GetViewPermissionId(IPropertyOwnerProfile owner) => PropertyInstanceService.KmQf9AS3S1GqB6RxHYs((object) this.GetAdapterByOwner(owner));

    public Guid GetEditPermissionId(IPropertyOwnerProfile owner) => PropertyInstanceService.gtgRoNSjsNV0bC1g7YU((object) this.GetAdapterByOwner(owner));

    /// <summary>Возвращает метаданные класса для адаптера</summary>
    /// <param name="profile">Профиль свойства</param>
    /// <returns></returns>
    public ClassMetadata GetClassMetadata(IAbstractPropertyProfile profile)
    {
      int num = 1;
      IMetadata metadata;
      IPropertyPermissionAdapter adapterByProfile;
      while (true)
      {
        switch (num)
        {
          case 1:
            adapterByProfile = this.GetAdapterByProfile(profile);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 == 0 ? 0 : 0;
            continue;
          case 2:
            metadata = (IMetadata) PropertyInstanceService.sdADNESNkqfZBnAYQBs((object) adapterByProfile, (object) profile);
            num = 3;
            continue;
          case 3:
            goto label_2;
          default:
            if (!(adapterByProfile is IClassMetadataPropertyPermissionAdapter))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 != 0 ? 2 : 1;
              continue;
            }
            goto label_7;
        }
      }
label_2:
      object classMetadata = (object) metadata;
      goto label_8;
label_7:
      classMetadata = PropertyInstanceService.THZsqsS0nB6sQbfUi9y((object) (IClassMetadataPropertyPermissionAdapter) adapterByProfile, (object) profile);
label_8:
      return classMetadata as ClassMetadata;
    }

    /// <summary>Возвращает метаданные класса для адаптера</summary>
    /// <param name="owner">Экземпляр объекта, для которого настраиваются права доступа на свойства</param>
    /// <returns></returns>
    public ClassMetadata GetClassMetadata(IPropertyOwnerProfile owner)
    {
      int num = 2;
      IMetadata metadata;
      IPropertyPermissionAdapter adapterByOwner;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(adapterByOwner is IClassMetadataPropertyPermissionAdapter))
            {
              num = 3;
              continue;
            }
            goto label_7;
          case 2:
            adapterByOwner = this.GetAdapterByOwner(owner);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 != 0 ? 1 : 1;
            continue;
          case 3:
            metadata = (IMetadata) adapterByOwner.GetMetadata(owner);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      object classMetadata = (object) metadata;
      goto label_8;
label_7:
      classMetadata = PropertyInstanceService.k1jEjrSZQnRZ94KbA3f((object) (IClassMetadataPropertyPermissionAdapter) adapterByOwner, (object) owner);
label_8:
      return classMetadata as ClassMetadata;
    }

    private IPropertyPermissionAdapter GetAdapterByOwner(
      IPropertyOwnerProfile owner)
    {
      int num1 = 2;
      IPropertyPermissionAdapter adapterByOwner;
      IPropertyOwnerProfile owner1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              owner1 = owner;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 == 0 ? 0 : 0;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 != 0 ? 1 : 0;
              continue;
            case 3:
              goto label_7;
            case 4:
              goto label_10;
            case 5:
              if (adapterByOwner == null)
              {
                num2 = 3;
                continue;
              }
              goto label_8;
            case 6:
              // ISSUE: reference to a compiler-generated method
              adapterByOwner = this.Adapters.FirstOrDefault<IPropertyPermissionAdapter>((Func<IPropertyPermissionAdapter, bool>) (a => PropertyInstanceService.\u003C\u003Ec__DisplayClass17_0.CGXV1Ywj72tKidtBSrZf((object) a, owner1.GetType())));
              num2 = 5;
              continue;
            default:
              PropertyInstanceService.ImXiw6SsncYbetJ5mT1((object) owner1, PropertyInstanceService.mgyiDoSAjc0l0shoGqh(-1310136491 - -570921450 ^ -739238549));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0 ? 4 : 1;
              continue;
          }
        }
label_10:
        PropertyInstanceService.iQKXkoS7L8SN5x8BgTV((object) this.Adapters, PropertyInstanceService.mgyiDoSAjc0l0shoGqh(-1257514304 ^ -1257521502));
        num1 = 6;
      }
label_7:
      throw new InvalidOperationException((string) PropertyInstanceService.lcuxSwSWUYFOC6b5eAh((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1880054609 ^ -1880047399), (object) new object[1]
      {
        (object) owner1.GetType()
      }));
label_8:
      return adapterByOwner;
    }

    private IPropertyPermissionAdapter GetAdapterByProfile(
      IAbstractPropertyProfile profile)
    {
      int num1 = 4;
      IPropertyPermissionAdapter adapterByProfile;
      IAbstractPropertyProfile profile1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              PropertyInstanceService.iQKXkoS7L8SN5x8BgTV((object) this.Adapters, PropertyInstanceService.mgyiDoSAjc0l0shoGqh(1780597820 ^ 1780588638));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 == 0 ? 2 : 6;
              continue;
            case 3:
              profile1 = profile;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0 ? 0 : 0;
              continue;
            case 4:
              num2 = 3;
              continue;
            case 5:
              if (adapterByProfile == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 1 : 0;
                continue;
              }
              goto label_10;
            case 6:
              // ISSUE: reference to a compiler-generated method
              adapterByProfile = this.Adapters.FirstOrDefault<IPropertyPermissionAdapter>((Func<IPropertyPermissionAdapter, bool>) (a => PropertyInstanceService.\u003C\u003Ec__DisplayClass18_0.veldbOwjyuyWH9urJ6fQ((object) a, profile1.GetType())));
              num2 = 5;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        Contract.ArgumentNotNull((object) profile1, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1687460816 ^ 1687486268));
        num1 = 2;
      }
label_9:
      throw new InvalidOperationException((string) PropertyInstanceService.lcuxSwSWUYFOC6b5eAh(PropertyInstanceService.mgyiDoSAjc0l0shoGqh(-517128429 ^ -517121043), (object) new object[1]
      {
        (object) profile1.GetType()
      }));
label_10:
      return adapterByProfile;
    }

    public PropertyInstanceService()
    {
      PropertyInstanceService.RQso31SrlAMW5iyctxW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object hHUF9VSt8pfAB4jgS8v([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static void cmBjcsSmIDgo36kAhjt([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static object wAFSQoS6J7bRShL1EkM([In] object obj0) => (object) ((INamedMetadata) obj0).DisplayName;

    internal static void I6l2OKSkde67BMvKfkL([In] object obj0, [In] Guid obj1) => ((AbstractMetadata) obj0).Uid = obj1;

    internal static bool LBP8R7SD7k7Q8wKi7Sg([In] object obj0) => ((IPropertyMetadata) obj0).Required;

    internal static void UuLqSlSauF42wgHaHXI([In] object obj0, [In] bool obj1) => ((PropertyMetadata) obj0).Required = obj1;

    internal static bool sbUPB3SRjIKxJSObD6h() => PropertyInstanceService.m9d6OySUynnFFeS4bdS == null;

    internal static PropertyInstanceService I4uirASoW7o7yWBcQsO() => PropertyInstanceService.m9d6OySUynnFFeS4bdS;

    internal static Guid dHUTQWSxRSqSR4qNRIM([In] object obj0) => ((ClassMetadata) obj0).TitlePropertyUid;

    internal static Guid xTt6DGSCqWXtvA3myeH([In] object obj0) => ((IAbstractPropertyProfile) obj0).PropertyGuid;

    internal static Guid KTntKNSiKOVIpydsa3q([In] object obj0) => ((IPropertyPermissionAdapter) obj0).GetHidePermissionId();

    internal static Guid KmQf9AS3S1GqB6RxHYs([In] object obj0) => ((IPropertyPermissionAdapter) obj0).GetViewPermissionId();

    internal static Guid gtgRoNSjsNV0bC1g7YU([In] object obj0) => ((IPropertyPermissionAdapter) obj0).GetEditPermissionId();

    internal static object sdADNESNkqfZBnAYQBs([In] object obj0, [In] object obj1) => (object) ((IPropertyPermissionAdapter) obj0).GetMetadata((IAbstractPropertyProfile) obj1);

    internal static object THZsqsS0nB6sQbfUi9y([In] object obj0, [In] object obj1) => (object) ((IClassMetadataPropertyPermissionAdapter) obj0).GetBaseMetadata((IAbstractPropertyProfile) obj1);

    internal static object k1jEjrSZQnRZ94KbA3f([In] object obj0, [In] object obj1) => (object) ((IClassMetadataPropertyPermissionAdapter) obj0).GetBaseMetadata((IPropertyOwnerProfile) obj1);

    internal static object mgyiDoSAjc0l0shoGqh(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void ImXiw6SsncYbetJ5mT1([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void iQKXkoS7L8SN5x8BgTV([In] object obj0, [In] object obj1) => Contract.ServiceNotNull(obj0, (string) obj1);

    internal static object lcuxSwSWUYFOC6b5eAh([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

    internal static void RQso31SrlAMW5iyctxW() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
