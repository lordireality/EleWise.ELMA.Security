// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Listeners.EntityInstanceDefaultPermissionEventListener
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.NH.Listeners;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Listeners
{
  /// <summary>Выдача прав по умолчанию при создании сущности</summary>
  [Component(Order = -2147483648)]
  internal class EntityInstanceDefaultPermissionEventListener : PostFlushEventListener
  {
    private readonly Func<IEnumerable<IEntityInstanceDefaultPermission>> permissionDefaults;
    private static EntityInstanceDefaultPermissionEventListener UZUWy1ABUFhgskDMxRq;

    /// <summary>Ctor</summary>
    /// <param name="permissionDefaults">Список привилегий по умолчанию для экземпляра объекта</param>
    public EntityInstanceDefaultPermissionEventListener(
      Func<IEnumerable<IEntityInstanceDefaultPermission>> permissionDefaults)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.permissionDefaults = permissionDefaults;
    }

    /// <inheritdoc />
    public override void OnPostInsert(PostInsertEvent @event)
    {
      int num1 = 4;
      IEntity entity;
      List<IEntityInstanceDefaultPermission>.Enumerator enumerator;
      while (true)
      {
        int num2 = num1;
        Type type;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_4;
            case 1:
              if (entity != null)
              {
                type = EntityInstanceDefaultPermissionEventListener.qYoxa7ATRweUIsRidCW((object) entity);
                num2 = 6;
                continue;
              }
              goto label_7;
            case 2:
              goto label_10;
            case 3:
              entity = @event.Entity as IEntity;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0 ? 1 : 0;
              continue;
            case 4:
              num2 = 3;
              continue;
            case 5:
              goto label_21;
            case 6:
              // ISSUE: reference to a compiler-generated method
              enumerator = this.permissionDefaults().Where<IEntityInstanceDefaultPermission>((Func<IEntityInstanceDefaultPermission, bool>) (e => EntityInstanceDefaultPermissionEventListener.\u003C\u003Ec__DisplayClass2_0.PWArnhwaQDROcgiN5RME(type, e.EntityType))).ToList<IEntityInstanceDefaultPermission>().GetEnumerator();
              num2 = 2;
              continue;
            default:
              goto label_17;
          }
        }
label_7:
        num1 = 5;
      }
label_4:
      return;
label_21:
      return;
label_17:
      return;
label_10:
      try
      {
label_13:
        if (enumerator.MoveNext())
          goto label_15;
        else
          goto label_14;
label_11:
        int num3;
        switch (num3)
        {
          case 0:
            return;
          case 1:
            goto label_13;
          case 2:
            goto label_15;
          default:
            return;
        }
label_14:
        num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 != 0 ? 0 : 0;
        goto label_11;
label_15:
        EntityInstanceDefaultPermissionEventListener.NEBgOyAFEgkjrym6Isb((object) enumerator.Current, (object) entity);
        num3 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0)
        {
          num3 = 1;
          goto label_11;
        }
        else
          goto label_11;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 == 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
    }

    internal static Type qYoxa7ATRweUIsRidCW([In] object obj0) => EntityHelper.GetType(obj0);

    internal static void NEBgOyAFEgkjrym6Isb([In] object obj0, [In] object obj1) => ((IEntityInstanceDefaultPermission) obj0).CreatePermissions((IEntity) obj1);

    internal static bool YTvVGQAp8jPixKHi7bE() => EntityInstanceDefaultPermissionEventListener.UZUWy1ABUFhgskDMxRq == null;

    internal static EntityInstanceDefaultPermissionEventListener LXZZSHAOKFfFiYLunWJ() => EntityInstanceDefaultPermissionEventListener.UZUWy1ABUFhgskDMxRq;
  }
}
