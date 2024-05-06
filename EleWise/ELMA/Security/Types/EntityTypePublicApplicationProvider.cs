// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Types.EntityTypePublicApplicationProvider
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Security.DTO.Models;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Security.Types
{
  internal class EntityTypePublicApplicationProvider : TypePublicApplicationProvider
  {
    private static EntityTypePublicApplicationProvider i5GA0ma4n9F4mMj6f3O;

    public override bool? IsPublicApplicationDisplayEnabled(Guid typeUid, Guid subTypeUid) => !(subTypeUid == UserDTO.UID) ? new bool?() : new bool?(true);

    public override bool? IsPublicApplicationEditorEnabled(Guid typeUid, Guid subTypeUid) => !(subTypeUid == UserDTO.UID) ? new bool?() : new bool?(true);

    public EntityTypePublicApplicationProvider()
    {
      EntityTypePublicApplicationProvider.nQUDnoaQ8uqQmeLnSOW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void nQUDnoaQ8uqQmeLnSOW() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool l0JoX9acoQWTwOhaqSu() => EntityTypePublicApplicationProvider.i5GA0ma4n9F4mMj6f3O == null;

    internal static EntityTypePublicApplicationProvider vd4jr8aPtXiXdWY4S65() => EntityTypePublicApplicationProvider.i5GA0ma4n9F4mMj6f3O;
  }
}
