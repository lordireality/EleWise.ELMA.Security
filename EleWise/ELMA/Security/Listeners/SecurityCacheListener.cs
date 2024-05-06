// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Listeners.SecurityCacheListener
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Collection;
using NHibernate.Engine;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Listeners
{
  [Component]
  internal class SecurityCacheListener : EntityEventsListener
  {
    internal const string needOldUpdateKey = "EleWise.ELMA.Security.SecurityCacheListener.Old.key";
    internal const string needUpdateKey = "EleWise.ELMA.Security.SecurityCacheListener.key";
    internal const string needUpdateUserKey = "EleWise.ELMA.Security.SecurityCacheListener.Users.key";
    internal const string needUpdateGroupKey = "EleWise.ELMA.Security.SecurityCacheListener.Groups.key";
    internal const string needUpdateOrganizationItemKey = "EleWise.ELMA.Security.SecurityCacheListener.OrganizationItems.key";
    private readonly IContextBoundVariableService contextBoundVariableService;
    internal static SecurityCacheListener gm57DGs3lnIKfgfQJ55;

    private IInternalSecurityService InternalSecurityService => (IInternalSecurityService) SecurityCacheListener.NXfUR3s7VvU68lAq8ju((object) (ILicensedModuleAssembly) SecurityCacheListener.ue6o8Tssb68Ir0j51Cy(SecurityCacheListener.r4IACXsZQDwSiK56fnJ(SecurityCacheListener.k9hrZFs0o1MnDI2wOfe()), SecurityCacheListener.WFbnknsAMd0XsQj1e21()));

    public SecurityCacheListener(
      IContextBoundVariableService contextBoundVariableService)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.contextBoundVariableService = contextBoundVariableService;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public override bool OnPreInsert(PreInsertEvent @event)
    {
      int num1 = 3;
      IUserGroup userGroup;
      while (true)
      {
        switch (num1)
        {
          case 1:
            IUserGroup entity1 = userGroup;
            // ISSUE: reference to a compiler-generated field
            Func<IUserGroup, ISet<EleWise.ELMA.Security.Models.IUser>> func1 = SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__10_2;
            Func<IUserGroup, ISet<EleWise.ELMA.Security.Models.IUser>> collectionAccessor1;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__10_2 = collectionAccessor1 = (Func<IUserGroup, ISet<EleWise.ELMA.Security.Models.IUser>>) (u => u.Users);
            }
            else
              goto label_19;
label_12:
            // ISSUE: reference to a compiler-generated field
            Action<IUserGroup, string> action1 = SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__10_3;
            Action<IUserGroup, string> hashSetter1;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__10_3 = hashSetter1 = (Action<IUserGroup, string>) ((u, v) =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      SecurityCacheListener.\u003C\u003Ec.KGrkPUwahGBEo4VhgVTa((object) u, (object) v);
                      num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              });
            }
            else
              goto label_18;
label_14:
            this.Process<IUserGroup, EleWise.ELMA.Security.Models.IUser>(entity1, collectionAccessor1, hashSetter1);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 == 0 ? 5 : 3;
            continue;
label_18:
            hashSetter1 = action1;
            goto label_14;
label_19:
            collectionAccessor1 = func1;
            goto label_12;
          case 2:
            if (userGroup != null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            userGroup = SecurityCacheListener.hXHVjWsWRSVLtgwHbJY((object) @event) as IUserGroup;
            num1 = 2;
            continue;
          case 4:
            goto label_2;
          case 5:
            IUserGroup entity2 = userGroup;
            // ISSUE: reference to a compiler-generated field
            Func<IUserGroup, ISet<IUserGroup>> func2 = SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__10_4;
            Func<IUserGroup, ISet<IUserGroup>> collectionAccessor2;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__10_4 = collectionAccessor2 = (Func<IUserGroup, ISet<IUserGroup>>) (u => u.Groups);
            }
            else
              goto label_20;
label_17:
            this.Process<IUserGroup, IUserGroup>(entity2, collectionAccessor2, (Action<IUserGroup, string>) ((u, v) =>
            {
              int num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    SecurityCacheListener.\u003C\u003Ec.QWJ4xYwaB07y5ZtGh2oS((object) u, (object) v);
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 4;
            continue;
label_20:
            collectionAccessor2 = func2;
            goto label_17;
          default:
            IUserGroup entity3 = userGroup;
            // ISSUE: reference to a compiler-generated field
            Action<IUserGroup, string> action2 = SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__10_1;
            Action<IUserGroup, string> hashSetter2;
            if (action2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__10_1 = hashSetter2 = (Action<IUserGroup, string>) ((u, v) =>
              {
                int num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      SecurityCacheListener.\u003C\u003Ec.o801FswaMjVi9kbi5Dry((object) u, (object) v);
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              });
            }
            else
              goto label_10;
label_8:
            this.Process<IUserGroup, IOrganizationItem>(entity3, (Func<IUserGroup, ISet<IOrganizationItem>>) (u => u.OrganizationItems), hashSetter2);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 != 0 ? 1 : 1;
            continue;
label_10:
            hashSetter2 = action2;
            goto label_8;
        }
      }
label_2:
      return SecurityCacheListener.avG9DjsrRVV1eEVLfPb((object) this, (object) @event);
    }

    public override bool OnPreUpdate(PreUpdateEvent @event)
    {
      int num1 = 22;
      while (true)
      {
        int num2 = num1;
        IOrganizationItem organizationItem;
        EleWise.ELMA.Security.Models.IUser user1;
        while (true)
        {
          EleWise.ELMA.Security.Models.IUser user2;
          int index;
          int num3;
          EleWise.ELMA.Security.Models.IUser user3;
          switch (num2)
          {
            case 1:
              num3 = Array.IndexOf<string>((string[]) SecurityCacheListener.KIZVdEsYceGRR1q0E7U((object) @event.Persister), (string) SecurityCacheListener.PRlP8xsyBM00xYMFQMj(617710536 ^ 617711104));
              break;
            case 2:
              if (!user2.OrganizationItems.IsInitialized<IOrganizationItem>())
              {
                num2 = 18;
                continue;
              }
              goto case 5;
            case 3:
              if (user1 != user2)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d != 0 ? 0 : 0;
                continue;
              }
              goto case 16;
            case 4:
              user2 = organizationItem.User;
              num2 = 14;
              continue;
            case 5:
              EleWise.ELMA.Security.Models.IUser entity1 = user2;
              IOrganizationItem add = organizationItem;
              // ISSUE: reference to a compiler-generated field
              Func<EleWise.ELMA.Security.Models.IUser, ISet<IOrganizationItem>> func1 = SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__11_2;
              Func<EleWise.ELMA.Security.Models.IUser, ISet<IOrganizationItem>> collectionAccessor1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__11_2 = collectionAccessor1 = (Func<EleWise.ELMA.Security.Models.IUser, ISet<IOrganizationItem>>) (u => u.OrganizationItems);
              }
              else
                goto label_3;
label_39:
              // ISSUE: reference to a compiler-generated field
              Action<EleWise.ELMA.Security.Models.IUser, string> action = SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__11_3;
              Action<EleWise.ELMA.Security.Models.IUser, string> hashSetter;
              if (action == null)
              {
                // ISSUE: reference to a compiler-generated field
                SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__11_3 = hashSetter = (Action<EleWise.ELMA.Security.Models.IUser, string>) ((u, v) =>
                {
                  int num4 = 1;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        SecurityCacheListener.\u003C\u003Ec.Xm0bmUwapQhFOkisF29d((object) u, (object) v);
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                });
              }
              else
                goto label_14;
label_41:
              this.ProcessAdd<EleWise.ELMA.Security.Models.IUser, IOrganizationItem>(entity1, add, collectionAccessor1, hashSetter);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 == 0 ? 9 : 19;
              continue;
label_14:
              hashSetter = action;
              goto label_41;
label_3:
              collectionAccessor1 = func1;
              goto label_39;
            case 6:
            case 7:
            case 17:
              goto label_25;
            case 8:
              user1.OrganizationItems.FirstOrDefault<IOrganizationItem>();
              num2 = 9;
              continue;
            case 9:
            case 11:
              EleWise.ELMA.Security.Models.IUser entity2 = user1;
              IOrganizationItem remove = organizationItem;
              // ISSUE: reference to a compiler-generated field
              Func<EleWise.ELMA.Security.Models.IUser, ISet<IOrganizationItem>> func2 = SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__11_0;
              Func<EleWise.ELMA.Security.Models.IUser, ISet<IOrganizationItem>> collectionAccessor2;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__11_0 = collectionAccessor2 = (Func<EleWise.ELMA.Security.Models.IUser, ISet<IOrganizationItem>>) (u => u.OrganizationItems);
              }
              else
                goto label_42;
label_36:
              this.ProcessRemove<EleWise.ELMA.Security.Models.IUser, IOrganizationItem>(entity2, remove, collectionAccessor2, (Action<EleWise.ELMA.Security.Models.IUser, string>) ((u, v) =>
              {
                int num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      SecurityCacheListener.\u003C\u003Ec.Xm0bmUwapQhFOkisF29d((object) u, (object) v);
                      num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = 15;
              continue;
label_42:
              collectionAccessor2 = func2;
              goto label_36;
            case 10:
              user3 = (EleWise.ELMA.Security.Models.IUser) SecurityCacheListener.HHE7u9sS6kXNaYRiuLq((object) @event)[index];
              goto label_33;
            case 12:
              if (index < 0)
                goto case 13;
              else
                goto label_16;
            case 13:
              user3 = (EleWise.ELMA.Security.Models.IUser) null;
              goto label_33;
            case 14:
              if (user1 != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 != 0 ? 3 : 3;
                continue;
              }
              goto case 16;
            case 15:
              goto label_9;
            case 16:
              if (user2 == null)
              {
                num2 = 7;
                continue;
              }
              goto case 2;
            case 18:
              user2.OrganizationItems.FirstOrDefault<IOrganizationItem>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0 ? 5 : 4;
              continue;
            case 19:
              SecurityCacheListener.TYIBdPsVUt6iERNSw3E((object) user2);
              num2 = 6;
              continue;
            case 20:
              if (SecurityCacheListener.HHE7u9sS6kXNaYRiuLq((object) @event) != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0 ? 0 : 1;
                continue;
              }
              num3 = -1;
              break;
            case 21:
              if (organizationItem == null)
              {
                num2 = 17;
                continue;
              }
              goto case 20;
            case 22:
              goto label_10;
            default:
              if (user1.OrganizationItems.IsInitialized<IOrganizationItem>())
              {
                num2 = 11;
                continue;
              }
              goto case 8;
          }
          index = num3;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 4 : 12;
          continue;
label_33:
          user1 = user3;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 != 0 ? 4 : 4;
        }
label_9:
        SecurityCacheListener.TYIBdPsVUt6iERNSw3E((object) user1);
        num1 = 16;
        continue;
label_10:
        organizationItem = SecurityCacheListener.hXHVjWsWRSVLtgwHbJY((object) @event) as IOrganizationItem;
        num1 = 21;
        continue;
label_16:
        num1 = 10;
      }
label_25:
      return SecurityCacheListener.VsBNBCsloGYNAP90dD1((object) this, (object) @event);
    }

    public override void OnPreUpdateCollection(PreCollectionUpdateEvent @event)
    {
      int num1 = 36;
      while (true)
      {
        int num2 = num1;
        int index1;
        CollectionEntry collectionEntry1;
        object[] objArray;
        int index2;
        CollectionEntry collectionEntry2;
        object[] array1;
        IOrganizationItem organizationItem1;
        IOrganizationItem[] array2;
        object[] array3;
        IOrganizationItem organizationItem2;
        EleWise.ELMA.Security.Models.IUser user1;
        EleWise.ELMA.Security.Models.IUser user2;
        EleWise.ELMA.Security.Models.IUser user3;
        IOrganizationItem organizationItem3;
        object[] array4;
        EleWise.ELMA.Security.Models.IUser[] array5;
        object[] array6;
        List<object> newCollection1;
        List<object> oldCollection1;
        EleWise.ELMA.Security.Models.IUser user;
        IOrganizationItem organizationItem;
        List<object> newCollection2;
        List<object> oldCollection2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              index1 = 0;
              num2 = 71;
              continue;
            case 3:
            case 8:
              organizationItem = @event.AffectedOwnerOrNull as IOrganizationItem;
              num2 = 62;
              continue;
            case 4:
              num2 = 5;
              continue;
            case 5:
              collectionEntry2 = (CollectionEntry) SecurityCacheListener.Rw9lrasP1gQC8qorhUM(SecurityCacheListener.DSa67VsEVILtvCFE52k(SecurityCacheListener.AATN1hs4ij6SxNwYKFY((object) @event)), (object) @event.Collection);
              num2 = 22;
              continue;
            case 6:
            case 70:
              organizationItem1 = (IOrganizationItem) objArray[index2];
              num2 = 67;
              continue;
            case 7:
              array1 = newCollection2.Where<object>((Func<object, bool>) (item => !oldCollection2.Contains(item))).ToArray<object>();
              num2 = 85;
              continue;
            case 9:
              index2 = 0;
              num2 = 2;
              continue;
            case 10:
              ++index2;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 != 0 ? 51 : 9;
              continue;
            case 11:
            case 34:
              goto label_28;
            case 12:
              index2 = 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 24 : 21;
              continue;
            case 13:
              array2 = user3.OrganizationGroups.Where<IOrganizationItem>((Func<IOrganizationItem, bool>) (oi => oi.Id == organizationItem.Id)).ToArray<IOrganizationItem>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 != 0 ? 0 : 1;
              continue;
            case 14:
              ++index1;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa == 0 ? 44 : 55;
              continue;
            case 15:
              objArray = array4;
              num2 = 42;
              continue;
            case 16:
            case 20:
              organizationItem2.Save();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 46 : 53;
              continue;
            case 17:
            case 46:
              goto label_9;
            case 18:
              goto label_89;
            case 19:
            case 51:
              if (index2 < objArray.Length)
              {
                num2 = 27;
                continue;
              }
              goto case 77;
            case 21:
            case 52:
              if (index1 < array5.Length)
                goto case 25;
              else
                goto label_47;
            case 22:
              newCollection1 = (SecurityCacheListener.Id2ktSsc1kLaxoMGVgm((object) @event) as IEnumerable).Cast<object>().ToList<object>();
              num2 = 32;
              continue;
            case 23:
            case 48:
              SecurityCacheListener.TYIBdPsVUt6iERNSw3E((object) user1);
              num2 = 60;
              continue;
            case 24:
            case 61:
              if (index2 >= objArray.Length)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 63 : 31;
                continue;
              }
              goto case 79;
            case 25:
              user2 = array5[index1];
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 != 0 ? 64 : 18;
              continue;
            case 26:
              array6 = newCollection1.Where<object>((Func<object, bool>) (item => !oldCollection1.Contains(item))).ToArray<object>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 31 : 3;
              continue;
            case 27:
            case 81:
              user3 = (EleWise.ELMA.Security.Models.IUser) objArray[index2];
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 == 0 ? 13 : 13;
              continue;
            case 28:
              index2 = 0;
              num2 = 33;
              continue;
            case 29:
              organizationItem2.Users.Add(user);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 20 : 18;
              continue;
            case 30:
              goto label_88;
            case 31:
              if (((string) SecurityCacheListener.z8iotOs80fKVT5GZ20b((object) collectionEntry2)).EndsWith((string) SecurityCacheListener.PRlP8xsyBM00xYMFQMj(-1277472395 ^ -1277492705)))
              {
                num2 = 15;
                continue;
              }
              goto label_82;
            case 32:
              oldCollection1 = (SecurityCacheListener.GTapcYsQoVaMst82VPo((object) collectionEntry2) as IEnumerable).Cast<object>().ToList<object>();
              num2 = 72;
              continue;
            case 33:
            case 49:
              if (index2 < objArray.Length)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 70 : 70;
                continue;
              }
              goto case 68;
            case 35:
              goto label_80;
            case 36:
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0 ? 35 : 13;
              continue;
            case 37:
              ++index2;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 43 : 61;
              continue;
            case 38:
            case 84:
              organizationItem3 = array2[index1];
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc == 0 ? 22 : 76;
              continue;
            case 39:
            case 45:
              if (index2 >= objArray.Length)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 18 : 5;
                continue;
              }
              goto case 73;
            case 40:
            case 56:
              if (index2 < objArray.Length)
              {
                num2 = 66;
                continue;
              }
              goto case 3;
            case 41:
              ++index2;
              num2 = 49;
              continue;
            case 42:
              index2 = 0;
              num2 = 19;
              continue;
            case 43:
              newCollection2 = (@event.Collection as IEnumerable).Cast<object>().ToList<object>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 47 : 39;
              continue;
            case 44:
              goto label_36;
            case 47:
              oldCollection2 = (SecurityCacheListener.GTapcYsQoVaMst82VPo((object) collectionEntry1) as IEnumerable).Cast<object>().ToList<object>();
              num2 = 57;
              continue;
            case 50:
              if (user != null)
              {
                num2 = 74;
                continue;
              }
              goto case 3;
            case 53:
              ++index2;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef != 0 ? 4 : 56;
              continue;
            case 54:
              goto label_19;
            case 55:
            case 71:
              if (index1 < array2.Length)
              {
                num2 = 38;
                continue;
              }
              goto label_36;
            case 57:
              array3 = oldCollection2.Where<object>((Func<object, bool>) (item => !newCollection2.Contains(item))).ToArray<object>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0 ? 7 : 2;
              continue;
            case 58:
              index1 = 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 52 : 27;
              continue;
            case 59:
              collectionEntry1 = (CollectionEntry) SecurityCacheListener.Rw9lrasP1gQC8qorhUM((object) ((ISessionImplementor) SecurityCacheListener.AATN1hs4ij6SxNwYKFY((object) @event)).PersistenceContext, SecurityCacheListener.Id2ktSsc1kLaxoMGVgm((object) @event));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 43 : 27;
              continue;
            case 60:
              ++index2;
              num2 = 45;
              continue;
            case 62:
              if (organizationItem != null)
              {
                num2 = 4;
                continue;
              }
              goto label_73;
            case 63:
              objArray = array1;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af == 0 ? 2 : 9;
              continue;
            case 64:
              organizationItem1.Users.Remove(user2);
              num2 = 80;
              continue;
            case 65:
              objArray = array3;
              num2 = 12;
              continue;
            case 66:
            case 86:
              organizationItem2 = (IOrganizationItem) objArray[index2];
              num2 = 78;
              continue;
            case 67:
              goto label_84;
            case 68:
              objArray = array1;
              num2 = 87;
              continue;
            case 69:
              ++index2;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 0 : 0;
              continue;
            case 72:
              array4 = oldCollection1.Where<object>((Func<object, bool>) (item => !newCollection1.Contains(item))).ToArray<object>();
              num2 = 26;
              continue;
            case 73:
              user1 = (EleWise.ELMA.Security.Models.IUser) objArray[index2];
              num2 = 30;
              continue;
            case 74:
              num2 = 59;
              continue;
            case 75:
              index2 = 0;
              num2 = 39;
              continue;
            case 76:
              goto label_54;
            case 77:
              objArray = array6;
              num2 = 75;
              continue;
            case 78:
              if (organizationItem2.Users.All<EleWise.ELMA.Security.Models.IUser>((Func<EleWise.ELMA.Security.Models.IUser, bool>) (u => u.Id != user.Id)))
                goto case 29;
              else
                goto label_86;
            case 79:
              IOrganizationItem organizationItem4 = (IOrganizationItem) objArray[index2];
              SecurityCacheListener.VKTBevsdqpY87S46iq0((object) organizationItem4, (object) null);
              SecurityCacheListener.TYIBdPsVUt6iERNSw3E((object) organizationItem4);
              num2 = 37;
              continue;
            case 80:
              goto label_71;
            case 82:
              goto label_12;
            case 83:
              goto label_64;
            case 85:
              if (!SecurityCacheListener.F4pSJss5pWpRCs0jjkO(SecurityCacheListener.z8iotOs80fKVT5GZ20b((object) collectionEntry1), SecurityCacheListener.PRlP8xsyBM00xYMFQMj(-404268492 ^ -404289236)))
              {
                num2 = 11;
                continue;
              }
              goto case 65;
            case 87:
              index2 = 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 != 0 ? 19 : 40;
              continue;
            default:
              if (index2 < objArray.Length)
              {
                num2 = 46;
                continue;
              }
              goto label_28;
          }
        }
