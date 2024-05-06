// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.PropertyPermissionService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Services
{
  [Service(Scope = ServiceScope.Application, Type = ComponentType.Server)]
  internal class PropertyPermissionService : IPropertyPermissionService, IInitHandler
  {
    private IContextBoundVariableService contextCacheService;
    private IUnionComplexCacheService unionComplexCacheService;
    private ISecurityService securityService;
    private IAuthenticationService authenticationService;
    internal static PropertyPermissionService jZVI7XScQ596yVeZUsW;

    public IEnumerable<IPropertyPermissionAdapter> Adapters { get; set; }

    public IUnionComplexCacheService UnionComplexCacheService
    {
      get
      {
        int num = 1;
        IUnionComplexCacheService service;
        IUnionComplexCacheService complexCacheService;
        while (true)
        {
          switch (num)
          {
            case 1:
              complexCacheService = this.unionComplexCacheService;
              if (complexCacheService == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.unionComplexCacheService = service = Locator.GetService<IUnionComplexCacheService>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0 ? 2 : 2;
              continue;
          }
        }
label_2:
        return complexCacheService;
label_6:
        return service;
      }
    }

    public IContextBoundVariableService ContextCacheService
    {
      get
      {
        int num = 2;
        IContextBoundVariableService service;
        IContextBoundVariableService contextCacheService;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.contextCacheService = service = Locator.GetService<IContextBoundVariableService>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 0 : 0;
              continue;
            case 2:
              contextCacheService = this.contextCacheService;
              if (contextCacheService == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed != 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return contextCacheService;
label_6:
        return service;
      }
    }

    public ISecurityService SecurityService
    {
      get
      {
        int num = 2;
        ISecurityService serviceNotNull;
        ISecurityService securityService;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.securityService = serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0 ? 0 : 0;
              continue;
            case 2:
              securityService = this.securityService;
              if (securityService == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return securityService;
label_6:
        return serviceNotNull;
      }
    }

    public IAuthenticationService AuthenticationService
    {
      get
      {
        int num = 2;
        IAuthenticationService serviceNotNull;
        IAuthenticationService authenticationService;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.authenticationService = serviceNotNull = Locator.GetServiceNotNull<IAuthenticationService>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 == 0 ? 0 : 0;
              continue;
            case 2:
              authenticationService = this.authenticationService;
              if (authenticationService == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b != 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return authenticationService;
label_6:
        return serviceNotNull;
      }
    }

    void IInitHandler.Init()
    {
    }

    void IInitHandler.InitComplete()
    {
      int num1 = 2;
      IEnumerator<IPropertyPermissionAdapter> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_16;
          case 1:
            goto label_4;
          case 2:
            enumerator = this.Adapters.GetEnumerator();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 == 0 ? 1 : 0;
            continue;
          default:
            goto label_11;
        }
      }
label_16:
      return;
label_11:
      return;
label_4:
      try
      {
label_9:
        if (enumerator.MoveNext())
          goto label_7;
        else
          goto label_10;
label_5:
        int num2;
        switch (num2)
        {
          case 0:
            return;
          case 1:
            goto label_9;
          case 2:
            break;
          default:
            return;
        }
label_7:
        enumerator.Current.PermissionsChanged += new EventHandler<PropertyPermissionsChangedEventArgs>(this.adapter_PermissionsChanged);
        num2 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0)
        {
          num2 = 0;
          goto label_5;
        }
        else
          goto label_5;
label_10:
        num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b != 0 ? 0 : 0;
        goto label_5;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_18;
              default:
                PropertyPermissionService.T66feTS8Mx7EXdKjOq5((object) enumerator);
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_18:;
      }
    }

    PropertyPermissionType IPropertyPermissionService.CheckPropertyPermissionByGlobalOnly(
      Type modelType,
      Guid propertyGuid,
      EleWise.ELMA.Security.IUser user)
    {
      return this.CheckPropertyPermissionByGlobalOnly(modelType, true, propertyGuid, user);
    }

    PropertyPermissionType IPropertyPermissionService.CheckPropertyPermissionByRoleOnly(
      object dataItem,
      Guid propertyGuid,
      EleWise.ELMA.Security.IUser user)
    {
      return this.CheckPropertyPermissionByRoleOnly(dataItem, propertyGuid, user);
    }

    PropertyPermissionType IPropertyPermissionService.CheckPropertyPermission(
      object dataItem,
      Guid propertyGuid,
      EleWise.ELMA.Security.IUser user)
    {
      return this.CheckPropertyPermission(dataItem, propertyGuid, user);
    }

    bool IPropertyPermissionService.HasPermissionsByRole(
      Type modelType,
      Guid propertyGuid,
      EleWise.ELMA.Security.IUser user)
    {
      return this.HasPermissionsByRole(modelType, propertyGuid, user);
    }

    public PropertyPermissionType CheckPropertyPermission(
      object dataItem,
      Guid propertyGuid,
      EleWise.ELMA.Security.IUser user = null)
    {
      int num1 = 5;
      PropertyPermissionType propertyPermissionType1;
      while (true)
      {
        PropertyPermissionType propertyPermissionType2;
        int num2;
        switch (num1)
        {
          case 1:
            goto label_7;
          case 2:
            if (propertyPermissionType1 < PropertyPermissionType.Edit)
            {
              num1 = 3;
              continue;
            }
            goto label_7;
          case 3:
            propertyPermissionType2 = this.CheckPropertyPermissionByGlobalOnly(dataItem.GetType(), false, propertyGuid, user);
            num1 = 6;
            continue;
          case 4:
            goto label_5;
          case 5:
            if (dataItem != null)
            {
              propertyPermissionType1 = this.CheckPropertyPermissionByRoleOnly(dataItem, propertyGuid, user);
              num1 = 2;
              continue;
            }
            num1 = 4;
            continue;
          case 6:
            if (propertyPermissionType2 <= propertyPermissionType1)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0 ? 0 : 0;
              continue;
            }
            num2 = (int) propertyPermissionType2;
            break;
          default:
            num2 = (int) propertyPermissionType1;
            break;
        }
        propertyPermissionType1 = (PropertyPermissionType) num2;
        num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 == 0 ? 1 : 1;
      }
label_5:
      return PropertyPermissionType.None;
label_7:
      return propertyPermissionType1;
    }

    public PropertyPermissionType CheckPropertyPermissionByGlobalOnly(
      Type modelType,
      bool includeChilds,
      Guid propertyGuid,
      EleWise.ELMA.Security.IUser user = null)
    {
      int num = 1;
      PropertyPermissionType? globalPermission;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(modelType == (Type) null))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            if (globalPermission.HasValue)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 != 0 ? 1 : 3;
              continue;
            }
            goto label_6;
          case 3:
            goto label_7;
          case 4:
            goto label_2;
          case 5:
            goto label_6;
          default:
            this.GetPermissions(modelType, includeChilds, propertyGuid, out globalPermission, out PropertyPermissionType? _, user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return PropertyPermissionType.None;
label_6:
      return PropertyPermissionType.None;
label_7:
      return globalPermission.Value;
    }

    public PropertyPermissionType CheckPropertyPermissionByRoleOnly(
      object dataItem,
      Guid propertyGuid,
      EleWise.ELMA.Security.IUser user = null)
    {
      int num1 = 32;
      PropertyPermissionType propertyPermissionType1;
      while (true)
      {
        int num2 = num1;
        PropertyPermissionService.PropertyProfileCacheEntry propertyCacheEntry;
        List<long> groupIds;
        PropertyPermissionType propertyPermissionType2;
        while (true)
        {
          List<long> orgItemIds;
          PropertyPermissionType propertyPermissionType3;
          long userId;
          int num3;
          long num4;
          switch (num2)
          {
            case 1:
              if (propertyCacheEntry.FuncForGroup == null)
              {
                num2 = 34;
                continue;
              }
              goto label_18;
            case 2:
            case 15:
              if (propertyPermissionType1 >= PropertyPermissionType.Edit)
              {
                num2 = 20;
                continue;
              }
              goto case 33;
            case 3:
              if (propertyPermissionType2 <= propertyPermissionType1)
              {
                num2 = 14;
                continue;
              }
              goto label_47;
            case 4:
              propertyPermissionType1 = propertyCacheEntry.FuncForUser(dataItem, userId);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 == 0 ? 2 : 0;
              continue;
            case 5:
            case 6:
            case 28:
              if (user == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 == 0 ? 23 : 17;
                continue;
              }
              goto case 22;
            case 7:
              num4 = -1L;
              break;
            case 8:
              if (propertyCacheEntry.FuncForOrgItem == null)
              {
                num2 = 30;
                continue;
              }
              goto case 5;
            case 9:
              PropertyPermissionService.UserRolesResult userRoles = this.GetUserRoles(userId);
              groupIds = userRoles.GroupIds;
              orgItemIds = userRoles.OrgItemIds;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d != 0 ? 17 : 0;
              continue;
            case 10:
              if (propertyCacheEntry.FuncForUser != null)
              {
                num2 = 28;
                continue;
              }
              goto case 29;
            case 11:
              goto label_18;
            case 12:
            case 27:
            case 30:
            case 34:
              goto label_11;
            case 13:
            case 20:
            case 25:
              if (propertyPermissionType1 >= PropertyPermissionType.Edit)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 27 : 12;
                continue;
              }
              goto case 1;
            case 14:
              goto label_13;
            case 16:
              propertyPermissionType3 = propertyCacheEntry.FuncForOrgItem(dataItem, orgItemIds);
              num2 = 19;
              continue;
            case 17:
              if (propertyCacheEntry.FuncForUser == null)
              {
                num2 = 15;
                continue;
              }
              goto case 4;
            case 18:
              num4 = (long) PropertyPermissionService.gJvZ26Sd9WmZcu8l9bk((object) user);
              break;
            case 19:
              if (propertyPermissionType3 > propertyPermissionType1)
              {
                num2 = 24;
                continue;
              }
              goto default;
            case 21:
              propertyCacheEntry = this.GetPropertyCacheEntry(dataItem.GetType(), propertyGuid);
              num2 = 26;
              continue;
            case 22:
              if (user != null)
              {
                num2 = 18;
                continue;
              }
              goto case 7;
            case 23:
              user = (EleWise.ELMA.Security.IUser) PropertyPermissionService.CZoVQ1S5nQw74Bvv16A((object) this.AuthenticationService);
              num2 = 22;
              continue;
            case 24:
              num3 = (int) propertyPermissionType3;
              goto label_46;
            case 26:
              if (propertyCacheEntry != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 != 0 ? 10 : 9;
                continue;
              }
              goto label_11;
            case 29:
              if (propertyCacheEntry.FuncForGroup != null)
              {
                num2 = 6;
                continue;
              }
              goto case 8;
            case 31:
              goto label_16;
            case 32:
              if (dataItem != null)
              {
                propertyPermissionType1 = PropertyPermissionType.None;
                num2 = 21;
                continue;
              }
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 7 : 31;
              continue;
            case 33:
              if (propertyCacheEntry.FuncForOrgItem == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 == 0 ? 6 : 13;
                continue;
              }
              goto case 16;
            default:
              num3 = (int) propertyPermissionType1;
              goto label_46;
          }
          userId = num4;
          num2 = 9;
          continue;
label_46:
          propertyPermissionType1 = (PropertyPermissionType) num3;
          num2 = 25;
        }
label_13:
        int num5 = (int) propertyPermissionType1;
        goto label_48;
label_18:
        propertyPermissionType2 = propertyCacheEntry.FuncForGroup(dataItem, groupIds);
        num1 = 3;
        continue;
label_47:
        num5 = (int) propertyPermissionType2;
label_48:
        propertyPermissionType1 = (PropertyPermissionType) num5;
        num1 = 12;
      }
label_11:
      return propertyPermissionType1;
label_16:
      return PropertyPermissionType.None;
    }

    public bool HasPermissionsByRole(Type modelType, Guid propertyGuid, EleWise.ELMA.Security.IUser user = null)
    {
      int num = 3;
      PropertyPermissionType? dependedPermission;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            this.GetPermissions(modelType, true, propertyGuid, out PropertyPermissionType? _, out dependedPermission, user);
            num = 5;
            continue;
          case 3:
            if (!(modelType == (Type) null))
            {
              num = 2;
              continue;
            }
            goto label_6;
          case 4:
            goto label_2;
          case 5:
            if (!dependedPermission.HasValue)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return dependedPermission.Value > PropertyPermissionType.Hide;
label_3:
      return false;
label_6:
      return false;
    }

    public bool HasPermissions(Type modelType) => this.GetAccesses(modelType, true) != null;

    private void adapter_PermissionsChanged(object sender, PropertyPermissionsChangedEventArgs e)
    {
      int num = 3;
      Type type;
      string timestampKey;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.UnionComplexCacheService.RefreshTimestamp(timestampKey);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 != 0 ? 0 : 0;
            continue;
          case 2:
            timestampKey = (string) PropertyPermissionService.rqaCAFSXr3jGWDbZsTL((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--306199571 ^ 306207121), (object) type.AssemblyQualifiedName);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 == 0 ? 1 : 1;
            continue;
          case 3:
            type = PropertyPermissionService.VOtFYXSGr5XTA5nvlsg(PropertyPermissionService.PQ9lwHSEKWGPJBw13sT((object) e));
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    private PropertyPermissionService.UserRolesResult GetUserRoles(
      long userId)
    {
      int num = 2;
      string name;
      long userId1;
      while (true)
      {
        switch (num)
        {
          case 1:
            userId1 = userId;
            num = 3;
            continue;
          case 2:
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa == 0 ? 0 : 1;
            continue;
          case 3:
            name = (string) PropertyPermissionService.BACaF2S1txTmeaFFTR6(PropertyPermissionService.gwoT9FS9sukMBNcskD3(4869926 >> 3 ^ 601092), (object) userId1);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.ContextCacheService.GetOrAdd<PropertyPermissionService.UserRolesResult>(name, (Func<PropertyPermissionService.UserRolesResult>) (() => new PropertyPermissionService.UserRolesResult()
      {
        GroupIds = ((UserGroupManager) PropertyPermissionService.\u003C\u003Ec__DisplayClass34_0.pyGZhBwjpPAqoiMWywVI()).GetGroupsByUser(userId1).ToList<long>(),
        OrgItemIds = ((OrganizationItemManager) PropertyPermissionService.\u003C\u003Ec__DisplayClass34_0.DTWaU0wjOQ2NSbbSumKa()).GetOrgItemIdsByUser(userId1).ToList<long>()
      }));
    }

    private void GetPermissions(
      Type modelType,
      bool includeChilds,
      Guid propertyGuid,
      out PropertyPermissionType? globalPermission,
      out PropertyPermissionType? dependedPermission,
      EleWise.ELMA.Security.IUser user = null)
    {
      int num = 15;
      while (true)
      {
        PropertyPermissionType propertyPermissionType1;
        Dictionary<Guid, PropertyPermissionType> dependedPermissionsOut;
        PropertyPermissionType propertyPermissionType2;
        PropertyPermissionType propertyPermissionType3;
        Dictionary<Guid, PropertyPermissionType> globalPermissionsOut;
        PropertyPermissionType propertyPermissionType4;
        PropertyPermissionType? nullable1;
        switch (num)
        {
          case 1:
          case 13:
            if (!dependedPermissionsOut.TryGetValue(propertyGuid, out propertyPermissionType3))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af != 0 ? 5 : 5;
              continue;
            }
            break;
          case 2:
            if (!dependedPermissionsOut.TryGetValue(Guid.Empty, out propertyPermissionType2))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            dependedPermission = new PropertyPermissionType?(propertyPermissionType2);
            num = 13;
            continue;
          case 4:
            this.GetPermissions(modelType, includeChilds, out globalPermissionsOut, out dependedPermissionsOut, user);
            num = 6;
            continue;
          case 5:
            goto label_26;
          case 6:
            if (globalPermissionsOut == null)
            {
              num = 17;
              continue;
            }
            goto case 16;
          case 7:
          case 17:
            if (dependedPermissionsOut != null)
            {
              num = 2;
              continue;
            }
            goto label_22;
          case 8:
            ref PropertyPermissionType? local1 = ref globalPermission;
            PropertyPermissionType? nullable2;
            if (globalPermission.HasValue)
            {
              nullable1 = globalPermission;
              PropertyPermissionType propertyPermissionType5 = propertyPermissionType4;
              nullable2 = !(nullable1.GetValueOrDefault() > propertyPermissionType5 & nullable1.HasValue) ? new PropertyPermissionType?(propertyPermissionType4) : globalPermission;
            }
            else
              nullable2 = new PropertyPermissionType?(propertyPermissionType4);
            local1 = nullable2;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 2 : 7;
            continue;
          case 9:
          case 11:
            if (globalPermissionsOut.TryGetValue(propertyGuid, out propertyPermissionType4))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af != 0 ? 3 : 8;
              continue;
            }
            goto case 7;
          case 10:
            goto label_11;
          case 12:
            globalPermission = new PropertyPermissionType?(propertyPermissionType1);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 7 : 9;
            continue;
          case 14:
            dependedPermission = new PropertyPermissionType?();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 1 : 4;
            continue;
          case 15:
            globalPermission = new PropertyPermissionType?();
            num = 14;
            continue;
          case 16:
            if (!globalPermissionsOut.TryGetValue(Guid.Empty, out propertyPermissionType1))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d == 0 ? 8 : 11;
              continue;
            }
            goto case 12;
        }
        ref PropertyPermissionType? local2 = ref dependedPermission;
        PropertyPermissionType? nullable3;
        if (dependedPermission.HasValue)
        {
          nullable1 = dependedPermission;
          PropertyPermissionType propertyPermissionType6 = propertyPermissionType3;
          nullable3 = nullable1.GetValueOrDefault() > propertyPermissionType6 & nullable1.HasValue ? dependedPermission : new PropertyPermissionType?(propertyPermissionType3);
        }
        else
          nullable3 = new PropertyPermissionType?(propertyPermissionType3);
        local2 = nullable3;
        num = 10;
      }
label_26:
      return;
label_11:
      return;
label_22:;
    }

    private void GetPermissions(
      Type modelType,
      bool includeChilds,
      out Dictionary<Guid, PropertyPermissionType> globalPermissionsOut,
      out Dictionary<Guid, PropertyPermissionType> dependedPermissionsOut,
      EleWise.ELMA.Security.IUser user = null)
    {
      int num1 = 6;
      while (true)
      {
        string name;
        PropertyPermissionService.GetPermissionResult orAdd;
        PropertyPermissionService permissionService;
        IEnumerable<PropertyAccessCacheItem> accesses;
        long userId;
        switch (num1)
        {
          case 1:
            dependedPermissionsOut = (Dictionary<Guid, PropertyPermissionType>) null;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 == 0 ? 4 : 11;
            continue;
          case 2:
            orAdd = this.ContextCacheService.GetOrAdd<PropertyPermissionService.GetPermissionResult>(name, (Func<PropertyPermissionService.GetPermissionResult>) (() =>
            {
              int num2 = 1;
              Dictionary<Guid, PropertyPermissionType> globalPermissionsOut1;
              Dictionary<Guid, PropertyPermissionType> dependedPermissionsOut1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    permissionService.GetPermissionsNonCached(accesses, out globalPermissionsOut1, out dependedPermissionsOut1, userId);
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_3:
              return new PropertyPermissionService.GetPermissionResult()
              {
                GlobalPermissions = globalPermissionsOut1,
                DependedPermissionsOut = dependedPermissionsOut1
              };
            }));
            num1 = 12;
            continue;
          case 3:
            accesses = this.GetAccesses(modelType, includeChilds);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc != 0 ? 11 : 13;
            continue;
          case 4:
            name = PropertyPermissionService.gwoT9FS9sukMBNcskD3(1658561670 << 4 ^ 767176274).ToString() + modelType.AssemblyQualifiedName + PropertyPermissionService.gwoT9FS9sukMBNcskD3(-1257514304 ^ -1257522092) + includeChilds.ToString() + PropertyPermissionService.gwoT9FS9sukMBNcskD3(1801131332 >> 4 ^ 112580552) + (object) userId;
            num1 = 2;
            continue;
          case 5:
            permissionService = this;
            num1 = 10;
            continue;
          case 6:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 == 0 ? 4 : 5;
            continue;
          case 7:
            user = (EleWise.ELMA.Security.IUser) PropertyPermissionService.CZoVQ1S5nQw74Bvv16A((object) this.AuthenticationService);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 == 0 ? 0 : 0;
            continue;
          case 8:
            dependedPermissionsOut = orAdd.DependedPermissionsOut;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b == 0 ? 9 : 5;
            continue;
          case 9:
            goto label_19;
          case 10:
            modelType = PropertyPermissionService.VOtFYXSGr5XTA5nvlsg(modelType);
            num1 = 3;
            continue;
          case 11:
            goto label_2;
          case 12:
            globalPermissionsOut = orAdd.GlobalPermissions;
            num1 = 8;
            continue;
          case 13:
            if (accesses == null)
            {
              num1 = 14;
              continue;
            }
            if (user == null)
            {
              num1 = 7;
              continue;
            }
            break;
          case 14:
            globalPermissionsOut = (Dictionary<Guid, PropertyPermissionType>) null;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 1 : 1;
            continue;
        }
        userId = user == null ? -1L : (long) PropertyPermissionService.gJvZ26Sd9WmZcu8l9bk((object) user);
        num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 != 0 ? 3 : 4;
      }
label_19:
      return;
label_2:;
    }

    private void GetPermissionsNonCached(
      IEnumerable<PropertyAccessCacheItem> accesses,
      out Dictionary<Guid, PropertyPermissionType> globalPermissionsOut,
      out Dictionary<Guid, PropertyPermissionType> dependedPermissionsOut,
      long userId)
    {
      if (accesses == null || !accesses.Any<PropertyAccessCacheItem>())
      {
        globalPermissionsOut = (Dictionary<Guid, PropertyPermissionType>) null;
        dependedPermissionsOut = (Dictionary<Guid, PropertyPermissionType>) null;
      }
      else
      {
        Dictionary<Guid, PropertyPermissionType> globalPermissions = new Dictionary<Guid, PropertyPermissionType>();
        Dictionary<Guid, PropertyPermissionType> dependedPermissions = new Dictionary<Guid, PropertyPermissionType>();
        PropertyPermissionService.UserRolesResult userRoles = this.GetUserRoles(userId);
        List<long> groupsId = userRoles.GroupIds;
        List<long> orgItemsId = userRoles.OrgItemIds;
        Action<PropertyAccessCacheItem> action = (Action<PropertyAccessCacheItem>) (c =>
        {
          int num = 3;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_6;
              case 1:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                globalPermissions[PropertyPermissionService.\u003C\u003Ec__DisplayClass37_0.mHeOkvwjnP14mSDx4LDM((object) c)] = PropertyPermissionService.\u003C\u003Ec__DisplayClass37_0.roVogPwjLAtvQLIfJvj0((object) c);
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 0 : 0;
                continue;
              case 2:
                // ISSUE: reference to a compiler-generated method
                if (PropertyPermissionService.\u003C\u003Ec__DisplayClass37_0.roVogPwjLAtvQLIfJvj0((object) c) <= globalPermissions[c.PropertyGuid])
                {
                  num = 6;
                  continue;
                }
                goto case 1;
              case 3:
                // ISSUE: reference to a compiler-generated method
                if (globalPermissions.ContainsKey(PropertyPermissionService.\u003C\u003Ec__DisplayClass37_0.mHeOkvwjnP14mSDx4LDM((object) c)))
                {
                  num = 2;
                  continue;
                }
                goto case 5;
              case 4:
                goto label_11;
              case 5:
                // ISSUE: reference to a compiler-generated method
                globalPermissions.Add(PropertyPermissionService.\u003C\u003Ec__DisplayClass37_0.mHeOkvwjnP14mSDx4LDM((object) c), c.PermissionType);
                num = 4;
                continue;
              case 6:
                goto label_3;
              default:
                goto label_2;
            }
          }
label_6:
          return;
label_11:
          return;
label_3:
          return;
label_2:;
        });
        IUserGroup allUserObj = UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
        accesses.Where<PropertyAccessCacheItem>((Func<PropertyAccessCacheItem, bool>) (c =>
        {
          int num = 3;
          long? groupId;
          Guid? assignedPropertyUid;
          long id;
          while (true)
          {
            switch (num)
            {
              case 1:
                if (assignedPropertyUid.HasValue)
                {
                  num = 5;
                  continue;
                }
                goto case 6;
              case 2:
                if (groupId.HasValue)
                {
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0 ? 8 : 7;
                  continue;
                }
                goto label_13;
              case 3:
                groupId = c.GroupId;
                num = 2;
                continue;
              case 4:
                goto label_12;
              case 5:
                goto label_13;
              case 6:
                if (c.GetCheckUserExpression == null)
                {
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 != 0 ? 3 : 4;
                  continue;
                }
                goto label_13;
              case 7:
                assignedPropertyUid = c.AssignedPropertyUid;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 != 0 ? 1 : 1;
                continue;
              case 8:
                groupId = c.GroupId;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0 ? 9 : 2;
                continue;
              case 9:
                id = allUserObj.Id;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e == 0 ? 0 : 0;
                continue;
              default:
                if (groupId.GetValueOrDefault() == id & groupId.HasValue)
                {
                  num = 7;
                  continue;
                }
                goto label_13;
            }
          }
label_12:
          // ISSUE: reference to a compiler-generated method
          return PropertyPermissionService.\u003C\u003Ec__DisplayClass37_0.roVogPwjLAtvQLIfJvj0((object) c) == PropertyPermissionType.Hide;
label_13:
          return false;
        })).ForEach<PropertyAccessCacheItem>(action);
        accesses.Where<PropertyAccessCacheItem>((Func<PropertyAccessCacheItem, bool>) (c =>
        {
          int num1 = 3;
          while (true)
          {
            int num2 = num1;
            long? groupId;
            Guid? assignedPropertyUid;
            while (true)
            {
              switch (num2)
              {
                case 1:
                case 4:
                  goto label_12;
                case 2:
                  if (!groupId.HasValue)
                  {
                    num2 = 4;
                    continue;
                  }
                  goto case 7;
                case 3:
                  groupId = c.GroupId;
                  num2 = 2;
                  continue;
                case 5:
                  goto label_11;
                case 6:
                  if (assignedPropertyUid.HasValue)
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 == 0 ? 0 : 1;
                    continue;
                  }
                  goto label_11;
                case 7:
                  List<long> longList = groupsId;
                  groupId = c.GroupId;
                  long num3 = groupId.Value;
                  if (longList.Contains(num3))
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 != 0 ? 0 : 0;
                    continue;
                  }
                  goto label_12;
                default:
                  goto label_7;
              }
            }
label_7:
            assignedPropertyUid = c.AssignedPropertyUid;
            num1 = 6;
          }
label_11:
          return c.GetCheckUserExpression == null;
label_12:
          return false;
        })).ForEach<PropertyAccessCacheItem>(action);
        accesses.Where<PropertyAccessCacheItem>((Func<PropertyAccessCacheItem, bool>) (c =>
        {
          int num4 = 1;
          long? organizationItemId;
          Guid? assignedPropertyUid;
          while (true)
          {
            switch (num4)
            {
              case 1:
                organizationItemId = c.OrganizationItemId;
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_2;
              case 3:
                assignedPropertyUid = c.AssignedPropertyUid;
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 == 0 ? 1 : 5;
                continue;
              case 4:
              case 7:
                goto label_3;
              case 5:
                if (!assignedPropertyUid.HasValue)
                {
                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 == 0 ? 1 : 2;
                  continue;
                }
                goto label_3;
              case 6:
                List<long> longList = orgItemsId;
                organizationItemId = c.OrganizationItemId;
                long num5 = organizationItemId.Value;
                if (!longList.Contains(num5))
                {
                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 3 : 7;
                  continue;
                }
                goto case 3;
              default:
                if (!organizationItemId.HasValue)
                {
                  num4 = 4;
                  continue;
                }
                goto case 6;
            }
          }
label_2:
          return c.GetCheckUserExpression == null;
label_3:
          return false;
        })).ForEach<PropertyAccessCacheItem>(action);
        accesses.Where<PropertyAccessCacheItem>((Func<PropertyAccessCacheItem, bool>) (c =>
        {
          int num6 = 1;
          Guid? assignedPropertyUid;
          long? organizationItemPositionId;
          while (true)
          {
            switch (num6)
            {
              case 1:
                organizationItemPositionId = c.OrganizationItemPositionId;
                num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c == 0 ? 0 : 0;
                continue;
              case 2:
                goto label_9;
              case 3:
                List<long> longList = orgItemsId;
                organizationItemPositionId = c.OrganizationItemPositionId;
                long num7 = organizationItemPositionId.Value;
                if (!longList.Contains(num7))
                {
                  num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c == 0 ? 2 : 2;
                  continue;
                }
                goto case 4;
              case 4:
                assignedPropertyUid = c.AssignedPropertyUid;
                num6 = 6;
                continue;
              case 5:
                goto label_8;
              case 6:
                if (!assignedPropertyUid.HasValue)
                {
                  num6 = 5;
                  continue;
                }
                goto label_9;
              default:
                if (organizationItemPositionId.HasValue)
                {
                  num6 = 3;
                  continue;
                }
                goto label_9;
            }
          }
label_8:
          return c.GetCheckUserExpression == null;
label_9:
          return false;
        })).ForEach<PropertyAccessCacheItem>(action);
        accesses.Where<PropertyAccessCacheItem>((Func<PropertyAccessCacheItem, bool>) (c =>
        {
          int num8 = 7;
          while (true)
          {
            int num9 = num8;
            long? userId1;
            Guid? assignedPropertyUid;
            while (true)
            {
              switch (num9)
              {
                case 1:
                  userId1 = c.UserId;
                  num9 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 == 0 ? 0 : 0;
                  continue;
                case 2:
                  goto label_7;
                case 3:
                  if (assignedPropertyUid.HasValue)
                  {
                    num9 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 5 : 5;
                    continue;
                  }
                  goto label_10;
                case 4:
                case 5:
                  goto label_11;
                case 6:
                  if (!userId1.HasValue)
                  {
                    num9 = 4;
                    continue;
                  }
                  goto case 1;
                case 7:
                  userId1 = c.UserId;
                  num9 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 6 : 4;
                  continue;
                case 8:
                  goto label_10;
                default:
                  if (userId1.Value == userId)
                  {
                    num9 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0 ? 2 : 2;
                    continue;
                  }
                  goto label_11;
              }
            }
label_7:
            assignedPropertyUid = c.AssignedPropertyUid;
            num8 = 3;
          }
label_10:
          return c.GetCheckUserExpression == null;
label_11:
          return false;
        })).ForEach<PropertyAccessCacheItem>(action);
        accesses.Where<PropertyAccessCacheItem>((Func<PropertyAccessCacheItem, bool>) (c =>
        {
          int num = 2;
          Guid? assignedPropertyUid;
          while (true)
          {
            switch (num)
            {
              case 1:
                if (!assignedPropertyUid.HasValue)
                {
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 0 : 0;
                  continue;
                }
                goto label_3;
              case 2:
                assignedPropertyUid = c.AssignedPropertyUid;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 != 0 ? 0 : 1;
                continue;
              default:
                goto label_2;
            }
          }
label_2:
          return c.GetCheckUserExpression != null;
label_3:
          return true;
        })).ForEach<PropertyAccessCacheItem>((Action<PropertyAccessCacheItem>) (c =>
        {
          int num = 4;
          while (true)
          {
            PropertyPermissionType propertyPermissionType1;
            PropertyPermissionType propertyPermissionType2;
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                dependedPermissions[PropertyPermissionService.\u003C\u003Ec__DisplayClass37_0.mHeOkvwjnP14mSDx4LDM((object) c)] = propertyPermissionType2;
                num = 6;
                continue;
              case 2:
                goto label_5;
              case 3:
                if (!dependedPermissions.ContainsKey(c.PropertyGuid))
                {
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 1 : 1;
                  continue;
                }
                break;
              case 4:
                // ISSUE: reference to a compiler-generated method
                propertyPermissionType2 = PropertyPermissionService.\u003C\u003Ec__DisplayClass37_0.roVogPwjLAtvQLIfJvj0((object) c);
                num = 3;
                continue;
              case 5:
                // ISSUE: reference to a compiler-generated method
                dependedPermissions[PropertyPermissionService.\u003C\u003Ec__DisplayClass37_0.mHeOkvwjnP14mSDx4LDM((object) c)] = propertyPermissionType1 > propertyPermissionType2 ? propertyPermissionType1 : propertyPermissionType2;
                num = 2;
                continue;
              case 6:
                goto label_7;
            }
            // ISSUE: reference to a compiler-generated method
            propertyPermissionType1 = dependedPermissions[PropertyPermissionService.\u003C\u003Ec__DisplayClass37_0.mHeOkvwjnP14mSDx4LDM((object) c)];
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0 ? 5 : 5;
          }
label_5:
          return;
label_7:;
        }));
        globalPermissionsOut = globalPermissions;
        dependedPermissionsOut = dependedPermissions;
      }
    }

    private PropertyPermissionService.TypeCacheEntry GetCacheEntry(
      Type modelType)
    {
      int num = 4;
      string key;
      string timestampKey;
      PropertyPermissionService permissionService;
      Type modelType1;
      while (true)
      {
        switch (num)
        {
          case 1:
            modelType1 = modelType;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc == 0 ? 1 : 2;
            continue;
          case 2:
            modelType1 = InterfaceActivator.TypeOf(modelType1);
            num = 5;
            continue;
          case 3:
            permissionService = this;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba != 0 ? 1 : 1;
            continue;
          case 4:
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 == 0 ? 0 : 3;
            continue;
          case 5:
            key = (string) PropertyPermissionService.rqaCAFSXr3jGWDbZsTL(PropertyPermissionService.gwoT9FS9sukMBNcskD3(-1277802350 ^ -1277809104), (object) modelType1.AssemblyQualifiedName);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 != 0 ? 6 : 4;
            continue;
          case 6:
            timestampKey = (string) PropertyPermissionService.rqaCAFSXr3jGWDbZsTL(PropertyPermissionService.gwoT9FS9sukMBNcskD3(1185105284 ^ 1185095686), (object) modelType1.AssemblyQualifiedName);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0 ? 0 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return this.UnionComplexCacheService.GetOrAdd<PropertyPermissionService.TypeCacheEntry>(key, timestampKey, (Func<PropertyPermissionService.TypeCacheEntry>) (() => permissionService.GenerateTypeCacheEntry(modelType1)));
    }

    private IEnumerable<PropertyAccessCacheItem> GetAccesses(
      Type modelType,
      bool includeChilds,
      IEnumerable<Guid> uids)
    {
      IEnumerable<PropertyAccessCacheItem> accesses = this.GetAccesses(modelType, includeChilds);
      if (uids == null)
        return accesses;
      return accesses == null ? (IEnumerable<PropertyAccessCacheItem>) null : (IEnumerable<PropertyAccessCacheItem>) accesses.Where<PropertyAccessCacheItem>((Func<PropertyAccessCacheItem, bool>) (a => uids.Contains<Guid>(a.PropertyGuid))).ToArray<PropertyAccessCacheItem>();
    }

    private IEnumerable<PropertyAccessCacheItem> GetAccesses(
      Type modelType,
      bool includeChilds)
    {
      if (modelType == (Type) null)
        return (IEnumerable<PropertyAccessCacheItem>) null;
      modelType = InterfaceActivator.TypeOf(modelType);
      return this.ContextCacheService.GetOrAdd<IEnumerable<PropertyAccessCacheItem>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1277472395 ^ -1277479013) + includeChilds.ToString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1880054609 ^ -1880047053) + modelType.AssemblyQualifiedName, (Func<IEnumerable<PropertyAccessCacheItem>>) (() => this.GetAccessesNonCached(modelType, includeChilds)));
    }

    private IEnumerable<PropertyAccessCacheItem> GetAccessesNonCached(
      Type modelType,
      bool includeChilds)
    {
      List<PropertyAccessCacheItem> result = (List<PropertyAccessCacheItem>) null;
      Action<PropertyPermissionService.TypeCacheEntry, bool> action = (Action<PropertyPermissionService.TypeCacheEntry, bool>) ((entry, before) =>
      {
        int num1 = 7;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_4;
              case 1:
              case 3:
                if (before)
                {
                  num2 = 4;
                  continue;
                }
                result.AddRange(entry.Properties.Values.SelectMany<PropertyPermissionService.PropertyProfileCacheEntry, PropertyAccessCacheItem>((Func<PropertyPermissionService.PropertyProfileCacheEntry, IEnumerable<PropertyAccessCacheItem>>) (p => (IEnumerable<PropertyAccessCacheItem>) p.Accesses)));
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 != 0 ? 0 : 8;
                continue;
              case 2:
                goto label_17;
              case 4:
                List<PropertyAccessCacheItem> propertyAccessCacheItemList = result;
                ICollection<PropertyPermissionService.PropertyProfileCacheEntry> values = entry.Properties.Values;
                // ISSUE: reference to a compiler-generated field
                Func<PropertyPermissionService.PropertyProfileCacheEntry, IEnumerable<PropertyAccessCacheItem>> func = PropertyPermissionService.\u003C\u003Ec.\u003C\u003E9__41_1;
                Func<PropertyPermissionService.PropertyProfileCacheEntry, IEnumerable<PropertyAccessCacheItem>> selector;
                if (func == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  PropertyPermissionService.\u003C\u003Ec.\u003C\u003E9__41_1 = selector = (Func<PropertyPermissionService.PropertyProfileCacheEntry, IEnumerable<PropertyAccessCacheItem>>) (p => (IEnumerable<PropertyAccessCacheItem>) p.Accesses);
                }
                else
                  goto label_21;
label_19:
                IEnumerable<PropertyAccessCacheItem> collection = values.SelectMany<PropertyPermissionService.PropertyProfileCacheEntry, PropertyAccessCacheItem>(selector);
                propertyAccessCacheItemList.InsertRange(0, collection);
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 == 0 ? 0 : 0;
                continue;
label_21:
                selector = func;
                goto label_19;
              case 5:
                result = new List<PropertyAccessCacheItem>();
                num2 = 3;
                continue;
              case 6:
                // ISSUE: reference to a compiler-generated method
                if (PropertyPermissionService.\u003C\u003Ec__DisplayClass41_0.SgCxymwNiCpx51dtMEyj((object) entry.Properties) <= 0)
                {
                  num2 = 2;
                  continue;
                }
                goto case 9;
              case 7:
                goto label_7;
              case 8:
                goto label_6;
              case 9:
                if (result != null)
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0 ? 1 : 1;
                  continue;
                }
                goto case 5;
              default:
                goto label_3;
            }
          }
