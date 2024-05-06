// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.DefaultProperties.CreationAuthorDefaultProperty
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.DefaultProperties;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.PropertyHandlers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.DefaultProperties
{
  /// <summary>Свойство по умолчанию "Автор создания"</summary>
  [Component(Order = 150)]
  internal class CreationAuthorDefaultProperty : DefaultProperty
  {
    private readonly Guid creationAuthorDefaultPropertyUid;
    private static CreationAuthorDefaultProperty hnpTvjiV3DTOJWhSIhA;

    /// <summary>Имя свойства (для текущей культуры)</summary>
    public override string Name => (string) CreationAuthorDefaultProperty.IERjBlicuKcDPxIQWdx(CreationAuthorDefaultProperty.wt3SbIi4Vq2ZvGIT8oD(-1788783669 - 1293477238 ^ 1212687469));

    /// <summary>Uid свойства</summary>
    public override Guid Uid => this.creationAuthorDefaultPropertyUid;

    /// <summary>
    /// Включена ли галочка использования данного свойства по умолчанию
    /// </summary>
    public override bool DefaultChecked => true;

    /// <summary>Инициализировать метаданные свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    public override void InitProperty(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            List<ViewAttribute> attributes1 = ((PropertyViewSettings) CreationAuthorDefaultProperty.CRkcyuiQpGhBXi85Zxm((object) propertyMetadata)).Attributes;
            ViewAttribute viewAttribute1 = new ViewAttribute();
            CreationAuthorDefaultProperty.nuHh2ui52fTyxdR05gw((object) viewAttribute1, ViewType.List);
            CreationAuthorDefaultProperty.FWyawUidjrScugv3CuR((object) viewAttribute1, Visibility.Hidden);
            attributes1.Add(viewAttribute1);
            num = 6;
            continue;
          case 2:
            List<ViewAttribute> attributes2 = ((PropertyViewSettings) CreationAuthorDefaultProperty.CRkcyuiQpGhBXi85Zxm((object) propertyMetadata)).Attributes;
            ViewAttribute viewAttribute2 = new ViewAttribute();
            CreationAuthorDefaultProperty.nuHh2ui52fTyxdR05gw((object) viewAttribute2, ViewType.Edit);
            CreationAuthorDefaultProperty.FWyawUidjrScugv3CuR((object) viewAttribute2, Visibility.Visible);
            CreationAuthorDefaultProperty.MYBhDgiEBv3aebFMjxO((object) viewAttribute2, true);
            attributes2.Add(viewAttribute2);
            num = 5;
            continue;
          case 3:
            CreationAuthorDefaultProperty.B8fTgDi8YCs4BEC3eIm((object) ((PropertyViewSettings) CreationAuthorDefaultProperty.CRkcyuiQpGhBXi85Zxm((object) propertyMetadata)).Attributes);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d != 0 ? 0 : 0;
            continue;
          case 4:
            CreationAuthorDefaultProperty.QOXSXciPooo5orjdlfr((object) this, (object) classMetadata, (object) propertyMetadata);
            num = 3;
            continue;
          case 5:
            List<ViewAttribute> attributes3 = propertyMetadata.ViewSettings.Attributes;
            ViewAttribute viewAttribute3 = new ViewAttribute();
            CreationAuthorDefaultProperty.nuHh2ui52fTyxdR05gw((object) viewAttribute3, ViewType.Display);
            viewAttribute3.Visibility = Visibility.Visible;
            attributes3.Add(viewAttribute3);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 != 0 ? 0 : 1;
            continue;
          case 6:
            goto label_2;
          default:
            List<ViewAttribute> attributes4 = ((PropertyViewSettings) CreationAuthorDefaultProperty.CRkcyuiQpGhBXi85Zxm((object) propertyMetadata)).Attributes;
            ViewAttribute viewAttribute4 = new ViewAttribute();
            CreationAuthorDefaultProperty.nuHh2ui52fTyxdR05gw((object) viewAttribute4, ViewType.Create);
            viewAttribute4.Visibility = Visibility.Hidden;
            attributes4.Add(viewAttribute4);
            num = 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Определяет имя свойства, по которому определяется доступность свойства (в методе IsAvailableFor)
    /// </summary>
    protected override string PropertyName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(386642440 ^ 386661422);

    /// <summary>UID типа данных</summary>
    protected override Guid TypeUid => EntityDescriptor.UID;

    /// <summary>UID подтипа</summary>
    protected override Guid SubTypeUid => new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(839394233 ^ 839410095));

    /// <summary>Получить настройки типа данных</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Настройки типа данных</returns>
    protected override TypeSettings GetTypeSettings(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata)
    {
      EntitySettings typeSettings = new EntitySettings();
      CreationAuthorDefaultProperty.DMx4vriGrC17LIa5dX2((object) typeSettings, (object) this.PropertyName);
      return (TypeSettings) typeSettings;
    }

    /// <summary>Доступно ли свойство для фильтра</summary>
    protected override bool Filterable => true;

    /// <summary>UID обработчика</summary>
    protected override Guid HandlerUid => CreationAuthorPropertyHandler.UID;

    public CreationAuthorDefaultProperty()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      this.creationAuthorDefaultPropertyUid = new Guid((string) CreationAuthorDefaultProperty.wt3SbIi4Vq2ZvGIT8oD(1076316568 ^ 1076299742));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object wt3SbIi4Vq2ZvGIT8oD(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object IERjBlicuKcDPxIQWdx([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool q71UigilJXbhj2jLDFO() => CreationAuthorDefaultProperty.hnpTvjiV3DTOJWhSIhA == null;

    internal static CreationAuthorDefaultProperty YG0LkCifF7FwE6wDwYR() => CreationAuthorDefaultProperty.hnpTvjiV3DTOJWhSIhA;

    internal static void QOXSXciPooo5orjdlfr([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((DefaultProperty) obj0).InitProperty((ClassMetadata) obj1, (PropertyMetadata) obj2));

    internal static object CRkcyuiQpGhBXi85Zxm([In] object obj0) => (object) ((PropertyMetadata) obj0).ViewSettings;

    internal static void B8fTgDi8YCs4BEC3eIm([In] object obj0) => ((List<ViewAttribute>) obj0).Clear();

    internal static void nuHh2ui52fTyxdR05gw([In] object obj0, [In] ViewType obj1) => ((ViewAttribute) obj0).ViewType = obj1;

    internal static void FWyawUidjrScugv3CuR([In] object obj0, [In] Visibility obj1) => ((ViewAttribute) obj0).Visibility = obj1;

    internal static void MYBhDgiEBv3aebFMjxO([In] object obj0, [In] bool obj1) => ((ViewAttribute) obj0).ReadOnly = obj1;

    internal static void DMx4vriGrC17LIa5dX2([In] object obj0, [In] object obj1) => ((SimpleTypeSettings) obj0).FieldName = (string) obj1;
  }
}