label_9:
        IOrganizationItem organizationItem5 = (IOrganizationItem) objArray[index2];
        SecurityCacheListener.VKTBevsdqpY87S46iq0((object) organizationItem5, (object) user);
        SecurityCacheListener.TYIBdPsVUt6iERNSw3E((object) organizationItem5);
        num1 = 69;
        continue;
label_12:
        SecurityCacheListener.TYIBdPsVUt6iERNSw3E((object) organizationItem1);
        num1 = 41;
        continue;
label_19:
        user1.OrganizationGroups.Add(organizationItem);
        num1 = 23;
        continue;
label_28:
        if (!SecurityCacheListener.F4pSJss5pWpRCs0jjkO(SecurityCacheListener.z8iotOs80fKVT5GZ20b((object) collectionEntry1), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1277802350 ^ -1277813806)))
        {
          num1 = 3;
          continue;
        }
        goto label_64;
label_36:
        SecurityCacheListener.TYIBdPsVUt6iERNSw3E((object) user3);
        num1 = 10;
        continue;
label_47:
        num1 = 82;
        continue;
label_54:
        user3.OrganizationGroups.Remove(organizationItem3);
        num1 = 14;
        continue;
label_64:
        objArray = array3;
        num1 = 28;
        continue;
label_71:
        ++index1;
        num1 = 21;
        continue;