label_7:
          if (entry != null)
            num1 = 6;
          else
            goto label_13;
        }
label_4:
        return;
label_17:
        return;
label_6:
        return;
label_3:
        return;
label_13:;
      });
      modelType = InterfaceActivator.TypeOf(modelType);
      for (Type modelType1 = modelType; modelType1 != (Type) null; modelType1 = modelType1.BaseType)
        action(this.GetCacheEntry(modelType1), true);
      if (includeChilds)
      {
        IEnumerable<Type> childTypes = this.GetAdapterByModelType(modelType)?.GetChildTypes(modelType);
        if (childTypes != null)
        {
          foreach (Type modelType2 in childTypes)
            action(this.GetCacheEntry(modelType2), false);
        }
      }
      return (IEnumerable<PropertyAccessCacheItem>) result;
    }

    private IDictionary<Guid, PropertyPermissionService.PropertyProfileCacheEntry> GetPropertyCacheEntries(
      Type modelType)
    {
      Dictionary<Guid, PropertyPermissionService.PropertyProfileCacheEntry> propertyCacheEntries = new Dictionary<Guid, PropertyPermissionService.PropertyProfileCacheEntry>();
      modelType = InterfaceActivator.TypeOf(modelType);
      for (Type modelType1 = modelType; modelType1 != (Type) null; modelType1 = modelType1.BaseType)
      {
        PropertyPermissionService.TypeCacheEntry cacheEntry = this.GetCacheEntry(modelType1);
        if (cacheEntry != null)
        {
          foreach (KeyValuePair<Guid, PropertyPermissionService.PropertyProfileCacheEntry> property in (IEnumerable<KeyValuePair<Guid, PropertyPermissionService.PropertyProfileCacheEntry>>) cacheEntry.Properties)
            propertyCacheEntries[property.Key] = property.Value;
        }
      }
      return (IDictionary<Guid, PropertyPermissionService.PropertyProfileCacheEntry>) propertyCacheEntries;
    }

    private PropertyPermissionService.PropertyProfileCacheEntry GetPropertyCacheEntry(
      Type modelType,
      Guid propertyGuid)
    {
      int num1 = 6;
      PropertyPermissionService.PropertyProfileCacheEntry propertyCacheEntry;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          Type modelType1;
          PropertyPermissionService.TypeCacheEntry cacheEntry;
          switch (num2)
          {
            case 2:
              goto label_5;
            case 3:
              cacheEntry = this.GetCacheEntry(modelType1);
              num2 = 7;
              continue;
            case 4:
              goto label_3;
            case 5:
              modelType1 = modelType;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 != 0 ? 0 : 0;
              continue;
            case 6:
              modelType = PropertyPermissionService.VOtFYXSGr5XTA5nvlsg(modelType);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 == 0 ? 5 : 4;
              continue;
            case 7:
              if (cacheEntry != null)
              {
                num2 = 8;
                continue;
              }
              break;
            case 8:
              if (!cacheEntry.Properties.TryGetValue(propertyGuid, out propertyCacheEntry))
                break;
              goto label_14;
            default:
              if (!PropertyPermissionService.kVwZv4SMhxIrhn5PDPt(modelType1, (Type) null))
              {
                num2 = 2;
                continue;
              }
              goto case 3;
          }
          modelType1 = modelType1.BaseType;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 0 : 1;
        }
