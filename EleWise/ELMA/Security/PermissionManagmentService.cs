// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.PermissionManagmentService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  [Service(EnableInterceptors = true, Scope = ServiceScope.Shell, Type = ComponentType.Server)]
  public class PermissionManagmentService : IPermissionManagmentService, IModuleContainerEvents
  {
    private IEnumerable<IPermissionManagmentServiceExtension> permissionManagmentServiceExtensions;
    private IEnumerable<IPermissionProvider> _permissionProviders;
    private IEnumerable<IModuleAccessPermissionProvider> _moduleAccessPermissionProviders;
    private bool permissionsCheckd;
    internal static PermissionManagmentService W592OwkNY1v3k7uTMeJ;

    /// <summary>Ctor</summary>
    /// <param name="permissionProviders">Интерфейс расширения списка привилегий</param>
    /// <param name="moduleAccessPermissionProviders">Интерфейс провайдера, определяющего привилегии для доступа к модулям</param>
    /// <param name="permissionManagmentServiceExtensions">Точка расширения для IPermissionManagmentService</param>
    public PermissionManagmentService(
      IEnumerable<IPermissionProvider> permissionProviders,
      IEnumerable<IModuleAccessPermissionProvider> moduleAccessPermissionProviders,
      IEnumerable<IPermissionManagmentServiceExtension> permissionManagmentServiceExtensions)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this._permissionProviders = permissionProviders;
      this._moduleAccessPermissionProviders = moduleAccessPermissionProviders;
      this.permissionManagmentServiceExtensions = permissionManagmentServiceExtensions;
    }

    public void Activated() => this.CheckPermissions();

    public void Terminating()
    {
    }

    [ContextCache]
    public virtual IEnumerable<Permission> GetPermissions()
    {
      this.CheckPermissions();
      return this._permissionProviders.SelectMany<IPermissionProvider, Permission>((Func<IPermissionProvider, IEnumerable<Permission>>) (pp => pp.GetPermissions()));
    }

    [ContextCache]
    public virtual Permission GetPermission(Guid permissionId)
    {
      int num = 1;
      Permission permission;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.GetPermissionsById().TryGetValue(permissionId, out permission);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return permission;
    }

    /// <inheritdoc />
    public Permission GetPermissionForBase(Permission permission, Type entityType)
    {
      int num1 = 2;
      Permission permissionForBase;
      while (true)
      {
        int num2 = num1;
        // ISSUE: variable of a compiler-generated type
        PermissionManagmentService.\u003C\u003Ec__DisplayClass6_0 cDisplayClass60;
        // ISSUE: variable of a compiler-generated type
        PermissionManagmentService.\u003C\u003Ec__DisplayClass6_1 cDisplayClass61;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass60.permission = permission;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 != 0 ? 0 : 9;
              continue;
            case 2:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass60 = new PermissionManagmentService.\u003C\u003Ec__DisplayClass6_0();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 1 : 0;
              continue;
            case 3:
              if (PermissionManagmentService.FKfsJIksgNwc4SsTuPJ((object) permissionForBase, (object) null))
              {
                num2 = 7;
                continue;
              }
              goto label_10;
            case 4:
              goto label_18;
            case 5:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass60.entityType = PermissionManagmentService.HLacI1kA0h5jnK9dgDy(cDisplayClass60.entityType);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 12 : 3;
              continue;
            case 6:
            case 13:
              goto label_10;
            case 7:
              // ISSUE: reference to a compiler-generated field
              if (!PermissionManagmentService.vTMNqmk7BWtKFe07iVJ(cDisplayClass60.entityType, (Type) null))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e == 0 ? 2 : 6;
                continue;
              }
              goto case 8;
            case 8:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass61 = new PermissionManagmentService.\u003C\u003Ec__DisplayClass6_1();
              num2 = 10;
              continue;
            case 9:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass60.entityType = entityType;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 5 : 1;
              continue;
            case 10:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass61.CS\u0024\u003C\u003E8__locals1 = cDisplayClass60;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 0 : 0;
              continue;
            case 11:
              goto label_13;
            case 12:
              goto label_8;
            default:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass61.metadata = PermissionManagmentService.z81CeTkWKRkNlZycy4s(cDisplayClass61.CS\u0024\u003C\u003E8__locals1.entityType, true, true) as ClassMetadata;
              num2 = 11;
              continue;
          }
        }
