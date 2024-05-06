// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.ViewPermissionManagerBehavior
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  [Component(Order = 1)]
  internal class ViewPermissionManagerBehavior : EntityManagerBehavior
  {
    private readonly ISecurityService securityService;
    private readonly IAuthenticationService authenticationService;
    internal static ViewPermissionManagerBehavior HLkGYIaw14uF4nGaAJ0;

    public RunWithElevatedPrivilegiesService RunWithElevatedPrivilegiesService
    {
      get => this.\u003CRunWithElevatedPrivilegiesService\u003Ek__BackingField;
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
              this.\u003CRunWithElevatedPrivilegiesService\u003Ek__BackingField = value;
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

    public ViewPermissionManagerBehavior(
      ISecurityService securityService,
      IAuthenticationService authenticationService)
    {
      ViewPermissionManagerBehavior.YJ07QlaUcqkThbqUMgf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.securityService = securityService;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.authenticationService = authenticationService;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    public override void OnLoad(object target)
    {
      int num1 = 16;
      Type type;
      string message;
      object obj1;
      IEntityManager entityManager;
      while (true)
      {
        int num2 = num1;
        EntityMetadata entityMetadata;
        string str;
        EleWise.ELMA.Security.Models.IUser user;
        while (true)
        {
          IEntity entity;
          object obj2;
          object obj3;
          switch (num2)
          {
            case 1:
              if (entityManager != null)
              {
                num2 = 4;
                continue;
              }
              goto label_7;
            case 2:
              obj2 = ViewPermissionManagerBehavior.MKKK4Wa6xqnq9jMSaGq((object) entity);
              break;
            case 3:
              goto label_23;
            case 4:
              goto label_38;
            case 5:
              goto label_5;
            case 6:
              goto label_7;
            case 7:
              goto label_19;
            case 8:
              entityManager = (IEntityManager) ViewPermissionManagerBehavior.TlPDvhaxDSo98TGESEN(type);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 == 0 ? 1 : 1;
              continue;
            case 9:
              if (ViewPermissionManagerBehavior.PMYf5YaoujAapvERys3((object) this.securityService, (object) CommonPermissions.View, target))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af != 0 ? 14 : 14;
                continue;
              }
              goto label_12;
            case 10:
              if (entityMetadata != null)
              {
                obj3 = ViewPermissionManagerBehavior.DsB0w2aaXJuXijRDgGg((object) entityMetadata);
                goto label_37;
              }
              else
                goto label_18;
            case 11:
              if (entity != null)
              {
                num2 = 2;
                continue;
              }
              goto case 18;
            case 12:
              goto label_14;
            case 13:
              entity = target as IEntity;
              num2 = 11;
              continue;
            case 14:
              user = (EleWise.ELMA.Security.Models.IUser) ViewPermissionManagerBehavior.tnI5qvatXC3syQkyV4s((object) this.authenticationService);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0 ? 0 : 0;
              continue;
            case 15:
              goto label_21;
            case 16:
              if (ViewPermissionManagerBehavior.vBgiSUaRhw65gQD7pei())
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 == 0 ? 13 : 15;
                continue;
              }
              if (!this.RunWithElevatedPrivilegiesService.Turned)
              {
                if (target != null)
                {
                  num2 = 9;
                  continue;
                }
                goto label_11;
              }
              else
              {
                num2 = 3;
                continue;
              }
            case 17:
              obj3 = (object) type.FullName;
              goto label_37;
            case 18:
              obj2 = ViewPermissionManagerBehavior.rBseGdamEPvh2SaRywU(-29763048 >> 5 ^ -946580);
              break;
            case 19:
              goto label_8;
            default:
              goto label_27;
          }
          obj1 = obj2;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af == 0 ? 15 : 19;
          continue;
label_37:
          str = (string) obj3;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 == 0 ? 2 : 7;
        }
label_5:
        entityMetadata = ViewPermissionManagerBehavior.EjSnapaDUWSw3EWXLjB(type, false, false) as EntityMetadata;
        num1 = 10;
        continue;
label_8:
        type = ViewPermissionManagerBehavior.hkVv9wakO0xBCCcsAOR(target);
        num1 = 5;
        continue;
label_18:
        num1 = 17;
        continue;
label_19:
        message = EleWise.ELMA.SR.T((string) ViewPermissionManagerBehavior.rBseGdamEPvh2SaRywU(1762575989 ^ 1762559673), (object) str, obj1);
        num1 = 8;
        continue;
label_27:
        if (!this.securityService.HasPermission((IUser) user, CommonPermissions.View, target))
          num1 = 13;
        else
          goto label_29;
      }
label_23:
      return;
label_14:
      return;
label_21:
      return;
label_7:
      object obj4 = (object) new EntitySecurityException(message);
      ((EntitySecurityException) obj4).EntityId = Convert.ToInt64(obj1);
      ViewPermissionManagerBehavior.uyAWKHaiVT9LTsFU0Li(obj4, ViewPermissionManagerBehavior.fHKTdlaCjfYKPaFI7vG(type, true));
      ViewPermissionManagerBehavior.dVK8YHaj6fEX2YD4HkX(obj4, ViewPermissionManagerBehavior.W7U05ma3oynXoNbcXxK((object) CommonPermissions.View));
      goto label_39;
label_12:
      return;
label_11:
      return;
label_29:
      return;
label_38:
      obj4 = ViewPermissionManagerBehavior.BlfivQaNhSRhy8KrGnH((object) entityManager, (object) message, obj1);
label_39:
      throw obj4;
    }

    internal static bool owC3nnabU9sCpej4xFN() => ViewPermissionManagerBehavior.HLkGYIaw14uF4nGaAJ0 == null;

    internal static ViewPermissionManagerBehavior OheuSfaKJaIslvxoSfO() => ViewPermissionManagerBehavior.HLkGYIaw14uF4nGaAJ0;

    internal static void YJ07QlaUcqkThbqUMgf() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool vBgiSUaRhw65gQD7pei() => SecurityService.DisableSecurityBySettings;

    internal static bool PMYf5YaoujAapvERys3([In] object obj0, [In] object obj1, [In] object obj2) => ((ISecurityService) obj0).CanCheckPermission((Permission) obj1, obj2);

    internal static object tnI5qvatXC3syQkyV4s([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static object rBseGdamEPvh2SaRywU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object MKKK4Wa6xqnq9jMSaGq([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static Type hkVv9wakO0xBCCcsAOR([In] object obj0) => EntityHelper.GetType(obj0);

    internal static object EjSnapaDUWSw3EWXLjB([In] Type obj0, [In] bool obj1, [In] bool obj2) => (object) MetadataLoader.LoadMetadata(obj0, obj1, obj2);

    internal static object DsB0w2aaXJuXijRDgGg([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object TlPDvhaxDSo98TGESEN([In] Type obj0) => (object) EntityHelper.GetEntityManager(obj0);

    internal static Guid fHKTdlaCjfYKPaFI7vG([In] Type obj0, [In] bool obj1) => InterfaceActivator.UID(obj0, obj1);

    internal static void uyAWKHaiVT9LTsFU0Li([In] object obj0, [In] Guid obj1) => ((EntitySecurityException) obj0).TypeUid = obj1;

    internal static Guid W7U05ma3oynXoNbcXxK([In] object obj0) => ((Permission) obj0).Id;

    internal static void dVK8YHaj6fEX2YD4HkX([In] object obj0, [In] Guid obj1) => ((EntitySecurityException) obj0).PermissionId = obj1;

    internal static object BlfivQaNhSRhy8KrGnH([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IEntityManager) obj0).CreateSecurityException((string) obj1, obj2);
  }
}