label_14:
        num1 = 4;
      }
label_3:
      return propertyCacheEntry;
label_5:
      return (PropertyPermissionService.PropertyProfileCacheEntry) null;
    }

    private PropertyPermissionService.TypeCacheEntry GenerateTypeCacheEntry(
      Type modelType)
    {
      int num1 = 7;
      PropertyPermissionService.TypeCacheEntry typeCacheEntry;
      // ISSUE: variable of a compiler-generated type
      PropertyPermissionService.\u003C\u003Ec__DisplayClass44_0 cDisplayClass440;
      IEnumerator<PropertyPermissionService.PropertyProfileCacheEntry> enumerator1;
      IEnumerator<IAbstractPropertyAccess> enumerator2;
      IEnumerable<IAbstractPropertyAccess> accesses;
      while (true)
      {
        switch (num1)
        {
          case 1:
          case 13:
label_55:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: type reference
            cDisplayClass440.modelExpression = (ParameterExpression) PropertyPermissionService.b4tVxJSpVORx9IEup6P(PropertyPermissionService.G5d17DSB1mYxCaU8Aqc(__typeref (object)), PropertyPermissionService.gwoT9FS9sukMBNcskD3(-1880054609 ^ -1880046703));
            num1 = 9;
            continue;
          case 2:
            enumerator2 = accesses.GetEnumerator();
            num1 = 19;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            cDisplayClass440.adapter = this.GetAdapterByModelType(cDisplayClass440.modelType);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 == 0 ? 10 : 9;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: type reference
            cDisplayClass440.localVarResult = (ParameterExpression) PropertyPermissionService.Hfc7D7SO2JBZtD5xV2i(PropertyPermissionService.G5d17DSB1mYxCaU8Aqc(__typeref (PropertyPermissionType)), PropertyPermissionService.gwoT9FS9sukMBNcskD3(1076316568 ^ 1076309728));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 0 : 0;
            continue;
          case 5:
            goto label_23;
          case 6:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass440.modelType = modelType;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 10 : 12;
            continue;
          case 7:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass440 = new PropertyPermissionService.\u003C\u003Ec__DisplayClass44_0();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d == 0 ? 0 : 6;
            continue;
          case 8:
            goto label_59;
          case 9:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: type reference
            cDisplayClass440.userIdExpression = (ParameterExpression) PropertyPermissionService.b4tVxJSpVORx9IEup6P(PropertyPermissionService.G5d17DSB1mYxCaU8Aqc(__typeref (long)), PropertyPermissionService.gwoT9FS9sukMBNcskD3(-206147790 ^ -206172942));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 != 0 ? 1 : 16;
            continue;
          case 10:
            // ISSUE: reference to a compiler-generated field
            if (cDisplayClass440.adapter == null)
            {
              num1 = 14;
              continue;
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            accesses = cDisplayClass440.adapter.GetAccesses(cDisplayClass440.modelType);
            num1 = 15;
            continue;
          case 11:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: type reference
            cDisplayClass440.orgItemsIdExpression = (ParameterExpression) PropertyPermissionService.b4tVxJSpVORx9IEup6P(PropertyPermissionService.G5d17DSB1mYxCaU8Aqc(__typeref (List<long>)), PropertyPermissionService.gwoT9FS9sukMBNcskD3(1290337431 ^ 1290312695));
            num1 = 4;
            continue;
          case 12:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass440.\u003C\u003E4__this = this;
            num1 = 17;
            continue;
          case 14:
            goto label_67;
          case 15:
            if (accesses == null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 != 0 ? 1 : 1;
              continue;
            }
            goto case 2;
          case 16:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: type reference
            cDisplayClass440.groupsIdExpression = (ParameterExpression) PropertyPermissionService.b4tVxJSpVORx9IEup6P(PropertyPermissionService.G5d17DSB1mYxCaU8Aqc(__typeref (List<long>)), PropertyPermissionService.gwoT9FS9sukMBNcskD3(-816108091 ^ -816100727));
            num1 = 11;
            continue;
          case 17:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            cDisplayClass440.modelType = InterfaceActivator.TypeOf(cDisplayClass440.modelType);
            num1 = 18;
            continue;
          case 18:
            typeCacheEntry = new PropertyPermissionService.TypeCacheEntry();
            num1 = 3;
            continue;
          case 19:
            try
            {
label_10:
              if (PropertyPermissionService.Q09nEpSh67lqlh46m2N((object) enumerator2))
                goto label_8;
              else
                goto label_11;
label_6:
              PropertyAccessCacheItem propertyAccessCacheItem;
              PropertyPermissionService.PropertyProfileCacheEntry profileCacheEntry;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    profileCacheEntry = new PropertyPermissionService.PropertyProfileCacheEntry()
                    {
                      PropertyGuid = propertyAccessCacheItem.PropertyGuid,
                      Accesses = new List<PropertyAccessCacheItem>()
                    };
                    num2 = 5;
                    continue;
                  case 2:
                    if (!typeCacheEntry.Properties.TryGetValue(propertyAccessCacheItem.PropertyGuid, out profileCacheEntry))
                    {
                      num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a == 0 ? 1 : 0;
                      continue;
                    }
                    goto case 3;
                  case 3:
                    profileCacheEntry.Accesses.Add(propertyAccessCacheItem);
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 0 : 0;
                    continue;
                  case 4:
                    goto label_55;
                  case 5:
                    typeCacheEntry.Properties[propertyAccessCacheItem.PropertyGuid] = profileCacheEntry;
                    num2 = 3;
                    continue;
                  case 6:
                    goto label_8;
                  default:
                    goto label_10;
                }
              }
label_8:
              propertyAccessCacheItem = new PropertyAccessCacheItem(enumerator2.Current);
              num2 = 1;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba == 0)
              {
                num2 = 2;
                goto label_6;
              }
              else
                goto label_6;
label_11:
              num2 = 4;
              goto label_6;
            }
            finally
            {
              if (enumerator2 != null)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_21;
                    default:
                      PropertyPermissionService.T66feTS8Mx7EXdKjOq5((object) enumerator2);
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_21:;
            }
          default:
            enumerator1 = typeCacheEntry.Properties.Values.GetEnumerator();
            num1 = 5;
            continue;
        }
      }
