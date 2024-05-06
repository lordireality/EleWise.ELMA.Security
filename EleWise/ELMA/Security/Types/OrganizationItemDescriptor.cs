// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Types.OrganizationItemDescriptor
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Types
{
  /// <summary>
  /// Дескриптор для типа "Сущность-&gt;Элемент оргструктуры"
  /// </summary>
  public class OrganizationItemDescriptor : EntitySubTypeDescriptor<IOrganizationItem>
  {
    internal static OrganizationItemDescriptor S5JJgaa8ZKvdhXYHv4L;

    /// <summary>Тип настроек</summary>
    public override Type SettingsType => OrganizationItemDescriptor.mNvZmiaEbqamZrvtHuC(__typeref (OrganizationItemSettings));

    /// <summary>Уникальный идентификатор сущности</summary>
    protected override Guid EntityUid => InterfaceActivator.UID<IOrganizationItem>();

    public OrganizationItemDescriptor()
    {
      OrganizationItemDescriptor.zS0e43aGbxmBURvVRXY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type mNvZmiaEbqamZrvtHuC([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void zS0e43aGbxmBURvVRXY() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool cnZNPLa5TFku8A2OpQl() => OrganizationItemDescriptor.S5JJgaa8ZKvdhXYHv4L == null;

    internal static OrganizationItemDescriptor UCLBn4ads7xMvpCXoSv() => OrganizationItemDescriptor.S5JJgaa8ZKvdhXYHv4L;
  }
}
