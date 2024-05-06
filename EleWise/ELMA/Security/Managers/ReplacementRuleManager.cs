// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.ReplacementRuleManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Managers
{
  /// <summary>
  /// Менеджер правил замещения <see cref="T:EleWise.ELMA.Security.Models.IReplacementRule" />
  /// </summary>
  [DeveloperApi(DeveloperApiType.Manager)]
  public class ReplacementRuleManager : EntityManager<IReplacementRule, long>
  {
    private IEnumerable<IReplacementRuleExtension> replacementRuleExtensions;
    private Func<Guid, IEnumerable<PropertyMetadata>> getReplaceableProperties;
    internal static ReplacementRuleManager U5uEFaGXkqp7AIj55V5;

    /// <summary>Статический экземпляр менеджера</summary>
    public static ReplacementRuleManager Instance => Locator.GetServiceNotNull<ReplacementRuleManager>();

    /// <summary>Правила</summary>
    /// <returns></returns>
    private IEnumerable<IReplacementRuleExtension> ReplacementRules() => this.replacementRuleExtensions ?? (this.replacementRuleExtensions = ComponentManager.Current.GetExtensionPoints<IReplacementRuleExtension>());

    /// <summary>
    /// Создать правила по умолчанию. При данной операции правила будут скопированы из предыдущего замещения.
    /// </summary>
    /// <param name="replacement">Замещение</param>
    [Transaction]
    public virtual void CreateDefaultRules(IReplacement replacement)
    {
      int num1 = 14;
      IEnumerator<IReplacementRule> enumerator;
      IReplacement replacement1;
      while (true)
      {
        int num2 = num1;
        IReplacementRuleFilter filter1;
        while (true)
        {
          IReplacement replacement2;
          Func<ReplacementStatus, IReplacement> func;
          IReplacement replacement3;
          switch (num2)
          {
            case 0:
              goto label_8;
            case 1:
              goto label_23;
            case 2:
              replacement3 = func(ReplacementStatus.Delete);
              break;
            case 3:
              IReplacement replacement4 = func(ReplacementStatus.Active);
              if (replacement4 == null)
              {
                num2 = 2;
                continue;
              }
              replacement3 = replacement4;
              break;
            case 4:
              goto label_4;
            case 5:
              if (replacement1 == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 == 0 ? 1 : 1;
                continue;
              }
              goto case 9;
            case 6:
              filter1.Replacement = replacement2;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 == 0 ? 7 : 1;
              continue;
            case 7:
              enumerator = this.Find((IEntityFilter) filter1, (FetchOptions) ReplacementRuleManager.xgA9SLGhi2pk771FtxE()).GetEnumerator();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0 ? 11 : 11;
              continue;
            case 8:
              if (replacement2 == null)
              {
                num2 = 10;
                continue;
              }
              goto label_5;
            case 9:
              if (ReplacementRuleManager.OGkHlaGME5l1QPBG69K((object) replacement1))
              {
                num2 = 12;
                continue;
              }
              goto label_28;
            case 10:
              goto label_36;
            case 11:
              goto label_21;
            case 12:
              func = (Func<ReplacementStatus, IReplacement>) (status =>
              {
                int num3 = 1;
                IReplacementFilter filter2;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      filter2 = InterfaceActivator.Create<IReplacementFilter>();
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_5;
                    case 3:
                      filter2.Status = new ReplacementStatus?(status);
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0 ? 2 : 2;
                      continue;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      filter2.SourceUser = (EleWise.ELMA.Security.Models.IUser) ReplacementRuleManager.\u003C\u003Ec__DisplayClass4_0.m2cEK6wAiamJR0JHVsej((object) replacement1);
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0 ? 1 : 3;
                      continue;
                  }
                }
label_5:
                // ISSUE: reference to a compiler-generated method
                return ReplacementManager.Instance.Find((IEntityFilter) filter2, new FetchOptions(0, 1, ListSortDirection.Descending, (string) ReplacementRuleManager.\u003C\u003Ec__DisplayClass4_0.AkJXbVwA3DCBPaxjXYGF(-340788466 ^ -340787494))).FirstOrDefault<IReplacement>();
              });
              num2 = 3;
              continue;
            case 13:
              replacement1 = replacement;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 2 : 5;
              continue;
            case 14:
              num2 = 13;
              continue;
            default:
              goto label_18;
          }
          replacement2 = replacement3;
          num2 = 8;
        }
label_5:
        filter1 = InterfaceActivator.Create<IReplacementRuleFilter>();
        num1 = 6;
      }
label_8:
      return;
label_23:
      return;
label_4:
      return;
label_36:
      return;
label_18:
      return;
label_28:
      return;
label_21:
      try
      {
label_26:
        if (ReplacementRuleManager.jndoATGp4cicitwhXAJ((object) enumerator))
          goto label_24;
        else
          goto label_27;
label_22:
        int num4;
        switch (num4)
        {
          case 1:
            return;
          case 2:
            goto label_26;
        }
label_24:
        IReplacementRule replacementRule = CloneHelperBuilder.Create<IReplacementRule>(enumerator.Current).Clone();
        replacementRule.Replacement = replacement1;
        ReplacementRuleManager.wRqxs4GB0B26Kih5JKv((object) replacementRule);
        num4 = 2;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 == 0)
        {
          num4 = 1;
          goto label_22;
        }
        else
          goto label_22;
label_27:
        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 1 : 1;
        goto label_22;
      }
      finally
      {
        if (enumerator != null)
        {
          int num5 = 1;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 == 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                enumerator.Dispose();
                num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab == 0 ? 0 : 0;
                continue;
              default:
                goto label_35;
            }
          }
        }
