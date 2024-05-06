// Decompiled with JetBrains decompiler
// Type: CERTENROLLLib.IX509Enrollment
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTENROLLLib
{
  [TypeIdentifier]
  [CompilerGenerated]
  [Guid("728AB346-217D-11DA-B2A4-000E7BBB2B09")]
  [ComImport]
  public interface IX509Enrollment
  {
    [DispId(1610743808)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Initialize([In] X509CertificateEnrollmentContext Context);

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    sealed extern void _VtblGap1_1();

    [DispId(1610743810)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void InitializeFromRequest([MarshalAs(UnmanagedType.Interface), In] IX509CertificateRequest pRequest);

    [DispId(1610743811)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    string CreateRequest([In] EncodingType Encoding = EncodingType.XCN_CRYPT_STRING_BASE64);

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    sealed extern void _VtblGap2_1();

    [DispId(1610743813)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void InstallResponse(
      [In] InstallResponseRestrictionFlags Restrictions,
      [MarshalAs(UnmanagedType.BStr), In] string strResponse,
      [In] EncodingType Encoding,
      [MarshalAs(UnmanagedType.BStr), In] string strPassword);
  }
}
