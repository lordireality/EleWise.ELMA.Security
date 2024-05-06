// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.OrgstructureElementUsesDTO
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>
  /// DTO элемента дерева использований элемента оргуструтуры
  /// </summary>
  public sealed class OrgstructureElementUsesDTO
  {
    internal static OrgstructureElementUsesDTO tPvX6bfV7rs7BpxHvGi;

    /// <summary>Ключ использования</summary>
    public string Key
    {
      get => this.\u003CKey\u003Ek__BackingField;
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
              this.\u003CKey\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0 ? 0 : 0;
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

    /// <summary>Ключ родителя</summary>
    public string ParentKey
    {
      get => this.\u003CParentKey\u003Ek__BackingField;
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
              this.\u003CParentKey\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 == 0 ? 0 : 0;
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

    /// <summary>Отображаемое имя использования</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 == 0 ? 0 : 0;
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

    /// <summary>Изображение</summary>
    public string Icon
    {
      get => this.\u003CIcon\u003Ek__BackingField;
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
              this.\u003CIcon\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 == 0 ? 0 : 0;
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

    /// <summary>Ctor</summary>
    public OrgstructureElementUsesDTO()
    {
      OrgstructureElementUsesDTO.w9Zg1df4dqGgHBG7r6A();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="name">Название </param>
    /// <param name="key">Ключ</param>
    /// <param name="parentKey">Ключ родителя</param>
    public OrgstructureElementUsesDTO(string name, string key, string parentKey)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.ParentKey = parentKey;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 == 0 ? 1 : 1;
            continue;
          case 3:
            this.Name = name;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 == 0 ? 0 : 0;
            continue;
          default:
            this.Key = key;
            num = 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Ctor</summary>
    /// <param name="name">Название </param>
    /// <param name="key">Ключ</param>
    /// <param name="parentKey">Ключ родителя</param>
    /// <param name="icon">Изображение</param>
    public OrgstructureElementUsesDTO(string name, string key, string parentKey, string icon)
    {
      OrgstructureElementUsesDTO.w9Zg1df4dqGgHBG7r6A();
      // ISSUE: explicit constructor call
      this.\u002Ector(name, key, parentKey);
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Icon = icon;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    internal static bool UEIKCQflM1QsjciM0kK() => OrgstructureElementUsesDTO.tPvX6bfV7rs7BpxHvGi == null;

    internal static OrgstructureElementUsesDTO keJK4Uffuk5WjwiYKAc() => OrgstructureElementUsesDTO.tPvX6bfV7rs7BpxHvGi;

    internal static void w9Zg1df4dqGgHBG7r6A() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