label_80:
        user = SecurityCacheListener.VUXEHvsfNDXKmZhN9ep((object) @event) as EleWise.ELMA.Security.Models.IUser;
        num1 = 50;
        continue;
label_84:
        array5 = organizationItem1.Users.Where<EleWise.ELMA.Security.Models.IUser>((Func<EleWise.ELMA.Security.Models.IUser, bool>) (u => u.Id == user.Id)).ToArray<EleWise.ELMA.Security.Models.IUser>();
        num1 = 58;
        continue;
label_86:
        num1 = 16;
        continue;
label_88:
        ISet<IOrganizationItem> organizationGroups = user1.OrganizationGroups;
        Func<IOrganizationItem, bool> func;
        Func<IOrganizationItem, bool> func1 = func;
        Func<IOrganizationItem, bool> predicate = func1 == null ? (func = (Func<IOrganizationItem, bool>) (oi => oi.Id != organizationItem.Id)) : func1;
        if (!organizationGroups.All<IOrganizationItem>(predicate))
          num1 = 48;
        else
          goto label_19;
      }
label_89:
      return;
label_82:
      return;
label_73:;
    }

    public override void OnPostInsert(PostInsertEvent @event)
    {
      int num = 23;
      while (true)
      {
        IOrganizationItem entity;
        IUserGroup userGroup;
        EleWise.ELMA.Security.Models.IUser user1;
        int index;
        EleWise.ELMA.Security.Models.IUser user2;
        EleWise.ELMA.Security.Models.IUser user3;
        switch (num)
        {
          case 1:
            if (userGroup == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 != 0 ? 4 : 19;
              continue;
            }
            goto case 25;
          case 2:
            if (SecurityCacheListener.YkL6UysXcLBsjaL1XxL((object) user1) != UserStatus.Blocked)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 15 : 11;
              continue;
            }
            goto case 26;
          case 3:
            index = Array.IndexOf<string>((string[]) SecurityCacheListener.KIZVdEsYceGRR1q0E7U(SecurityCacheListener.dKq2hcs9wn43xcK4NGY((object) @event)), (string) SecurityCacheListener.PRlP8xsyBM00xYMFQMj(-1527733619 - 442652394 ^ -1970385301));
            num = 4;
            continue;
          case 4:
            if (index >= 0)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0 ? 20 : 21;
              continue;
            }
            goto case 11;
          case 5:
            if (SecurityCacheListener.EBTYnisG25t71Ee8TGE((object) @event) is IUserGroup)
            {
              num = 20;
              continue;
            }
            goto case 13;
          case 6:
          case 19:
            entity = @event.Entity as IOrganizationItem;
            num = 9;
            continue;
          case 7:
            goto label_37;
          case 8:
            goto label_31;
          case 9:
            if (entity == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 10 : 16;
              continue;
            }
            goto case 3;
          case 10:
          case 20:
            this.RaiseOldUpdateCache();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 2 : 8;
            continue;
          case 11:
            user3 = (EleWise.ELMA.Security.Models.IUser) null;
            break;
          case 12:
            this.RaiseUpdateCache();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 0 : 0;
            continue;
          case 13:
            if (!(SecurityCacheListener.EBTYnisG25t71Ee8TGE((object) @event) is IOrganizationItem))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0 ? 7 : 4;
              continue;
            }
            goto case 10;
          case 14:
          case 16:
            if (@event.Entity is IOrganizationModel)
            {
              num = 12;
              continue;
            }
            goto default;
          case 15:
            this.InternalSecurityService.CheckUserToAuthenticate(user1, (Func<bool>) null, (Func<int, bool>) null, (Func<int>) null);
            num = 26;
            continue;
          case 17:
          case 18:
            userGroup = SecurityCacheListener.EBTYnisG25t71Ee8TGE((object) @event) as IUserGroup;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 != 0 ? 1 : 0;
            continue;
          case 21:
            user3 = (EleWise.ELMA.Security.Models.IUser) SecurityCacheListener.sOx7lYs1dfTpY5AbVup((object) @event)[index];
            break;
          case 22:
            if (user1 == null)
            {
              num = 17;
              continue;
            }
            goto case 2;
          case 23:
            user1 = SecurityCacheListener.EBTYnisG25t71Ee8TGE((object) @event) as EleWise.ELMA.Security.Models.IUser;
            num = 22;
            continue;
          case 24:
            IOrganizationItem organizationItem = entity;
            ISet<EleWise.ELMA.Security.Models.IUser> users = entity.Users;
            // ISSUE: reference to a compiler-generated field
            Func<EleWise.ELMA.Security.Models.IUser, long> func1 = SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__13_3;
            Func<EleWise.ELMA.Security.Models.IUser, long> selector1;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__13_3 = selector1 = (Func<EleWise.ELMA.Security.Models.IUser, long>) (u => u.Id);
            }
            else
              goto label_40;
label_39:
            Pair<long[], long[]> userChanges1 = new Pair<long[], long[]>(users.Select<EleWise.ELMA.Security.Models.IUser, long>(selector1).ToArray<long>(), new long[0]);
            EleWise.ELMA.Security.Models.IUser newUser = user2;
            this.RaiseUpdateCache(organizationItem, userChanges1, (EleWise.ELMA.Security.Models.IUser) null, newUser);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 14 : 0;
            continue;
label_40:
            selector1 = func1;
            goto label_39;
          case 25:
            IUserGroup group = userGroup;
            Pair<long[], long[]> userChanges2 = new Pair<long[], long[]>(userGroup.Users.Select<EleWise.ELMA.Security.Models.IUser, long>((Func<EleWise.ELMA.Security.Models.IUser, long>) (u => u.Id)).ToArray<long>(), new long[0]);
            ISet<IOrganizationItem> organizationItems = userGroup.OrganizationItems;
            // ISSUE: reference to a compiler-generated field
            Func<IOrganizationItem, long> func2 = SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__13_1;
            Func<IOrganizationItem, long> selector2;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__13_1 = selector2 = (Func<IOrganizationItem, long>) (oi => oi.Id);
            }
            else
              goto label_13;
