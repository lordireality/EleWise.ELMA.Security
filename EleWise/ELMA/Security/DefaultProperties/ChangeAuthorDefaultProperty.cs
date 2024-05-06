// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.DefaultProperties.ChangeAuthorDefaultProperty
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
  /// <summary>Свойство по умолчанию "Автор изменения"</summary>
  [Component(Order = 250)]
  internal class ChangeAuthorDefaultProperty : DefaultProperty
  {
    private readonly Guid changeAuthorDefaultPropertyUid;
    internal static ChangeAuthorDefaultProperty XptntFijrd0TrfeNaPG;

    /// <summary>Имя свойства (для текущей культуры)</summary>
    public override string Name => (string) ChangeAuthorDefaultProperty.qEuLCJiZoZ3DAdW085M((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1976147292 - 421656521 ^ 1897146179));

    /// <summary>Uid свойства</summary>
    public override Guid Uid => this.changeAuthorDefaultPropertyUid;

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
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              base.InitProperty(classMetadata, propertyMetadata);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 == 0 ? 0 : 0;
              continue;
            case 2:
              List<ViewAttribute> attributes1 = ((PropertyViewSettings) ChangeAuthorDefaultProperty.TRp8XoiAkHXGbfFPfOK((object) propertyMetadata)).Attributes;
              ViewAttribute viewAttribute1 = new ViewAttribute();
              ChangeAuthorDefaultProperty.tEkRx5iWS5JOjfWvSoJ((object) viewAttribute1, ViewType.Display);
              ChangeAuthorDefaultProperty.yJbyoxi7qAGpic0NIwD((object) viewAttribute1, Visibility.Visible);
              attributes1.Add(viewAttribute1);
              num2 = 4;
              continue;
            case 3:
              goto label_4;
            case 4:
              List<ViewAttribute> attributes2 = ((PropertyViewSettings) ChangeAuthorDefaultProperty.TRp8XoiAkHXGbfFPfOK((object) propertyMetadata)).Attributes;
              ViewAttribute viewAttribute2 = new ViewAttribute();
              ChangeAuthorDefaultProperty.tEkRx5iWS5JOjfWvSoJ((object) viewAttribute2, ViewType.List);
              viewAttribute2.Visibility = Visibility.Hidden;
              attributes2.Add(viewAttribute2);
              num2 = 6;
              continue;
            case 5:
              List<ViewAttribute> attributes3 = ((PropertyViewSettings) ChangeAuthorDefaultProperty.TRp8XoiAkHXGbfFPfOK((object) propertyMetadata)).Attributes;
              ViewAttribute viewAttribute3 = new ViewAttribute();
              ChangeAuthorDefaultProperty.tEkRx5iWS5JOjfWvSoJ((object) viewAttribute3, ViewType.Edit);
              ChangeAuthorDefaultProperty.yJbyoxi7qAGpic0NIwD((object) viewAttribute3, Visibility.Visible);
              ChangeAuthorDefaultProperty.BubxmMirMbkbNuBag1N((object) viewAttribute3, true);
              attributes3.Add(viewAttribute3);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 1 : 2;
              continue;
            case 6:
              goto label_3;
            default:
              ChangeAuthorDefaultProperty.D2aXO4is4MfiJCr8yYN((object) ((PropertyViewSettings) ChangeAuthorDefaultProperty.TRp8XoiAkHXGbfFPfOK((object) propertyMetadata)).Attributes);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b != 0 ? 3 : 2;
              continue;
          }
        }
label_4:
        List<ViewAttribute> attributes4 = ((PropertyViewSettings) ChangeAuthorDefaultProperty.TRp8XoiAkHXGbfFPfOK((object) propertyMetadata)).Attributes;
        ViewAttribute viewAttribute4 = new ViewAttribute();
        viewAttribute4.ViewType = ViewType.Create;
        ChangeAuthorDefaultProperty.yJbyoxi7qAGpic0NIwD((object) viewAttribute4, Visibility.Hidden);
        attributes4.Add(viewAttribute4);
        num1 = 5;
      }
label_3:;
    }

    /// <summary>
    /// Определяет имя свойства, по которому определяется доступность свойства (в методе IsAvailableFor)
    /// </summary>
    protected override string PropertyName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(19590779 ^ 19571649);

    /// <summary>UID типа данных</summary>
    protected override Guid TypeUid => EntityDescriptor.UID;

    /// <summary>UID подтипа</summary>
    protected override Guid SubTypeUid => new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(911364681 ^ 911347807));

    /// <summary>Получить настройки типа данных</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Настройки типа данных</returns>
    protected override TypeSettings GetTypeSettings(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata)
    {
      EntitySettings typeSettings = new EntitySettings();
      ChangeAuthorDefaultProperty.GYoQGriSgVKRAk2ubrD((object) typeSettings, (object) this.PropertyName);
      return (TypeSettings) typeSettings;
    }

    /// <summary>Доступно ли свойство для фильтра</summary>
    protected override bool Filterable => true;

    /// <summary>UID обработчика</summary>
    protected override Guid HandlerUid => ChangeAuthorPropertyHandler.UID;

    public ChangeAuthorDefaultProperty()
    {
      ChangeAuthorDefaultProperty.kXs0aaiYtc2huPvEqw0();
      this.changeAuthorDefaultPropertyUid = new Guid((string) ChangeAuthorDefaultProperty.TwH7deiyXnEsQjlyTxI(-845204010 ^ 2052495102 ^ -1211502850));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object qEuLCJiZoZ3DAdW085M([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool vEY4tgiNgZertc5sUIK() => ChangeAuthorDefaultProperty.XptntFijrd0TrfeNaPG == null;

    internal static ChangeAuthorDefaultProperty wsX2hei06PD2WoDHZHn() => ChangeAuthorDefaultProperty.XptntFijrd0TrfeNaPG;

    internal static object TRp8XoiAkHXGbfFPfOK([In] object obj0) => (object) ((PropertyMetadata) obj0).ViewSettings;

    internal static void D2aXO4is4MfiJCr8yYN([In] object obj0) => ((List<ViewAttribute>) obj0).Clear();

    internal static void yJbyoxi7qAGpic0NIwD([In] object obj0, [In] Visibility obj1) => ((ViewAttribute) obj0).Visibility = obj1;

    internal static void tEkRx5iWS5JOjfWvSoJ([In] object obj0, [In] ViewType obj1) => ((ViewAttribute) obj0).ViewType = obj1;

    internal static void BubxmMirMbkbNuBag1N([In] object obj0, [In] bool obj1) => ((ViewAttribute) obj0).ReadOnly = obj1;

    internal static void GYoQGriSgVKRAk2ubrD([In] object obj0, [In] object obj1) => ((SimpleTypeSettings) obj0).FieldName = (string) obj1;

    internal static void kXs0aaiYtc2huPvEqw0() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static object TwH7deiyXnEsQjlyTxI(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
