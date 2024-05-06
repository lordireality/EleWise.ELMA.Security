// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.CommonRoleTypes
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CSharp.RuntimeBinder;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  [Component]
  public class CommonRoleTypes : IPermissionRoleTypeProvider
  {
    /// <summary>Все пользователи</summary>
    public static readonly PermissionRoleType AllUsers;
    /// <summary>Пользователь</summary>
    public static readonly PermissionRoleType User;
    /// <summary>Группа</summary>
    public static readonly PermissionRoleType Group;
    /// <summary>Элемент оргструктуры</summary>
    public static readonly PermissionRoleType OrganizationItem;
    /// <summary>Автор</summary>
    public static readonly PermissionRoleType Author;
    /// <summary>Ответственный</summary>
    public static readonly PermissionRoleType Responsible;
    /// <summary>Участники работ</summary>
    public static readonly PermissionRoleType ParticipantWork;
    /// <summary>Информируемые</summary>
    public static readonly PermissionRoleType Informs;
    /// <summary>Свойство</summary>
    public static readonly PermissionRoleType Property;
    internal static CommonRoleTypes rBBKanUq96VXgwstyXo;

    public IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes() => (IEnumerable<PermissionRoleTypeStereotype>) EmptyArray<PermissionRoleTypeStereotype>.Instance;

    public IEnumerable<PermissionRoleType> GetRoleTypes() => (IEnumerable<PermissionRoleType>) new PermissionRoleType[6]
    {
      CommonRoleTypes.AllUsers,
      CommonRoleTypes.Group,
      CommonRoleTypes.OrganizationItem,
      CommonRoleTypes.User,
      CommonRoleTypes.Author,
      CommonRoleTypes.Property
    };

    public List<string> LocalizedItemNames() => new List<string>();

    public CommonRoleTypes()
    {
      CommonRoleTypes.FI84tnUIRtrnNkmJvZV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static CommonRoleTypes()
    {
      int num1 = 9;
      while (true)
      {
        switch (num1)
        {
          case 1:
            CommonRoleTypes.Responsible = new PermissionRoleType(new Guid((string) CommonRoleTypes.g4mWJuUeoWRFpri7Jvt(-1540570615 - 1746246777 ^ 1008140314)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1893095749 ^ -1893104787), InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>(), (Func<object, IEntity>) (e =>
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 2:
                    // ISSUE: reference to a compiler-generated field
                    if (CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__3 != null)
                    {
                      num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 1 : 1;
                      continue;
                    }
                    goto case 3;
                  case 3:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__3 = CallSite<Func<CallSite, object, IEntity>>.Create((CallSiteBinder) CommonRoleTypes.\u003C\u003Ec.Fv7y9qwt0nMATdvQWt9l(CSharpBinderFlags.ConvertExplicit, CommonRoleTypes.\u003C\u003Ec.fAtutiwtNo0iA6UK5Gf7(__typeref (IEntity)), CommonRoleTypes.\u003C\u003Ec.fAtutiwtNo0iA6UK5Gf7(__typeref (CommonRoleTypes))));
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_5;
                }
              }
label_5:
              // ISSUE: reference to a compiler-generated field
              Func<CallSite, object, IEntity> target = CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__3.Target;
              // ISSUE: reference to a compiler-generated field
              CallSite<Func<CallSite, object, IEntity>> p3 = CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__3;
              // ISSUE: reference to a compiler-generated field
              if (CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: type reference
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, (string) CommonRoleTypes.\u003C\u003Ec.UVYVS7wtA9Goq9hH8ham(-1527733619 - 442652394 ^ -1970313885), CommonRoleTypes.\u003C\u003Ec.fAtutiwtNo0iA6UK5Gf7(__typeref (CommonRoleTypes)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                {
                  (CSharpArgumentInfo) CommonRoleTypes.\u003C\u003Ec.O5vmBewtZBLWBducPriU(CSharpArgumentInfoFlags.None, (object) null)
                }));
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              object obj = CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__2.Target((CallSite) CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__2, e);
              return target((CallSite) p3, obj);
            }));
            num1 = 2;
            continue;
          case 2:
            CommonRoleTypes.ParticipantWork = new PermissionRoleType(new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1640694811 << 2 ^ 2027145824)), (string) CommonRoleTypes.g4mWJuUeoWRFpri7Jvt(-1536327508 ^ -1536317716), InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>(), (Func<object, IEntity>) (e =>
            {
              int num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated field
                    if (CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__5 == null)
                    {
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_5;
                  case 2:
                    goto label_5;
                  default:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__5 = CallSite<Func<CallSite, object, IEntity>>.Create((CallSiteBinder) CommonRoleTypes.\u003C\u003Ec.Fv7y9qwt0nMATdvQWt9l(CSharpBinderFlags.ConvertExplicit, CommonRoleTypes.\u003C\u003Ec.fAtutiwtNo0iA6UK5Gf7(__typeref (IEntity)), CommonRoleTypes.\u003C\u003Ec.fAtutiwtNo0iA6UK5Gf7(__typeref (CommonRoleTypes))));
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 1 : 2;
                    continue;
                }
              }
label_5:
              // ISSUE: reference to a compiler-generated field
              Func<CallSite, object, IEntity> target = CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__5.Target;
              // ISSUE: reference to a compiler-generated field
              CallSite<Func<CallSite, object, IEntity>> p5 = CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__5;
              // ISSUE: reference to a compiler-generated field
              if (CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__4 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: type reference
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__4 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1677147940 ^ 1677160706), CommonRoleTypes.\u003C\u003Ec.fAtutiwtNo0iA6UK5Gf7(__typeref (CommonRoleTypes)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                {
                  (CSharpArgumentInfo) CommonRoleTypes.\u003C\u003Ec.O5vmBewtZBLWBducPriU(CSharpArgumentInfoFlags.None, (object) null)
                }));
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              object obj = CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__4.Target((CallSite) CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__4, e);
              return target((CallSite) p5, obj);
            }));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 == 0 ? 4 : 3;
            continue;
          case 3:
            CommonRoleTypes.Group = new PermissionRoleType(new Guid((string) CommonRoleTypes.g4mWJuUeoWRFpri7Jvt(1658561670 << 4 ^ 767191936)), (string) CommonRoleTypes.biMvGAUnEA4cWOmArAH(CommonRoleTypes.g4mWJuUeoWRFpri7Jvt(84189367 + 1997579375 ^ 2081775882)), InterfaceActivator.TypeOf<IUserGroup>(), (string) CommonRoleTypes.g4mWJuUeoWRFpri7Jvt(~-272519830 ^ 272529065), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-278393783 ^ -278386659));
            num1 = 7;
            continue;
          case 4:
            CommonRoleTypes.Informs = new PermissionRoleType(new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(868767899 ^ 868777677)), (string) CommonRoleTypes.g4mWJuUeoWRFpri7Jvt(1690209562 ^ 116876444 ^ 1649004324), InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>(), (Func<object, IEntity>) (e =>
            {
              int num4 = 2;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__7 = CallSite<Func<CallSite, object, IEntity>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, CommonRoleTypes.\u003C\u003Ec.fAtutiwtNo0iA6UK5Gf7(__typeref (IEntity)), CommonRoleTypes.\u003C\u003Ec.fAtutiwtNo0iA6UK5Gf7(__typeref (CommonRoleTypes))));
                    num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    // ISSUE: reference to a compiler-generated field
                    if (CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__7 == null)
                    {
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 1 : 0;
                      continue;
                    }
                    goto label_5;
                  default:
                    goto label_5;
                }
              }