label_23:
      try
      {
label_28:
        if (PropertyPermissionService.Q09nEpSh67lqlh46m2N((object) enumerator1))
          goto label_32;
        else
          goto label_29;
label_24:
        // ISSUE: variable of a compiler-generated type
        PropertyPermissionService.\u003C\u003Ec__DisplayClass44_1 cDisplayClass441;
        Expression<Func<object, List<long>, PropertyPermissionType>> expression1;
        PropertyPermissionService.PropertyProfileCacheEntry current;
        Expression<Func<object, long, PropertyPermissionType>> expression2;
        Expression<Func<object, List<long>, PropertyPermissionType>> expression3;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass441 = new PropertyPermissionService.\u003C\u003Ec__DisplayClass44_1();
              num4 = 5;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated method
              current.Accesses.Where<PropertyAccessCacheItem>((Func<PropertyAccessCacheItem, bool>) (p =>
              {
                int num5 = 1;
                Guid? assignedPropertyUid;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      assignedPropertyUid = p.AssignedPropertyUid;
                      num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_4;
                    default:
                      if (!assignedPropertyUid.HasValue)
                      {
                        num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 0 : 2;
                        continue;
                      }
                      goto label_5;
                  }
                }
label_4:
                return p.GetCheckUserExpression != null;
label_5:
                return true;
              })).OrderByDescending<PropertyAccessCacheItem, PropertyPermissionType>((Func<PropertyAccessCacheItem, PropertyPermissionType>) (p => p.PermissionType)).ForEach<PropertyAccessCacheItem>(new Action<PropertyAccessCacheItem>(cDisplayClass441.\u003CGenerateTypeCacheEntry\u003Eb__2));
              num4 = 18;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              expression3 = Expression.Lambda<Func<object, List<long>, PropertyPermissionType>>((Expression) this.FuncCommon(cDisplayClass441.groupExpressions, cDisplayClass441.CS\u0024\u003C\u003E8__locals1.localVarResult), cDisplayClass441.CS\u0024\u003C\u003E8__locals1.modelExpression, cDisplayClass441.CS\u0024\u003C\u003E8__locals1.groupsIdExpression);
              num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f == 0 ? 8 : 1;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              if (PropertyPermissionService.FkDV3eSTDBATUvSdylZ((object) cDisplayClass441.groupExpressions) > 0)
              {
                num4 = 3;
                continue;
              }
              goto label_28;
            case 5:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass441.CS\u0024\u003C\u003E8__locals1 = cDisplayClass440;
              num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 == 0 ? 11 : 13;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass441.orgItemExpressions = new List<Expression>();
              num4 = 9;
              continue;
            case 7:
            case 11:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass441.orgItemExpressions.Count > 0)
              {
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 8:
              current.FuncForGroup = expression3.Compile();
              num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d != 0 ? 12 : 4;
              continue;
            case 9:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass441.groupExpressions = new List<Expression>();
              num4 = 2;
              continue;
            case 10:
              current.FuncForUser = expression2.Compile();
              num4 = 11;
              continue;
            case 12:
              goto label_28;
            case 13:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass441.userExpressions = new List<Expression>();
              num4 = 6;
              continue;
            case 14:
              goto label_59;
            case 15:
              current.FuncForOrgItem = expression1.Compile();
              num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 4 : 3;
              continue;
            case 16:
              goto label_32;
            case 17:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              expression2 = Expression.Lambda<Func<object, long, PropertyPermissionType>>((Expression) this.FuncCommon(cDisplayClass441.userExpressions, cDisplayClass441.CS\u0024\u003C\u003E8__locals1.localVarResult), cDisplayClass441.CS\u0024\u003C\u003E8__locals1.modelExpression, cDisplayClass441.CS\u0024\u003C\u003E8__locals1.userIdExpression);
              num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 6 : 10;
              continue;
            case 18:
              // ISSUE: reference to a compiler-generated field
              if (PropertyPermissionService.FkDV3eSTDBATUvSdylZ((object) cDisplayClass441.userExpressions) <= 0)
              {
                num4 = 7;
                continue;
              }
              goto case 17;
            default:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              expression1 = Expression.Lambda<Func<object, List<long>, PropertyPermissionType>>((Expression) this.FuncCommon(cDisplayClass441.orgItemExpressions, cDisplayClass441.CS\u0024\u003C\u003E8__locals1.localVarResult), cDisplayClass441.CS\u0024\u003C\u003E8__locals1.modelExpression, cDisplayClass441.CS\u0024\u003C\u003E8__locals1.orgItemsIdExpression);
              num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec != 0 ? 8 : 15;
              continue;
          }
        }
