﻿// Decompiled with JetBrains decompiler
// Type: CERTENROLLLib.IX500DistinguishedName
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTENROLLLib
{
  [TypeIdentifier]
  [Guid("728AB303-217D-11DA-B2A4-000E7BBB2B09")]
  [CompilerGenerated]
  [ComImport]
  public interface IX500DistinguishedName
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    sealed extern void _VtblGap1_1();

    [DispId(1610743809)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Encode([MarshalAs(UnmanagedType.BStr), In] string strName, [In] X500NameFlags NameFlags = X500NameFlags.XCN_CERT_NAME_STR_NONE);
  }
}
