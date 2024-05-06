// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Types.Settings.OrganizationItemSettings
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Security.Types.Settings
{
  /// <summary>Настройки типа "Сущность-&gt;Элемент оргструктуры"</summary>
  [Serializable]
  public class OrganizationItemSettings : EntitySettings
  {
    internal static OrganizationItemSettings lOOqv9ximSqIO0mGQ7o;

    /// <summary>Ctor</summary>
    public OrganizationItemSettings()
    {
      OrganizationItemSettings.w1rHwVxNMjbgrdhXU2G();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected OrganizationItemSettings(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Показывать пользователей / количество пользователей (если несколько), начначенных на должность
    /// </summary>
    [DefaultValue(false)]
    public bool ShowUsers
    {
      get => this.\u003CShowUsers\u003Ek__BackingField;
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
              this.\u003CShowUsers\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 0 : 0;
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

    internal static void w1rHwVxNMjbgrdhXU2G() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool synXPFx3HNhBbrjgbrY() => OrganizationItemSettings.lOOqv9ximSqIO0mGQ7o == null;

    internal static OrganizationItemSettings ibqxqdxjBpVyhR388Qm() => OrganizationItemSettings.lOOqv9ximSqIO0mGQ7o;
  }
}
