// Decompiled with JetBrains decompiler
// Type: CERTENROLLLib.X509KeyUsageFlags
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTENROLLLib
{
  [CompilerGenerated]
  [TypeIdentifier("728AB348-217D-11DA-B2A4-000E7BBB2B09", "CERTENROLLLib.X509KeyUsageFlags")]
  public enum X509KeyUsageFlags
  {
    XCN_CERT_NO_KEY_USAGE = 0,
    XCN_CERT_ENCIPHER_ONLY_KEY_USAGE = 1,
    XCN_CERT_CRL_SIGN_KEY_USAGE = 2,
    XCN_CERT_OFFLINE_CRL_SIGN_KEY_USAGE = 2,
    XCN_CERT_KEY_CERT_SIGN_KEY_USAGE = 4,
    XCN_CERT_KEY_AGREEMENT_KEY_USAGE = 8,
    XCN_CERT_DATA_ENCIPHERMENT_KEY_USAGE = 16, // 0x00000010
    XCN_CERT_KEY_ENCIPHERMENT_KEY_USAGE = 32, // 0x00000020
    XCN_CERT_NON_REPUDIATION_KEY_USAGE = 64, // 0x00000040
    XCN_CERT_DIGITAL_SIGNATURE_KEY_USAGE = 128, // 0x00000080
    XCN_CERT_DECIPHER_ONLY_KEY_USAGE = 32768, // 0x00008000
  }
}