label_33:
            Pair<long[], long[]> orgItemsChanges = new Pair<long[], long[]>(organizationItems.Select<IOrganizationItem, long>(selector2).ToArray<long>(), new long[0]);
            Pair<long[], long[]> groupsChanges = new Pair<long[], long[]>(userGroup.Groups.Select<IUserGroup, long>((Func<IUserGroup, long>) (g => g.Id)).ToArray<long>(), new long[0]);
            this.RaiseUpdateCache(group, userChanges2, orgItemsChanges, groupsChanges);
            num = 6;
            continue;
label_13:
            selector2 = func2;
            goto label_33;
          case 26:
            this.RaiseUpdateCache(user1);
            num = 18;
            continue;
          default:
            if (!(SecurityCacheListener.EBTYnisG25t71Ee8TGE((object) @event) is EleWise.ELMA.Security.Models.IUser))
            {
              num = 5;
              continue;
            }
            goto case 10;
        }
        user2 = user3;
        num = 24;
      }
label_37:
      return;
label_31:;
    }

    public override void OnPostUpdate(PostUpdateEvent @event)
    {
      int num1 = 17;
      while (true)
      {
        int num2 = num1;
        int index;
        while (true)
        {
          IUserGroup userGroup;
          IOrganizationItem organizationItem1;
          EleWise.ELMA.Security.Models.IUser user1;
          EleWise.ELMA.Security.Models.IUser user2;
          EleWise.ELMA.Security.Models.IUser user3;
          switch (num2)
          {
            case 0:
              goto label_10;
            case 1:
              goto label_16;
            case 2:
            case 4:
              organizationItem1 = SecurityCacheListener.EBTYnisG25t71Ee8TGE((object) @event) as IOrganizationItem;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 != 0 ? 6 : 7;
              continue;
            case 3:
              IOrganizationItem organizationItem2 = organizationItem1;
              PostUpdateEvent event1 = @event;
              ParameterExpression parameterExpression1 = (ParameterExpression) SecurityCacheListener.dkWZ2qshRODMgeDqNQX(typeof (IOrganizationItem), SecurityCacheListener.PRlP8xsyBM00xYMFQMj(-340788466 ^ -340809586));
              // ISSUE: method reference
              Expression<Func<IOrganizationItem, string>> prop1 = Expression.Lambda<Func<IOrganizationItem, string>>((Expression) SecurityCacheListener.a9EQRospta7Th5WUwyr((object) parameterExpression1, (object) (MethodInfo) SecurityCacheListener.bU8I88sBJCpwrEoVnkT(__methodref (IOrganizationItem.get_UsersHash))), parameterExpression1);
              Pair<long[], long[]> changedIds1 = this.GetChangedIds<IOrganizationItem>((AbstractPostDatabaseOperationEvent) event1, prop1);
              EleWise.ELMA.Security.Models.IUser oldUser = user1;
              EleWise.ELMA.Security.Models.IUser newUser = user2;
              this.RaiseUpdateCache(organizationItem2, changedIds1, oldUser, newUser);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0 ? 10 : 0;
              continue;
            case 5:
              if (SecurityCacheListener.EBTYnisG25t71Ee8TGE((object) @event) is IOrganizationItem)
              {
                num2 = 15;
                continue;
              }
              goto label_9;
            case 6:
              if (SecurityCacheListener.d33WDdsOJ6CG9Lwijrb((object) @event) != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 0 : 1;
                continue;
              }
              goto label_28;
            case 7:
              if (organizationItem1 == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 14 : 6;
                continue;
              }
              goto case 6;
            case 8:
              user2 = (EleWise.ELMA.Security.Models.IUser) SecurityCacheListener.T2GA0OsT5btCjHoOpe3((object) organizationItem1);
              num2 = 3;
              continue;
            case 9:
              if (!(SecurityCacheListener.EBTYnisG25t71Ee8TGE((object) @event) is IUserGroup))
              {
                num2 = 5;
                continue;
              }
              goto case 15;
            case 10:
            case 14:
              if (!(@event.Entity is EleWise.ELMA.Security.Models.IUser))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 == 0 ? 7 : 9;
                continue;
              }
              goto case 15;
            case 11:
              if (index < 0)
              {
                num2 = 13;
                continue;
              }
              user3 = (EleWise.ELMA.Security.Models.IUser) @event.OldState[index];
              break;
            case 12:
              IUserGroup group = userGroup;
              PostUpdateEvent event2 = @event;
              // ISSUE: type reference
              ParameterExpression parameterExpression2 = (ParameterExpression) SecurityCacheListener.dkWZ2qshRODMgeDqNQX(SecurityCacheListener.MlTFKrsMiqc4jiNLwoY(__typeref (IUserGroup)), SecurityCacheListener.PRlP8xsyBM00xYMFQMj(789532496 ^ 1575286436 ^ 1928063630));
              // ISSUE: method reference
              Expression<Func<IUserGroup, string>> prop2 = Expression.Lambda<Func<IUserGroup, string>>((Expression) SecurityCacheListener.a9EQRospta7Th5WUwyr((object) parameterExpression2, (object) (MethodInfo) SecurityCacheListener.bU8I88sBJCpwrEoVnkT(__methodref (IUserGroup.get_UsersHash))), parameterExpression2);
              Pair<long[], long[]> changedIds2 = this.GetChangedIds<IUserGroup>((AbstractPostDatabaseOperationEvent) event2, prop2);
              PostUpdateEvent event3 = @event;
              // ISSUE: type reference
              ParameterExpression parameterExpression3 = (ParameterExpression) SecurityCacheListener.dkWZ2qshRODMgeDqNQX(SecurityCacheListener.MlTFKrsMiqc4jiNLwoY(__typeref (IUserGroup)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1958138283 - -279956781 ^ -1678202632));
              // ISSUE: method reference
              Expression<Func<IUserGroup, string>> prop3 = Expression.Lambda<Func<IUserGroup, string>>((Expression) SecurityCacheListener.a9EQRospta7Th5WUwyr((object) parameterExpression3, (object) (MethodInfo) SecurityCacheListener.bU8I88sBJCpwrEoVnkT(__methodref (IUserGroup.get_OrganizationItemsHash))), parameterExpression3);
              Pair<long[], long[]> changedIds3 = this.GetChangedIds<IUserGroup>((AbstractPostDatabaseOperationEvent) event3, prop3);
              PostUpdateEvent event4 = @event;
              // ISSUE: type reference
              ParameterExpression parameterExpression4 = (ParameterExpression) SecurityCacheListener.dkWZ2qshRODMgeDqNQX(SecurityCacheListener.MlTFKrsMiqc4jiNLwoY(__typeref (IUserGroup)), SecurityCacheListener.PRlP8xsyBM00xYMFQMj(-404268492 ^ -404289202));
              // ISSUE: method reference
              Expression<Func<IUserGroup, string>> prop4 = Expression.Lambda<Func<IUserGroup, string>>((Expression) SecurityCacheListener.a9EQRospta7Th5WUwyr((object) parameterExpression4, (object) (MethodInfo) SecurityCacheListener.bU8I88sBJCpwrEoVnkT(__methodref (IUserGroup.get_GroupsHash))), parameterExpression4);
              Pair<long[], long[]> changedIds4 = this.GetChangedIds<IUserGroup>((AbstractPostDatabaseOperationEvent) event4, prop4);
              this.RaiseUpdateCache(group, changedIds2, changedIds3, changedIds4);
              num2 = 2;
              continue;
            case 13:
              user3 = (EleWise.ELMA.Security.Models.IUser) null;
              break;
            case 15:
              this.RaiseOldUpdateCache();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef == 0 ? 0 : 0;
              continue;
            case 16:
              if (userGroup == null)
              {
                num2 = 4;
                continue;
              }
              goto case 12;
            case 17:
              userGroup = SecurityCacheListener.EBTYnisG25t71Ee8TGE((object) @event) as IUserGroup;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0 ? 13 : 16;
              continue;
            default:
              goto label_3;
          }
          user1 = user3;
          num2 = 8;
        }
label_16:
        int num3 = Array.IndexOf<string>((string[]) SecurityCacheListener.KIZVdEsYceGRR1q0E7U((object) @event.Persister), (string) SecurityCacheListener.PRlP8xsyBM00xYMFQMj(-1440374117 ^ -1440372909));
        goto label_29;
label_28:
        num3 = -1;
label_29:
        index = num3;
        num1 = 11;
      }
label_10:
      return;
label_3:
      return;
