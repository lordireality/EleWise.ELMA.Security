// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.PropertyAccessCacheItem
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Models
{
  internal class PropertyAccessCacheItem
  {
    private static PropertyAccessCacheItem qYcpAE4NoKge0fOsxfo;

    public PropertyAccessCacheItem(IAbstractPropertyAccess access)
    {
      PropertyAccessCacheItem.Gyafge4A2l0TMMkwsQF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(access is IPropertyAccessByUserFunc accessByUserFunc))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 == 0 ? 3 : 10;
              continue;
            }
            break;
          case 2:
            PropertyAccessCacheItem.d37YLg4sbccOM9rWKDB((object) access, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1324692970 << 3 ^ -2007575802));
            num = 11;
            continue;
          case 3:
            this.AssignedPropertyEntityUid = access.AssignedPropertyEntityUid;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 1 : 1;
            continue;
          case 4:
            goto label_13;
          case 5:
            this.GroupId = PropertyAccessCacheItem.gVaGyE4rpHtAFxlyf8r((object) access) == null ? new long?() : new long?(((IEntity<long>) PropertyAccessCacheItem.gVaGyE4rpHtAFxlyf8r((object) access)).Id);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 5 : 9;
            continue;
          case 6:
            this.PermissionType = PropertyAccessCacheItem.emfhp847AbvUhT65BqV((object) access);
            num = 8;
            continue;
          case 7:
            this.OrganizationItemId = PropertyAccessCacheItem.wIBitQ4YpGyLE0XgPDX((object) access) != null ? new long?(((IEntity<long>) PropertyAccessCacheItem.wIBitQ4YpGyLE0XgPDX((object) access)).Id) : new long?();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 != 0 ? 6 : 12;
            continue;
          case 8:
            this.UserId = PropertyAccessCacheItem.jU2FNG4WIrdobiGfxSH((object) access) != null ? new long?(((IEntity<long>) PropertyAccessCacheItem.jU2FNG4WIrdobiGfxSH((object) access)).Id) : new long?();
            num = 5;
            continue;
          case 9:
            this.OrganizationItemPositionId = PropertyAccessCacheItem.lbTj3H4SpTTIhUrI1HL((object) access) != null ? new long?(((IEntity<long>) PropertyAccessCacheItem.lbTj3H4SpTTIhUrI1HL((object) access)).Id) : new long?();
            num = 7;
            continue;
          case 10:
            goto label_4;
          case 11:
            this.PropertyGuid = access.GetPropertyGuid();
            num = 6;
            continue;
          case 12:
            this.AssignedPropertyUid = access.AssignedPropertyUid;
            num = 3;
            continue;
        }
        this.GetCheckUserExpression = new Func<ParameterExpression, ParameterExpression, ParameterExpression, Expression>(accessByUserFunc.GetCheckUserExpression);
        num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff == 0 ? 4 : 4;
      }
label_13:
      return;
label_4:;
    }

    /// <summary>Тип модели (сущности)</summary>
    public Type ModelType
    {
      get => this.\u003CModelType\u003Ek__BackingField;
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
              this.\u003CModelType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af != 0 ? 0 : 0;
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
    /// Uid свойства, для которого предназначена данная настройка доступа
    /// </summary>
    public Guid PropertyGuid
    {
      get => this.\u003CPropertyGuid\u003Ek__BackingField;
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
              this.\u003CPropertyGuid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 0 : 0;
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

    /// <summary>Тип привилегии на свойство</summary>
    public PropertyPermissionType PermissionType
    {
      get => this.\u003CPermissionType\u003Ek__BackingField;
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
              this.\u003CPermissionType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 0 : 0;
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

    /// <summary>ID пользователя</summary>
    public long? UserId { get; set; }

    /// <summary>ID группы пользователей</summary>
    public long? GroupId { get; set; }

    /// <summary>ID должности</summary>
    public long? OrganizationItemPositionId { get; set; }

    /// <summary>ID элемента оргструктуры</summary>
    public long? OrganizationItemId { get; set; }

    /// <summary>Uid свойства</summary>
    /// <remarks>Uid свойства-обладателя привилегии</remarks>
    public Guid? AssignedPropertyUid { get; set; }

    /// <summary>Uid метаданных свойства</summary>
    /// <remarks>Uid метаданных свойства-обладателя привилегии</remarks>
    public Guid? AssignedPropertyEntityUid { get; set; }

    /// <summary>Функция для проверки прав по пользователю</summary>
    public Func<ParameterExpression, ParameterExpression, ParameterExpression, Expression> GetCheckUserExpression { get; set; }

    internal static void Gyafge4A2l0TMMkwsQF() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static void d37YLg4sbccOM9rWKDB([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static PropertyPermissionType emfhp847AbvUhT65BqV([In] object obj0) => ((IAbstractPropertyAccess) obj0).GetPermissionType();

    internal static object jU2FNG4WIrdobiGfxSH([In] object obj0) => (object) ((IAbstractPropertyAccess) obj0).User;

    internal static object gVaGyE4rpHtAFxlyf8r([In] object obj0) => (object) ((IAbstractPropertyAccess) obj0).Group;

    internal static object lbTj3H4SpTTIhUrI1HL([In] object obj0) => (object) ((IAbstractPropertyAccess) obj0).OrganizationItemPosition;

    internal static object wIBitQ4YpGyLE0XgPDX([In] object obj0) => (object) ((IAbstractPropertyAccess) obj0).OrganizationItem;

    internal static bool lgpqF840tt6gKLt8ytk() => PropertyAccessCacheItem.qYcpAE4NoKge0fOsxfo == null;

    internal static PropertyAccessCacheItem ih5Nx74Zp4NvCBm0W2q() => PropertyAccessCacheItem.qYcpAE4NoKge0fOsxfo;
  }
}