label_8:
        // ISSUE: reference to a compiler-generated method
        permissionForBase = this.GetPermissions().FirstOrDefault<Permission>(new Func<Permission, bool>(cDisplayClass60.\u003CGetPermissionForBase\u003Eb__0));
        num1 = 3;
        continue;
label_13:
        // ISSUE: reference to a compiler-generated field
        if (cDisplayClass61.metadata != null)
        {
          num1 = 4;
          continue;
        }
        break;
label_18:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        permissionForBase = this.permissionManagmentServiceExtensions.Select<IPermissionManagmentServiceExtension, Permission>(new Func<IPermissionManagmentServiceExtension, Permission>(cDisplayClass61.\u003CGetPermissionForBase\u003Eb__1)).Where<Permission>((Func<Permission, bool>) (p => PermissionManagmentService.\u003C\u003Ec.Lwj003w6QnFfMDHDgSKH((object) p, (object) null))).FirstOrDefault<Permission>();
        num1 = 13;
      }
label_10:
      return permissionForBase;
    }

    [ContextCache]
    public virtual Permission GetModuleAccessPermission(string moduleUid)
    {
      int num = 1;
      Permission accessPermission;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.GetModuleAccessPermissionsById().TryGetValue(moduleUid, out accessPermission);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return accessPermission;
    }

    [ContextCache]
    protected virtual Dictionary<Guid, Permission> GetPermissionsById() => this.GetPermissions().ToDictionary<Permission, Guid>((Func<Permission, Guid>) (p => PermissionManagmentService.\u003C\u003Ec.LEYAV6w681V0MyBtfNU9((object) p)));

    [ContextCache]
    protected virtual Dictionary<string, Permission> GetModuleAccessPermissionsById() => this._moduleAccessPermissionProviders.SelectMany<IModuleAccessPermissionProvider, KeyValuePair<string, Permission>>((Func<IModuleAccessPermissionProvider, IEnumerable<KeyValuePair<string, Permission>>>) (pp => (IEnumerable<KeyValuePair<string, Permission>>) pp.GetModuleAccessPermissions())).ToDictionary<KeyValuePair<string, Permission>, string, Permission>((Func<KeyValuePair<string, Permission>, string>) (p => p.Key), (Func<KeyValuePair<string, Permission>, Permission>) (p => p.Value));

    private void CheckPermissions()
    {
      int num1 = 1;
      IGrouping<Guid, \u003C\u003Ef__AnonymousType3<Permission, IPermissionProvider>>[] array1;
      while (true)
      {
        int num2 = num1;
        \u003C\u003Ef__AnonymousType3<Permission, IPermissionProvider>[] array2;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_19;
            case 3:
              str = EleWise.ELMA.SR.T((string) PermissionManagmentService.q3B4DHkS8wUaio62PXQ(-1254421137 >> 4 ^ -78413672));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 == 0 ? 2 : 2;
              continue;
            case 4:
              if (array2.Length == 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 5 : 5;
                continue;
              }
              goto case 3;
            case 5:
              goto label_14;
            case 6:
              IEnumerable<IPermissionProvider> permissionProviders = this._permissionProviders;
              // ISSUE: reference to a compiler-generated field
              Func<IPermissionProvider, IEnumerable<\u003C\u003Ef__AnonymousType3<Permission, IPermissionProvider>>> func = PermissionManagmentService.\u003C\u003Ec.\u003C\u003E9__13_0;
              Func<IPermissionProvider, IEnumerable<\u003C\u003Ef__AnonymousType3<Permission, IPermissionProvider>>> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: object of a compiler-generated type is created
                PermissionManagmentService.\u003C\u003Ec.\u003C\u003E9__13_0 = selector = i => i.GetPermissions().Select(p => new \u003C\u003Ef__AnonymousType3<Permission, IPermissionProvider>(p, i));
              }
              else
                goto label_20;
label_16:
              List<\u003C\u003Ef__AnonymousType3<Permission, IPermissionProvider>> list = permissionProviders.SelectMany(selector).ToList();
              array1 = list.GroupBy(v => v.permission.Id).Where<IGrouping<Guid, \u003C\u003Ef__AnonymousType3<Permission, IPermissionProvider>>>(g => g.Count() > 1).ToArray<IGrouping<Guid, \u003C\u003Ef__AnonymousType3<Permission, IPermissionProvider>>>();
              if (array1.Length == 0)
              {
                ISecurityService securityService = Locator.GetServiceNotNull<ISecurityService>();
                array2 = list.Where(p =>
                {
                  if (!(p.permission.EntityType != (Type) null))
                    return false;
                  if (p.permission.PermissionType == PermissionType.Instance && !securityService.CanCheckPermission(p.permission, InterfaceActivator.Create(p.permission.EntityType)))
                    return true;
                  return p.permission.PermissionType == PermissionType.EntityType && !securityService.CanCheckPermission(p.permission, p.permission.EntityType);
                }).ToArray();
                num2 = 4;
                continue;
              }
              goto label_17;
label_20:
              selector = func;
              goto label_16;
            case 7:
              goto label_11;
            case 8:
              PermissionManagmentService.VO4maDkVedSptkELp4Z(PermissionManagmentService.TjlDZ8kyD7GgsDh92A4(), (object) str);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb == 0 ? 9 : 3;
              continue;
            case 9:
              goto label_3;
            default:
              if (this.permissionsCheckd)
              {
                num2 = 7;
                continue;
              }
              this.permissionsCheckd = true;
              num2 = 6;
              continue;
          }
        }