label_9:;
    }

    public override void OnPostDelete(PostDeleteEvent @event)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          IUserGroup entity;
          IOrganizationItem organizationItem1;
          int index;
          EleWise.ELMA.Security.Models.IUser user1;
          EleWise.ELMA.Security.Models.IUser user2;
          switch (num2)
          {
            case 1:
              organizationItem1 = SecurityCacheListener.EBTYnisG25t71Ee8TGE((object) @event) as IOrganizationItem;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 0 : 0;
              continue;
            case 2:
              index = Array.IndexOf<string>((string[]) SecurityCacheListener.KIZVdEsYceGRR1q0E7U(SecurityCacheListener.dKq2hcs9wn43xcK4NGY((object) @event)), (string) SecurityCacheListener.PRlP8xsyBM00xYMFQMj(~-272519830 ^ 272521053));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0 ? 5 : 0;
              continue;
            case 3:
              IOrganizationItem organizationItem2 = organizationItem1;
              PostDeleteEvent event1 = @event;
              // ISSUE: type reference
              ParameterExpression parameterExpression1 = (ParameterExpression) SecurityCacheListener.dkWZ2qshRODMgeDqNQX(SecurityCacheListener.MlTFKrsMiqc4jiNLwoY(__typeref (IOrganizationItem)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-169284490 ^ -169295882));
              // ISSUE: method reference
              Expression<Func<IOrganizationItem, string>> prop1 = Expression.Lambda<Func<IOrganizationItem, string>>((Expression) SecurityCacheListener.a9EQRospta7Th5WUwyr((object) parameterExpression1, (object) (MethodInfo) SecurityCacheListener.bU8I88sBJCpwrEoVnkT(__methodref (IOrganizationItem.get_UsersHash))), parameterExpression1);
              Pair<long[], long[]> changedIds1 = this.GetChangedIds<IOrganizationItem>((AbstractPostDatabaseOperationEvent) event1, prop1);
              EleWise.ELMA.Security.Models.IUser oldUser = user1;
              this.RaiseUpdateCache(organizationItem2, changedIds1, oldUser, (EleWise.ELMA.Security.Models.IUser) null);
              num2 = 9;
              continue;
            case 4:
              this.RaiseOldUpdateCache();
              num2 = 11;
              continue;
            case 5:
              if (index >= 0)
              {
                num2 = 14;
                continue;
              }
              goto case 13;
            case 6:
              if (!(SecurityCacheListener.EBTYnisG25t71Ee8TGE((object) @event) is IUserGroup))
              {
                num2 = 10;
                continue;
              }
              goto case 4;
            case 7:
              if (entity != null)
              {
                num2 = 12;
                continue;
              }
              goto case 1;
            case 8:
              entity = @event.Entity as IUserGroup;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 == 0 ? 7 : 3;
              continue;
            case 9:
              if (!(SecurityCacheListener.EBTYnisG25t71Ee8TGE((object) @event) is EleWise.ELMA.Security.Models.IUser))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 4 : 6;
                continue;
              }
              goto case 4;
            case 10:
              if (SecurityCacheListener.EBTYnisG25t71Ee8TGE((object) @event) is IOrganizationItem)
                goto case 4;
              else
                goto label_4;
            case 11:
              goto label_17;
            case 12:
              IUserGroup group = entity;
              PostDeleteEvent event2 = @event;
              // ISSUE: type reference
              ParameterExpression parameterExpression2 = (ParameterExpression) SecurityCacheListener.dkWZ2qshRODMgeDqNQX(SecurityCacheListener.MlTFKrsMiqc4jiNLwoY(__typeref (IUserGroup)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1687460816 ^ 1687472298));
              // ISSUE: method reference
              Expression<Func<IUserGroup, string>> prop2 = Expression.Lambda<Func<IUserGroup, string>>((Expression) SecurityCacheListener.a9EQRospta7Th5WUwyr((object) parameterExpression2, (object) (MethodInfo) SecurityCacheListener.bU8I88sBJCpwrEoVnkT(__methodref (IUserGroup.get_UsersHash))), parameterExpression2);
              Pair<long[], long[]> changedIds2 = this.GetChangedIds<IUserGroup>((AbstractPostDatabaseOperationEvent) event2, prop2);
              PostDeleteEvent event3 = @event;
              // ISSUE: type reference
              ParameterExpression parameterExpression3 = (ParameterExpression) SecurityCacheListener.dkWZ2qshRODMgeDqNQX(SecurityCacheListener.MlTFKrsMiqc4jiNLwoY(__typeref (IUserGroup)), SecurityCacheListener.PRlP8xsyBM00xYMFQMj(2016571091 >> 5 ^ 63029260));
              // ISSUE: method reference
              Expression<Func<IUserGroup, string>> prop3 = Expression.Lambda<Func<IUserGroup, string>>((Expression) SecurityCacheListener.a9EQRospta7Th5WUwyr((object) parameterExpression3, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IUserGroup.get_OrganizationItemsHash))), parameterExpression3);
              Pair<long[], long[]> changedIds3 = this.GetChangedIds<IUserGroup>((AbstractPostDatabaseOperationEvent) event3, prop3);
              PostDeleteEvent event4 = @event;
              // ISSUE: type reference
              ParameterExpression parameterExpression4 = (ParameterExpression) SecurityCacheListener.dkWZ2qshRODMgeDqNQX(SecurityCacheListener.MlTFKrsMiqc4jiNLwoY(__typeref (IUserGroup)), SecurityCacheListener.PRlP8xsyBM00xYMFQMj(-1028265253 << 4 ^ 727645898));
              // ISSUE: method reference
              Expression<Func<IUserGroup, string>> prop4 = Expression.Lambda<Func<IUserGroup, string>>((Expression) SecurityCacheListener.a9EQRospta7Th5WUwyr((object) parameterExpression4, (object) (MethodInfo) SecurityCacheListener.bU8I88sBJCpwrEoVnkT(__methodref (IUserGroup.get_GroupsHash))), parameterExpression4);
              Pair<long[], long[]> changedIds4 = this.GetChangedIds<IUserGroup>((AbstractPostDatabaseOperationEvent) event4, prop4);
              this.RaiseUpdateCache(group, changedIds2, changedIds3, changedIds4);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 0 : 1;
              continue;
            case 13:
              user2 = (EleWise.ELMA.Security.Models.IUser) null;
              break;
            case 14:
              user2 = (EleWise.ELMA.Security.Models.IUser) SecurityCacheListener.OP81wgsFXnSVH8YtTWA((object) @event)[index];
              break;
            case 15:
              goto label_10;
            default:
              if (organizationItem1 == null)
                goto case 9;
              else
                goto label_8;
          }
          user1 = user2;
          num2 = 3;
        }
label_4:
        num1 = 15;
        continue;
label_8:
        num1 = 2;
      }
label_17:
      return;
label_10:;
    }

    public override void OnPostUpdateCollection(PostCollectionUpdateEvent @event)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        EleWise.ELMA.Security.Models.IUser entity1;
        IUserGroup affectedOwnerOrNull;
        IOrganizationItem organizationItem;
        while (true)
        {
          switch (num2)
          {
            case 1:
              entity1 = SecurityCacheListener.VUXEHvsfNDXKmZhN9ep((object) @event) as EleWise.ELMA.Security.Models.IUser;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 0 : 0;
              continue;
            case 2:
              object obj1 = SecurityCacheListener.Rw9lrasP1gQC8qorhUM(SecurityCacheListener.DSa67VsEVILtvCFE52k((object) @event.Session), SecurityCacheListener.Id2ktSsc1kLaxoMGVgm((object) @event));
              if (((string) SecurityCacheListener.z8iotOs80fKVT5GZ20b(obj1)).EndsWith((string) SecurityCacheListener.PRlP8xsyBM00xYMFQMj(-880091293 >> 4 ^ -54984978)))
              {
                this.Process<EleWise.ELMA.Security.Models.IUser, IOrganizationItem>(entity1, (Func<EleWise.ELMA.Security.Models.IUser, ISet<IOrganizationItem>>) (u => u.OrganizationItems), (Action<EleWise.ELMA.Security.Models.IUser, string>) ((u, v) =>
                {
                  int num3 = 1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        SecurityCacheListener.\u003C\u003Ec.Xm0bmUwapQhFOkisF29d((object) u, (object) v);
                        num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                }));
                SecurityCacheListener.TYIBdPsVUt6iERNSw3E((object) entity1);
              }
              if (SecurityCacheListener.F4pSJss5pWpRCs0jjkO(SecurityCacheListener.z8iotOs80fKVT5GZ20b(obj1), SecurityCacheListener.PRlP8xsyBM00xYMFQMj(2086891181 ^ 2086878701)))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 18 : 11;
                continue;
              }
              goto label_14;
            case 3:
              if (affectedOwnerOrNull == null)
              {
                num2 = 12;
                continue;
              }
              goto case 5;
            case 4:
              IUserGroup entity2 = affectedOwnerOrNull;
              // ISSUE: reference to a compiler-generated field
              Func<IUserGroup, ISet<IUserGroup>> func1 = SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__16_10;
              Func<IUserGroup, ISet<IUserGroup>> collectionAccessor1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__16_10 = collectionAccessor1 = (Func<IUserGroup, ISet<IUserGroup>>) (u => u.Groups);
              }
              else
                goto label_48;
label_43:
              // ISSUE: reference to a compiler-generated field
              Action<IUserGroup, string> action1 = SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__16_11;
              Action<IUserGroup, string> hashSetter1;
              if (action1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__16_11 = hashSetter1 = (Action<IUserGroup, string>) ((u, v) =>
                {
                  int num4 = 1;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        u.GroupsHash = v;
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                });
              }
              else
                goto label_47;
