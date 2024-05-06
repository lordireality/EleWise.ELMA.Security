// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.AddPermissionModel
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Модель необходимых прав для объекта</summary>
  [DataContract]
  [Serializable]
  public class AddPermissionModel
  {
    internal static AddPermissionModel tEDxlkfU8oJLeyFWba0;

    /// <summary>ctor</summary>
    public AddPermissionModel()
    {
      AddPermissionModel.M8FpJcftX4qHmajWOp6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>ctor</summary>
    /// <param name="type">Тип сущности</param>
    /// <param name="entityMetadata">Метаданные сущности</param>
    /// <param name="stereotypes">Модели типов прав на объект</param>
    public AddPermissionModel(
      Type type,
      EntityMetadata entityMetadata,
      IEnumerable<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>> stereotypes)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.PermissionTypeRolesModels = stereotypes;
      this.EntityType = type;
      this.EntityMetadata = entityMetadata;
    }

    /// <summary>Тип объекта</summary>
    [DataMember]
    public Type EntityType
    {
      get => this.\u003CEntityType\u003Ek__BackingField;
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
              this.\u003CEntityType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af != 0 ? 0 : 0;
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

    /// <summary>Метаданные объекта</summary>
    [DataMember]
    public EntityMetadata EntityMetadata
    {
      get => this.\u003CEntityMetadata\u003Ek__BackingField;
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
              this.\u003CEntityMetadata\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 0 : 0;
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

    /// <summary>Массив идентификаторов сущностей и пользователей</summary>
    [DataMember]
    public System.Collections.Generic.Dictionary<object, List<IUser>> Dictionary { get; set; }

    /// <summary>Права по умолчанию</summary>
    [DataMember]
    public Guid[] DefaultPermissions
    {
      get => this.\u003CDefaultPermissions\u003Ek__BackingField;
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
              this.\u003CDefaultPermissions\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0 ? 0 : 0;
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

    /// <summary>Модели типов прав на объект</summary>
    [DataMember]
    public IEnumerable<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>> PermissionTypeRolesModels { get; set; }

    /// <summary>Может ли пользователь раздавать права на объект</summary>
    [DataMember]
    public bool HasGrantPermission
    {
      get => this.\u003CHasGrantPermission\u003Ek__BackingField;
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
              this.\u003CHasGrantPermission\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 != 0 ? 0 : 0;
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

    /// <summary>
    /// Привилегии которые пользователь может выдать на объект
    /// </summary>
    [DataMember]
    public System.Collections.Generic.Dictionary<long, IEnumerable<Permission>> GrandPermissions { get; set; }

    internal static void M8FpJcftX4qHmajWOp6() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool mZKMeLfR6Nx3n7vMRHR() => AddPermissionModel.tEDxlkfU8oJLeyFWba0 == null;

    internal static AddPermissionModel TLG3nbfoMN7PyXp0ja4() => AddPermissionModel.tEDxlkfU8oJLeyFWba0;
  }
}