label_29:
        num4 = 14;
        goto label_24;
label_32:
        current = enumerator1.Current;
        num4 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 == 0)
        {
          num4 = 1;
          goto label_24;
        }
        else
          goto label_24;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num6 = 1;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 != 0)
            num6 = 0;
          while (true)
          {
            switch (num6)
            {
              case 1:
                PropertyPermissionService.T66feTS8Mx7EXdKjOq5((object) enumerator1);
                num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 0 : 0;
                continue;
              default:
                goto label_52;
            }
          }
        }
label_52:;
      }
label_59:
      return typeCacheEntry;
label_67:
      return typeCacheEntry;
    }

    private BlockExpression FuncCommon(
      List<Expression> exps,
      ParameterExpression localVarResult)
    {
      BinaryExpression binaryExpression = Expression.Assign((Expression) localVarResult, (Expression) Expression.Constant((object) PropertyPermissionType.None));
      List<Expression> expressionList = exps;
      expressionList.Insert(0, (Expression) binaryExpression);
      expressionList.Add((Expression) localVarResult);
      return Expression.Block((IEnumerable<ParameterExpression>) new ParameterExpression[1]
      {
        localVarResult
      }, (IEnumerable<Expression>) expressionList);
    }

    private BlockExpression GenerateFunc(
      string name,
      PropertyPermissionType permission,
      Type type,
      ParameterExpression modelExpression,
      ParameterExpression userIdExpression,
      ParameterExpression localVarResult)
    {
      int num = 10;
      ParameterExpression parameterExpression;
      ConstantExpression constantExpression1;
      BinaryExpression binaryExpression1;
      ConstantExpression constantExpression2;
      ParameterExpression left;
      BinaryExpression test;
      BinaryExpression binaryExpression2;
      BinaryExpression binaryExpression3;
      BinaryExpression binaryExpression4;
      BinaryExpression binaryExpression5;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            binaryExpression1 = (BinaryExpression) PropertyPermissionService.CixOksSnPGlv9GMtbSt(PropertyPermissionService.Vcyq9oSqmnka6nGWvbp((object) constantExpression1, PropertyPermissionService.G5d17DSB1mYxCaU8Aqc(__typeref (int))), (object) Expression.Convert((Expression) localVarResult, typeof (int)));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0 ? 1 : 5;
            continue;
          case 2:
            binaryExpression4 = Expression.Assign((Expression) left, (Expression) PropertyPermissionService.Vcyq9oSqmnka6nGWvbp((object) modelExpression, type));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 2 : 3;
            continue;
          case 3:
            test = (BinaryExpression) PropertyPermissionService.jtuxNUSJ9rcwrWUFVG8(PropertyPermissionService.MBN9UNSgHI8qeIfvOto((object) left, (object) name), (object) constantExpression2);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 != 0 ? 0 : 0;
            continue;
          case 4:
            // ISSUE: type reference
            parameterExpression = Expression.Variable(PropertyPermissionService.G5d17DSB1mYxCaU8Aqc(__typeref (long)), (string) PropertyPermissionService.gwoT9FS9sukMBNcskD3(1458233619 ^ 1458210481));
            num = 6;
            continue;
          case 5:
            goto label_9;
          case 6:
            binaryExpression5 = (BinaryExpression) PropertyPermissionService.aCJoftSvfdWh2RHi1Nu((object) localVarResult, PropertyPermissionService.pMO0lQSFWGP7I5rh75I((object) permission));
            num = 2;
            continue;
          case 7:
            left = Expression.Variable(type, (string) PropertyPermissionService.gwoT9FS9sukMBNcskD3(-1640694811 << 2 ^ 2027128860));
            num = 4;
            continue;
          case 8:
            binaryExpression3 = (BinaryExpression) PropertyPermissionService.waFBtHSesj9jH7tSKl6((object) userIdExpression, (object) parameterExpression);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 1 : 0;
            continue;
          case 9:
            constantExpression2 = (ConstantExpression) PropertyPermissionService.pMO0lQSFWGP7I5rh75I((object) null);
            num = 7;
            continue;
          case 10:
            constantExpression1 = (ConstantExpression) PropertyPermissionService.pMO0lQSFWGP7I5rh75I((object) permission);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 == 0 ? 9 : 9;
            continue;
          default:
            // ISSUE: type reference
            // ISSUE: explicit non-virtual call
            binaryExpression2 = (BinaryExpression) PropertyPermissionService.aCJoftSvfdWh2RHi1Nu((object) parameterExpression, PropertyPermissionService.Vcyq9oSqmnka6nGWvbp(PropertyPermissionService.NKI4r7SIOV6Nk4VCnC1(PropertyPermissionService.MBN9UNSgHI8qeIfvOto((object) left, (object) name), (object) __nonvirtual (PropertyPermissionService.G5d17DSB1mYxCaU8Aqc(__typeref (IIdentified)).GetMethod((string) PropertyPermissionService.gwoT9FS9sukMBNcskD3(978908330 << 6 ^ -1774367428), new Type[0]))), typeof (long)));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 == 0 ? 8 : 0;
            continue;
        }
      }