label_46:
              this.Process<IUserGroup, IUserGroup>(entity2, collectionAccessor1, hashSetter1);
              num2 = 13;
              continue;
label_47:
              hashSetter1 = action1;
              goto label_46;
label_48:
              collectionAccessor1 = func1;
              goto label_43;
            case 5:
              object obj2 = SecurityCacheListener.Rw9lrasP1gQC8qorhUM(SecurityCacheListener.DSa67VsEVILtvCFE52k(SecurityCacheListener.AATN1hs4ij6SxNwYKFY((object) @event)), SecurityCacheListener.Id2ktSsc1kLaxoMGVgm((object) @event));
              if (((string) SecurityCacheListener.z8iotOs80fKVT5GZ20b(obj2)).EndsWith((string) SecurityCacheListener.PRlP8xsyBM00xYMFQMj(1940240517 ^ 974551502 ^ 1236505171)))
              {
                IUserGroup entity3 = affectedOwnerOrNull;
                // ISSUE: reference to a compiler-generated field
                Func<IUserGroup, ISet<IOrganizationItem>> func2 = SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__16_6;
                Func<IUserGroup, ISet<IOrganizationItem>> collectionAccessor2;
                if (func2 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__16_6 = collectionAccessor2 = (Func<IUserGroup, ISet<IOrganizationItem>>) (u => u.OrganizationItems);
                }
                else
                  goto label_51;
label_30:
                this.Process<IUserGroup, IOrganizationItem>(entity3, collectionAccessor2, (Action<IUserGroup, string>) ((u, v) =>
                {
                  int num5 = 1;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        SecurityCacheListener.\u003C\u003Ec.o801FswaMjVi9kbi5Dry((object) u, (object) v);
                        num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                }));
                SecurityCacheListener.TYIBdPsVUt6iERNSw3E((object) affectedOwnerOrNull);
                goto label_31;
label_51:
                collectionAccessor2 = func2;
                goto label_30;
              }
label_31:
              if (SecurityCacheListener.F4pSJss5pWpRCs0jjkO((object) ((CollectionEntry) obj2).Role, SecurityCacheListener.PRlP8xsyBM00xYMFQMj(213026252 ^ 213046950)))
              {
                IUserGroup entity4 = affectedOwnerOrNull;
                // ISSUE: reference to a compiler-generated field
                Func<IUserGroup, ISet<EleWise.ELMA.Security.Models.IUser>> func3 = SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__16_8;
                Func<IUserGroup, ISet<EleWise.ELMA.Security.Models.IUser>> collectionAccessor3;
                if (func3 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__16_8 = collectionAccessor3 = (Func<IUserGroup, ISet<EleWise.ELMA.Security.Models.IUser>>) (u => u.Users);
                }
                else
                  goto label_50;
label_34:
                // ISSUE: reference to a compiler-generated field
                Action<IUserGroup, string> action2 = SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__16_9;
                Action<IUserGroup, string> hashSetter2;
                if (action2 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__16_9 = hashSetter2 = (Action<IUserGroup, string>) ((u, v) =>
                  {
                    int num6 = 1;
                    while (true)
                    {
                      switch (num6)
                      {
                        case 0:
                          goto label_2;
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          SecurityCacheListener.\u003C\u003Ec.KGrkPUwahGBEo4VhgVTa((object) u, (object) v);
                          num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef == 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_4;
                      }
                    }
label_2:
                    return;
label_4:;
                  });
                }
                else
                  goto label_49;
label_37:
                this.Process<IUserGroup, EleWise.ELMA.Security.Models.IUser>(entity4, collectionAccessor3, hashSetter2);
                SecurityCacheListener.TYIBdPsVUt6iERNSw3E((object) affectedOwnerOrNull);
                goto label_38;
label_49:
                hashSetter2 = action2;
                goto label_37;
label_50:
                collectionAccessor3 = func3;
                goto label_34;
              }
label_38:
              if (!SecurityCacheListener.F4pSJss5pWpRCs0jjkO(SecurityCacheListener.z8iotOs80fKVT5GZ20b(obj2), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-624171910 - 757669187 ^ -1381854031)))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f == 0 ? 16 : 13;
                continue;
              }
              goto case 4;
            case 6:
              SecurityCacheListener.TYIBdPsVUt6iERNSw3E((object) organizationItem);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af != 0 ? 8 : 3;
              continue;
            case 7:
              if (organizationItem == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 2 : 17;
                continue;
              }
              goto case 15;
            case 8:
            case 17:
              affectedOwnerOrNull = @event.AffectedOwnerOrNull as IUserGroup;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 == 0 ? 3 : 2;
              continue;
            case 9:
            case 10:
              goto label_14;
            case 11:
              IOrganizationItem entity5 = organizationItem;
              // ISSUE: reference to a compiler-generated field
              Func<IOrganizationItem, ISet<EleWise.ELMA.Security.Models.IUser>> func4 = SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__16_4;
              Func<IOrganizationItem, ISet<EleWise.ELMA.Security.Models.IUser>> collectionAccessor4;
              if (func4 == null)
              {
                // ISSUE: reference to a compiler-generated field
                SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__16_4 = collectionAccessor4 = (Func<IOrganizationItem, ISet<EleWise.ELMA.Security.Models.IUser>>) (u => u.Users);
              }
              else
                goto label_52;
