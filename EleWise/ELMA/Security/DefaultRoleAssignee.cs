// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.DefaultRoleAssignee
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
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

namespace EleWise.ELMA.Security
{
  /// <summary>
  /// Назначение ролей про умолчанию для привилегий
  /// назначениме происходит
  /// 1) в момент инсталляции модуля
  /// 2) в момент запуска приложения при условии что нет ни одной роли с привилегиями
  /// </summary>
  [Component(EnableInterceptiors = true)]
  public class DefaultRoleAssignee : IModuleEvents, IModuleContainerEvents
  {
    private readonly IPermissionManagmentService permissionManagmentService;
    private readonly IEnumerable<IPermissionProvider> permissionProviders;
    private readonly UserGroupManager userGroupManager;
    private readonly GroupPermissionManager groupPermissionManager;
    private readonly IModuleService moduleService;
    private readonly IEntityManager<IAssignedRoleStereotype> assignedRoleStereotypeManager;
    internal static DefaultRoleAssignee m8TMhyULc9ViAf6LgbS;

    /// <summary>Ctor</summary>
    public DefaultRoleAssignee(
      IPermissionManagmentService permissionManagmentService,
      IEnumerable<IPermissionProvider> permissionProviders,
      UserGroupManager userGroupManager,
      GroupPermissionManager groupPermissionManager,
      IModuleService moduleService,
      IEntityManager<IAssignedRoleStereotype> assignedRoleStereotypeManager)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.permissionManagmentService = permissionManagmentService;
      this.permissionProviders = permissionProviders;
      this.userGroupManager = userGroupManager;
      this.groupPermissionManager = groupPermissionManager;
      this.moduleService = moduleService;
      this.assignedRoleStereotypeManager = assignedRoleStereotypeManager;
    }

    /// <summary>Назначить привилегии ролям по умолчанию</summary>
    [Transaction]
    public virtual void AssignDefaultRoles()
    {
      int num1 = 1;
      IEnumerator<PermissionStereotype> enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            IEnumerable<IEnumerable<PermissionStereotype>> source = this.permissionProviders.Select<IPermissionProvider, IEnumerable<PermissionStereotype>>((Func<IPermissionProvider, IEnumerable<PermissionStereotype>>) (pp => pp.GetPermissionStereotypes())).Where<IEnumerable<PermissionStereotype>>((Func<IEnumerable<PermissionStereotype>, bool>) (ps => ps != null));
            // ISSUE: reference to a compiler-generated field
            Func<IEnumerable<PermissionStereotype>, IEnumerable<PermissionStereotype>> func = DefaultRoleAssignee.\u003C\u003Ec.\u003C\u003E9__7_2;
            Func<IEnumerable<PermissionStereotype>, IEnumerable<PermissionStereotype>> selector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              DefaultRoleAssignee.\u003C\u003Ec.\u003C\u003E9__7_2 = selector = (Func<IEnumerable<PermissionStereotype>, IEnumerable<PermissionStereotype>>) (ps => ps);
            }
            else
              goto label_51;
label_50:
            enumerator1 = source.SelectMany<IEnumerable<PermissionStereotype>, PermissionStereotype>(selector).GetEnumerator();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 == 0 ? 0 : 0;
            continue;
label_51:
            selector = func;
            goto label_50;
          case 2:
            goto label_48;
          default:
            goto label_2;
        }
      }
label_48:
      return;
