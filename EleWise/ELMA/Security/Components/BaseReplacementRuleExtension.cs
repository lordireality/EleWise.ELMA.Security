// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.BaseReplacementRuleExtension
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>
  /// Запрет использования объектов Элемент листа ознакомления и Элемент листа согласования в правилах замещений
  /// </summary>
  [Component(Order = 100)]
  public class BaseReplacementRuleExtension : IReplacementRuleExtension
  {
    internal static BaseReplacementRuleExtension LFBGFwHIiJDu0D0eori;

    public virtual bool Can(EntityMetadata metadata) => true;

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public virtual bool CanRule(EntityMetadata metadata) => true;

    public BaseReplacementRuleExtension()
    {
      BaseReplacementRuleExtension.C3qjEGHLoDCWQCJHEPG();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void C3qjEGHLoDCWQCJHEPG() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool aX9QWYHejPv6jrD0HgV() => BaseReplacementRuleExtension.LFBGFwHIiJDu0D0eori == null;

    internal static BaseReplacementRuleExtension jTfgPdHn8r3qtOy8QL0() => BaseReplacementRuleExtension.LFBGFwHIiJDu0D0eori;
  }
}