label_9:
      return Expression.Block((IEnumerable<ParameterExpression>) new ParameterExpression[2]
      {
        left,
        parameterExpression
      }, (Expression) binaryExpression4, (Expression) Expression.IfThen((Expression) test, (Expression) PropertyPermissionService.ztC9xOSH3QeraMmTOV0((object) binaryExpression2, PropertyPermissionService.nELawpS2IEtIhr5YtOH(PropertyPermissionService.oBGEVUSL9jPtQA25eZ7((object) binaryExpression3, (object) binaryExpression1), (object) binaryExpression5))));
    }

    private BlockExpression GenerateFuncForList(
      string name,
      PropertyPermissionType permission,
      Type type,
      ParameterExpression modelExpression,
      ParameterExpression itemsIdExpression,
      ParameterExpression localVarResult)
    {
      int num1 = 9;
      ParameterExpression parameterExpression1;
      BinaryExpression binaryExpression1;
      BinaryExpression binaryExpression2;
      BinaryExpression binaryExpression3;
      BinaryExpression binaryExpression4;
      ParameterExpression parameterExpression2;
      MethodCallExpression methodCallExpression;
      BinaryExpression binaryExpression5;
      while (true)
      {
        int num2 = num1;
        ConstantExpression constantExpression1;
        ConstantExpression constantExpression2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              binaryExpression4 = (BinaryExpression) PropertyPermissionService.aCJoftSvfdWh2RHi1Nu((object) localVarResult, PropertyPermissionService.pMO0lQSFWGP7I5rh75I((object) permission));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 0 : 0;
              continue;
            case 2:
              // ISSUE: type reference
              methodCallExpression = (MethodCallExpression) PropertyPermissionService.sXTsaKSztUqLgHhumI4((object) itemsIdExpression, (object) typeof (List<long>).GetMethod((string) PropertyPermissionService.gwoT9FS9sukMBNcskD3(868767899 ^ 868761469), new Type[1]
              {
                PropertyPermissionService.G5d17DSB1mYxCaU8Aqc(__typeref (long))
              }), (object) new Expression[1]
              {
                (Expression) parameterExpression2
              });
              num2 = 3;
              continue;
            case 3:
              goto label_13;
            case 4:
              // ISSUE: type reference
              // ISSUE: explicit non-virtual call
              // ISSUE: type reference
              binaryExpression5 = (BinaryExpression) PropertyPermissionService.aCJoftSvfdWh2RHi1Nu((object) parameterExpression2, (object) Expression.Convert((Expression) PropertyPermissionService.NKI4r7SIOV6Nk4VCnC1(PropertyPermissionService.MBN9UNSgHI8qeIfvOto((object) parameterExpression1, (object) name), (object) __nonvirtual (PropertyPermissionService.G5d17DSB1mYxCaU8Aqc(__typeref (IIdentified)).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1536327508 ^ -1536301296), new Type[0]))), PropertyPermissionService.G5d17DSB1mYxCaU8Aqc(__typeref (long))));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0 ? 4 : 6;
              continue;
            case 5:
              binaryExpression1 = (BinaryExpression) PropertyPermissionService.jtuxNUSJ9rcwrWUFVG8(PropertyPermissionService.MBN9UNSgHI8qeIfvOto((object) parameterExpression1, (object) name), (object) constantExpression1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0 ? 1 : 0;
              continue;
            case 6:
              // ISSUE: type reference
              binaryExpression2 = Expression.GreaterThan((Expression) PropertyPermissionService.Vcyq9oSqmnka6nGWvbp((object) constantExpression2, typeof (int)), (Expression) PropertyPermissionService.Vcyq9oSqmnka6nGWvbp((object) localVarResult, PropertyPermissionService.G5d17DSB1mYxCaU8Aqc(__typeref (int))));
              num2 = 2;
              continue;
            case 7:
              // ISSUE: type reference
              parameterExpression2 = (ParameterExpression) PropertyPermissionService.Hfc7D7SO2JBZtD5xV2i(PropertyPermissionService.G5d17DSB1mYxCaU8Aqc(__typeref (long)), PropertyPermissionService.gwoT9FS9sukMBNcskD3(1433051380 + 1051547170 ^ -1810394916));
              num2 = 5;
              continue;
            case 8:
              constantExpression1 = (ConstantExpression) PropertyPermissionService.pMO0lQSFWGP7I5rh75I((object) null);
              num2 = 10;
              continue;
            case 9:
              goto label_11;
            case 10:
              parameterExpression1 = (ParameterExpression) PropertyPermissionService.Hfc7D7SO2JBZtD5xV2i(type, PropertyPermissionService.gwoT9FS9sukMBNcskD3(1100789287 - 1555711667 ^ -454948612));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 2 : 7;
              continue;
            default:
              binaryExpression3 = (BinaryExpression) PropertyPermissionService.aCJoftSvfdWh2RHi1Nu((object) parameterExpression1, (object) Expression.Convert((Expression) modelExpression, type));
              num2 = 4;
              continue;
          }
        }
