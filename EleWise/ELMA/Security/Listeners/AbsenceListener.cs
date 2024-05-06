// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Listeners.AbsenceListener
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Listeners
{
  /// <summary>
  /// Listener для сброса кэша при создании, обновлении или удалении "Отсутсвия"
  /// </summary>
  [Component]
  public class AbsenceListener : EntityEventsListener
  {
    private static AbsenceListener HZnQVDZeGwyxbjpi71a;

    public IComplexCacheService ComplexCacheService
    {
      get => this.\u003CComplexCacheService\u003Ek__BackingField;
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
              this.\u003CComplexCacheService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a == 0 ? 0 : 0;
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

    public override void OnPostInsert(PostInsertEvent @event)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.RefreshCache(AbsenceListener.shQy5DZ2ZNT4kGYgprQ((object) @event));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override void OnPostUpdate(PostUpdateEvent @event)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.RefreshCache(AbsenceListener.shQy5DZ2ZNT4kGYgprQ((object) @event));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override void OnPostDelete(PostDeleteEvent @event)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.RefreshCache(@event.Entity);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private void RefreshCache(object entity)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        IAbsence absence;
        EleWise.ELMA.Security.Models.IUser user;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_8;
            case 1:
              goto label_4;
            case 2:
              user = (EleWise.ELMA.Security.Models.IUser) AbsenceListener.iTbYUaZHWXJ5Le7ppID((object) absence);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 3 : 2;
              continue;
            case 3:
              AbsenceListener.H2RptMAwkShB9nwbUB0((object) this.ComplexCacheService, AbsenceListener.YUVG16Au0vmO7cVPIFm(AbsenceListener.FXlX7NZziPb0400trRf(~248518394 ^ -248530869), user.GetId()));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 == 0 ? 1 : 0;
              continue;
            case 4:
              goto label_9;
            case 5:
              absence = entity as IAbsence;
              num2 = 4;
              continue;
            default:
              goto label_11;
          }
        }
label_9:
        if (absence != null)
          num1 = 2;
        else
          goto label_3;
      }
label_8:
      return;
label_4:
      return;
label_11:
      return;
label_3:;
    }

    public AbsenceListener()
    {
      AbsenceListener.xeoLYDAbavntJDDP6f1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool z7MO1SZnjjCRPEvuxuA() => AbsenceListener.HZnQVDZeGwyxbjpi71a == null;

    internal static AbsenceListener REcQjOZLWJl9aIKt8ge() => AbsenceListener.HZnQVDZeGwyxbjpi71a;

    internal static object shQy5DZ2ZNT4kGYgprQ([In] object obj0) => ((AbstractPostDatabaseOperationEvent) obj0).Entity;

    internal static object iTbYUaZHWXJ5Le7ppID([In] object obj0) => (object) ((IAbsence) obj0).User;

    internal static object FXlX7NZziPb0400trRf(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object YUVG16Au0vmO7cVPIFm([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static void H2RptMAwkShB9nwbUB0([In] object obj0, [In] object obj1) => ((IComplexCacheService) obj0).RefreshTimestamp((string) obj1);

    internal static void xeoLYDAbavntJDDP6f1() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
