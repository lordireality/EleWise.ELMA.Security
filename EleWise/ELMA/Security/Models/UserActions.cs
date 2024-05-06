// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.UserActions
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Действия для объекта "Пользователь"</summary>
  public class UserActions : DefaultEntityActions
  {
    /// <summary>Блокировать</summary>
    /// <remarks>Блокировать учетную запись пользователя</remarks>
    [Image(typeof (UserActions), "lock", 16, ImageFormatType.IconPack, false)]
    [Description(typeof (__Resources_UserActions), "P_Block_Description")]
    [Uid("baf28d51-cab7-4fd2-9bcb-4a7d44e3ad05")]
    [DisplayName(typeof (__Resources_UserActions), "P_Block_DisplayName")]
    public const string Block = "baf28d51-cab7-4fd2-9bcb-4a7d44e3ad05";
    private static Guid _blockGuid;
    /// <summary>Разблокировать</summary>
    /// <remarks>Разблокировать учетную запись пользователя</remarks>
    [Image(typeof (UserActions), "unlock", 16, ImageFormatType.IconPack, false)]
    [Description(typeof (__Resources_UserActions), "P_UnBlock_Description")]
    [Uid("90387e19-8ba0-4e47-a7b3-3d690bbe0431")]
    [DisplayName(typeof (__Resources_UserActions), "P_UnBlock_DisplayName")]
    public const string UnBlock = "90387e19-8ba0-4e47-a7b3-3d690bbe0431";
    private static Guid _unBlockGuid;
    /// <summary>Сменить пароль</summary>
    [DisplayName(typeof (__Resources_UserActions), "P_PasswordReset_DisplayName")]
    [Uid("0c15db7e-0291-4d60-b225-35ae01eaa90f")]
    public const string PasswordReset = "0c15db7e-0291-4d60-b225-35ae01eaa90f";
    private static Guid _passwordResetGuid;
    /// <summary>Редактировать</summary>
    [DisplayName(typeof (__Resources_UserActions), "P_Edit_DisplayName")]
    [Uid("0e6e1881-1e4c-48c9-8a6b-724afd97566a")]
    public const string Edit = "0e6e1881-1e4c-48c9-8a6b-724afd97566a";
    private static Guid _editGuid;
    /// <summary>Блокировка входа пользователя в систему</summary>
    [DisplayName(typeof (__Resources_UserActions), "P_LogonBlock_DisplayName")]
    [Image(typeof (UserActions), "lock", 16, ImageFormatType.IconPack, false)]
    [Uid("cc548a2c-afe3-4810-bf18-98b038beb625")]
    public const string LogonBlock = "cc548a2c-afe3-4810-bf18-98b038beb625";
    private static Guid _logonBlockGuid;
    internal static UserActions IhFubK56IMsSMufn3Dl;

    /// <summary>ctor</summary>
    protected UserActions()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Блокировать</summary>
    /// <remarks>Блокировать учетную запись пользователя</remarks>
    public static Guid BlockGuid => UserActions._blockGuid;

    /// <summary>Разблокировать</summary>
    /// <remarks>Разблокировать учетную запись пользователя</remarks>
    public static Guid UnBlockGuid => UserActions._unBlockGuid;

    /// <summary>Сменить пароль</summary>
    public static Guid PasswordResetGuid => UserActions._passwordResetGuid;

    /// <summary>Редактировать</summary>
    public static Guid EditGuid => UserActions._editGuid;

    /// <summary>Блокировка входа пользователя в систему</summary>
    public static Guid LogonBlockGuid => UserActions._logonBlockGuid;

    static UserActions()
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
              UserActions.BRRKea5a034GOo7tcJw();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            case 3:
              UserActions._passwordResetGuid = new Guid((string) UserActions.rtP7q35xaDttL2GOpXL(-1958977588 ^ -1958951958));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 2 : 1;
              continue;
            case 4:
              goto label_3;
            case 5:
              UserActions._logonBlockGuid = new Guid((string) UserActions.rtP7q35xaDttL2GOpXL(581409346 ^ 581371644));
              num2 = 4;
              continue;
            case 6:
              UserActions._unBlockGuid = new Guid((string) UserActions.rtP7q35xaDttL2GOpXL(386642440 ^ 386607570));
              num2 = 3;
              continue;
            default:
              UserActions._blockGuid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-696756495 ^ -696726145));
              num2 = 6;
              continue;
          }
        }
label_5:
        UserActions._editGuid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1013954274 ^ 1013918352));
        num1 = 5;
      }
label_3:;
    }

    internal static bool E3i0h15kJyAiweFVrDH() => UserActions.IhFubK56IMsSMufn3Dl == null;

    internal static UserActions h5sJYU5DOGFVHtiKQ5R() => UserActions.IhFubK56IMsSMufn3Dl;

    internal static void BRRKea5a034GOo7tcJw() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static object rtP7q35xaDttL2GOpXL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