label_2:
      try
      {
label_16:
        if (DefaultRoleAssignee.dViprJR3GfCTy5UYaEg((object) enumerator1))
          goto label_13;
        else
          goto label_17;
label_4:
        // ISSUE: variable of a compiler-generated type
        DefaultRoleAssignee.\u003C\u003Ec__DisplayClass7_0 cDisplayClass70;
        IUserGroup userGroup;
        PermissionStereotype current1;
        IEnumerator<Permission> enumerator2;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.userGroupManager.Save(userGroup);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0 ? 0 : 6;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              userGroup = new InstanceOf<IUserGroup>()
              {
                New = {
                  Name = ((GroupDescriptor) DefaultRoleAssignee.QwncmoRt2wZPImdXYhR((object) cDisplayClass70.stereotype)).Name,
                  Uid = DefaultRoleAssignee.CilfRvRmjlCfUOH3TBT(DefaultRoleAssignee.QwncmoRt2wZPImdXYhR((object) cDisplayClass70.stereotype))
                }
              }.New;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 == 0 ? 0 : 1;
              continue;
            case 3:
              UserGroupManager userGroupManager = this.userGroupManager;
              // ISSUE: type reference
              ParameterExpression parameterExpression1 = Expression.Parameter(DefaultRoleAssignee.zGqF1CUznKFjWIpEjWh(__typeref (IUserGroup)), (string) DefaultRoleAssignee.yPKyoHRu5YxgRl7QsU4(-1212789817 - 1827404527 ^ 1254782948));
              // ISSUE: method reference
              // ISSUE: field reference
              // ISSUE: method reference
              // ISSUE: method reference
              // ISSUE: method reference
              Expression<Func<IUserGroup, bool>> condition1 = Expression.Lambda<Func<IUserGroup, bool>>((Expression) DefaultRoleAssignee.TjOtRkRoxfckOFXZkX3((object) Expression.Property((Expression) parameterExpression1, (MethodInfo) DefaultRoleAssignee.dHTZsYRwQhX9nl4RknB(__methodref (IUserGroup.get_Uid))), DefaultRoleAssignee.SfQdY7RRRhDw1BESiiO(DefaultRoleAssignee.SfQdY7RRRhDw1BESiiO(DefaultRoleAssignee.J3Tm7nRUcKc6MT8BiAa(DefaultRoleAssignee.aU5JZTRb727S92LPx7w((object) cDisplayClass70, typeof (DefaultRoleAssignee.\u003C\u003Ec__DisplayClass7_0)), DefaultRoleAssignee.CH78TsRKUHkVCDyiWqx(__fieldref (DefaultRoleAssignee.\u003C\u003Ec__DisplayClass7_0.stereotype))), (object) (MethodInfo) DefaultRoleAssignee.dHTZsYRwQhX9nl4RknB(__methodref (PermissionStereotype.get_DefaultAssignee))), (object) (MethodInfo) DefaultRoleAssignee.dHTZsYRwQhX9nl4RknB(__methodref (GroupDescriptor.get_Uid))), false, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality))), parameterExpression1);
              userGroup = userGroupManager.Find(condition1).FirstOrDefault<IUserGroup>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 != 0 ? 3 : 5;
              continue;
            case 4:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass70 = new DefaultRoleAssignee.\u003C\u003Ec__DisplayClass7_0();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0 ? 2 : 9;
              continue;
            case 5:
              if (userGroup == null)
              {
                num2 = 2;
                continue;
              }
              goto case 6;
            case 6:
              // ISSUE: reference to a compiler-generated field
              enumerator2 = cDisplayClass70.stereotype.Permissions.GetEnumerator();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 == 0 ? 7 : 8;
              continue;
            case 7:
              goto label_44;
            case 8:
              goto label_18;
            case 9:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass70.stereotype = current1;
              num2 = 11;
              continue;
            case 10:
              goto label_16;
            case 11:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass70.stereotype != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 3 : 2;
                continue;
              }
              goto label_16;
            default:
              goto label_13;
          }
        }
label_44:
        return;