label_35:;
      }
    }

    /// <summary>
    /// Возвращает объект в котором реализовано указанное свойство с флагом замещения.
    /// </summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <returns></returns>
    public EntityMetadata ObjectForProperty(Guid propertyUid)
    {
      int num1 = 3;
      Guid propertyUid1;
      IEnumerable<IReplacementRuleExtension> extensions;
      while (true)
      {
        switch (num1)
        {
          case 1:
            extensions = this.ReplacementRules();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 == 0 ? 0 : 0;
            continue;
          case 2:
            propertyUid1 = propertyUid;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 1 : 1;
            continue;
          case 3:
            num1 = 2;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      Func<PropertyMetadata, bool> func;
      return ((IMetadataService) ReplacementRuleManager.mRjV1AGOcytQKuurpKA((object) this)).GetMetadataList().OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (md =>
      {
        int num2 = 7;
        IReplacementRuleExtension replacementRuleExtension;
        EntityMetadata md1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              replacementRuleExtension = extensions.FirstOrDefault<IReplacementRuleExtension>((Func<IReplacementRuleExtension, bool>) (e => ReplacementRuleManager.\u003C\u003Ec__DisplayClass5_1.W1aa5CwAYDoeXt2PHQRK((object) e, (object) md1)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 != 0 ? 4 : 4;
              continue;
            case 2:
              if (md1.Type != EntityMetadataType.InterfaceImplementation)
              {
                num2 = 5;
                continue;
              }
              goto label_4;
            case 3:
              goto label_3;
            case 4:
              if (replacementRuleExtension == null)
              {
                num2 = 3;
                continue;
              }
              goto label_2;
            case 5:
              List<PropertyMetadata> properties = ReplacementRuleManager.GetProperties(md1);
              Func<PropertyMetadata, bool> func1 = func;
              // ISSUE: reference to a compiler-generated method
              Func<PropertyMetadata, bool> predicate = func1 == null ? (func = (Func<PropertyMetadata, bool>) (p => ReplacementRuleManager.\u003C\u003Ec__DisplayClass5_0.lAGYPPwAsmKK2TTr00gI(p.Uid, propertyUid1))) : func1;
              if (!properties.Any<PropertyMetadata>(predicate))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            case 6:
              md1 = md;
              num2 = 2;
              continue;
            case 7:
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e == 0 ? 6 : 6;
              continue;
            case 8:
              goto label_2;
            default:
              goto label_4;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        return ReplacementRuleManager.\u003C\u003Ec__DisplayClass5_0.SlFfUVwAAK4AnLZbI35Z((object) replacementRuleExtension, (object) md1);
label_3:
        return false;
label_4:
        return false;
      })).FirstOrDefault<EntityMetadata>();
    }

    /// <summary>
    /// Возвращает список объектов, которые поддерживают замещения.
    /// </summary>
    /// <returns></returns>
    public List<EntityMetadata> RootRulesObjects()
    {
      IEnumerable<IReplacementRuleExtension> extensions = this.ReplacementRules();
      return this.MetadataRuntimeService.GetMetadataList().OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (md =>
      {
        int num1 = 2;
        IReplacementRuleExtension replacementRuleExtension;
        EntityMetadata md1;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_13;
              case 2:
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 1 : 1;
                continue;
              case 3:
                goto label_9;
              case 4:
                if (replacementRuleExtension != null)
                {
                  num2 = 6;
                  continue;
                }
                goto label_6;
              case 5:
                if (this.GetPropertiesInnerLogic(md1).Any<PropertyMetadata>())
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 0 : 0;
                  continue;
                }
                goto label_7;
              case 6:
                goto label_5;
              default:
                // ISSUE: reference to a compiler-generated method
                replacementRuleExtension = extensions.FirstOrDefault<IReplacementRuleExtension>((Func<IReplacementRuleExtension, bool>) (e => ReplacementRuleManager.\u003C\u003Ec__DisplayClass6_1.bsh1fdwA8RiGrZmIsbbU((object) e, (object) md1)));
                num2 = 4;
                continue;
            }
          }
label_9:
          // ISSUE: reference to a compiler-generated method
          if (ReplacementRuleManager.\u003C\u003Ec__DisplayClass6_0.CIHMLiwAfVCQVc4rKZgG((object) md1) != EntityMetadataType.InterfaceImplementation)
          {
            num1 = 5;
            continue;
          }
          goto label_7;
label_13:
          md1 = md;
          num1 = 3;
        }
label_5:
        return replacementRuleExtension.CanRule(md1);
label_6:
        return false;
label_7:
        return false;
      })).ToList<EntityMetadata>();
    }

    /// <summary>
    /// Возвращает список свойств для типа сущности с флагом "Замещение"
    /// </summary>
    /// <param name="entityMetadata">Метаданные типа</param>
    /// <returns></returns>
    public static List<PropertyMetadata> GetProperties(
      EntityMetadata entityMetadata)
    {
      return ReplacementRuleManager.Instance.GetPropertiesInnerLogic(entityMetadata);
    }

    /// <summary>
    /// Возвращает список свойств для типа сущности с флагом "Замещение"
    /// </summary>
    /// <param name="objectUid">Uid типа объекта</param>
    /// <returns></returns>
    public static List<PropertyMetadata> GetProperties(Guid objectUid) => ReplacementRuleManager.GetProperties(MetadataLoader.LoadMetadata(objectUid, loadImplementation: false) as EntityMetadata);

    /// <summary>Внутренняя инициализация менеджера</summary>
    protected override void InitInternal()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ReplacementRuleManager.WLJwkFGTImYsAdactC3((object) this);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ParameterExpression parameterExpression = (ParameterExpression) ReplacementRuleManager.OdQ2NKGvmyYjXTgvuEK(typeof (Guid), ReplacementRuleManager.PWPANDGFVTVa97CFh1p(-757186336 ^ -757177908));
            // ISSUE: type reference
            // ISSUE: method reference
            this.getReplaceableProperties = MetadataLoader.UseCachingForFunc<Guid, IEnumerable<PropertyMetadata>>(System.Linq.Expressions.Expression.Lambda<Func<Guid, IEnumerable<PropertyMetadata>>>((System.Linq.Expressions.Expression) ReplacementRuleManager.js1r83GIS9iIQKIJTDv(ReplacementRuleManager.ARcepKGgWSyvuASjyt2((object) this, ReplacementRuleManager.gviJvoGqJFBeSeRvVuf(__typeref (ReplacementRuleManager))), (object) (MethodInfo) ReplacementRuleManager.LR2vXOGJDZEuscYBbiL(__methodref (ReplacementRuleManager.GenerateReplaceableProperties)), (object) new System.Linq.Expressions.Expression[1]
            {
              (System.Linq.Expressions.Expression) parameterExpression
            }), parameterExpression));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    private List<PropertyMetadata> GetPropertiesInnerLogic(
      EntityMetadata entityMetadata)
    {
      return entityMetadata == null ? new List<PropertyMetadata>() : this.getReplaceableProperties(entityMetadata.Uid).ToList<PropertyMetadata>();
    }

    private IEnumerable<PropertyMetadata> GenerateReplaceableProperties(
      Guid metadataUid)
    {
      Guid userTypeUid = InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>(false);
      return ((ClassMetadata) MetadataLoader.LoadMetadata(metadataUid, loadImplementation: false)).Properties.Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
      {
        int num1 = 2;
        EntityUserSettings entityUserSettings;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                if (entityUserSettings == null)
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 0 : 0;
                  continue;
                }
                goto label_5;
              case 2:
                // ISSUE: reference to a compiler-generated method
                entityUserSettings = ReplacementRuleManager.\u003C\u003Ec__DisplayClass12_0.sdNtLywAGmLX52CVcnJC((object) p) as EntityUserSettings;
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 != 0 ? 1 : 1;
                continue;
              case 3:
                goto label_5;
              case 5:
                goto label_8;
              default:
                goto label_9;
            }
          }
