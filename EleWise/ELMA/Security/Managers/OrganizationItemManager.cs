// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.OrganizationItemManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Managers
{
  /// <summary>Менеджер элементов оргструктуры</summary>
  [DeveloperApi(DeveloperApiType.Manager)]
  public class OrganizationItemManager : EntityManager<IOrganizationItem, long>
  {
    private IUnionComplexCacheService unionComplexCacheService;
    private static OrganizationItemManager j2GFPhBAeLRE99FFRH3;

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
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.unionComplexCacheService = service = Locator.GetService<IUnionComplexCacheService>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 == 0 ? 2 : 0;
              continue;
          }
        }
label_2:
        return complexCacheService;
label_6:
        return service;
      }
    }

    /// <summary>Провайдер перобразования БД</summary>
    public ITransformationProvider TransformationProvider
    {
      get => this.\u003CTransformationProvider\u003Ek__BackingField;
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
              this.\u003CTransformationProvider\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 != 0 ? 0 : 0;
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

    /// <summary>Экземпляр менеджера</summary>
    public static OrganizationItemManager Instance => Locator.GetServiceNotNull<OrganizationItemManager>();

    /// <summary>
    /// Загружает все элементы оргструктуры c дочерними элементами и пользователями
    /// </summary>
    /// <returns></returns>
    public IOrganizationItem LoadFullTree()
    {
      IQueryOver<IOrganizationItem, IOrganizationItem> queryOver = ((ISession) OrganizationItemManager.KL82ZMBWByg5h3D3HMC((object) this)).QueryOver<IOrganizationItem>();
      ParameterExpression parameterExpression1 = (ParameterExpression) OrganizationItemManager.BJL9uGBSTysHdojiSLA(typeof (IOrganizationItem), OrganizationItemManager.V9bGmhBrYjBx3NXrv2H(-550634672 ^ -550683184));
      // ISSUE: method reference
      System.Linq.Expressions.Expression<Func<IOrganizationItem, object>> path1 = System.Linq.Expressions.Expression.Lambda<Func<IOrganizationItem, object>>((System.Linq.Expressions.Expression) OrganizationItemManager.LFr0a7ByCWbvukNZKL0((object) parameterExpression1, (object) (MethodInfo) OrganizationItemManager.z1K9pNBYl0MMu2w1AKA(__methodref (IOrganizationItem.get_ParentItem))), parameterExpression1);
      IQueryOver<IOrganizationItem, IOrganizationItem> eager = queryOver.Fetch(path1).Eager;
      // ISSUE: type reference
      ParameterExpression parameterExpression2 = System.Linq.Expressions.Expression.Parameter(OrganizationItemManager.I9jvrgBVY9wVG7qpnhB(__typeref (IOrganizationItem)), (string) OrganizationItemManager.V9bGmhBrYjBx3NXrv2H(-1324692970 << 3 ^ -2007591376));
      // ISSUE: method reference
      System.Linq.Expressions.Expression<Func<IOrganizationItem, object>> path2 = System.Linq.Expressions.Expression.Lambda<Func<IOrganizationItem, object>>((System.Linq.Expressions.Expression) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) parameterExpression2, (MethodInfo) OrganizationItemManager.z1K9pNBYl0MMu2w1AKA(__methodref (IOrganizationItem.get_Users))), parameterExpression2);
      return eager.Fetch(path2).Eager.List().FirstOrDefault<IOrganizationItem>((Func<IOrganizationItem, bool>) (i =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (OrganizationItemManager.\u003C\u003Ec.VoIBFcwWc7mQ6qX7EMN0((object) i) == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        return !OrganizationItemManager.\u003C\u003Ec.BUvpN7wWPJy5P8PKAt9W((object) i);
label_3:
        return false;
      }));
    }

    /// <summary>Получить все элементы оргструктуры</summary>
    /// <returns></returns>
    public IEnumerable<IOrganizationItem> LoadFullList() => (IEnumerable<IOrganizationItem>) this.Session.CreateCriteria<IOrganizationItem>().Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(841533798 << 6 ^ -1976384800), (object) false)).List<IOrganizationItem>().ToList<IOrganizationItem>();

    /// <summary>Получение элементов оргструктуры</summary>
    /// <returns>Оргструктура в виде плоского списка</returns>
    [Obsolete("Для загрузки списка оргструктуры используйте LoadFullList()")]
    public IEnumerable<IOrganizationItem> LoadFullRootList() => this.LoadFullList();

    /// <summary>Получение элементов оргструктуры OrganizationItemDTO</summary>
    /// <returns>Оргструктура в виде плоского списка</returns>
    public IEnumerable<OrganizationItemDTO> LoadRootList() => (IEnumerable<OrganizationItemDTO>) this.Session.GetNamedQuery(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1801131332 >> 4 ^ 112555996)).SetResultTransformer((IResultTransformer) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(typeof (OrganizationItemDTO))).CleanUpCache(false).List<OrganizationItemDTO>();

    /// <summary>Загрузка полной оргструктуры</summary>
    /// <returns>Возвращает корневой элемент</returns>
    [Obsolete("Для загрузки корневого элемента использовать LoadOrgStructRoot(). Для плоского списка всей оргструктуры LoadFullRootList()")]
    public virtual IOrganizationItem LoadFullRoot()
    {
      int num = 2;
      IEnumerable<IOrganizationItem> source;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated method
            if (source.Count<IOrganizationItem>((Func<IOrganizationItem, bool>) (i => OrganizationItemManager.\u003C\u003Ec.VoIBFcwWc7mQ6qX7EMN0((object) i) == null)) <= 1)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            source = this.LoadFullList();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_8;
          case 4:
            goto label_2;
          default:
            if (source.Count<IOrganizationItem>() == 0)
            {
              num = 3;
              continue;
            }
            goto label_9;
        }
      }
