// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.InstanceExpressionPermissionManagerBehavior
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  [Component(Order = 10)]
  public class InstanceExpressionPermissionManagerBehavior : EntityManagerBehavior
  {
    private readonly IEnumerable<IInstanceExpressionPermission> instanceExpressionPermissions;
    private readonly IPermissionManagmentService permissionManagmentService;
    private readonly IAuthenticationService authenticationService;
    private readonly ISecurityService securityService;
    internal static InstanceExpressionPermissionManagerBehavior ybMXB8m5yewYXEI8daJ;

    public InstanceExpressionPermissionManagerBehavior(
      IEnumerable<IInstanceExpressionPermission> instanceExpressionPermissions,
      IPermissionManagmentService permissionManagmentService,
      IAuthenticationService authenticationService,
      ISecurityService securityService)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.instanceExpressionPermissions = instanceExpressionPermissions;
      this.permissionManagmentService = permissionManagmentService;
      this.authenticationService = authenticationService;
      this.securityService = securityService;
    }

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
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 == 0 ? 0 : 0;
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

    public override void OnCreateCriteria(ICriteria criteria, IEntityFilter filter)
    {
      int num1 = 14;
      while (true)
      {
        Permission permission;
        Guid? permissionId;
        object obj;
        System.Type criteriaRootType;
        ICriteria criteria1;
        ITransformationProvider transform;
        EleWise.ELMA.Security.Models.IUser user;
        switch (num1)
        {
          case 1:
            permissionId = filter.PermissionId;
            num1 = 7;
            continue;
          case 2:
            transform = Locator.GetServiceNotNull<ITransformationProvider>();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 7 : 16;
            continue;
          case 3:
            user = this.authenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
            num1 = 17;
            continue;
          case 4:
            if (!filter.DisableSecurity)
            {
              num1 = 5;
              continue;
            }
            goto label_34;
          case 5:
            if (!InstanceExpressionPermissionManagerBehavior.iMQXZHmGVme60XSowJ9((object) this.RunWithElevatedPrivilegiesService))
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 != 0 ? 6 : 11;
              continue;
            }
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 18 : 10;
            continue;
          case 6:
            if (!(permission == (Permission) null))
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 3 : 3;
              continue;
            }
            goto label_16;
          case 7:
            if (!permissionId.HasValue)
            {
              num1 = 15;
              continue;
            }
            IPermissionManagmentService managmentService = this.permissionManagmentService;
            permissionId = filter.PermissionId;
            Guid guid = permissionId.Value;
            obj = InstanceExpressionPermissionManagerBehavior.m4bEIfm19c6GyCKrmUn((object) managmentService, guid);
            break;
          case 8:
            goto label_21;
          case 9:
            goto label_5;
          case 10:
            goto label_7;
          case 11:
            try
            {
              criteriaRootType = InstanceExpressionPermissionManagerBehavior.dMmbfkmX0nyMTPJjKjI((object) criteria1);
              int num2 = 0;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 != 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_18;
              }
            }
            catch (HibernateException ex)
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0)
                num3 = 0;
              switch (num3)
              {
                case 0:
                  return;
                default:
                  return;
              }
            }
          case 12:
label_18:
            if (filter != null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 1 : 1;
              continue;
            }
            goto case 15;
          case 13:
            criteria1 = criteria;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 == 0 ? 0 : 0;
            continue;
          case 14:
            num1 = 13;
            continue;
          case 15:
            obj = InstanceExpressionPermissionManagerBehavior.LFus4Pm9S5nrEnerUn5((object) this.permissionManagmentService, (object) CommonPermissions.View, criteriaRootType);
            break;
          case 16:
            IEnumerable<IInstanceExpressionPermission> source = this.instanceExpressionPermissions.Where<IInstanceExpressionPermission>((Func<IInstanceExpressionPermission, bool>) (p =>
            {
              int num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (!InstanceExpressionPermissionManagerBehavior.\u003C\u003Ec__DisplayClass9_0.BAacTGwmBiVhn6WZRS3R(criteriaRootType, InstanceExpressionPermissionManagerBehavior.\u003C\u003Ec__DisplayClass9_0.RxEnrUwmhFGr8dCYnyNp((object) p)))
                    {
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_4;
                  case 2:
                    goto label_4;
                  default:
                    goto label_5;
                }
              }
label_4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return !InstanceExpressionPermissionManagerBehavior.\u003C\u003Ec__DisplayClass9_0.ASFIEtwmOh7snlZcwU0u(InstanceExpressionPermissionManagerBehavior.\u003C\u003Ec__DisplayClass9_0.QA7Wi2wmpg2axAWatEon((object) p));
label_5:
              return false;
            }));
            // ISSUE: reference to a compiler-generated field
            Func<IInstanceExpressionPermission, string> func = InstanceExpressionPermissionManagerBehavior.\u003C\u003Ec.\u003C\u003E9__9_1;
            Func<IInstanceExpressionPermission, string> keySelector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              InstanceExpressionPermissionManagerBehavior.\u003C\u003Ec.\u003C\u003E9__9_1 = keySelector = (Func<IInstanceExpressionPermission, string>) (p => (string) InstanceExpressionPermissionManagerBehavior.\u003C\u003Ec.ErOmFqwmgUODVM8WFmd5((object) p));
            }
            else
              goto label_47;
label_46:
            source.GroupBy<IInstanceExpressionPermission, string>(keySelector).ForEach<IGrouping<string, IInstanceExpressionPermission>>((Action<IGrouping<string, IInstanceExpressionPermission>>) (p => criteria1.Add((ICriterion) Expression.Sql(string.Format(p.First<IInstanceExpressionPermission>().PermissionType.IsInheritOrSame<ISecurityExpressionSetIdHolder>() ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(2047763786 ^ 1536686658 ^ 563654284) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(911364681 ^ 911441183), (object) transform.NoLockTableExpression(p.Key, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1489118656 ^ 643054122 ^ -2123772066)), (object) transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1677147940 ^ 1677146864)), (object) transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1224834736 ^ 1224756520))), new object[1]
            {
              (object) user.Id
            }, new IType[1]{ (IType) NHibernateUtil.Int64 }))));
            num1 = 20;
            continue;
label_47:
            keySelector = func;
            goto label_46;
          case 17:
            if (user != null)
            {
              if (!this.HasAdminPermissions(permission, user))
              {
                num1 = 2;
                continue;
              }
              goto label_40;
            }
            else
            {
              num1 = 10;
              continue;
            }
          case 18:
            goto label_44;
          case 19:
            goto label_17;
          case 20:
            goto label_10;
          default:
            if (filter != null)
            {
              num1 = 4;
              continue;
            }
            goto case 5;
        }
        permission = (Permission) obj;
        num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 6 : 3;
      }
label_21:
      return;
label_5:
      return;
label_44:
      return;
label_17:
      return;
label_10:
      return;
label_34:
      return;
label_7:
      throw new InvalidOperationException((string) InstanceExpressionPermissionManagerBehavior.NNJMg4mhKnXAYGkZ15R(InstanceExpressionPermissionManagerBehavior.bQmqKOmMI8QmoXfDwH2(~-1362653258 ^ 1362648429)));
label_40:
      return;
label_16:;
    }

    private bool HasAdminPermissions(Permission permission, EleWise.ELMA.Security.Models.IUser user)
    {
      int num1 = 3;
      IEnumerator<Permission> enumerator;
      while (true)
      {
        int num2 = num1;
        Permission[] permissionArray;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 5:
              goto label_3;
            case 2:
              if (permissionArray == null)
              {
                num2 = 5;
                continue;
              }
              break;
            case 3:
              goto label_5;
            case 4:
              goto label_6;
          }
          Permission[] source = permissionArray;
          // ISSUE: reference to a compiler-generated field
          Func<Permission, bool> func = InstanceExpressionPermissionManagerBehavior.\u003C\u003Ec.\u003C\u003E9__10_0;
          Func<Permission, bool> predicate;
          if (func == null)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            InstanceExpressionPermissionManagerBehavior.\u003C\u003Ec.\u003C\u003E9__10_0 = predicate = (Func<Permission, bool>) (p => InstanceExpressionPermissionManagerBehavior.\u003C\u003Ec.VlwZZGwmJyFS3hwlJ1EX((object) p) == PermissionType.Global);
          }
          else
            goto label_18;