label_5:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          if (!ReplacementRuleManager.\u003C\u003Ec__DisplayClass12_0.ungoIjwA9QPuvd63xfvK(ReplacementRuleManager.\u003C\u003Ec__DisplayClass12_0.MTHts1wAXNJHoXMlCi3b((object) p), userTypeUid))
            num1 = 4;
          else
            break;
        }
label_8:
        // ISSUE: reference to a compiler-generated method
        return ReplacementRuleManager.\u003C\u003Ec__DisplayClass12_0.bHruJmwA1IYi2Vmer9Ui((object) entityUserSettings);
label_9:
        return false;
      }));
    }

    /// <summary>Возвращает название объекта для правила замещения</summary>
    /// <param name="rule">Правило замещения</param>
    /// <returns></returns>
    public static string ObjectDisplayName(IReplacementRule rule)
    {
      int num = 3;
      IEntityMetadata entityMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (entityMetadata == null)
            {
              num = 4;
              continue;
            }
            goto label_4;
          case 2:
            goto label_2;
          case 3:
            if (rule != null)
            {
              entityMetadata = (IEntityMetadata) ((ReplacementRuleManager) ReplacementRuleManager.IIYZWDGe92jki85iUk7()).ObjectForProperty(ReplacementRuleManager.SspoF8GnRVlG7yvv5K4((object) rule));
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 1 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d == 0 ? 2 : 2;
            continue;
          case 4:
            goto label_5;
          default:
            goto label_4;
        }
      }
