// Decompiled with JetBrains decompiler
// Type: CERTADMINLib.ICertAdmin2
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTADMINLib
{
  [TypeIdentifier]
  [Guid("F7C3AC41-B8CE-4FB4-AA58-3D1DC0E36B39")]
  [CompilerGenerated]
  [ComImport]
  public interface ICertAdmin2 : ICertAdmin
  {
    [DispId(1610743808)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int IsValidCertificate([MarshalAs(UnmanagedType.BStr), In] string strConfig, [MarshalAs(UnmanagedType.BStr), In] string strSerialNumber);
  }
}