label_11:
        constantExpression2 = (ConstantExpression) PropertyPermissionService.pMO0lQSFWGP7I5rh75I((object) permission);
        num1 = 8;
      }
label_13:
      return Expression.Block((IEnumerable<ParameterExpression>) new ParameterExpression[2]
      {
        parameterExpression1,
        parameterExpression2
      }, (Expression) binaryExpression3, (Expression) PropertyPermissionService.nELawpS2IEtIhr5YtOH((object) binaryExpression1, PropertyPermissionService.ztC9xOSH3QeraMmTOV0((object) binaryExpression5, PropertyPermissionService.nELawpS2IEtIhr5YtOH(PropertyPermissionService.oBGEVUSL9jPtQA25eZ7((object) methodCallExpression, (object) binaryExpression2), (object) binaryExpression4))));
    }

    private IPropertyPermissionAdapter GetAdapterByModelType(
      Type modelType)
    {
      int num = 1;
      Type modelType1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            modelType1 = modelType;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 != 0 ? 2 : 1;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      return this.Adapters.FirstOrDefault<IPropertyPermissionAdapter>((Func<IPropertyPermissionAdapter, bool>) (a => PropertyPermissionService.\u003C\u003Ec__DisplayClass48_0.aZOMBpwNG8fawdZlxLTR((object) a, modelType1)));
    }

    public PropertyPermissionService()
    {
      PropertyPermissionService.WJ2cAwYuKSnR1kaa3Eg();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool NWcEq9SPDdS2UVNpU6K() => PropertyPermissionService.jZVI7XScQ596yVeZUsW == null;

    internal static PropertyPermissionService DsntukSQ2Re365jIqGE() => PropertyPermissionService.jZVI7XScQ596yVeZUsW;

    internal static void T66feTS8Mx7EXdKjOq5([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object CZoVQ1S5nQw74Bvv16A([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static object gJvZ26Sd9WmZcu8l9bk([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static Type PQ9lwHSEKWGPJBw13sT([In] object obj0) => ((PropertyPermissionsChangedEventArgs) obj0).ModelType;

    internal static Type VOtFYXSGr5XTA5nvlsg([In] Type obj0) => InterfaceActivator.TypeOf(obj0);

    internal static object rqaCAFSXr3jGWDbZsTL([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object gwoT9FS9sukMBNcskD3(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object BACaF2S1txTmeaFFTR6([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static bool kVwZv4SMhxIrhn5PDPt([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool Q09nEpSh67lqlh46m2N([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static Type G5d17DSB1mYxCaU8Aqc([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object b4tVxJSpVORx9IEup6P([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object Hfc7D7SO2JBZtD5xV2i([In] Type obj0, [In] object obj1) => (object) Expression.Variable(obj0, (string) obj1);

    internal static int FkDV3eSTDBATUvSdylZ([In] object obj0) => ((List<Expression>) obj0).Count;

    internal static object pMO0lQSFWGP7I5rh75I([In] object obj0) => (object) Expression.Constant(obj0);

    internal static object aCJoftSvfdWh2RHi1Nu([In] object obj0, [In] object obj1) => (object) Expression.Assign((Expression) obj0, (Expression) obj1);

    internal static object Vcyq9oSqmnka6nGWvbp([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);

    internal static object MBN9UNSgHI8qeIfvOto([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (string) obj1);

    internal static object jtuxNUSJ9rcwrWUFVG8([In] object obj0, [In] object obj1) => (object) Expression.NotEqual((Expression) obj0, (Expression) obj1);

    internal static object NKI4r7SIOV6Nk4VCnC1([In] object obj0, [In] object obj1) => (object) Expression.Call((Expression) obj0, (MethodInfo) obj1);

    internal static object waFBtHSesj9jH7tSKl6([In] object obj0, [In] object obj1) => (object) Expression.Equal((Expression) obj0, (Expression) obj1);

    internal static object CixOksSnPGlv9GMtbSt([In] object obj0, [In] object obj1) => (object) Expression.GreaterThan((Expression) obj0, (Expression) obj1);

    internal static object oBGEVUSL9jPtQA25eZ7([In] object obj0, [In] object obj1) => (object) Expression.And((Expression) obj0, (Expression) obj1);

    internal static object nELawpS2IEtIhr5YtOH([In] object obj0, [In] object obj1) => (object) Expression.IfThen((Expression) obj0, (Expression) obj1);

    internal static object ztC9xOSH3QeraMmTOV0([In] object obj0, [In] object obj1) => (object) Expression.Block((Expression) obj0, (Expression) obj1);

    internal static object sXTsaKSztUqLgHhumI4([In] object obj0, [In] object obj1, [In] object obj2) => (object) Expression.Call((Expression) obj0, (MethodInfo) obj1, (Expression[]) obj2);

    internal static void WJ2cAwYuKSnR1kaa3Eg() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    private class PropertyProfileCacheEntry
    {
      private static object VfajoOwjVqPQAxO3Ifeo;

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
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 != 0 ? 0 : 0;
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

      public List<PropertyAccessCacheItem> Accesses { get; set; }

      public Func<object, long, PropertyPermissionType> FuncForUser { get; set; }

      public Func<object, List<long>, PropertyPermissionType> FuncForOrgItem { get; set; }

      public Func<object, List<long>, PropertyPermissionType> FuncForGroup { get; set; }

      public PropertyProfileCacheEntry()
      {
        PropertyPermissionService.PropertyProfileCacheEntry.wbZkyLwj4RtbWL4x8x8t();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool q74VR6wjls9jT1jvk08f() => PropertyPermissionService.PropertyProfileCacheEntry.VfajoOwjVqPQAxO3Ifeo == null;

      internal static PropertyPermissionService.PropertyProfileCacheEntry SeurstwjfEIaRZc9Xv5s() => (PropertyPermissionService.PropertyProfileCacheEntry) PropertyPermissionService.PropertyProfileCacheEntry.VfajoOwjVqPQAxO3Ifeo;

      internal static void wbZkyLwj4RtbWL4x8x8t() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
    }

    private class TypeCacheEntry
    {
      internal static object vwn4bswjcQ8YLGZVFwkF;

      public TypeCacheEntry()
      {
        PropertyPermissionService.TypeCacheEntry.YWIMq5wj8lC2gnykKLSB();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.Properties = (IDictionary<Guid, PropertyPermissionService.PropertyProfileCacheEntry>) new Dictionary<Guid, PropertyPermissionService.PropertyProfileCacheEntry>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 != 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      public IDictionary<Guid, PropertyPermissionService.PropertyProfileCacheEntry> Properties { get; private set; }

      internal static void YWIMq5wj8lC2gnykKLSB() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

      internal static bool IJsTyhwjPapbxMBwF0CN() => PropertyPermissionService.TypeCacheEntry.vwn4bswjcQ8YLGZVFwkF == null;

      internal static PropertyPermissionService.TypeCacheEntry nMS8N9wjQI0ncQDvWlHq() => (PropertyPermissionService.TypeCacheEntry) PropertyPermissionService.TypeCacheEntry.vwn4bswjcQ8YLGZVFwkF;
    }

    private class GetPermissionResult
    {
      private static object WaZ4Nnwj5oWA1TUEAUI3;

      public Dictionary<Guid, PropertyPermissionType> GlobalPermissions { get; set; }

      public Dictionary<Guid, PropertyPermissionType> DependedPermissionsOut { get; set; }

      public GetPermissionResult()
      {
        PropertyPermissionService.GetPermissionResult.E3AdOdwjGNi9LnTGSNxI();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void E3AdOdwjGNi9LnTGSNxI() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

      internal static bool kSqTb0wjdm6Rndfpo5X5() => PropertyPermissionService.GetPermissionResult.WaZ4Nnwj5oWA1TUEAUI3 == null;

      internal static PropertyPermissionService.GetPermissionResult wGZmCcwjErZKqLjE3ecM() => (PropertyPermissionService.GetPermissionResult) PropertyPermissionService.GetPermissionResult.WaZ4Nnwj5oWA1TUEAUI3;
    }

    private class UserRolesResult
    {
      private static object F8EKt4wjXImJu63AKqd2;

      public List<long> GroupIds { get; set; }

      public List<long> OrgItemIds { get; set; }

      public UserRolesResult()
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool O8rA8lwj9NLJxFn2Ger6() => PropertyPermissionService.UserRolesResult.F8EKt4wjXImJu63AKqd2 == null;

      internal static PropertyPermissionService.UserRolesResult AJrSs9wj1b7bijOekL6Q() => (PropertyPermissionService.UserRolesResult) PropertyPermissionService.UserRolesResult.F8EKt4wjXImJu63AKqd2;
    }
  }
}