label_26:
              this.Process<IOrganizationItem, EleWise.ELMA.Security.Models.IUser>(entity5, collectionAccessor4, (Action<IOrganizationItem, string>) ((u, v) =>
              {
                int num7 = 1;
                while (true)
                {
                  switch (num7)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      u.UsersHash = v;
                      num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = 6;
              continue;
label_52:
              collectionAccessor4 = func4;
              goto label_26;
            case 12:
              goto label_44;
            case 13:
              SecurityCacheListener.TYIBdPsVUt6iERNSw3E((object) affectedOwnerOrNull);
              num2 = 14;
              continue;
            case 14:
              goto label_41;
            case 15:
              if (SecurityCacheListener.F4pSJss5pWpRCs0jjkO((object) ((CollectionEntry) SecurityCacheListener.Rw9lrasP1gQC8qorhUM(SecurityCacheListener.DSa67VsEVILtvCFE52k(SecurityCacheListener.AATN1hs4ij6SxNwYKFY((object) @event)), SecurityCacheListener.Id2ktSsc1kLaxoMGVgm((object) @event))).Role, SecurityCacheListener.PRlP8xsyBM00xYMFQMj(1658561670 << 4 ^ 767171338)))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 == 0 ? 11 : 6;
                continue;
              }
              goto case 8;
            case 16:
              goto label_35;
            case 18:
              EleWise.ELMA.Security.Models.IUser entity6 = entity1;
              // ISSUE: reference to a compiler-generated field
              Func<EleWise.ELMA.Security.Models.IUser, ISet<IOrganizationItem>> func5 = SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__16_2;
              Func<EleWise.ELMA.Security.Models.IUser, ISet<IOrganizationItem>> collectionAccessor5;
              if (func5 == null)
              {
                // ISSUE: reference to a compiler-generated field
                SecurityCacheListener.\u003C\u003Ec.\u003C\u003E9__16_2 = collectionAccessor5 = (Func<EleWise.ELMA.Security.Models.IUser, ISet<IOrganizationItem>>) (u => u.OrganizationGroups);
              }
              else
                goto label_53;
label_23:
              this.Process<EleWise.ELMA.Security.Models.IUser, IOrganizationItem>(entity6, collectionAccessor5, (Action<EleWise.ELMA.Security.Models.IUser, string>) ((u, v) =>
              {
                int num8 = 1;
                while (true)
                {
                  switch (num8)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      SecurityCacheListener.\u003C\u003Ec.x4WQNswaO183mAEKIMPd((object) u, (object) v);
                      num8 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = 19;
              continue;
label_53:
              collectionAccessor5 = func5;
              goto label_23;
            case 19:
              SecurityCacheListener.TYIBdPsVUt6iERNSw3E((object) entity1);
              num2 = 10;
              continue;
            default:
              if (entity1 == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 == 0 ? 9 : 5;
                continue;
              }
              goto case 2;
          }
        }
label_14:
        organizationItem = SecurityCacheListener.VUXEHvsfNDXKmZhN9ep((object) @event) as IOrganizationItem;
        num1 = 7;
      }
label_44:
      return;
label_41:
      return;
label_35:;
    }

    private Pair<long[], long[]> GetChangedIds<T>(
      AbstractPostDatabaseOperationEvent @event,
      Expression<Func<T, string>> prop)
    {
      switch (@event)
      {
        case PostInsertEvent _:
          return this.GetChangedIds(@event.Persister.PropertyNames, (object[]) null, ((PostInsertEvent) @event).State, LinqUtils.NameOf<T, string>(prop));
        case PostDeleteEvent _:
          return this.GetChangedIds(@event.Persister.PropertyNames, ((PostDeleteEvent) @event).DeletedState, (object[]) null, LinqUtils.NameOf<T, string>(prop));
        default:
          return this.GetChangedIds(@event.Persister.PropertyNames, ((PostUpdateEvent) @event).OldState, ((PostUpdateEvent) @event).State, LinqUtils.NameOf<T, string>(prop));
      }
    }

    private Pair<long[], long[]> GetChangedIds(
      string[] propertyNames,
      object[] oldState,
      object[] state,
      string propName)
    {
      int index = Array.IndexOf<string>(propertyNames, propName);
      if (index < 0)
        return (Pair<long[], long[]>) null;
      List<long> longList1;
      if (oldState == null || oldState[index] == null)
      {
        longList1 = new List<long>();
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        longList1 = ((IEnumerable<string>) ((string) oldState[index]).Split(new string[1]
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1958138283 - -279956781 ^ -1678186866)
        }, StringSplitOptions.RemoveEmptyEntries)).Select<string, long>((Func<string, long>) (s => SecurityCacheListener.\u003C\u003Ec.bPXCcbwaFe1sx8pjcZxm(SecurityCacheListener.\u003C\u003Ec.DKaT76waTxIgGqR7n4ha((object) s)))).ToList<long>();
      }
      List<long> oldValues = longList1;
      List<long> longList2;
      if (state == null || state[index] == null)
      {
        longList2 = new List<long>();
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        longList2 = ((IEnumerable<string>) ((string) state[index]).Split(new string[1]
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-979995965 << 4 ^ 1499935036)
        }, StringSplitOptions.RemoveEmptyEntries)).Select<string, long>((Func<string, long>) (s => SecurityCacheListener.\u003C\u003Ec.bPXCcbwaFe1sx8pjcZxm(SecurityCacheListener.\u003C\u003Ec.DKaT76waTxIgGqR7n4ha((object) s)))).ToList<long>();
      }
      List<long> newValues = longList2;
      return new Pair<long[], long[]>(newValues.Where<long>((Func<long, bool>) (v => !oldValues.Contains(v))).ToArray<long>(), oldValues.Where<long>((Func<long, bool>) (v => !newValues.Contains(v))).ToArray<long>());
    }

    private void RaiseOldUpdateCache()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            SecurityCacheListener.EPE5OOsv9YA4GJ2CyOI((object) this.contextBoundVariableService, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1245871191 - 2145700088 ^ -899817273), (object) SecurityCacheListener.UpdateFlag.True);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private void RaiseUpdateCache()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.contextBoundVariableService.Set((string) SecurityCacheListener.PRlP8xsyBM00xYMFQMj(~248518394 ^ -248529657), (object) SecurityCacheListener.UpdateFlag.True);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            SecurityCacheListener.XYQ96rsqf9CXfK3DVEx((object) this.contextBoundVariableService, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1640694811 << 2 ^ 2027142128));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    private void RaiseUpdateCache(EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 3;
      Dictionary<EleWise.ELMA.Security.Models.IUser, byte> orAdd;
      while (true)
      {
        switch (num)
        {
          case 1:
            orAdd[user] = (byte) 0;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 == 0 ? 0 : 0;
            continue;
          case 2:
            orAdd = this.contextBoundVariableService.GetOrAdd<Dictionary<EleWise.ELMA.Security.Models.IUser, byte>>((string) SecurityCacheListener.PRlP8xsyBM00xYMFQMj(334323849 << 5 ^ 2108442100), (Func<Dictionary<EleWise.ELMA.Security.Models.IUser, byte>>) (() => new Dictionary<EleWise.ELMA.Security.Models.IUser, byte>()));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d == 0 ? 0 : 1;
            continue;
          case 3:
            if (!SecurityCacheListener.jQEI96sgJsWCT0o5PlI((object) this.contextBoundVariableService.GetOrAdd<SecurityCacheListener.UpdateFlag>((string) SecurityCacheListener.PRlP8xsyBM00xYMFQMj(-816108091 ^ -816088633), (Func<SecurityCacheListener.UpdateFlag>) (() => SecurityCacheListener.UpdateFlag.False))))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 != 0 ? 2 : 0;
              continue;
            }
            goto label_8;
          case 4:
            goto label_2;
          default:
            SecurityCacheListener.EPE5OOsv9YA4GJ2CyOI((object) this.contextBoundVariableService, SecurityCacheListener.PRlP8xsyBM00xYMFQMj(-1310136491 - -570921450 ^ -739234325), (object) orAdd);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 == 0 ? 0 : 4;
            continue;
        }
      }
label_2:
      return;
