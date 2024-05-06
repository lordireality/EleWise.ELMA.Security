// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Listeners.UserGroupListener
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Listeners
{
  /// <summary>
  /// Класс для прослушивания событий при удалении групп пользователей
  /// </summary>
  public class UserGroupListener : EntityEventsListener
  {
    private static UserGroupListener CpZNZQsz2VAZSLCoC3y;

    /// <summary>Перед удалением группы пользователей</summary>
    /// <param name="event"></param>
    /// <returns></returns>
    public override bool OnPreDelete(PreDeleteEvent @event)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            UserGroupListener.ayARyT7bGvQiislKsAK((object) this, (object) @event);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 != 0 ? 0 : 0;
            continue;
          case 2:
            if (@event.Entity is IUserGroup)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e != 0 ? 1 : 1;
              continue;
            }
            goto label_5;
          default:
            goto label_5;
        }
      }
label_5:
      return false;
    }

    /// <summary>
    /// Метод действий, выполняемых при удалении группы пользователей
    /// </summary>
    /// <param name="event"></param>
    public virtual void DeletePermissions(PreDeleteEvent @event)
    {
    }

    /// <summary>Удаление настроек доступа у объектов</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="event"></param>
    /// <param name="propExpr"></param>
    public void DeletePermission<T>(PreDeleteEvent @event, Expression<Func<T, object>> propExpr)
    {
      ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
      string groupPropName = LinqUtils.NameOf<T>(propExpr);
      EntityMetadata entityMetadata = (EntityMetadata) MetadataLoader.LoadMetadata(typeof (T));
      if (entityMetadata == null)
        return;
      string tableName = entityMetadata.TableName;
      PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Name == groupPropName));
      if (string.IsNullOrWhiteSpace(tableName) || propertyMetadata == null)
        return;
      string fieldName = ((SimpleTypeSettings) propertyMetadata.Settings).FieldName;
      if (string.IsNullOrWhiteSpace(fieldName))
        return;
      object id = ((IIdentified) @event.Entity).GetId();
      serviceNotNull.BulkDelete(tableName, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2047763786 ^ 1536686658 ^ 563727040), (object) serviceNotNull.Dialect.QuoteIfNeeded(fieldName), (object) serviceNotNull.ParameterSeparator), new Dictionary<string, object>()
      {
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1310136491 - -570921450 ^ -739234603),
          id
        }
      });
    }

    public UserGroupListener()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void ayARyT7bGvQiislKsAK([In] object obj0, [In] object obj1) => ((UserGroupListener) obj0).DeletePermissions((PreDeleteEvent) obj1);

    internal static bool v7OjSa7uSw32tiFw2rR() => UserGroupListener.CpZNZQsz2VAZSLCoC3y == null;

    internal static UserGroupListener MaZnbm7wM9CAch75uUu() => UserGroupListener.CpZNZQsz2VAZSLCoC3y;
  }
}
