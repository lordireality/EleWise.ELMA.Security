// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Audit.HistoryPermissionInfo
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Security.Audit
{
  /// <summary>ИНформация о пермишене в истории</summary>
  [XmlRoot("HistoryPermissionInfo")]
  [Serializable]
  public class HistoryPermissionInfo
  {
    internal static HistoryPermissionInfo TT3alGwwoZySRf3MBnCH;

    /// <summary>Тип объекта на кого назначают</summary>
    [XmlElement("ObjectTypeUid")]
    public Guid ObjectTypeUid
    {
      get => this.\u003CObjectTypeUid\u003Ek__BackingField;
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
              this.\u003CObjectTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed == 0 ? 0 : 0;
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

    /// <summary>Тип роли</summary>
    [XmlElement("RoleTypeUid")]
    public Guid RoleTypeUid
    {
      get => this.\u003CRoleTypeUid\u003Ek__BackingField;
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
              this.\u003CRoleTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 0 : 0;
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

    /// <summary>Идентификатор того, на кого назначают</summary>
    [XmlElement("ObjectId")]
    public long ObjectId
    {
      get => this.\u003CObjectId\u003Ek__BackingField;
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
              this.\u003CObjectId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 0 : 0;
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

    /// <summary>Пекрмишен</summary>
    [XmlElement("PermissionId")]
    public Guid PermissionId
    {
      get => this.\u003CPermissionId\u003Ek__BackingField;
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
              this.\u003CPermissionId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 0 : 0;
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

    /// <summary>Раздача пермишенов</summary>
    [XmlElement("ManageAccess")]
    public bool ManageAccess
    {
      get => this.\u003CManageAccess\u003Ek__BackingField;
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
              this.\u003CManageAccess\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 == 0 ? 0 : 0;
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

    /// <summary>Получить объект пермишена</summary>
    /// <returns></returns>
    public IEntity GetObject() => (IEntity) HistoryPermissionInfo.pPdAcbwwDXqNRRJWhOoe(HistoryPermissionInfo.O1HIA7wwk4tamIobqICb(HistoryPermissionInfo.ndgbnwww6hRT07s7Q2xb((object) Locator.GetService<IMetadataRuntimeService>(), this.ObjectTypeUid, true)), (object) this.ObjectId);

    /// <summary>Получить пермишен</summary>
    /// <returns></returns>
    public Permission GetPermission() => Locator.GetServiceNotNull<IPermissionManagmentService>().GetPermissions().FirstOrDefault<Permission>((Func<Permission, bool>) (p => HistoryPermissionInfo.Dsn3EIwwa86dYgRxuZvB((object) p) == this.PermissionId));

    public HistoryPermissionInfo()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool zSUOC7wwtNTlQZu1P361() => HistoryPermissionInfo.TT3alGwwoZySRf3MBnCH == null;

    internal static HistoryPermissionInfo vfWB8EwwmrrOq9LmOJJO() => HistoryPermissionInfo.TT3alGwwoZySRf3MBnCH;

    internal static Type ndgbnwww6hRT07s7Q2xb([In] object obj0, [In] Guid obj1, [In] bool obj2) => ((IMetadataRuntimeService) obj0).GetTypeByUid(obj1, obj2);

    internal static object O1HIA7wwk4tamIobqICb([In] Type obj0) => (object) EntityHelper.GetEntityManager(obj0);

    internal static object pPdAcbwwDXqNRRJWhOoe([In] object obj0, [In] object obj1) => ((IEntityManager) obj0).LoadOrNull(obj1);

    internal static Guid Dsn3EIwwa86dYgRxuZvB([In] object obj0) => ((Permission) obj0).Id;
  }
}