label_18:
        try
        {
label_22:
          if (enumerator2.MoveNext())
            goto label_32;
          else
            goto label_23;
label_20:
          Permission current2;
          int num3;
          while (true)
          {
            int num4;
            // ISSUE: variable of a compiler-generated type
            DefaultRoleAssignee.\u003C\u003Ec__DisplayClass7_1 cDisplayClass71;
            IAssignedRoleStereotype assignedRoleStereotype;
            switch (num3)
            {
              case 1:
                goto label_32;
              case 2:
                assignedRoleStereotype = InterfaceActivator.Create<IAssignedRoleStereotype>();
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 == 0 ? 5 : 2;
                continue;
              case 3:
                // ISSUE: reference to a compiler-generated field
                assignedRoleStereotype.PermissionUid = new Guid?(cDisplayClass71.permissionUid);
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 4 : 4;
                continue;
              case 4:
                this.assignedRoleStereotypeManager.Save(assignedRoleStereotype);
                num4 = 10;
                break;
              case 5:
                // ISSUE: reference to a compiler-generated field
                assignedRoleStereotype.GroupUid = new Guid?(cDisplayClass71.roleUid);
                num3 = 3;
                continue;
              case 6:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass71.permissionUid = DefaultRoleAssignee.W2rkiBR64TdcxxEgu8l((object) current2);
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 0 : 0;
                continue;
              case 7:
                DefaultRoleAssignee.cAhyKURCZA1xdVChGjB((object) this.groupPermissionManager, (object) userGroup, (object) current2);
                num3 = 2;
                continue;
              case 8:
                goto label_16;
              case 9:
                // ISSUE: object of a compiler-generated type is created
                cDisplayClass71 = new DefaultRoleAssignee.\u003C\u003Ec__DisplayClass7_1();
                num4 = 11;
                break;
              case 10:
                goto label_22;
              case 11:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass71.roleUid = userGroup.Uid;
                num4 = 6;
                break;
              default:
                IEntityManager<IAssignedRoleStereotype> stereotypeManager = this.assignedRoleStereotypeManager;
                // ISSUE: type reference
                ParameterExpression parameterExpression2 = (ParameterExpression) DefaultRoleAssignee.LSUypTRkIaJgmU3jEcb(DefaultRoleAssignee.zGqF1CUznKFjWIpEjWh(__typeref (IAssignedRoleStereotype)), DefaultRoleAssignee.yPKyoHRu5YxgRl7QsU4(-979995965 << 4 ^ 1499925364));
                // ISSUE: method reference
                // ISSUE: type reference
                // ISSUE: field reference
                // ISSUE: type reference
                // ISSUE: method reference
                // ISSUE: method reference
                // ISSUE: type reference
                // ISSUE: field reference
                // ISSUE: method reference
                Expression<Func<IAssignedRoleStereotype, bool>> condition2 = Expression.Lambda<Func<IAssignedRoleStereotype, bool>>((Expression) DefaultRoleAssignee.ToBTpfRaQkHRwniyU9R((object) Expression.Equal((Expression) DefaultRoleAssignee.SfQdY7RRRhDw1BESiiO((object) parameterExpression2, (object) (MethodInfo) DefaultRoleAssignee.dHTZsYRwQhX9nl4RknB(__methodref (IAssignedRoleStereotype.get_GroupUid))), (Expression) DefaultRoleAssignee.ohEK3TRDmEt2vZjildN(DefaultRoleAssignee.J3Tm7nRUcKc6MT8BiAa(DefaultRoleAssignee.aU5JZTRb727S92LPx7w((object) cDisplayClass71, DefaultRoleAssignee.zGqF1CUznKFjWIpEjWh(__typeref (DefaultRoleAssignee.\u003C\u003Ec__DisplayClass7_1))), (object) FieldInfo.GetFieldFromHandle(__fieldref (DefaultRoleAssignee.\u003C\u003Ec__DisplayClass7_1.roleUid))), DefaultRoleAssignee.zGqF1CUznKFjWIpEjWh(__typeref (Guid?))), false, (MethodInfo) DefaultRoleAssignee.dHTZsYRwQhX9nl4RknB(__methodref (Guid.op_Equality))), DefaultRoleAssignee.TjOtRkRoxfckOFXZkX3(DefaultRoleAssignee.SfQdY7RRRhDw1BESiiO((object) parameterExpression2, (object) (MethodInfo) DefaultRoleAssignee.dHTZsYRwQhX9nl4RknB(__methodref (IAssignedRoleStereotype.get_PermissionUid))), DefaultRoleAssignee.ohEK3TRDmEt2vZjildN(DefaultRoleAssignee.J3Tm7nRUcKc6MT8BiAa(DefaultRoleAssignee.aU5JZTRb727S92LPx7w((object) cDisplayClass71, DefaultRoleAssignee.zGqF1CUznKFjWIpEjWh(__typeref (DefaultRoleAssignee.\u003C\u003Ec__DisplayClass7_1))), (object) FieldInfo.GetFieldFromHandle(__fieldref (DefaultRoleAssignee.\u003C\u003Ec__DisplayClass7_1.permissionUid))), typeof (Guid?)), false, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), parameterExpression2);
                if (DefaultRoleAssignee.kUuXQ7RxvXOx5DdAtyE((object) stereotypeManager.Find(condition2)) <= 0)
                {
                  num3 = 7;
                  continue;
                }
                goto label_22;
            }
            num3 = num4;
          }
label_23:
          num3 = 8;
          goto label_20;
label_32:
          current2 = enumerator2.Current;
          num3 = 9;
          goto label_20;
        }
        finally
        {
          int num5;
          if (enumerator2 == null)
            num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 0 : 1;
          else
            goto label_37;
label_36:
          switch (num5)
          {
            case 2:
              break;
            default:
          }
label_37:
          DefaultRoleAssignee.wsaB1FRiqtpINThNiSD((object) enumerator2);
          num5 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e != 0)
          {
            num5 = 0;
            goto label_36;
          }
          else
            goto label_36;
        }
label_13:
        current1 = enumerator1.Current;
        num2 = 4;
        goto label_4;