label_2:
      throw new InvalidOperationException((string) OrganizationItemManager.We6UgvBlg8Dabjq9Ywu(OrganizationItemManager.V9bGmhBrYjBx3NXrv2H(1690209562 ^ 116876444 ^ 1648963360)));
label_8:
      return (IOrganizationItem) null;
label_9:
      // ISSUE: reference to a compiler-generated method
      return source.First<IOrganizationItem>((Func<IOrganizationItem, bool>) (i => OrganizationItemManager.\u003C\u003Ec.VoIBFcwWc7mQ6qX7EMN0((object) i) == null));
    }

    /// <summary>
    /// Загрузка оргструктуры и формирование дерева элементов OrganizationItemDTO
    /// </summary>
    /// <returns>Возвращает корневой элемент</returns>
    public virtual OrganizationItemDTO LoadRoot()
    {
      int num1 = 1;
      OrganizationItemDTO organizationItemDto1;
      IEnumerator<OrganizationItemDTO> enumerator;
      Dictionary<long, OrganizationItemDTO> dictionary;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: type reference
            IList<OrganizationItemDTO> source = ((IQuery) OrganizationItemManager.rAWaMjB4Md24PlPMgP7(OrganizationItemManager.aBlctmBflKaD346IaJ0((object) ((ISession) OrganizationItemManager.KL82ZMBWByg5h3D3HMC((object) this)).GetNamedQuery((string) OrganizationItemManager.V9bGmhBrYjBx3NXrv2H(447286529 ^ 447335305)), (object) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(OrganizationItemManager.I9jvrgBVY9wVG7qpnhB(__typeref (OrganizationItemDTO)))), false)).List<OrganizationItemDTO>();
            // ISSUE: reference to a compiler-generated field
            Func<OrganizationItemDTO, bool> func1 = OrganizationItemManager.\u003C\u003Ec.\u003C\u003E9__13_0;
            Func<OrganizationItemDTO, bool> predicate;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              OrganizationItemManager.\u003C\u003Ec.\u003C\u003E9__13_0 = predicate = (Func<OrganizationItemDTO, bool>) (i => OrganizationItemManager.\u003C\u003Ec.yQgJ3ZwWQ3SAn0K7sU1V((object) i) == 0L);
            }
            else
              goto label_33;