label_19:
        str = str + (string) PermissionManagmentService.q3B4DHkS8wUaio62PXQ(1780597820 ^ 1780610164) + string.Join((string) PermissionManagmentService.q3B4DHkS8wUaio62PXQ(-1958138283 - -279956781 ^ -1678193718), array2.Select(v => string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1245871191 - 2145700088 ^ -899907355), (object) v.provider, (object) v.permission.Name)));
        num1 = 8;
      }
label_14:
      return;
label_11:
      return;
label_3:
      return;
label_17:
      throw new InvalidOperationException((string) PermissionManagmentService.UJEtTxkYyqPATaYcsZn(PermissionManagmentService.UQt3BVkrGy7vDaLWlfS((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-522456341 ^ -522461895)), PermissionManagmentService.q3B4DHkS8wUaio62PXQ(-1277472395 ^ -1277468355), (object) string.Join((string) PermissionManagmentService.q3B4DHkS8wUaio62PXQ(-1880054609 ^ -1880058649), array1.Select<IGrouping<Guid, \u003C\u003Ef__AnonymousType3<Permission, IPermissionProvider>>, string>(g => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1859356887 ^ -1859304319) + g.Key.ToString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-979995965 << 4 ^ 1499864964) + string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1691384762 ^ -1691383702), g.Select(v => string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1055964645 ^ 1056018015), (object) v.provider, (object) v.permission.Name))) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(908197830 ^ 908161054)))));
    }

    internal static bool EkQwtNk06xVpAsLFJ1o() => PermissionManagmentService.W592OwkNY1v3k7uTMeJ == null;

    internal static PermissionManagmentService rulFrukZPJnegQZOofL() => PermissionManagmentService.W592OwkNY1v3k7uTMeJ;

    internal static Type HLacI1kA0h5jnK9dgDy([In] Type obj0) => InterfaceActivator.TypeOf(obj0);

    internal static bool FKfsJIksgNwc4SsTuPJ([In] object obj0, [In] object obj1) => (Permission) obj0 == (Permission) obj1;

    internal static bool vTMNqmk7BWtKFe07iVJ([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object z81CeTkWKRkNlZycy4s([In] Type obj0, [In] bool obj1, [In] bool obj2) => (object) MetadataLoader.LoadMetadata(obj0, obj1, obj2);

    internal static object UQt3BVkrGy7vDaLWlfS([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object q3B4DHkS8wUaio62PXQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object UJEtTxkYyqPATaYcsZn([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object TjlDZ8kyD7GgsDh92A4() => (object) Logger.Log;

    internal static void VO4maDkVedSptkELp4Z([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);
  }
}