label_17:
        num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 != 0 ? 7 : 2;
        goto label_4;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num6 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 == 0)
            num6 = 0;
          while (true)
          {
            switch (num6)
            {
              case 1:
                goto label_46;
              default:
                DefaultRoleAssignee.wsaB1FRiqtpINThNiSD((object) enumerator1);
                num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_46:;
      }
    }

    public void Activated()
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        SecurityService service;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_7;
            case 1:
              goto label_12;
            case 2:
              if (service == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 != 0 ? 2 : 6;
                continue;
              }
              goto case 5;
            case 3:
              this.AssignDefaultRoles();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 1 : 1;
              continue;
            case 4:
              if (!EleWise.ELMA.SR.GetSetting<bool>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1341618464 ^ -1341612470)))
              {
                num2 = 3;
                continue;
              }
              goto label_6;
            case 5:
              DefaultRoleAssignee.OAdeYiRjPO2YgRta0W1((object) service);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 0 : 0;
              continue;
            case 6:
              goto label_3;
            case 7:
              goto label_9;
            default:
              goto label_14;
          }
        }
label_12:
        service = Locator.GetService<SecurityService>();
        num1 = 2;
      }
label_7:
      return;
label_3:
      return;
label_9:
      return;
label_14:
      return;
label_6:;
    }

    public void Terminating()
    {
    }

    public void Installing(IWebModuleUnit module)
    {
    }

    public void Installed(IWebModuleUnit module) => DefaultRoleAssignee.PUOSvLRN8YHU0qADhmX((object) this);

    public void Enabling(IWebModuleUnit module)
    {
    }

    public void Enabled(IWebModuleUnit module)
    {
    }

    public void Disabling(IWebModuleUnit module)
    {
    }

    public void Disabled(IWebModuleUnit module)
    {
    }

    public void Uninstalling(IWebModuleUnit module)
    {
    }

    public void Uninstalled(IWebModuleUnit module)
    {
    }

    internal static Type zGqF1CUznKFjWIpEjWh([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object yPKyoHRu5YxgRl7QsU4(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object dHTZsYRwQhX9nl4RknB([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object aU5JZTRb727S92LPx7w([In] object obj0, [In] Type obj1) => (object) Expression.Constant(obj0, obj1);

    internal static object CH78TsRKUHkVCDyiWqx([In] RuntimeFieldHandle obj0) => (object) FieldInfo.GetFieldFromHandle(obj0);

    internal static object J3Tm7nRUcKc6MT8BiAa([In] object obj0, [In] object obj1) => (object) Expression.Field((Expression) obj0, (FieldInfo) obj1);

    internal static object SfQdY7RRRhDw1BESiiO([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object TjOtRkRoxfckOFXZkX3([In] object obj0, [In] object obj1, [In] bool obj2, [In] object obj3) => (object) Expression.Equal((Expression) obj0, (Expression) obj1, obj2, (MethodInfo) obj3);

    internal static object QwncmoRt2wZPImdXYhR([In] object obj0) => (object) ((PermissionStereotype) obj0).DefaultAssignee;

    internal static Guid CilfRvRmjlCfUOH3TBT([In] object obj0) => ((GroupDescriptor) obj0).Uid;

    internal static Guid W2rkiBR64TdcxxEgu8l([In] object obj0) => ((Permission) obj0).Id;

    internal static object LSUypTRkIaJgmU3jEcb([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object ohEK3TRDmEt2vZjildN([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);

    internal static object ToBTpfRaQkHRwniyU9R([In] object obj0, [In] object obj1) => (object) Expression.AndAlso((Expression) obj0, (Expression) obj1);

    internal static int kUuXQ7RxvXOx5DdAtyE([In] object obj0) => ((ICollection<IAssignedRoleStereotype>) obj0).Count;

    internal static void cAhyKURCZA1xdVChGjB([In] object obj0, [In] object obj1, [In] object obj2) => ((GroupPermissionManager) obj0).GrantPermission((IUserGroup) obj1, (Permission) obj2);

    internal static void wsaB1FRiqtpINThNiSD([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool dViprJR3GfCTy5UYaEg([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool tVylBkU2UP2TNmOdQgx() => DefaultRoleAssignee.m8TMhyULc9ViAf6LgbS == null;

    internal static DefaultRoleAssignee oPU0t4UHwYwMy7Wd3F8() => DefaultRoleAssignee.m8TMhyULc9ViAf6LgbS;

    internal static void OAdeYiRjPO2YgRta0W1([In] object obj0) => ((SecurityService) obj0).ResetPermissionsCache();

    internal static void PUOSvLRN8YHU0qADhmX([In] object obj0) => ((DefaultRoleAssignee) obj0).AssignDefaultRoles();
  }
}
