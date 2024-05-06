// Decompiled with JetBrains decompiler
// Type: CERTCLIENTLib.ICertRequest2
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTCLIENTLib
{
  [Guid("A4772988-4A85-4FA9-824E-B5CF5C16405A")]
  [TypeIdentifier]
  [CompilerGenerated]
  [ComImport]
  public interface ICertRequest2 : ICertRequest
  {
    [DispId(1610743808)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int Submit([In] int Flags, [MarshalAs(UnmanagedType.BStr), In] string strRequest, [MarshalAs(UnmanagedType.BStr), In] string strAttributes, [MarshalAs(UnmanagedType.BStr), In] string strConfig);

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    sealed extern void _VtblGap1_4();

    [DispId(1610743813)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    string GetCACertificate([In] int fExchangeCertificate, [MarshalAs(UnmanagedType.BStr), In] string strConfig, [In] int Flags);

    [DispId(1610743814)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    string GetCertificate([In] int Flags);
  }
}
