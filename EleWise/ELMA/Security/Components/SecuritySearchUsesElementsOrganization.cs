// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.SecuritySearchUsesElementsOrganization
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>
  /// Поиск использования элемента оргуструктуры в модуле безопасность
  /// </summary>
  [Component]
  internal class SecuritySearchUsesElementsOrganization : ISearchUsesElementsOrganization
  {
    private static SecuritySearchUsesElementsOrganization LINan4zAoOvv5qCdVJo;

    /// <inheritdoc />
    public List<OrgstructureElementUsesDTO> SearchUses(
      IOrganizationItem organizationItem)
    {
      List<OrgstructureElementUsesDTO> orgstructureElementUsesDtoList = new List<OrgstructureElementUsesDTO>();
      OrgstructureElementUsesDTO orgstructureElementUsesDto = new OrgstructureElementUsesDTO(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801309555 ^ -801249415)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1744916777 - 891549337 ^ 853296826), (string) null, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1702973981 - 773209001 ^ 1818780226));
      if (organizationItem != null && organizationItem.User != null)
      {
        orgstructureElementUsesDtoList.Add(new OrgstructureElementUsesDTO(organizationItem.User.FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(84189367 + 1997579375 ^ 2081802998) + organizationItem.User.UserName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1958138283 - -279956781 ^ -1678216102), Guid.NewGuid().ToString(), orgstructureElementUsesDto.Key, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1859356887 ^ -1859360943)));
        orgstructureElementUsesDtoList.Add(orgstructureElementUsesDto);
        return orgstructureElementUsesDtoList;
      }
      if (organizationItem == null || organizationItem.Users == null || !organizationItem.Users.Any<EleWise.ELMA.Security.Models.IUser>())
        return (List<OrgstructureElementUsesDTO>) null;
      foreach (EleWise.ELMA.Security.Models.IUser user in (IEnumerable<EleWise.ELMA.Security.Models.IUser>) organizationItem.Users)
        orgstructureElementUsesDtoList.Add(new OrgstructureElementUsesDTO(user.FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-979995965 << 4 ^ 1499964384) + user.UserName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1711335411 ^ -1711302699), Guid.NewGuid().ToString(), orgstructureElementUsesDto.ToString(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1677147940 ^ 1677143900)));
      orgstructureElementUsesDtoList.Add(orgstructureElementUsesDto);
      return orgstructureElementUsesDtoList;
    }

    public SecuritySearchUsesElementsOrganization()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool KBtRE7zsdfVmXTwDibC() => SecuritySearchUsesElementsOrganization.LINan4zAoOvv5qCdVJo == null;

    internal static SecuritySearchUsesElementsOrganization sVZ365z7seyCDvy5FwV() => SecuritySearchUsesElementsOrganization.LINan4zAoOvv5qCdVJo;
  }
}
