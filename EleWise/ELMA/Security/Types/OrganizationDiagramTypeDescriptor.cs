// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Types.OrganizationDiagramTypeDescriptor
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security.Diagrams;
using EleWise.ELMA.Security.Types.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Types
{
  /// <summary>Тип "Диаграмма оргструктуры"</summary>
  public class OrganizationDiagramTypeDescriptor : 
    CLRTypeDescriptor<OrganizationDiagram, OrganizationDiagramTypeSettings>
  {
    public const string UID_S = "{C977BD31-07D1-4BA2-AB9C-5049D363A923}";
    public static readonly Guid UID;
    private static OrganizationDiagramTypeDescriptor ve13g6xw8QNnw4G4Ggf;

    /// <summary>Uid типа</summary>
    public override Guid Uid => OrganizationDiagramTypeDescriptor.UID;

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <summary>Имя "Диаграмма оргструктуры"</summary>
    public override string Name => EleWise.ELMA.SR.T((string) OrganizationDiagramTypeDescriptor.wDS76xxUssyKPcS9NZg(~-1362653258 ^ 1362637355));

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="entityMetadata">Метаданные сущности (не может быть NULL)</param>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.Binary);
    }

    /// <summary>
    /// Получить сериализуемые значения для значения свойства данного типа
    /// </summary>
    /// <param name="obj">Объект, содержащий свойство данного типа</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="serializationSettings">Настройки сериализации</param>
    /// <returns>Словарь сериализуемых значений</returns>
    public override IDictionary<string, object> Serialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      EntitySerializationSettings serializationSettings)
    {
      if (obj == null)
        return (IDictionary<string, object>) null;
      if (metadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1212037053 ^ -1727812018 ^ -784475295));
      if (propertyMetadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1687460816 ^ 1687476598));
      obj = obj.CastAsRealType();
      PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
      if (property == (PropertyInfo) null || !property.CanRead)
        return (IDictionary<string, object>) null;
      object obj1 = property.GetValue(obj, (object[]) null);
      SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
      if (obj1 != null)
        serializableDictionary[propertyMetadata.Name] = obj1;
      return (IDictionary<string, object>) serializableDictionary;
    }

    /// <inheritdoc />
    public override bool Visible
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (MetadataAccessInfo.EnvironmentType != MetadataEnvironmentType.VisualStudio)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              if (OrganizationDiagramTypeDescriptor.NUyYr5xR7VLviknkM3y((object) this))
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0 ? 1 : 0;
                continue;
              }
              goto label_4;
            default:
              goto label_2;
          }
        }
label_2:
        return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
label_3:
        return true;
label_4:
        return false;
      }
    }

    public OrganizationDiagramTypeDescriptor()
    {
      OrganizationDiagramTypeDescriptor.G2BxlhxoDt2bOG3fGan();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static OrganizationDiagramTypeDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            OrganizationDiagramTypeDescriptor.UID = new Guid((string) OrganizationDiagramTypeDescriptor.wDS76xxUssyKPcS9NZg(1687460816 ^ 1687476506));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 != 0 ? 0 : 0;
            continue;
          case 2:
            OrganizationDiagramTypeDescriptor.G2BxlhxoDt2bOG3fGan();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object wDS76xxUssyKPcS9NZg(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool HbkU5Wxbif2iey0wsPm() => OrganizationDiagramTypeDescriptor.ve13g6xw8QNnw4G4Ggf == null;

    internal static OrganizationDiagramTypeDescriptor UDXT5BxKwyiiVXh8GBI() => OrganizationDiagramTypeDescriptor.ve13g6xw8QNnw4G4Ggf;

    internal static bool NUyYr5xR7VLviknkM3y([In] object obj0) => __nonvirtual (((TypeDescriptor) obj0).Visible);

    internal static void G2BxlhxoDt2bOG3fGan() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
