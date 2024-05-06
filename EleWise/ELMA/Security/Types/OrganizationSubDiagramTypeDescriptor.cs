// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Types.OrganizationSubDiagramTypeDescriptor
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security.Diagrams;
using EleWise.ELMA.Security.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Types
{
  /// <summary>Тип "Диаграмма оргструктуры"</summary>
  public class OrganizationSubDiagramTypeDescriptor : 
    CLRTypeDescriptor<OrganizationSubDiagram, OrganizationSubDiagramTypeSettings>
  {
    public const string UID_S = "{1F571770-0498-4192-A076-C987A3A265F8}";
    public static readonly Guid UID;
    private static OrganizationSubDiagramTypeDescriptor zZxD6iahUTSKYn8UAft;

    /// <summary>Uid типа</summary>
    public override Guid Uid => OrganizationSubDiagramTypeDescriptor.UID;

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <summary>Имя "Диаграмма оргструктуры"</summary>
    public override string Name => (string) OrganizationSubDiagramTypeDescriptor.aoLYn7aTOUsb6KOoFFv(OrganizationSubDiagramTypeDescriptor.QkrHYLaOUWQ5SDko3uo(2086891181 ^ 2086874921));

    /// <inheritdoc />
    public override bool Visible
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (base.Visible)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e == 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 2:
              goto label_4;
            default:
              if (MetadataAccessInfo.EnvironmentType != MetadataEnvironmentType.VisualStudio)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0 ? 2 : 1;
                continue;
              }
              goto label_5;
          }
        }
label_4:
        return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
label_5:
        return true;
label_6:
        return false;
      }
    }

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

    public OrganizationSubDiagramTypeDescriptor()
    {
      OrganizationSubDiagramTypeDescriptor.NeJiowaFRfu1b1wLpoC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static OrganizationSubDiagramTypeDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            OrganizationSubDiagramTypeDescriptor.UID = new Guid((string) OrganizationSubDiagramTypeDescriptor.QkrHYLaOUWQ5SDko3uo(1940240517 ^ 974551502 ^ 1236500621));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object QkrHYLaOUWQ5SDko3uo(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object aoLYn7aTOUsb6KOoFFv([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool I8g4JZaBn2ATk5gnECu() => OrganizationSubDiagramTypeDescriptor.zZxD6iahUTSKYn8UAft == null;

    internal static OrganizationSubDiagramTypeDescriptor hlARWQapSQV2omlnFcv() => OrganizationSubDiagramTypeDescriptor.zZxD6iahUTSKYn8UAft;

    internal static void NeJiowaFRfu1b1wLpoC() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
