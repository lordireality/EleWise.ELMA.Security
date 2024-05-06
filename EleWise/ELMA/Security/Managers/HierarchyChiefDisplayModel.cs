// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.HierarchyChiefDisplayModel
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Managers
{
  /// <summary>
  /// Модель отображения начальников и оргструктуры в порядке иерархии
  /// </summary>
  public class HierarchyChiefDisplayModel
  {
    private Dictionary<IOrganizationItem, IEnumerable<HierarchyChiefDisplayModel.HierarchyChiefModel>> dictionary;

    public HierarchyChiefDisplayModel(
      Dictionary<IOrganizationItem, IEnumerable<HierarchyChiefDisplayModel.HierarchyChiefModel>> dictionary)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.dictionary = dictionary;
    }

    /// <summary>Словарик с элементами</summary>
    public Dictionary<IOrganizationItem, IEnumerable<HierarchyChiefDisplayModel.HierarchyChiefModel>> Items => this.dictionary;

    /// <summary>Получить начальников в порядке иерархии</summary>
    /// <param name="startItem">Стартовый элемент, от которого начнется построение иерархии</param>
    /// <returns>Начальники в порядке иерархии</returns>
    public IEnumerable<EleWise.ELMA.Security.Models.IUser> GetUsersHierarchy(
      IOrganizationItem startItem)
    {
      List<EleWise.ELMA.Security.Models.IUser> usersHierarchy = new List<EleWise.ELMA.Security.Models.IUser>();
      foreach (HierarchyChiefDisplayModel.HierarchyChiefModel hierarchyChiefModel in this.dictionary[startItem])
        usersHierarchy.Add(hierarchyChiefModel.User);
      return (IEnumerable<EleWise.ELMA.Security.Models.IUser>) usersHierarchy;
    }

    /// <summary>Получить элементы оргструктуры в порядке иерархии</summary>
    /// <param name="startItem">Стартовый элемент, от которого начнется построение иерархии</param>
    /// <returns>Элементы оргструктуры в порядке иерархии</returns>
    public IEnumerable<IOrganizationItem> GetOrgItemsHierarchy(
      IOrganizationItem startItem)
    {
      List<IOrganizationItem> orgItemsHierarchy = new List<IOrganizationItem>();
      foreach (HierarchyChiefDisplayModel.HierarchyChiefModel hierarchyChiefModel in this.dictionary[startItem])
        orgItemsHierarchy.Add(hierarchyChiefModel.OrgItem);
      return (IEnumerable<IOrganizationItem>) orgItemsHierarchy;
    }

    /// <summary>
    /// Модель представления начальников пользователя по иерархии вверх
    /// </summary>
    public class HierarchyChiefModel
    {
      private static HierarchyChiefDisplayModel.HierarchyChiefModel SIZO9nwYeDvhnQ03ofV0;

      /// <summary>
      /// Идентификатор элемент оргструктуры, от которого ищеться иерархия вверх
      /// </summary>
      public long StartItemId
      {
        get => this.\u003CStartItemId\u003Ek__BackingField;
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
                this.\u003CStartItemId\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 0 : 0;
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

      /// <summary>Идентификатор элемента оргструктуры в иерархии</summary>
      public long OrgItemId
      {
        get => this.\u003COrgItemId\u003Ek__BackingField;
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
                this.\u003COrgItemId\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 0 : 0;
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

      /// <summary>Уровень</summary>
      public long Lvl
      {
        get => this.\u003CLvl\u003Ek__BackingField;
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
                this.\u003CLvl\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 != 0 ? 0 : 0;
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

      /// <summary>Идентификатор начальника</summary>
      public long UserId
      {
        get => this.\u003CUserId\u003Ek__BackingField;
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
                this.\u003CUserId\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 0 : 0;
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
      /// Элемент оргструктуры, от которого ищеться иерархия вверх
      /// </summary>
      public IOrganizationItem StartItem
      {
        get => this.\u003CStartItem\u003Ek__BackingField;
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
                this.\u003CStartItem\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 0 : 0;
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

      /// <summary>Элемент оргструктуры в иерархии</summary>
      public IOrganizationItem OrgItem
      {
        get => this.\u003COrgItem\u003Ek__BackingField;
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
                this.\u003COrgItem\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff == 0 ? 0 : 0;
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

      /// <summary>Начальник</summary>
      public EleWise.ELMA.Security.Models.IUser User
      {
        get => this.\u003CUser\u003Ek__BackingField;
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
                this.\u003CUser\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 != 0 ? 0 : 0;
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

      public HierarchyChiefModel()
      {
        HierarchyChiefDisplayModel.HierarchyChiefModel.ADcqxBwY2j2m16lSn6TR();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool WGUJjmwYnIAYOKn2qJTK() => HierarchyChiefDisplayModel.HierarchyChiefModel.SIZO9nwYeDvhnQ03ofV0 == null;

      internal static HierarchyChiefDisplayModel.HierarchyChiefModel t1Sd15wYL6YQrDqGklY6() => HierarchyChiefDisplayModel.HierarchyChiefModel.SIZO9nwYeDvhnQ03ofV0;

      internal static void ADcqxBwY2j2m16lSn6TR() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
    }
  }
}
