// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.DTO.Managers.OrganizationDTOManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.DTO.Managers
{
  /// <summary>Менеджер оргструктуры для работы через Remoting</summary>
  public class OrganizationDTOManager : DTOManager, IOrganizationDTOManager, IConfigurationService
  {
    private static OrganizationDTOManager ncQedu37T94J5WPe123;

    /// <summary>Менеджер модели оргструктуры</summary>
    public OrganizationModelManager Manager
    {
      get => this.\u003CManager\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 == 0 ? 0 : 0;
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

    public virtual OrganizationModelDTO LoadOrNull() => Mapper.Map<IOrganizationModel, OrganizationModelDTO>((IOrganizationModel) OrganizationDTOManager.meZByr3S5yqt5j94UjW((object) this.Manager), new OrganizationModelDTO());

    public virtual OrganizationModelDTO LoadOrNull(int id) => Mapper.Map<IOrganizationModel, OrganizationModelDTO>(this.Manager.Load(id), new OrganizationModelDTO());

    public virtual OrganizationModelDTO LoadPublishedOrNull() => Mapper.Map<IOrganizationModel, OrganizationModelDTO>(this.Manager.LoadPublishedOrNull(), new OrganizationModelDTO());

    public virtual void Save(OrganizationModelDTO organizationModel)
    {
      int num = 5;
      IOrganizationModel destination;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Manager.Save(destination);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 3 : 3;
            continue;
          case 3:
            goto label_8;
          case 4:
            if (destination.Id <= 0)
            {
              num = 2;
              continue;
            }
            goto case 6;
          case 5:
            destination = (IOrganizationModel) OrganizationDTOManager.meZByr3S5yqt5j94UjW((object) this.Manager);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 != 0 ? 3 : 4;
            continue;
          case 6:
            organizationModel.Id = destination.Id;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 0 : 0;
            continue;
          default:
            Mapper.Map<OrganizationModelDTO, IOrganizationModel>(organizationModel, destination);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 != 0 ? 0 : 1;
            continue;
        }
      }
label_8:;
    }

    public virtual int Publish(
      OrganizationModelDTO organizationModel,
      out OrganizationModelPublishWarning warning)
    {
      int num = 4;
      IOrganizationModel organizationModel1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
          case 5:
            Mapper.Map<OrganizationModelDTO, IOrganizationModel>(organizationModel, organizationModel1);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0 ? 0 : 0;
            continue;
          case 3:
            if (organizationModel1.Id <= 0)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0 ? 1 : 5;
              continue;
            }
            goto case 6;
          case 4:
            organizationModel1 = this.Manager.Load();
            num = 3;
            continue;
          case 6:
            organizationModel.Id = organizationModel1.Id;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 == 0 ? 2 : 0;
            continue;
          default:
            warning = (OrganizationModelPublishWarning) null;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0 ? 1 : 0;
            continue;
        }
      }
label_8:
      return this.Manager.Publish(organizationModel1, out warning);
    }

    public virtual int Publish(OrganizationModelDTO organizationModel)
    {
      int num = 1;
      IOrganizationModel destination;
      while (true)
      {
        switch (num)
        {
          case 1:
            destination = (IOrganizationModel) OrganizationDTOManager.meZByr3S5yqt5j94UjW((object) this.Manager);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e == 0 ? 0 : 0;
            continue;
          case 2:
          case 5:
            Mapper.Map<OrganizationModelDTO, IOrganizationModel>(organizationModel, destination);
            num = 4;
            continue;
          case 3:
            organizationModel.Id = destination.Id;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc != 0 ? 0 : 5;
            continue;
          case 4:
            goto label_2;
          default:
            if (destination.Id <= 0)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0 ? 0 : 2;
              continue;
            }
            goto case 3;
        }
      }
label_2:
      return OrganizationDTOManager.UZ7ItN3YKauEGJ7V8AL((object) this.Manager, (object) destination);
    }

    public virtual int Validate(OrganizationModelDTO organizationModel)
    {
      int num = 4;
      IOrganizationModel destination;
      while (true)
      {
        switch (num)
        {
          case 1:
            Mapper.Map<OrganizationModelDTO, IOrganizationModel>(organizationModel, destination);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 0 : 2;
            continue;
          case 2:
            goto label_6;
          case 3:
            if (destination.Id > 0)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          case 4:
            destination = this.Manager.Load();
            num = 3;
            continue;
          default:
            organizationModel.Id = destination.Id;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 != 0 ? 1 : 1;
            continue;
        }
      }
label_6:
      return OrganizationDTOManager.RV7DkQ3yyesBK7nussK((object) this.Manager, (object) destination);
    }

    public virtual int Validate(
      OrganizationModelDTO organizationModel,
      out OrganizationModelPublishWarning warning)
    {
      int num = 3;
      IOrganizationModel organizationModel1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (organizationModel1.Id > 0)
            {
              num = 5;
              continue;
            }
            goto case 4;
          case 3:
            organizationModel1 = this.Manager.Load();
            num = 2;
            continue;
          case 4:
            Mapper.Map<OrganizationModelDTO, IOrganizationModel>(organizationModel, organizationModel1);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 0 : 0;
            continue;
          case 5:
            organizationModel.Id = organizationModel1.Id;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 2 : 4;
            continue;
          default:
            warning = (OrganizationModelPublishWarning) null;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a == 0 ? 1 : 1;
            continue;
        }
      }
label_6:
      return this.Manager.Validate(organizationModel1, out warning);
    }

    public virtual ICollection<OrganizationVersionDTO> FindAllVersions() => this.Manager.FindAllVersions();

    public virtual int CurrentVersion => this.Manager.CurrentVersion;

    public OrganizationDTOManager()
    {
      OrganizationDTOManager.SP6qyx3VSdddAabfyoV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool lF5RDi3Wu1xt8V7YZw3() => OrganizationDTOManager.ncQedu37T94J5WPe123 == null;

    internal static OrganizationDTOManager pv88Jo3rDH4v57AvuHe() => OrganizationDTOManager.ncQedu37T94J5WPe123;

    internal static object meZByr3S5yqt5j94UjW([In] object obj0) => (object) ((OrganizationModelManager) obj0).Load();

    internal static int UZ7ItN3YKauEGJ7V8AL([In] object obj0, [In] object obj1) => ((OrganizationModelManager) obj0).Publish((IOrganizationModel) obj1);

    internal static int RV7DkQ3yyesBK7nussK([In] object obj0, [In] object obj1) => ((OrganizationModelManager) obj0).Validate((IOrganizationModel) obj1);

    internal static void SP6qyx3VSdddAabfyoV() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