label_24:
            if (source.Count<OrganizationItemDTO>(predicate) <= 1)
            {
              organizationItemDto1 = new OrganizationItemDTO();
              // ISSUE: reference to a compiler-generated field
              Func<OrganizationItemDTO, long> func2 = OrganizationItemManager.\u003C\u003Ec.\u003C\u003E9__13_1;
              Func<OrganizationItemDTO, long> keySelector;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                OrganizationItemManager.\u003C\u003Ec.\u003C\u003E9__13_1 = keySelector = (Func<OrganizationItemDTO, long>) (k => k.Id);
              }
              else
                goto label_32;
label_28:
              // ISSUE: reference to a compiler-generated field
              Func<OrganizationItemDTO, OrganizationItemDTO> func3 = OrganizationItemManager.\u003C\u003Ec.\u003C\u003E9__13_2;
              Func<OrganizationItemDTO, OrganizationItemDTO> elementSelector;
              if (func3 == null)
              {
                // ISSUE: reference to a compiler-generated field
                OrganizationItemManager.\u003C\u003Ec.\u003C\u003E9__13_2 = elementSelector = (Func<OrganizationItemDTO, OrganizationItemDTO>) (v => v);
              }
              else
                goto label_31;
label_30:
              dictionary = source.ToDictionary<OrganizationItemDTO, long, OrganizationItemDTO>(keySelector, elementSelector);
              enumerator = source.GetEnumerator();
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 0 : 0;
              continue;
label_31:
              elementSelector = func3;
              goto label_30;
label_32:
              keySelector = func2;
              goto label_28;
            }
            else
              goto label_25;
label_33:
            predicate = func1;
            goto label_24;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return organizationItemDto1;
label_3:
      try
      {
label_10:
        if (OrganizationItemManager.b3ERUhBPaI190jGORdM((object) enumerator))
          goto label_12;
        else
          goto label_11;
label_5:
        OrganizationItemDTO organizationItemDto2;
        OrganizationItemDTO current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (OrganizationItemManager.qmkcTBBcC1rM0My2mWr((object) current) == 0L)
              {
                num2 = 7;
                continue;
              }
              goto case 3;
            case 2:
              organizationItemDto2.Items.Add(current);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 0 : 0;
              continue;
            case 3:
              if (dictionary.TryGetValue(OrganizationItemManager.qmkcTBBcC1rM0My2mWr((object) current), out organizationItemDto2))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 2 : 1;
                continue;
              }
              goto label_10;
            case 4:
              goto label_2;
            case 6:
              goto label_12;
            case 7:
              organizationItemDto1 = current;
              num2 = 5;
              continue;
            default:
              goto label_10;
          }
        }
label_11:
        num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 2 : 4;
        goto label_5;
label_12:
        current = enumerator.Current;
        num2 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 == 0)
        {
          num2 = 1;
          goto label_5;
        }
        else
          goto label_5;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = 2;
        else
          goto label_19;
label_18:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_19:
        OrganizationItemManager.ktSrquBQ1Cu8kZY0KgE((object) enumerator);
        num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 == 0)
        {
          num3 = 0;
          goto label_18;
        }
        else
          goto label_18;
      }
