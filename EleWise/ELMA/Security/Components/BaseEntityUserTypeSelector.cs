// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.BaseEntityUserTypeSelector
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>Базовый класс выбора пользователей из сущности</summary>
  public abstract class BaseEntityUserTypeSelector : IEntityUserTypeSelector
  {
    private static BaseEntityUserTypeSelector fiHNALz8KlGIGlp6rpq;

    public abstract Type EntityType { get; }

    public abstract string Prefix { get; }

    public abstract string DisplayName { get; }

    public virtual IEntity<long> GetEntity(string value)
    {
      string fullPrefix = this.GetFullPrefix();
      if (!value.Contains(fullPrefix))
        return (IEntity<long>) null;
      long int64 = Convert.ToInt64(value.Replace(fullPrefix, ""));
      return (IEntity<long>) EntityHelper.GetEntityManager(this.EntityType).Load((object) int64);
    }

    public abstract List<EleWise.ELMA.Security.Models.IUser> ExtractUsers(string value);

    public virtual string PrefixedValue(IEntity<long> entity) => string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-901653144 ^ -901687282), (object) this.GetFullPrefix(), (object) entity.Id);

    /// <summary>
    /// Полный префикс (без него в значении остается только Id)
    /// </summary>
    /// <returns></returns>
    public virtual string GetFullPrefix() => (string) BaseEntityUserTypeSelector.sohSn7zGuS10bskufBb(BaseEntityUserTypeSelector.hAMiN9zEsKItF8MU1Il((object) this));

    /// <summary>Получить полный префикс из значения</summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string ExtractFullPrefix(string value) => (string) BaseEntityUserTypeSelector.sohSn7zGuS10bskufBb((object) BaseEntityUserTypeSelector.ExtractPrefix(value));

    /// <summary>Получить префикс из значения</summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string ExtractPrefix(string value)
    {
      int num = 2;
      string[] strArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (strArray.Length < 2)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            strArray = (string[]) BaseEntityUserTypeSelector.OQec4Jz97aFX8yD7OVn((object) value, (object) new string[1]
            {
              (string) BaseEntityUserTypeSelector.anRWUSzXU91kHjMFRaJ(1690569372 >> 6 ^ 26427570)
            }, StringSplitOptions.RemoveEmptyEntries);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) null;
label_4:
      return strArray[0];
    }

    /// <summary>Загрузить сущность по значению</summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static IEntity<long> LoadEntity(string value)
    {
      string prefix = BaseEntityUserTypeSelector.ExtractPrefix(value);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return ComponentManager.Current.GetExtensionPoints<IEntityUserTypeSelector>().FirstOrDefault<IEntityUserTypeSelector>((Func<IEntityUserTypeSelector, bool>) (s => BaseEntityUserTypeSelector.\u003C\u003Ec__DisplayClass12_0.zRwtyKwlpVMLk7ojoTc0(BaseEntityUserTypeSelector.\u003C\u003Ec__DisplayClass12_0.CxayQ0wlBg3QEV3KaLRw((object) s), (object) prefix)))?.GetEntity(value);
    }

    /// <summary>
    /// Загрузить сущность по типу и значению. Если тип указанный и тип значения не совпадет, то вернется null
    /// </summary>
    /// <param name="value"></param>
    /// <param name="entityType"></param>
    /// <returns></returns>
    public static IEntity<long> LoadEntity(string value, Type entityType) => ComponentManager.Current.GetExtensionPoints<IEntityUserTypeSelector>().FirstOrDefault<IEntityUserTypeSelector>((Func<IEntityUserTypeSelector, bool>) (s => BaseEntityUserTypeSelector.\u003C\u003Ec__DisplayClass13_0.merv1kwlqYANvo3aiO0j(BaseEntityUserTypeSelector.\u003C\u003Ec__DisplayClass13_0.m28EpIwlvByYSBllRbZq((object) s), entityType)))?.GetEntity(value);

    /// <summary>Получиьт список пользователей по значению</summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static List<EleWise.ELMA.Security.Models.IUser> GetUsers(string value)
    {
      string prefix = BaseEntityUserTypeSelector.ExtractPrefix(value);
      // ISSUE: reference to a compiler-generated method
      return ComponentManager.Current.GetExtensionPoints<IEntityUserTypeSelector>().FirstOrDefault<IEntityUserTypeSelector>((Func<IEntityUserTypeSelector, bool>) (s => BaseEntityUserTypeSelector.\u003C\u003Ec__DisplayClass14_0.FWFOyVwlnQka1LLeNrBZ((object) s.Prefix, (object) prefix)))?.ExtractUsers(value);
    }

    /// <summary>Получить полный префикс</summary>
    /// <param name="prefix"></param>
    /// <returns></returns>
    public static string GetFullPrefix(string prefix) => (string) BaseEntityUserTypeSelector.kEW5jUz14RTGZlvZ6sS(BaseEntityUserTypeSelector.anRWUSzXU91kHjMFRaJ(--1587467489 ^ 1587529879), (object) prefix);

    /// <summary>Достать Id объекта по префиксу и значению</summary>
    /// <param name="prefix"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static long GetObjectId(string prefix, string value) => Convert.ToInt64((string) BaseEntityUserTypeSelector.Wiv0QAzMj9Jv7fCKGjg((object) value, (object) prefix, (object) ""));

    protected BaseEntityUserTypeSelector()
    {
      BaseEntityUserTypeSelector.mNx9OwzhRPWq4vBHaWE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object hAMiN9zEsKItF8MU1Il([In] object obj0) => (object) ((BaseEntityUserTypeSelector) obj0).Prefix;

    internal static object sohSn7zGuS10bskufBb([In] object obj0) => (object) BaseEntityUserTypeSelector.GetFullPrefix((string) obj0);

    internal static bool pSpxFIz5Ml3w9gDJYsE() => BaseEntityUserTypeSelector.fiHNALz8KlGIGlp6rpq == null;

    internal static BaseEntityUserTypeSelector QZE6mhzdHbZdMkhkcvf() => BaseEntityUserTypeSelector.fiHNALz8KlGIGlp6rpq;

    internal static object anRWUSzXU91kHjMFRaJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object OQec4Jz97aFX8yD7OVn([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((string[]) obj1, obj2);

    internal static object kEW5jUz14RTGZlvZ6sS([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object Wiv0QAzMj9Jv7fCKGjg([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static void mNx9OwzhRPWq4vBHaWE() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