label_2:
      return (string) null;
label_4:
      return (string) ReplacementRuleManager.wPAMcjGL8lLG1gY3YPV((object) entityMetadata);
label_5:
      return "";
    }

    /// <summary>
    /// Возвращает название свойства объекта для правила замещения
    /// </summary>
    /// <param name="rule">Свойство Правило замещения</param>
    /// <returns></returns>
    public static string PropertyDisplayName(IReplacementRule rule)
    {
      int num = 6;
      PropertyMetadata propertyMetadata;
      IReplacementRule rule1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (rule1 != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 == 0 ? 0 : 2;
              continue;
            }
            goto label_8;
          case 2:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            propertyMetadata = ReplacementRuleManager.GetProperties(ReplacementRuleManager.HVlooyGHpAJGdMEAo4E(ReplacementRuleManager.nFfh4XG2C5PnBsn8msd(ReplacementRuleManager.IIYZWDGe92jki85iUk7(), ReplacementRuleManager.SspoF8GnRVlG7yvv5K4((object) rule1)))).FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (m => ReplacementRuleManager.\u003C\u003Ec__DisplayClass14_0.C4AQTLwAO7P9Trv05KmG(m.Uid, ReplacementRuleManager.\u003C\u003Ec__DisplayClass14_0.QuRVZkwApDVF8fshQh0P((object) rule1))));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d == 0 ? 7 : 5;
            continue;
          case 3:
            goto label_4;
          case 4:
            goto label_5;
          case 5:
            rule1 = rule;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 1 : 0;
            continue;
          case 6:
            num = 5;
            continue;
          case 7:
            if (propertyMetadata == null)
            {
              num = 4;
              continue;
            }
            goto label_4;
          default:
            goto label_8;
        }
      }
label_4:
      return propertyMetadata.DisplayName;
label_5:
      return (string) null;