label_5:
              // ISSUE: reference to a compiler-generated field
              Func<CallSite, object, IEntity> target = CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__7.Target;
              // ISSUE: reference to a compiler-generated field
              CallSite<Func<CallSite, object, IEntity>> p7 = CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__7;
              // ISSUE: reference to a compiler-generated field
              if (CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__6 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__6 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, z2jc63fLkugS1X8Q9N.tE1kD1vbB(868767899 ^ 868751037), typeof (CommonRoleTypes), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                {
                  (CSharpArgumentInfo) CommonRoleTypes.\u003C\u003Ec.O5vmBewtZBLWBducPriU(CSharpArgumentInfoFlags.None, (object) null)
                }));
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              object obj = CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__6.Target((CallSite) CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__6, e);
              return target((CallSite) p7, obj);
            }));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 == 0 ? 0 : 0;
            continue;
          case 5:
            CommonRoleTypes.Author = new PermissionRoleType(new Guid((string) CommonRoleTypes.g4mWJuUeoWRFpri7Jvt(~-192923496 ^ 192930391)), (string) CommonRoleTypes.biMvGAUnEA4cWOmArAH(CommonRoleTypes.g4mWJuUeoWRFpri7Jvt(1690209562 ^ 116876444 ^ 1649003770)), InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>(), (Func<object, IEntity>) (e =>
            {
              int num5 = 2;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                  case 3:
                    goto label_5;
                  case 2:
                    // ISSUE: reference to a compiler-generated field
                    if (CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__1 != null)
                    {
                      num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 != 0 ? 1 : 0;
                      continue;
                    }
                    break;
                }
                // ISSUE: reference to a compiler-generated field
                // ISSUE: type reference
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, IEntity>>.Create((CallSiteBinder) CommonRoleTypes.\u003C\u003Ec.Fv7y9qwt0nMATdvQWt9l(CSharpBinderFlags.ConvertExplicit, typeof (IEntity), CommonRoleTypes.\u003C\u003Ec.fAtutiwtNo0iA6UK5Gf7(__typeref (CommonRoleTypes))));
                num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 == 0 ? 3 : 3;
              }
label_5:
              // ISSUE: reference to a compiler-generated field
              Func<CallSite, object, IEntity> target = CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__1.Target;
              // ISSUE: reference to a compiler-generated field
              CallSite<Func<CallSite, object, IEntity>> p1 = CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__1;
              // ISSUE: reference to a compiler-generated field
              if (CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__0 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1200636245 >> 6 ^ 18747171), typeof (CommonRoleTypes), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                {
                  (CSharpArgumentInfo) CommonRoleTypes.\u003C\u003Ec.O5vmBewtZBLWBducPriU(CSharpArgumentInfoFlags.None, (object) null)
                }));
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              object obj = CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__0.Target((CallSite) CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__0, e);
              return target((CallSite) p1, obj);
            }));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 == 0 ? 0 : 1;
            continue;
          case 6:
            CommonRoleTypes.User = new PermissionRoleType(new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-522456341 ^ -522464815)), (string) CommonRoleTypes.biMvGAUnEA4cWOmArAH(CommonRoleTypes.g4mWJuUeoWRFpri7Jvt(-845204010 ^ 2052495102 ^ -1211531090)), InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>(), (string) CommonRoleTypes.g4mWJuUeoWRFpri7Jvt(--306199571 ^ 306192183), (string) CommonRoleTypes.g4mWJuUeoWRFpri7Jvt(908197830 ^ 908188772));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 3 : 1;
            continue;
          case 7:
            CommonRoleTypes.OrganizationItem = new PermissionRoleType(new Guid((string) CommonRoleTypes.g4mWJuUeoWRFpri7Jvt(1841261835 ^ 1841252759)), (string) CommonRoleTypes.biMvGAUnEA4cWOmArAH(CommonRoleTypes.g4mWJuUeoWRFpri7Jvt(84189367 + 1997579375 ^ 2081776078)), InterfaceActivator.TypeOf<IOrganizationItem>(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-909559362 ^ -398405015 ^ 562679491));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 != 0 ? 5 : 5;
            continue;
          case 8:
            CommonRoleTypes.AllUsers = new PermissionRoleType(new Guid((string) CommonRoleTypes.g4mWJuUeoWRFpri7Jvt(-1743015995 ^ -1743024783)), (string) CommonRoleTypes.biMvGAUnEA4cWOmArAH(CommonRoleTypes.g4mWJuUeoWRFpri7Jvt(-1958977588 ^ -1958970164)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1702973981 - 773209001 ^ 1818775838));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 5 : 6;
            continue;
          case 9:
            CommonRoleTypes.FI84tnUIRtrnNkmJvZV();
            num1 = 8;
            continue;
          case 10:
            goto label_2;
          default:
            CommonRoleTypes.Property = new PermissionRoleType(new Guid((string) CommonRoleTypes.g4mWJuUeoWRFpri7Jvt(1567399832 << 6 ^ 1529331904)), (string) CommonRoleTypes.g4mWJuUeoWRFpri7Jvt(-2143851882 - 923330995 ^ 1227794415), InterfaceActivator.TypeOf<IPropertyMetadata>(), (Func<object, IEntity>) (e =>
            {
              int num6 = 1;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated field
                    if (CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__10 == null)
                    {
                      num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_5;
                  case 2:
                    goto label_5;
                  default:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__10 = CallSite<Func<CallSite, object, Guid>>.Create((CallSiteBinder) CommonRoleTypes.\u003C\u003Ec.Fv7y9qwt0nMATdvQWt9l(CSharpBinderFlags.ConvertExplicit, CommonRoleTypes.\u003C\u003Ec.fAtutiwtNo0iA6UK5Gf7(__typeref (Guid)), CommonRoleTypes.\u003C\u003Ec.fAtutiwtNo0iA6UK5Gf7(__typeref (CommonRoleTypes))));
                    num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 == 0 ? 2 : 1;
                    continue;
                }
              }
label_5:
              // ISSUE: reference to a compiler-generated field
              Func<CallSite, object, Guid> target1 = CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__10.Target;
              // ISSUE: reference to a compiler-generated field
              CallSite<Func<CallSite, object, Guid>> p10 = CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__10;
              // ISSUE: reference to a compiler-generated field
              if (CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__9 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: type reference
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__9 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, (string) CommonRoleTypes.\u003C\u003Ec.UVYVS7wtA9Goq9hH8ham(-2008710664 - -232311158 ^ -1776327244), CommonRoleTypes.\u003C\u003Ec.fAtutiwtNo0iA6UK5Gf7(__typeref (CommonRoleTypes)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                {
                  (CSharpArgumentInfo) CommonRoleTypes.\u003C\u003Ec.O5vmBewtZBLWBducPriU(CSharpArgumentInfoFlags.None, (object) null)
                }));
              }
              // ISSUE: reference to a compiler-generated field
              Func<CallSite, object, object> target2 = CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__9.Target;
              // ISSUE: reference to a compiler-generated field
              CallSite<Func<CallSite, object, object>> p9 = CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__9;
              // ISSUE: reference to a compiler-generated field
              if (CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__8 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: type reference
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__8 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, (string) CommonRoleTypes.\u003C\u003Ec.UVYVS7wtA9Goq9hH8ham(1100789287 - 1555711667 ^ -454868584), CommonRoleTypes.\u003C\u003Ec.fAtutiwtNo0iA6UK5Gf7(__typeref (CommonRoleTypes)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                {
                  (CSharpArgumentInfo) CommonRoleTypes.\u003C\u003Ec.O5vmBewtZBLWBducPriU(CSharpArgumentInfoFlags.None, (object) null)
                }));
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              object obj1 = CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__8.Target((CallSite) CommonRoleTypes.\u003C\u003Eo__13.\u003C\u003Ep__8, e);
              object obj2 = target2((CallSite) p9, obj1);
              // ISSUE: reference to a compiler-generated method
              return (IEntity) (CommonRoleTypes.\u003C\u003Ec.pQue0mwts66xP1epxOsK(target1((CallSite) p10, obj2), true, true) as EntityMetadata);
            }), (string) CommonRoleTypes.g4mWJuUeoWRFpri7Jvt(839394233 ^ 839386265), string.Empty);
            num1 = 10;
            continue;
        }
      }
label_2:;
    }

    internal static void FI84tnUIRtrnNkmJvZV() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool rNtwMUUgcKu8BaaEmFX() => CommonRoleTypes.rBBKanUq96VXgwstyXo == null;

    internal static CommonRoleTypes Dqv5rnUJhIubucX7ZcP() => CommonRoleTypes.rBBKanUq96VXgwstyXo;

    internal static object g4mWJuUeoWRFpri7Jvt(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object biMvGAUnEA4cWOmArAH([In] object obj0) => (object) EleWise.ELMA.SR.M((string) obj0);
  }
}