label_25:
      throw new InvalidOperationException((string) OrganizationItemManager.We6UgvBlg8Dabjq9Ywu(OrganizationItemManager.V9bGmhBrYjBx3NXrv2H(--1207559533 ^ 1207509625)));
    }

    /// <summary>Загрузка корневого элемента оргструктуры</summary>
    /// <returns>Корневой элемент</returns>
    public virtual IOrganizationItem LoadOrgStructRoot()
    {
      ParameterExpression parameterExpression = (ParameterExpression) OrganizationItemManager.BJL9uGBSTysHdojiSLA(typeof (IOrganizationItem), OrganizationItemManager.V9bGmhBrYjBx3NXrv2H(-1115268484 ^ -1115261636));
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      return this.Find(System.Linq.Expressions.Expression.Lambda<Func<IOrganizationItem, bool>>((System.Linq.Expressions.Expression) OrganizationItemManager.dId6FGBdudXyBAEhd3j((object) System.Linq.Expressions.Expression.Equal((System.Linq.Expressions.Expression) OrganizationItemManager.LFr0a7ByCWbvukNZKL0((object) parameterExpression, (object) (MethodInfo) OrganizationItemManager.z1K9pNBYl0MMu2w1AKA(__methodref (IOrganizationItem.get_ParentItem))), (System.Linq.Expressions.Expression) OrganizationItemManager.BNG25TB8cXGmGnc8m43((object) null, OrganizationItemManager.I9jvrgBVY9wVG7qpnhB(__typeref (object)))), OrganizationItemManager.EmuQQxB5cOOBJMuG0TM(OrganizationItemManager.LFr0a7ByCWbvukNZKL0((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IOrganizationItem.get_IsDeleted))), OrganizationItemManager.BNG25TB8cXGmGnc8m43((object) false, typeof (bool)))), parameterExpression)).FirstOrDefault<IOrganizationItem>();
    }

    public virtual ICollection<IOrganizationItem> GetChildDepartments(
      IOrganizationItem parent)
    {
      return this.Find((System.Linq.Expressions.Expression<Func<IOrganizationItem, bool>>) (organizationItem => organizationItem.ParentItem == parent && organizationItem.IsDeleted == false));
    }

    [EleWise.ELMA.Cache.Attributes.Cache]
    public virtual long[] GetTree(IOrganizationItem item)
    {
      int num1 = 8;
      IEnumerator<IOrganizationItem> enumerator;
      List<long> longList;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
          case 4:
          case 6:
            goto label_19;
          case 3:
            longList.Add(item.Id);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 0 : 0;
            continue;
          case 5:
            if (OrganizationItemManager.p74bPUBE5QSGsgpYYUB((object) item))
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 1 : 2;
              continue;
            }
            goto case 3;
          case 7:
            if (item == null)
            {
              num1 = 4;
              continue;
            }
            goto case 5;
          case 8:
            longList = new List<long>();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e == 0 ? 7 : 1;
            continue;
          default:
            enumerator = item.SubItems.GetEnumerator();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:
      try
      {
label_5:
        if (OrganizationItemManager.b3ERUhBPaI190jGORdM((object) enumerator))
          goto label_8;
        else
          goto label_6;
label_4:
        IOrganizationItem current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_5;
            case 3:
              goto label_19;
            default:
              longList.AddRange((IEnumerable<long>) this.GetTree(current));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 2 : 2;
              continue;
          }
        }
label_6:
        num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0 ? 1 : 3;
        goto label_4;