label_8:
      return (string) null;
    }

    /// <summary>
    /// Возвращает заместителя для объекта, согласно правил замещения. Если правило не найдено, то возвращает null. По умолчанию метод сохраняет объект и выполняет Flush. Отменить сохранение можно, изменив параметр saveAndFlush на false.
    /// </summary>
    /// <param name="entity">Объект</param>
    /// <param name="expr">Свойство</param>
    /// <param name="replacement"></param>
    /// <param name="saveAndFlush">Сохранить объект и выполнить Flush</param>
    /// <returns></returns>
    public EleWise.ELMA.Security.Models.IUser AssignmentReplacementRule<T>(
      T entity,
      System.Linq.Expressions.Expression<Func<T, object>> expr,
      IReplacement replacement,
      bool saveAndFlush = true)
      where T : IEntity
    {
      return (object) entity == null || expr == null ? (EleWise.ELMA.Security.Models.IUser) null : this.AssignmentReplacementRule((IEntity) entity, InterfaceActivator.PropertyUid<T>(expr, true), replacement, saveAndFlush);
    }

    /// <summary>
    /// Возвращает заместителя для объекта, согласно правил замещения. Если правило не найдено, то возвращает null. По умолчанию метод сохраняет объект и выполняет Flush. Отменить сохранение можно, изменив параметр saveAndFlush на false.
    /// </summary>
    /// <param name="replacement">Замещение</param>
    /// <param name="entity">Объект</param>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <param name="saveAndFlush">Сохранить объект и выполнить Flush</param>
    /// <returns></returns>
    public EleWise.ELMA.Security.Models.IUser AssignmentReplacementRule(
      IEntity entity,
      Guid propertyUid,
      IReplacement replacement,
      bool saveAndFlush = true)
    {
      int num1 = 6;
      IReplacementRule replacementRule;
      IReplacementRuleFilter filter;
      ReplacementRuleManager replacementRuleManager;
      Guid entityTypeUid;
      IEntity entity1;
      bool saveAndFlush1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            saveAndFlush1 = saveAndFlush;
            num1 = 10;
            continue;
          case 2:
            replacementRule = ReplacementRuleManager.Instance.Find((IEntityFilter) filter, new FetchOptions(0, 0, (string) ReplacementRuleManager.PWPANDGFVTVa97CFh1p(1124861159 ^ 1124906849))).FirstOrDefault<IReplacementRule>((Func<IReplacementRule, bool>) (r =>
            {
              int num2 = 7;
              while (true)
              {
                int num3 = num2;
                EntityMetadata entityMetadata;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                    case 2:
                      if (replacementRuleManager.CheckRule(r, entity1, saveAndFlush1))
                      {
                        num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_5;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (entity1.GetType().IsSubclassOf(ReplacementRuleManager.\u003C\u003Ec__DisplayClass16_0.G2tZiRwAnqBTFe60Fwrs(ReplacementRuleManager.\u003C\u003Ec__DisplayClass16_0.TdRKn2wAeRPPuAkys7cf((object) replacementRuleManager), entityMetadata.Uid, true)))
                        goto case 1;
                      else
                        goto label_11;
                    case 4:
                    case 5:
                      goto label_12;
                    case 6:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (ReplacementRuleManager.\u003C\u003Ec__DisplayClass16_0.ObyqKHwAIalvxdF4PPPF(ReplacementRuleManager.\u003C\u003Ec__DisplayClass16_0.xl16UswAJSHP2xnTRoMf((object) entityMetadata), entityTypeUid))
                      {
                        num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc == 0 ? 1 : 1;
                        continue;
                      }
                      goto case 3;
                    case 7:
                      // ISSUE: reference to a compiler-generated method
                      entityMetadata = replacementRuleManager.ObjectForProperty(ReplacementRuleManager.\u003C\u003Ec__DisplayClass16_0.H1fnXywAg40u3mnPa9NI((object) r));
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 6 : 3;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_5:
                saveAndFlush1 = false;
                num2 = 4;
                continue;
label_11:
                num2 = 5;
              }
label_4:
              return true;
label_12:
              return false;
            }));
            num1 = 11;
            continue;
          case 3:
            filter.Replacement = replacement;
            num1 = 2;
            continue;
          case 4:
            goto label_2;
          case 5:
            replacementRuleManager = this;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 9 : 0;
            continue;
          case 6:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec != 0 ? 2 : 5;
            continue;
          case 7:
            filter = InterfaceActivator.Create<IReplacementRuleFilter>();
            num1 = 8;
            continue;
          case 8:
            filter.PropertyUid = new Guid?(propertyUid);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0 ? 1 : 3;
            continue;
          case 9:
            entity1 = entity;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 1 : 1;
            continue;
          case 10:
            if (entity1 == null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 != 0 ? 0 : 0;
              continue;
            }
            entityTypeUid = ReplacementRuleManager.c7qLwSGz3cMiGX8XEpl(entity1.GetType(), false);
            num1 = 7;
            continue;
          case 11:
            if (replacementRule == null)
            {
              num1 = 4;
              continue;
            }
            goto label_3;
          default:
            goto label_15;
        }
      }
label_2:
      return (EleWise.ELMA.Security.Models.IUser) null;
label_3:
      return (EleWise.ELMA.Security.Models.IUser) ReplacementRuleManager.F3OLBnXullkSIKUwTnT((object) replacementRule);
