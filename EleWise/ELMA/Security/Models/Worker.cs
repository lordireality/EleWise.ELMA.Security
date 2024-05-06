// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.Worker
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Security.DTO.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Исполнитель</summary>
  [Serializable]
  public class Worker
  {
    internal static Worker HhXklv5PotblNVHA8qs;

    /// <summary>Ctor</summary>
    public Worker()
    {
      Worker.wjncl655Mrm5MJuKSsq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.WorkerDisplayType = WorkerDisplayType.UserName;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Тип исполнителя</summary>
    public Guid WorkerType
    {
      get => this.\u003CWorkerType\u003Ek__BackingField;
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
              this.\u003CWorkerType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0 ? 0 : 0;
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

    /// <summary>Идентификатор исполнителя</summary>
    [DefaultValue(0)]
    public long WorkerId
    {
      get => this.\u003CWorkerId\u003Ek__BackingField;
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
              this.\u003CWorkerId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b != 0 ? 0 : 0;
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
    /// Уникальный идентификатор исполнителя (если не используется WorkerId)
    /// </summary>
    public Guid WorkerUid
    {
      get => this.\u003CWorkerUid\u003Ek__BackingField;
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
              this.\u003CWorkerUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 == 0 ? 0 : 0;
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

    /// <summary>Тип отображения</summary>
    [DefaultValue(WorkerDisplayType.UserName)]
    public WorkerDisplayType WorkerDisplayType
    {
      get => this.\u003CWorkerDisplayType\u003Ek__BackingField;
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
              this.\u003CWorkerDisplayType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc == 0 ? 0 : 0;
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

    /// <inheritdoc />
    public override bool Equals(object obj)
    {
      int num1 = 5;
      Worker worker;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (this.WorkerId == Worker.bbsL1a5Glbu4jmiNFNF((object) worker))
              {
                num2 = 3;
                continue;
              }
              goto label_13;
            case 2:
              if (this.WorkerUid == Worker.E777475Eq20bjECZkjm((object) worker))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 != 0 ? 1 : 1;
                continue;
              }
              goto label_13;
            case 3:
              goto label_12;
            case 4:
              if (worker != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 == 0 ? 0 : 0;
                continue;
              }
              goto label_13;
            case 5:
              worker = obj as Worker;
              num2 = 4;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        if (this.WorkerType == Worker.Wjd5xu5duJ2nmrYfxos((object) worker))
          num1 = 2;
        else
          goto label_13;
      }
label_12:
      return this.WorkerDisplayType == Worker.dLIdSL5XRL81FcsI4Rb((object) worker);
label_13:
      return false;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
      int num = 1;
      (Guid, long, Guid, WorkerDisplayType) valueTuple;
      while (true)
      {
        switch (num)
        {
          case 1:
            valueTuple = (this.WorkerType, this.WorkerId, this.WorkerUid, this.WorkerDisplayType);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return valueTuple.GetHashCode();
    }

    /// <summary>Получить исполнителя из элемента оргструктуры</summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public static Worker GetFrom(OrganizationItemDTO item)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) item, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-340788466 ^ -340831418));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return new Worker()
      {
        WorkerType = OrganizationItemDTO.MetadataUid,
        WorkerId = item.Id
      };
    }

    /// <summary>Получить исполнителя из группы</summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public static Worker GetFrom(UserGroupDTO item)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Worker.xOG6jU59naORbV2LfVG((object) item, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1076316568 ^ 1076355536));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      Worker from = new Worker();
      Worker.kpVRMa51macKBQUNOmy((object) from, UserGroupDTO.MetadataUid);
      Worker.zTj8KJ5MtsDtNwHXGaE((object) from, item.Id);
      return from;
    }

    /// <summary>Получить исполнителя из свойства</summary>
    /// <param name="prop"></param>
    /// <returns></returns>
    public static Worker GetFrom(IPropertyMetadata prop)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Worker.xOG6jU59naORbV2LfVG((object) prop, Worker.ToeL0s5huVLjrJTbSZw(658384612 ^ 658411184));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      Worker from = new Worker();
      Worker.kpVRMa51macKBQUNOmy((object) from, Worker.Types.Property);
      Worker.FsdRJP5pu8qCjNq2Awh((object) from, Worker.SD90Mp5BvvsPQdTF1Qr((object) prop));
      return from;
    }

    /// <summary>Подготовить список исполнителей для выборки</summary>
    /// <param name="workers">Список исполнителей</param>
    /// <param name="entity">Сущность, в которой содержатся данные для элементов с типом Types.Property</param>
    /// <returns></returns>
    public static List<Worker> PrepareForFilter(List<Worker> workers, IEntity entity)
    {
      List<Worker> result = new List<Worker>();
      if (workers != null)
      {
        foreach (Worker worker in workers)
        {
          Worker w = worker;
          if (w.WorkerType == Worker.Types.Property)
          {
            bool flag = false;
            if (entity != null)
            {
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              PropertyMetadata propertyMetadata = ((ClassMetadata) MetadataLoader.LoadMetadata(entity.CastAsRealType<IEntity>().GetType())).Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => Worker.\u003C\u003Ec__DisplayClass23_0.yE3GJ3wZLWCH9Xq0SKlB(Worker.\u003C\u003Ec__DisplayClass23_0.TbfVbTwZeUmwpRdRuRk4((object) p), Worker.\u003C\u003Ec__DisplayClass23_0.Bfp45PwZnVUlRVrjrUEs((object) w))));
              EntitySettings settings = propertyMetadata != null ? propertyMetadata.Settings as EntitySettings : (EntitySettings) null;
              object propertyValue = propertyMetadata != null ? entity.GetPropertyValue(propertyMetadata.Uid) : (object) null;
              if (propertyMetadata != null && settings != null && propertyValue != null)
              {
                if (propertyMetadata.SubTypeUid == UserDTO.UID || propertyMetadata.SubTypeUid == UserDTO.ImplUID)
                  flag = Worker.AddItems<IUser>(result, propertyValue, (object) settings, UserDTO.UID);
                else if (propertyMetadata.SubTypeUid == UserGroupDTO.MetadataUid || propertyMetadata.SubTypeUid == UserGroupDTO.ImplMetadataUid)
                  flag = Worker.AddItems<IUserGroup>(result, propertyValue, (object) settings, UserGroupDTO.MetadataUid);
                else if (propertyMetadata.SubTypeUid == OrganizationItemDTO.MetadataUid || propertyMetadata.SubTypeUid == OrganizationItemDTO.ImplMetadataUid)
                  flag = Worker.AddItems<IOrganizationItem>(result, propertyValue, (object) settings, OrganizationItemDTO.MetadataUid);
              }
            }
            if (!flag)
              result.Add(w);
          }
          else
            result.Add(w);
        }
      }
      return result;
    }

    private static bool AddItems<T>(
      List<Worker> result,
      object propertyValue,
      object settings,
      Guid workerType)
      where T : class, IEntity<long>
    {
      bool flag = false;
      if (((EntitySettings) settings).RelationType == RelationType.OneToOne)
      {
        if (propertyValue is T obj1)
        {
          result.Add(new Worker()
          {
            WorkerType = workerType,
            WorkerId = obj1.Id
          });
          flag = true;
        }
      }
      else if (propertyValue is IEnumerable source)
      {
        foreach (T obj2 in source.OfType<T>().ToList<T>())
        {
          result.Add(new Worker()
          {
            WorkerType = workerType,
            WorkerId = obj2.Id
          });
          flag = true;
        }
      }
      return flag;
    }

    internal static void wjncl655Mrm5MJuKSsq() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool xiTSN45QieVMt6ftokL() => Worker.HhXklv5PotblNVHA8qs == null;

    internal static Worker Cq5rpE58McF3TFKRRQq() => Worker.HhXklv5PotblNVHA8qs;

    internal static Guid Wjd5xu5duJ2nmrYfxos([In] object obj0) => ((Worker) obj0).WorkerType;

    internal static Guid E777475Eq20bjECZkjm([In] object obj0) => ((Worker) obj0).WorkerUid;

    internal static long bbsL1a5Glbu4jmiNFNF([In] object obj0) => ((Worker) obj0).WorkerId;

    internal static WorkerDisplayType dLIdSL5XRL81FcsI4Rb([In] object obj0) => ((Worker) obj0).WorkerDisplayType;

    internal static void xOG6jU59naORbV2LfVG([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void kpVRMa51macKBQUNOmy([In] object obj0, Guid value) => ((Worker) obj0).WorkerType = value;

    internal static void zTj8KJ5MtsDtNwHXGaE([In] object obj0, long value) => ((Worker) obj0).WorkerId = value;

    internal static object ToeL0s5huVLjrJTbSZw(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Guid SD90Mp5BvvsPQdTF1Qr([In] object obj0) => ((IPropertyMetadata) obj0).PropertyUid;

    internal static void FsdRJP5pu8qCjNq2Awh([In] object obj0, Guid value) => ((Worker) obj0).WorkerUid = value;

    public static class Types
    {
      public static readonly Guid Property;
      internal static Worker.Types s24PFnwZOS356ROak5h5;

      static Types()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              Worker.Types.Property = new Guid((string) Worker.Types.y7d0fJwZvoaSmytPh6vy(617026523 ^ 616965401));
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b == 0 ? 2 : 1;
              continue;
          }
        }
label_2:;
      }

      internal static object y7d0fJwZvoaSmytPh6vy(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool pkXcdWwZTKXpCD5oo3RV() => Worker.Types.s24PFnwZOS356ROak5h5 == null;

      internal static Worker.Types FCZWILwZFxu51gZJjf2e() => Worker.Types.s24PFnwZOS356ROak5h5;
    }
  }
}