label_8:
        current = enumerator.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 == 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                enumerator.Dispose();
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 == 0 ? 0 : 0;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
label_19:
      return (long[]) OrganizationItemManager.sptYv8BGyxFNYFiy9CG((object) longList);
    }

    /// <summary>
    /// Получить должности, на которых находится сам пользователь и его подчиненные
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    public virtual IEnumerable<long> GetOrgItemIdsByUser(long userId) => this.UnionComplexCacheService.GetOrAdd<IEnumerable<long>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1608980123 ^ -1609027891) + (object) userId, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1207559533 ^ 1207512425), (Func<IEnumerable<long>>) (() =>
    {
      string sql = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1076316568 ^ 1076264508), (object) this.TransformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1185105284 ^ 1185090832)), (object) this.TransformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(789532496 ^ 1575286436 ^ 1928067602)), (object) this.TransformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1053060681 ^ 1053060325)), (object) userId);
      List<long> orgItemIdsByUser = new List<long>();
      using (IDataReader dataReader = this.TransformationProvider.ExecuteQuery(sql, (Dictionary<string, object>) null))
      {
        while (dataReader.Read())
          orgItemIdsByUser.Add(dataReader.GetInt64(0));
      }
      return (IEnumerable<long>) orgItemIdsByUser;
    }));

    /// <summary>
    /// Получение элементов оргструктуры: должностей и групп, к которым непосредственно относится пользователь
    /// </summary>
    /// <param name="userId">Id пользователя</param>
    /// <returns></returns>
    public virtual IEnumerable<long> GetItemsByUser(long userId)
    {
      SqlSubQuery itemsByUserQuery = this.GetItemsByUserQuery(userId);
      ISQLQuery sqlQuery = this.Session.CreateSQLQuery(itemsByUserQuery.Sql);
      for (int position = 0; position < itemsByUserQuery.ParametersValues.Length; ++position)
        sqlQuery.SetParameter(position, itemsByUserQuery.ParametersValues[position]);
      return (IEnumerable<long>) sqlQuery.CleanUpCache(false).List<object>().Select<object, long>(new Func<object, long>(Convert.ToInt64)).ToArray<long>();
    }

    /// <summary>
    /// Получить подзапрос поиска элементов оргструктуры: должностей и групп, к которым непосредственно относится пользователь
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    public virtual SqlSubQuery GetItemsByUserQuery(long userId) => (SqlSubQuery) OrganizationItemManager.FiV5BwBBllYGKTwQr2y(OrganizationItemManager.NK4gPoBhoZJ6ArnaoYV(OrganizationItemManager.KL82ZMBWByg5h3D3HMC((object) this), (object) ((string) OrganizationItemManager.zxbWGbB1knBS0GTGgjp((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2086891181 ^ 2086905563), OrganizationItemManager.JWXGHXBXAfawXwWHTSO((object) this.TransformationProvider.Dialect, OrganizationItemManager.V9bGmhBrYjBx3NXrv2H(841533798 << 6 ^ -1976397458)), OrganizationItemManager.JWXGHXBXAfawXwWHTSO(OrganizationItemManager.o92s6cB9hOuRCd8pVIl((object) this.TransformationProvider), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-340788466 ^ -340839912)), OrganizationItemManager.JWXGHXBXAfawXwWHTSO(OrganizationItemManager.o92s6cB9hOuRCd8pVIl((object) this.TransformationProvider), OrganizationItemManager.V9bGmhBrYjBx3NXrv2H(-110921701 >> 6 ^ -1732788))) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1489118656 ^ 643054122 ^ -2123814610) + (string) OrganizationItemManager.sPL2HXBMmL2D6rOdNEm(OrganizationItemManager.V9bGmhBrYjBx3NXrv2H(-404268492 ^ -404253854), (object) new object[4]
    {
      OrganizationItemManager.JWXGHXBXAfawXwWHTSO(OrganizationItemManager.o92s6cB9hOuRCd8pVIl((object) this.TransformationProvider), OrganizationItemManager.V9bGmhBrYjBx3NXrv2H(-1489118656 ^ 643054122 ^ -2123766338)),
      OrganizationItemManager.JWXGHXBXAfawXwWHTSO(OrganizationItemManager.o92s6cB9hOuRCd8pVIl((object) this.TransformationProvider), OrganizationItemManager.V9bGmhBrYjBx3NXrv2H(1095474805 ^ 155418997 ^ 1208538844)),
      OrganizationItemManager.JWXGHXBXAfawXwWHTSO((object) this.TransformationProvider.Dialect, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~248518394 ^ -248517719)),
      OrganizationItemManager.JWXGHXBXAfawXwWHTSO(OrganizationItemManager.o92s6cB9hOuRCd8pVIl((object) this.TransformationProvider), OrganizationItemManager.V9bGmhBrYjBx3NXrv2H(-1711335411 ^ -1711288093))
    }))), OrganizationItemManager.V9bGmhBrYjBx3NXrv2H(711486506 ^ 711462890), (object) userId);

    /// <summary>
    /// Получить все нижестоящие элементы элемента оргструктуры
    /// </summary>
    /// <example>
    /// <para>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.PortalApiRoot.SecurityPortalApi.OrganizationItemSecurityApi.Load(System.Int64)">Как загрузить элемент оргструктуры</seealso>
    /// </para>
    /// <code>
    /// //загружаем элемент оргструтуры по идентификатору
    /// var orgItem = PublicAPI.Portal.Security.OrganizationItem.Load(3);
    /// 
    /// //получаем все нижестоящие элементы. Если таковых нет, вернет пустой список
    /// var subItemList = PublicAPI.Portal.Security.OrganizationItemSecurity.GetSubItems(orgItem);
    /// 
    /// //subItemList - список всех нижестоящих элементов элемента оргструктуры
    /// </code>
    /// </example>
    /// <param name="orgItem">Элемент оргструктуры</param>
    /// <returns>Список нижестоящих элементов</returns>
    [PublicApiMember]
    public virtual IEnumerable<IOrganizationItem> GetSubItems(
      IOrganizationItem orgItem)
    {
      List<IOrganizationItem> subItems1 = new List<IOrganizationItem>();
      if (orgItem == null)
        throw new NullReferenceException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--180540780 ^ 180494188)));
      if (!orgItem.SubItems.Any<IOrganizationItem>())
        return (IEnumerable<IOrganizationItem>) subItems1;
      foreach (IOrganizationItem subItem in (IEnumerable<IOrganizationItem>) orgItem.SubItems)
      {
        if (!subItem.SubItems.Any<IOrganizationItem>())
        {
          subItems1.Add(subItem);
        }
        else
        {
          subItems1.Add(subItem);
          IEnumerable<IOrganizationItem> subItems2 = this.GetSubItems(subItem);
          subItems1.AddRange(subItems2);
        }
      }
      return (IEnumerable<IOrganizationItem>) subItems1;
    }

    /// <summary>
    /// Получить нижестоящие элементы элемента оргструктуры по уровню вложенности
    /// </summary>
    /// <example>
    /// <para>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.PortalApiRoot.SecurityPortalApi.OrganizationItemSecurityApi.Load(System.Int64)">Как загрузить элемент оргструктуры</seealso>
    /// </para>
    /// <code>
    /// //загружаем элемент оргструтуры по идентификатору
    /// var orgItem = PublicAPI.Portal.Security.OrganizationItem.Load(3);
    /// 
    /// //получаем нижестоящие элементы по уровню вложенности. Если таковых нет, вернет пустой список
    /// var subItemList = PublicAPI.Portal.Security.OrganizationItemSecurity.GetSubItems(orgItem, 2);
    /// 
    /// //subItemList - список нижестоящих элементов элемента оргструктуры на два уровня вниз
    /// </code>
    /// </example>
    /// <param name="orgItem">Элемент оргструктуры</param>
    /// <param name="lvl">Уровень вложенности</param>
    /// <returns>Список нижестоящих элементов</returns>
    [PublicApiMember]
    public virtual IEnumerable<IOrganizationItem> GetSubItemsByLvl(
      IOrganizationItem orgItem,
      int lvl)
    {
      List<IOrganizationItem> subItemsByLvl1 = new List<IOrganizationItem>();
      if (lvl <= 0)
        return (IEnumerable<IOrganizationItem>) subItemsByLvl1;
      if (orgItem == null)
        throw new NullReferenceException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1880054609 ^ -1880068433)));
      if (!orgItem.SubItems.Any<IOrganizationItem>())
        return (IEnumerable<IOrganizationItem>) subItemsByLvl1;
      foreach (IOrganizationItem subItem in (IEnumerable<IOrganizationItem>) orgItem.SubItems)
      {
        subItemsByLvl1.Add(subItem);
        IEnumerable<IOrganizationItem> subItemsByLvl2 = this.GetSubItemsByLvl(subItem, lvl - 1);
        subItemsByLvl1.AddRange(subItemsByLvl2);
      }
      return (IEnumerable<IOrganizationItem>) subItemsByLvl1;
    }

    /// <summary>Получить непосредственный отдел должности</summary>
    /// <example>
    /// <para>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.PortalApiRoot.SecurityPortalApi.OrganizationItemSecurityApi.Load(System.Int64)">Как загрузить элемент оргструктуры</seealso>
    /// </para>
    /// <code>
    /// //загружаем элемент оргструтуры по идентификатору
    /// var orgItem = PublicAPI.Portal.Security.OrganizationItem.Load(3);
    /// 
    /// //Получаем непосредственный отдел должности. Если нет, вернет null
    /// var dept = PublicAPI.Portal.Security.OrganizationItem.GetItemDepartment(orgItem);
    /// 
    /// </code>
    /// </example>
    /// <param name="orgItem">Элемент оргструктуры</param>
    /// <returns>Непосредственный отдел должности</returns>
    [PublicApiMember]
    public virtual IOrganizationItem GetItemDepartment(IOrganizationItem orgItem)
    {
      int num = 1;
      IOrganizationItem itemDepartment;
      while (true)
      {
        switch (num)
        {
          case 1:
            itemDepartment = (IOrganizationItem) OrganizationItemManager.FWfoJFBpQBubCnAn5FD((object) orgItem);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            if (OrganizationItemManager.Q9eStNBOU51w2BS2R6T((object) itemDepartment) != OrganizationItemType.Department)
            {
              itemDepartment = (IOrganizationItem) OrganizationItemManager.FWfoJFBpQBubCnAn5FD((object) itemDepartment);
              num = 5;
              continue;
            }
            num = 4;
            continue;
          case 4:
            goto label_6;
          default:
            if (itemDepartment == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 2 : 2;
              continue;
            }
            goto case 3;
        }
      }
label_5:
      return itemDepartment;
label_6:
      return itemDepartment;
    }

    /// <summary>
    /// Получить начальника/начальников отдела выбранной должности
    /// </summary>
    /// <example>
    /// <para>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.PortalApiRoot.SecurityPortalApi.OrganizationItemSecurityApi.Load(System.Int64)">Как загрузить элемент оргструктуры</seealso>
    /// </para>
    /// <code>
    /// //загружаем элемент оргструтуры по идентификатору
    /// var orgItem = PublicAPI.Portal.Security.OrganizationItem.Load(3);
    /// 
    /// //Получаем начальника/начальников отдела выбранной должности. Если нет, вернет пустой список
    /// var heads = PublicAPI.Portal.Security.OrganizationItem.GetItemDeptHead(orgItem);
    /// 
    /// </code>
    /// </example>
    /// <param name="orgItem">Элемент оргструктуры</param>
    /// <returns>Начальник/начальники отдела выбранной должности</returns>
    [PublicApiMember]
    public virtual ICollection<IOrganizationItem> GetItemDeptHead(
      IOrganizationItem orgItem)
    {
      List<IOrganizationItem> itemDeptHead = new List<IOrganizationItem>();
      IOrganizationItem itemDepartment = this.GetItemDepartment(orgItem);
      if (itemDepartment != null)
      {
        // ISSUE: reference to a compiler-generated method
        itemDeptHead.AddRange(itemDepartment.SubItems.Where<IOrganizationItem>((Func<IOrganizationItem, bool>) (i => OrganizationItemManager.\u003C\u003Ec.MoTTrewW8MOm1x3ejlZy((object) i) == OrganizationItemType.Position)));
      }
      return (ICollection<IOrganizationItem>) itemDeptHead;
    }

    /// <summary>
    /// Получить начальника/начальников отдела/отделов пользователя
    /// </summary>
    /// <example>
    /// <code>
    /// //загружаем пользователя по идентификатору
    /// var orgItem = PublicAPI.Portal.Security.User.Load(3);
    /// 
    /// //Получаем начальника/начальников отдела/отделов пользователя. Если нет, вернет пустой список
    /// var heads = PublicAPI.Portal.Security.OrganizationItem.GetUserDeptHead(userId);
    /// 
    /// </code>
    /// </example>
    /// <param name="user">Пользователь</param>
    /// <returns>Начальник/начальники отдела/отделов пользователя</returns>
    [PublicApiMember]
    public virtual ICollection<IOrganizationItem> GetUserDeptHead(
      EleWise.ELMA.Security.Models.IUser user)
    {
      List<IOrganizationItem> userDeptHead = new List<IOrganizationItem>();
      ISet<IOrganizationItem> organizationGroups = user.OrganizationGroups;
      organizationGroups.AddRange<IOrganizationItem>((IEnumerable<IOrganizationItem>) user.OrganizationItems);
      foreach (IOrganizationItem orgItem in (IEnumerable<IOrganizationItem>) organizationGroups)
        userDeptHead.AddRange((IEnumerable<IOrganizationItem>) this.GetItemDeptHead(orgItem));
      return (ICollection<IOrganizationItem>) userDeptHead;
    }

    public OrganizationItemManager()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool VXuvM9BsOHAqwmvsgxn() => OrganizationItemManager.j2GFPhBAeLRE99FFRH3 == null;

    internal static OrganizationItemManager PNv5lSB7BSPJsGRTrnX() => OrganizationItemManager.j2GFPhBAeLRE99FFRH3;

    internal static object KL82ZMBWByg5h3D3HMC([In] object obj0) => (object) ((NHManagerBase) obj0).Session;

    internal static object V9bGmhBrYjBx3NXrv2H(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object BJL9uGBSTysHdojiSLA([In] Type obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Parameter(obj0, (string) obj1);

    internal static object z1K9pNBYl0MMu2w1AKA([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object LFr0a7ByCWbvukNZKL0([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) obj0, (MethodInfo) obj1);

    internal static Type I9jvrgBVY9wVG7qpnhB([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object We6UgvBlg8Dabjq9Ywu([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object aBlctmBflKaD346IaJ0([In] object obj0, [In] object obj1) => (object) ((IQuery) obj0).SetResultTransformer((IResultTransformer) obj1);

    internal static object rAWaMjB4Md24PlPMgP7([In] object obj0, [In] bool obj1) => (object) ((IQuery) obj0).CleanUpCache(obj1);

    internal static long qmkcTBBcC1rM0My2mWr([In] object obj0) => ((OrganizationItemDTO) obj0).ParentItemId;

    internal static bool b3ERUhBPaI190jGORdM([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void ktSrquBQ1Cu8kZY0KgE([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object BNG25TB8cXGmGnc8m43([In] object obj0, [In] Type obj1) => (object) System.Linq.Expressions.Expression.Constant(obj0, obj1);

    internal static object EmuQQxB5cOOBJMuG0TM([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Equal((System.Linq.Expressions.Expression) obj0, (System.Linq.Expressions.Expression) obj1);

    internal static object dId6FGBdudXyBAEhd3j([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.AndAlso((System.Linq.Expressions.Expression) obj0, (System.Linq.Expressions.Expression) obj1);

    internal static bool p74bPUBE5QSGsgpYYUB([In] object obj0) => ((IEntity) obj0).IsNew();

    internal static object sptYv8BGyxFNYFiy9CG([In] object obj0) => (object) ((List<long>) obj0).ToArray();

    internal static object JWXGHXBXAfawXwWHTSO([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object o92s6cB9hOuRCd8pVIl([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object zxbWGbB1knBS0GTGgjp([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) string.Format((string) obj0, obj1, obj2, obj3);

    internal static object sPL2HXBMmL2D6rOdNEm([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static object NK4gPoBhoZJ6ArnaoYV([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).CreateSQLSubQuery((string) obj1);

    internal static object FiV5BwBBllYGKTwQr2y([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SqlSubQuery) obj0).SetParameter((string) obj1, obj2);

    internal static object FWfoJFBpQBubCnAn5FD([In] object obj0) => (object) ((IOrganizationItem) obj0).ParentItem;

    internal static OrganizationItemType Q9eStNBOU51w2BS2R6T([In] object obj0) => ((IOrganizationItem) obj0).ItemType;

    [Component]
    internal class SecurityCacheSetIdAction : ISecurityCacheSetIdAction
    {
      private static OrganizationItemManager.SecurityCacheSetIdAction jre7URwW7uqc0STLnxyS;

      public void Execute()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              OrganizationItemManager.SecurityCacheSetIdAction.CaYutIwWYNxh20XbJ1p9((object) Locator.GetServiceNotNull<IUnionComplexCacheService>(), OrganizationItemManager.SecurityCacheSetIdAction.eb8fCJwWSO36h4iCZTRa(-696756495 ^ -696738059));
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public SecurityCacheSetIdAction()
      {
        OrganizationItemManager.SecurityCacheSetIdAction.ve4TG8wWyQHPtyYO6b8c();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object eb8fCJwWSO36h4iCZTRa(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void CaYutIwWYNxh20XbJ1p9([In] object obj0, [In] object obj1) => ((IUnionComplexCacheService) obj0).RefreshTimestamp((string) obj1);

      internal static bool GyQwDlwWWZhDqEFyYK8i() => OrganizationItemManager.SecurityCacheSetIdAction.jre7URwW7uqc0STLnxyS == null;

      internal static OrganizationItemManager.SecurityCacheSetIdAction Qo5RoCwWrTN96s2XQA8N() => OrganizationItemManager.SecurityCacheSetIdAction.jre7URwW7uqc0STLnxyS;

      internal static void ve4TG8wWyQHPtyYO6b8c() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
    }
  }
}