label_15:
      return (EleWise.ELMA.Security.Models.IUser) null;
    }

    /// <summary>Проверяет, применимо ли правило замещения к объекту</summary>
    /// <param name="rule">Правило замещения</param>
    /// <param name="entity">Объект</param>
    /// <param name="saveAndFlush">Сохранить объект и выполнить Flush</param>
    /// <returns></returns>
    private bool CheckRule(IReplacementRule rule, IEntity entity, bool saveAndFlush)
    {
      int num1 = 7;
      IEntityFilter entityFilter;
      IEntityManager entityManagerOrNull;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          FilterForAttribute attribute;
          Type type1;
          Type c;
          Type type2;
          switch (num2)
          {
            case 1:
              if (attribute == null)
              {
                num2 = 23;
                continue;
              }
              type2 = ReplacementRuleManager.CRpRexXR3L7rwDkFVkx((object) attribute);
              break;
            case 2:
              if (entity != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 != 0 ? 4 : 18;
                continue;
              }
              goto label_4;
            case 3:
              attribute = AttributeHelper<FilterForAttribute>.GetAttribute(entityFilter.GetType(), false);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 == 0 ? 1 : 1;
              continue;
            case 4:
              ReplacementRuleManager.lf8Hj3XULytt1jqnpVo(ReplacementRuleManager.tqfDKmXK3GdV9ccjJfe((object) this));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 3 : 0;
              continue;
            case 5:
            case 22:
              goto label_26;
            case 6:
            case 9:
            case 11:
              goto label_4;
            case 7:
              if (rule == null)
              {
                num2 = 6;
                continue;
              }
              goto case 21;
            case 8:
              if (entityFilter != null)
              {
                num2 = 20;
                continue;
              }
              goto label_11;
            case 10:
              goto label_27;
            case 12:
              if (!ReplacementRuleManager.UdmI5TXoTX12o7GJxXO(c, (Type) null))
              {
                num2 = 10;
                continue;
              }
              goto case 13;
            case 13:
              if (ReplacementRuleManager.UWCgoQXtBIRsMCTlnx1(type1, c))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc == 0 ? 22 : 12;
                continue;
              }
              goto case 17;
            case 14:
              goto label_11;
            case 15:
              entityFilter.Id = (object) Convert.ToInt64(entity.GetId());
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 0 : 0;
              continue;
            case 16:
              type1 = entity.GetType();
              num2 = 15;
              continue;
            case 17:
              if (type1.IsSubclassOf(c))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 5 : 5;
                continue;
              }
              goto label_27;
            case 18:
              entityFilter = (IEntityFilter) ReplacementRuleManager.moXx3jXbVlDliMns6Zn(ReplacementRuleManager.suUxBAXw2vr9KJeKtyH((object) rule), (object) null, (object) null, (object) null);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 7 : 8;
              continue;
            case 19:
              goto label_31;
            case 20:
              if (!saveAndFlush)
                goto case 3;
              else
                goto label_13;
            case 21:
              if (ReplacementRuleManager.suUxBAXw2vr9KJeKtyH((object) rule) == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec == 0 ? 11 : 1;
                continue;
              }
              goto case 2;
            case 23:
              type2 = (Type) null;
              break;
            case 24:
              entityManagerOrNull = ModelHelper.GetEntityManagerOrNull(type1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0 ? 19 : 19;
              continue;
            case 25:
              ((ISession) ReplacementRuleManager.tqfDKmXK3GdV9ccjJfe((object) this)).Flush();
              num2 = 4;
              continue;
            case 26:
              goto label_23;
            default:
              goto label_25;
          }
          c = type2;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed == 0 ? 10 : 16;
        }
label_13:
        num1 = 26;
        continue;
label_23:
        ReplacementRuleManager.wRqxs4GB0B26Kih5JKv((object) entity);
        num1 = 25;
        continue;
label_25:
        entityFilter.DisableSecurity = true;
        num1 = 24;
        continue;
label_31:
        if (entityManagerOrNull != null)
          num1 = 12;
        else
          goto label_27;
      }
label_4:
      return false;
label_11:
      return false;
label_26:
      return ReplacementRuleManager.A0hnWsXmrvch1UcAIMJ((object) entityManagerOrNull, (object) entityFilter) == 1L;
