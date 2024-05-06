// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.API.Service.v1.ISecurityService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Security.API.Models;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;
using System;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace EleWise.ELMA.Security.API.Service.v1
{
  [ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
  [WsdlDocumentation(typeof (__ISecurityServiceResources), "ServiceDescription")]
  public interface ISecurityService
  {
    [AuthorizeOperationBehavior]
    [WebGet(UriTemplate = "/GetSubordinateUsers")]
    [WsdlDocumentation(typeof (__ISecurityServiceResources), "GetSubordinateUsersDescription")]
    [OperationContract]
    [FaultContract(typeof (PublicServiceException))]
    [return: WsdlParamOrReturnDocumentation(typeof (__ISecurityServiceResources), "GetSubordinateUsersResultDescription")]
    SubordinateUsersResponse GetSubordinateUsers();

    [WsdlDocumentation(typeof (__ISecurityServiceResources), "AddUserToGroupDescription")]
    [WebInvoke(Method = "POST", UriTemplate = "/AddUserToGroup?userId={userId}&userGroupUid={userGroupUid}")]
    [AuthorizeOperationBehavior]
    [FaultContract(typeof (PublicServiceException))]
    [OperationContract]
    [return: WsdlParamOrReturnDocumentation(typeof (__ISecurityServiceResources), "AddUserToGroupResultDescription")]
    bool AddUserToGroup([WsdlParamOrReturnDocumentation(typeof (__ISecurityServiceResources), "AddUserToGroupUserIdDescription")] long userId, [WsdlParamOrReturnDocumentation(typeof (__ISecurityServiceResources), "AddUserToGroupUserGroupIdDescription")] Guid userGroupUid);
  }
}