label_8:;
    }

    private void RaiseUpdateCache(
      IUserGroup group,
      Pair<long[], long[]> userChanges,
      Pair<long[], long[]> orgItemsChanges,
      Pair<long[], long[]> groupsChanges)
    {
      if (this.contextBoundVariableService.GetOrAdd<SecurityCacheListener.UpdateFlag>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1841261835 ^ 1841248521), (Func<SecurityCacheListener.UpdateFlag>) (() => SecurityCacheListener.UpdateFlag.False)).Enabled || (userChanges.First == null || userChanges.First.Length == 0) && (userChanges.Second == null || userChanges.Second.Length == 0) && (orgItemsChanges.First == null || orgItemsChanges.First.Length == 0) && (orgItemsChanges.Second == null || orgItemsChanges.Second.Length == 0) && (groupsChanges.First == null || groupsChanges.First.Length == 0) && (groupsChanges.Second == null || groupsChanges.Second.Length == 0))
        return;
      Dictionary<IUserGroup, GroupUpdate> orAdd = this.contextBoundVariableService.GetOrAdd<Dictionary<IUserGroup, GroupUpdate>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(841533798 << 6 ^ -1976431132), (Func<Dictionary<IUserGroup, GroupUpdate>>) (() => new Dictionary<IUserGroup, GroupUpdate>()));
      GroupUpdate groupUpdate = orAdd.ContainsKey(group) ? orAdd[group] : new GroupUpdate();
      this.UpdateLists(ref groupUpdate.AddUsers, ref groupUpdate.RemoveUsers, userChanges);
      this.UpdateLists(ref groupUpdate.AddOrganizationItems, ref groupUpdate.RemoveOrganizationItems, orgItemsChanges);
      this.UpdateLists(ref groupUpdate.AddGroups, ref groupUpdate.RemoveGroups, groupsChanges);
      orAdd[group] = groupUpdate;
      this.contextBoundVariableService.Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(617710536 ^ 617732012), (object) orAdd);
    }

    private void RaiseUpdateCache(
      IOrganizationItem organizationItem,
      Pair<long[], long[]> userChanges,
      EleWise.ELMA.Security.Models.IUser oldUser,
      EleWise.ELMA.Security.Models.IUser newUser)
    {
      if (this.contextBoundVariableService.GetOrAdd<SecurityCacheListener.UpdateFlag>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1007654939 ^ 1007668249), (Func<SecurityCacheListener.UpdateFlag>) (() => SecurityCacheListener.UpdateFlag.False)).Enabled)
        return;
      if (oldUser != newUser)
      {
        if (oldUser != null)
          userChanges.Second = new long[1]{ oldUser.Id };
        if (newUser != null)
          userChanges.First = new long[1]{ newUser.Id };
      }
      if ((userChanges.First == null || userChanges.First.Length == 0) && (userChanges.Second == null || userChanges.Second.Length == 0))
        return;
      Dictionary<IOrganizationItem, OrganizationItemUpdate> orAdd = this.contextBoundVariableService.GetOrAdd<Dictionary<IOrganizationItem, OrganizationItemUpdate>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(552500104 ^ 552480458), (Func<Dictionary<IOrganizationItem, OrganizationItemUpdate>>) (() => new Dictionary<IOrganizationItem, OrganizationItemUpdate>()));
      OrganizationItemUpdate organizationItemUpdate = orAdd.ContainsKey(organizationItem) ? orAdd[organizationItem] : new OrganizationItemUpdate();
      this.UpdateLists(ref organizationItemUpdate.AddUsers, ref organizationItemUpdate.RemoveUsers, userChanges);
      orAdd[organizationItem] = organizationItemUpdate;
      this.contextBoundVariableService.Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17837901 ^ -17857039), (object) orAdd);
    }

    private void UpdateLists(
      ref long[] addList,
      ref long[] removeList,
      Pair<long[], long[]> changes)
    {
      long[] add = addList ?? new long[0];
      long[] remove = removeList ?? new long[0];
      addList = ((IEnumerable<long>) add).Where<long>((Func<long, bool>) (i => !((IEnumerable<long>) changes.Second).Contains<long>(i))).Concat<long>(((IEnumerable<long>) changes.First).Where<long>((Func<long, bool>) (i =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (((IEnumerable<long>) remove).Contains<long>(i))
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return !((IEnumerable<long>) add).Contains<long>(i);
label_5:
        return false;
      }))).ToArray<long>();
      removeList = ((IEnumerable<long>) remove).Where<long>((Func<long, bool>) (i => !((IEnumerable<long>) changes.First).Contains<long>(i))).Concat<long>(((IEnumerable<long>) changes.Second).Where<long>((Func<long, bool>) (i =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (((IEnumerable<long>) remove).Contains<long>(i))
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return !((IEnumerable<long>) add).Contains<long>(i);
label_5:
        return false;
      }))).ToArray<long>();
    }

    private void Process<EntityT, CollectionEntryT>(
      EntityT entity,
      Func<EntityT, ISet<CollectionEntryT>> collectionAccessor,
      Action<EntityT, string> hashSetter)
      where EntityT : IEntity
      where CollectionEntryT : IEntity
    {
      if (!NHibernateUtil.IsInitialized((object) entity))
        return;
      ISet<CollectionEntryT> collection = collectionAccessor(entity);
      if (!collection.IsInitialized<CollectionEntryT>())
        return;
      this.HashSet<EntityT, CollectionEntryT>(entity, (IEnumerable<CollectionEntryT>) collection, hashSetter);
    }

    private void ProcessAdd<EntityT, CollectionEntryT>(
      EntityT entity,
      CollectionEntryT add,
      Func<EntityT, ISet<CollectionEntryT>> collectionAccessor,
      Action<EntityT, string> hashSetter)
      where EntityT : IEntity
      where CollectionEntryT : IEntity
    {
      if (!NHibernateUtil.IsInitialized((object) entity))
        return;
      ISet<CollectionEntryT> set = collectionAccessor(entity);
      if (!set.IsInitialized<CollectionEntryT>())
        return;
      this.HashSet<EntityT, CollectionEntryT>(entity, set.Concat<CollectionEntryT>((IEnumerable<CollectionEntryT>) new CollectionEntryT[1]
      {
        add
      }), hashSetter);
    }

    private void ProcessRemove<EntityT, CollectionEntryT>(
      EntityT entity,
      CollectionEntryT remove,
      Func<EntityT, ISet<CollectionEntryT>> collectionAccessor,
      Action<EntityT, string> hashSetter)
      where EntityT : IEntity
      where CollectionEntryT : IEntity
    {
      if (!NHibernateUtil.IsInitialized((object) entity))
        return;
      ISet<CollectionEntryT> set = collectionAccessor(entity);
      if (!set.IsInitialized<CollectionEntryT>())
        return;
      this.HashSet<EntityT, CollectionEntryT>(entity, set.Where<CollectionEntryT>((Func<CollectionEntryT, bool>) (i => !i.GetId().Equals(remove.GetId()))), hashSetter);
    }

    private void HashSet<EntityT, CollectionEntryT>(
      EntityT entity,
      IEnumerable<CollectionEntryT> collection,
      Action<EntityT, string> hashSetter)
      where EntityT : IEntity
      where CollectionEntryT : IEntity
    {
      hashSetter(entity, string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1567399832 << 6 ^ 1529342508), collection.Select<CollectionEntryT, object>((Func<CollectionEntryT, object>) (i => i.GetId())).Distinct<object>((Func<object, object, bool>) ((o, o1) => o.Equals(o1))).OrderBy<object, object>((Func<object, object>) (id => id)).ToArray<object>()));
    }

    internal static object k9hrZFs0o1MnDI2wOfe() => (object) ComponentManager.Current;

    internal static object r4IACXsZQDwSiK56fnJ([In] object obj0) => (object) ((ComponentManager) obj0).ModuleManager;

    internal static Guid WFbnknsAMd0XsQj1e21() => __AssemblyInfo.UID;

    internal static object ue6o8Tssb68Ir0j51Cy([In] object obj0, [In] Guid obj1) => (object) ((IModuleManager) obj0).FindUnitByUid(obj1);

    internal static object NXfUR3s7VvU68lAq8ju([In] object obj0) => (object) ((ILicensedModuleAssembly) obj0).LicenseUnit;

    internal static bool BDRWNosj1KbPZSS4Tm5() => SecurityCacheListener.gm57DGs3lnIKfgfQJ55 == null;

    internal static SecurityCacheListener gg5imqsNmfCihqbUaKe() => SecurityCacheListener.gm57DGs3lnIKfgfQJ55;

    internal static object hXHVjWsWRSVLtgwHbJY([In] object obj0) => ((AbstractPreDatabaseOperationEvent) obj0).Entity;

    internal static bool avG9DjsrRVV1eEVLfPb([In] object obj0, [In] object obj1) => __nonvirtual (((EntityEventsListener) obj0).OnPreInsert((PreInsertEvent) obj1));

    internal static object HHE7u9sS6kXNaYRiuLq([In] object obj0) => (object) ((PreUpdateEvent) obj0).OldState;

    internal static object KIZVdEsYceGRR1q0E7U([In] object obj0) => (object) ((IEntityPersister) obj0).PropertyNames;

    internal static object PRlP8xsyBM00xYMFQMj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void TYIBdPsVUt6iERNSw3E([In] object obj0) => ((IEntity) obj0).Save();

    internal static bool VsBNBCsloGYNAP90dD1([In] object obj0, [In] object obj1) => __nonvirtual (((EntityEventsListener) obj0).OnPreUpdate((PreUpdateEvent) obj1));

    internal static object VUXEHvsfNDXKmZhN9ep([In] object obj0) => ((AbstractCollectionEvent) obj0).AffectedOwnerOrNull;

    internal static object AATN1hs4ij6SxNwYKFY([In] object obj0) => (object) ((AbstractEvent) obj0).Session;

    internal static object Id2ktSsc1kLaxoMGVgm([In] object obj0) => (object) ((AbstractCollectionEvent) obj0).Collection;

    internal static object Rw9lrasP1gQC8qorhUM([In] object obj0, [In] object obj1) => (object) ((IPersistenceContext) obj0).GetCollectionEntry((IPersistentCollection) obj1);

    internal static object GTapcYsQoVaMst82VPo([In] object obj0) => ((CollectionEntry) obj0).Snapshot;

    internal static object z8iotOs80fKVT5GZ20b([In] object obj0) => (object) ((CollectionEntry) obj0).Role;

    internal static bool F4pSJss5pWpRCs0jjkO([In] object obj0, [In] object obj1) => ((string) obj0).EndsWith((string) obj1);

    internal static void VKTBevsdqpY87S46iq0([In] object obj0, [In] object obj1) => ((IOrganizationItem) obj0).User = (EleWise.ELMA.Security.Models.IUser) obj1;

    internal static object DSa67VsEVILtvCFE52k([In] object obj0) => (object) ((ISessionImplementor) obj0).PersistenceContext;

    internal static object EBTYnisG25t71Ee8TGE([In] object obj0) => ((AbstractPostDatabaseOperationEvent) obj0).Entity;

    internal static UserStatus YkL6UysXcLBsjaL1XxL([In] object obj0) => ((EleWise.ELMA.Security.Models.IUser) obj0).Status;

    internal static object dKq2hcs9wn43xcK4NGY([In] object obj0) => (object) ((AbstractPostDatabaseOperationEvent) obj0).Persister;

    internal static object sOx7lYs1dfTpY5AbVup([In] object obj0) => (object) ((PostInsertEvent) obj0).State;

    internal static Type MlTFKrsMiqc4jiNLwoY([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object dkWZ2qshRODMgeDqNQX([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object bU8I88sBJCpwrEoVnkT([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object a9EQRospta7Th5WUwyr([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object d33WDdsOJ6CG9Lwijrb([In] object obj0) => (object) ((PostUpdateEvent) obj0).OldState;

    internal static object T2GA0OsT5btCjHoOpe3([In] object obj0) => (object) ((IOrganizationItem) obj0).User;

    internal static object OP81wgsFXnSVH8YtTWA([In] object obj0) => (object) ((PostDeleteEvent) obj0).DeletedState;

    internal static void EPE5OOsv9YA4GJ2CyOI([In] object obj0, [In] object obj1, [In] object obj2) => ((IAbstractBoundVariableService) obj0).Set((string) obj1, obj2);

    internal static void XYQ96rsqf9CXfK3DVEx([In] object obj0, [In] object obj1) => ((IAbstractBoundVariableService) obj0).Remove((string) obj1);

    internal static bool jQEI96sgJsWCT0o5PlI([In] object obj0) => ((SecurityCacheListener.UpdateFlag) obj0).Enabled;

    internal class UpdateFlag
    {
      public static readonly SecurityCacheListener.UpdateFlag True;
      public static readonly SecurityCacheListener.UpdateFlag False;
      private static SecurityCacheListener.UpdateFlag uncUunwa8ayxq8HbNRdE;

      public UpdateFlag(bool enabled)
      {
        SecurityCacheListener.UpdateFlag.CrT5uBwaEx55LhqgFoVD();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.Enabled = enabled;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 != 0 ? 0 : 1;
              continue;
          }
        }
label_3:;
      }

      public bool Enabled
      {
        get => this.\u003CEnabled\u003Ek__BackingField;
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
                this.\u003CEnabled\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 0 : 0;
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

      static UpdateFlag()
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              SecurityCacheListener.UpdateFlag.False = new SecurityCacheListener.UpdateFlag(false);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 0 : 0;
              continue;
            case 2:
              SecurityCacheListener.UpdateFlag.True = new SecurityCacheListener.UpdateFlag(true);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af != 0 ? 0 : 1;
              continue;
            case 3:
              SecurityCacheListener.UpdateFlag.CrT5uBwaEx55LhqgFoVD();
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

      internal static void CrT5uBwaEx55LhqgFoVD() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

      internal static bool fUsfa5wa5uNSjXXyMAwk() => SecurityCacheListener.UpdateFlag.uncUunwa8ayxq8HbNRdE == null;

      internal static SecurityCacheListener.UpdateFlag GPE13QwadiaR5vyyFBJ3() => SecurityCacheListener.UpdateFlag.uncUunwa8ayxq8HbNRdE;
    }
  }
}