label_27:
      return false;
    }

    /// <summary>Изменить порядок согласно списка</summary>
    /// <param name="replacementId"></param>
    /// <param name="ruleList"></param>
    [Transaction]
    public virtual void Reorder(long replacementId, List<long> ruleList)
    {
      if (ReplacementManager.Instance.LoadOrNull(replacementId) == null)
        return;
      ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
      ruleList = ruleList ?? new List<long>();
      for (int index = 0; index < ruleList.Count; ++index)
        serviceNotNull.Update(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29763048 >> 5 ^ -950972), new string[1]
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(84189367 + 1997579375 ^ 2081814176)
        }, new object[1]{ (object) index }, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1859356887 ^ -1859337057), (object) serviceNotNull.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1567399832 << 6 ^ 1529304544)), (object) replacementId, (object) serviceNotNull.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2008710664 - -232311158 ^ -1776398662)), (object) ruleList[index]));
      string str = string.Join<long>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(781628008 - 11982093 ^ 769638487), (IEnumerable<long>) ruleList);
      serviceNotNull.Update(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--2002186503 ^ 2002141843), new string[1]
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1958138283 - -279956781 ^ -1678227452)
      }, new object[1]{ (object) int.MaxValue }, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-1362653258 ^ 1362674611), (object) serviceNotNull.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(617710536 ^ 617689128)), (object) replacementId, string.IsNullOrEmpty(str) ? (object) "" : (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~123928154 ^ -123882057), (object) serviceNotNull.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1702973981 - 773209001 ^ 1818785774)), (object) str)));
    }

    /// <summary>
    /// Находит все правила замещений на заданный период для указанных пользователей<br />
    /// если указан только параметр fromUser, то ищутся все замещения, где этот пользователь замещается<br />
    /// если указан только параметр toUser, то ищутся все замещения, где этот пользователь замещает<br />
    /// если указаны оба параметра, то ищутся все замещения, где пользователь toUser замещает или пользователь fromUser замещается или замещает
    /// </summary>
    /// <param name="fromUser">Замещаемый пользователь</param>
    /// <param name="toUser">Замещающий пользователь</param>
    /// <param name="startDate">Дата начала замещения</param>
    /// <param name="endDate">Дата оканчания</param>
    /// <param name="ignoreReplacementId">Идентификатор замещения, которое нужно игнорировать</param>
    /// <returns></returns>
    public virtual IList<IReplacementRule> FindPlannedReplacementRule(
      EleWise.ELMA.Security.IUser fromUser,
      EleWise.ELMA.Security.IUser toUser,
      DateTime? startDate,
      DateTime? endDate,
      long? ignoreReplacementId = null)
    {
      ICriteria criteria = this.CreateCriteria();
      criteria.CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1053060681 ^ 1053089193), z2jc63fLkugS1X8Q9N.tE1kD1vbB(447286529 ^ 447330625), JoinType.LeftOuterJoin);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      criteria.If(endDate.HasValue, (Func<ICriteria, ICriteria>) (c => c.Add((ICriterion) ReplacementRuleManager.\u003C\u003Ec__DisplayClass19_0.uWOYQUwswgWfwEHMFeaB(ReplacementRuleManager.\u003C\u003Ec__DisplayClass19_0.l7xNwPwsuOMgtC0vwYgP(1744916777 - 891549337 ^ 853306808), (object) endDate)))).If(startDate.HasValue, (Func<ICriteria, ICriteria>) (c => (ICriteria) ReplacementRuleManager.\u003C\u003Ec__DisplayClass19_0.JBcGS7wsKYarOiQELV86((object) c, ReplacementRuleManager.\u003C\u003Ec__DisplayClass19_0.BpZDL2wsb9JVZclCs2Fq(ReplacementRuleManager.\u003C\u003Ec__DisplayClass19_0.l7xNwPwsuOMgtC0vwYgP(-1958138283 - -279956781 ^ -1678225448), (object) startDate)))).Add((ICriterion) Restrictions.Not((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-347045778 ^ -347065304), (object) ReplacementStatus.Delete))).AddOrder(Order.Asc(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1212037053 ^ -1727812018 ^ -784519767)));
      if (fromUser != null && toUser != null)
        criteria.Add((ICriterion) Restrictions.Disjunction().Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1076316568 ^ 1076362728), (object) fromUser)).Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-901653144 ^ -901682716), (object) fromUser)).Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(868767899 ^ 868805867), (object) toUser)));
      else if (fromUser != null)
      {
        criteria.Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-278393783 ^ -278349767), (object) fromUser));
      }
      else
      {
        if (toUser == null)
          throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(84189367 + 1997579375 ^ 2081812866));
        criteria.Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~123928154 ^ -123882199), (object) toUser));
      }
      if (ignoreReplacementId.HasValue)
        criteria.Add((ICriterion) Restrictions.Not((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-757186336 ^ -757140392), (object) ignoreReplacementId.Value)));
      return criteria.SetCacheable(true).List<IReplacementRule>();
    }

    /// <summary>Проверить, есть ли у замещений правила</summary>
    /// <param name="replacement">Список замещений</param>
    /// <returns>Словарь, где key - id замещения, value - есть ли правила</returns>
    public IDictionary<long, bool> CheckIfReplacementsHaveRules(
      IList<IReplacement> replacement)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (IDictionary<long, bool>) this.CreateCriteria().CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1744916777 - 891549337 ^ 853404016), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1440374117 ^ -1440409893), JoinType.RightOuterJoin).Add((ICriterion) Restrictions.In(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17837901 ^ -17865717), (ICollection) replacement.Select<IReplacement, long>((Func<IReplacement, long>) (r => r.Id)).ToArray<long>())).SetProjection((IProjection) Projections.ProjectionList().Add((IProjection) Projections.GroupProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1277802350 ^ -1277756374))).Add((IProjection) Projections.Count(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1702973981 - 773209001 ^ 1818785774)))).List<object[]>().ToDictionary<object[], long, bool>((Func<object[], long>) (r => ReplacementRuleManager.\u003C\u003Ec.Xjajc6wstL2y5DlY5epc(r[0])), (Func<object[], bool>) (r => ReplacementRuleManager.\u003C\u003Ec.Xjajc6wstL2y5DlY5epc(r[1]) > 0L));
    }

    public ReplacementRuleManager()
    {
      ReplacementRuleManager.DDp8L9X6mgAvvojNgQQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool OGkHlaGME5l1QPBG69K([In] object obj0) => ((IEntity) obj0).IsNew();

    internal static object xgA9SLGhi2pk771FtxE() => (object) FetchOptions.All;

    internal static void wRqxs4GB0B26Kih5JKv([In] object obj0) => ((IEntity) obj0).Save();

    internal static bool jndoATGp4cicitwhXAJ([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool GhkQsvG9gAgGZmNIgjk() => ReplacementRuleManager.U5uEFaGXkqp7AIj55V5 == null;

    internal static ReplacementRuleManager o7CsQKG1VW2QtXRN9j0() => ReplacementRuleManager.U5uEFaGXkqp7AIj55V5;

    internal static object mRjV1AGOcytQKuurpKA([In] object obj0) => (object) ((EntityManager<IReplacementRule, long>) obj0).MetadataRuntimeService;

    internal static void WLJwkFGTImYsAdactC3([In] object obj0) => __nonvirtual (((NHManager) obj0).InitInternal());

    internal static object PWPANDGFVTVa97CFh1p(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object OdQ2NKGvmyYjXTgvuEK([In] Type obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Parameter(obj0, (string) obj1);

    internal static Type gviJvoGqJFBeSeRvVuf([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object ARcepKGgWSyvuASjyt2([In] object obj0, [In] Type obj1) => (object) System.Linq.Expressions.Expression.Constant(obj0, obj1);

    internal static object LR2vXOGJDZEuscYBbiL([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object js1r83GIS9iIQKIJTDv([In] object obj0, [In] object obj1, [In] object obj2) => (object) System.Linq.Expressions.Expression.Call((System.Linq.Expressions.Expression) obj0, (MethodInfo) obj1, (System.Linq.Expressions.Expression[]) obj2);

    internal static object IIYZWDGe92jki85iUk7() => (object) ReplacementRuleManager.Instance;

    internal static Guid SspoF8GnRVlG7yvv5K4([In] object obj0) => ((IReplacementRule) obj0).PropertyUid;

    internal static object wPAMcjGL8lLG1gY3YPV([In] object obj0) => (object) ((ICodeItemMetadata) obj0).DisplayName;

    internal static object nFfh4XG2C5PnBsn8msd([In] object obj0, Guid propertyUid) => (object) ((ReplacementRuleManager) obj0).ObjectForProperty(propertyUid);

    internal static Guid HVlooyGHpAJGdMEAo4E([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

    internal static Guid c7qLwSGz3cMiGX8XEpl([In] Type obj0, [In] bool obj1) => InterfaceActivator.UID(obj0, obj1);

    internal static object F3OLBnXullkSIKUwTnT([In] object obj0) => (object) ((IReplacementRule) obj0).TargetUser;

    internal static object suUxBAXw2vr9KJeKtyH([In] object obj0) => ((IReplacementRule) obj0).Filter;

    internal static object moXx3jXbVlDliMns6Zn([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) UniversalFilterSaver.UnPack(obj0, (ReferenceOnEntityType) obj1, (IEntityFilter) obj2, (ITypeWrapperResolver) obj3);

    internal static object tqfDKmXK3GdV9ccjJfe([In] object obj0) => (object) ((NHManagerBase) obj0).Session;

    internal static void lf8Hj3XULytt1jqnpVo([In] object obj0) => ((ISession) obj0).Flush();

    internal static Type CRpRexXR3L7rwDkFVkx([In] object obj0) => ((FilterForAttribute) obj0).EntityType;

    internal static bool UdmI5TXoTX12o7GJxXO([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool UWCgoQXtBIRsMCTlnx1([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static long A0hnWsXmrvch1UcAIMJ([In] object obj0, [In] object obj1) => ((IEntityManager) obj0).Count((IEntityFilter) obj1);

    internal static void DDp8L9X6mgAvvojNgQQ() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