label_26:
          enumerator = ((IEnumerable<Permission>) source).Where<Permission>(predicate).GetEnumerator();
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 4 : 2;
          continue;
label_18:
          predicate = func;
          goto label_26;
        }
label_5:
        permissionArray = (Permission[]) InstanceExpressionPermissionManagerBehavior.LVAj62mBXUsDoDdOw3e((object) permission);
        num1 = 2;
      }
label_3:
      return false;
label_6:
      bool flag;
      try
      {
label_10:
        if (InstanceExpressionPermissionManagerBehavior.LjQWBmmOfdNxZ4twwbS((object) enumerator))
          goto label_8;
        else
          goto label_11;
label_7:
        Permission current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              flag = true;
              num3 = 4;
              continue;
            case 2:
              goto label_8;
            case 3:
              goto label_3;
            case 4:
              goto label_4;
            case 5:
              if (InstanceExpressionPermissionManagerBehavior.DuHGXHmpIApaCOQuZ8O((object) this.securityService, (object) user, (object) current))
              {
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 != 0 ? 0 : 1;
                continue;
              }
              goto label_10;
            default:
              goto label_10;
          }
        }
label_8:
        current = enumerator.Current;
        num3 = 5;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0)
        {
          num3 = 5;
          goto label_7;
        }
        else
          goto label_7;
label_11:
        num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c == 0 ? 0 : 3;
        goto label_7;
      }
      finally
      {
        int num4;
        if (enumerator == null)
          num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 0 : 0;
        else
          goto label_19;
label_17:
        switch (num4)
        {
          case 2:
            break;
          default:
        }
label_19:
        enumerator.Dispose();
        num4 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0)
        {
          num4 = 1;
          goto label_17;
        }
        else
          goto label_17;
      }
label_4:
      return flag;
    }

    internal static bool zhbR5FmdhkyOqtocwGD() => InstanceExpressionPermissionManagerBehavior.ybMXB8m5yewYXEI8daJ == null;

    internal static InstanceExpressionPermissionManagerBehavior BZXyXKmE9P4KYJJ4mRZ() => InstanceExpressionPermissionManagerBehavior.ybMXB8m5yewYXEI8daJ;

    internal static bool iMQXZHmGVme60XSowJ9([In] object obj0) => ((RunWithElevatedPrivilegiesService) obj0).Turned;

    internal static System.Type dMmbfkmX0nyMTPJjKjI([In] object obj0) => ((ICriteria) obj0).GetRootEntityTypeIfAvailable();

    internal static object LFus4Pm9S5nrEnerUn5([In] object obj0, [In] object obj1, [In] System.Type obj2) => (object) ((IPermissionManagmentService) obj0).GetPermissionForBase((Permission) obj1, obj2);

    internal static object m4bEIfm19c6GyCKrmUn([In] object obj0, [In] Guid obj1) => (object) ((IPermissionManagmentService) obj0).GetPermission(obj1);

    internal static object bQmqKOmMI8QmoXfDwH2(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object NNJMg4mhKnXAYGkZ15R([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object LVAj62mBXUsDoDdOw3e([In] object obj0) => (object) ((Permission) obj0).AdminPermissions;

    internal static bool DuHGXHmpIApaCOQuZ8O([In] object obj0, [In] object obj1, [In] object obj2) => ((ISecurityService) obj0).HasPermission((IUser) obj1, (Permission) obj2);

    internal static bool LjQWBmmOfdNxZ4twwbS([In] object obj0) => ((IEnumerator) obj0).MoveNext();
  }
}
