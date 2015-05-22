namespace Cinema.WCFService.Interfaces
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Collections.Generic;  

    using Models;
    using Domain;
    using Attributes;      

    [ServiceContract]
    public interface IScreeningInfoService
    {
        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "screeninginfo")]
        int CreateScreeningInfo(ScreeningInfo screeninginfo);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "screeninginfo/{screeninginfoId}")]
        void UpdateScreeningInfo(ScreeningInfo screeninginfo, string screeninginfoId);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "screeninginfo/{screeninginfoId}")]
        void DeleteScreeningInfo(string screeninginfoId);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "screeninginfo/{screeninginfoId}")]
        ScreeningInfo GetScreeningInfo(string screeninginfoId);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "screeninginfos/movie/{movieId}")]
        ICollection<ScreeningInfo> GetScreeningInfosByMovieId(string movieId);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "screeninginfos/page/{page}/{noperpage}")]
        ICollection<ScreeningInfo> GetScreeningInfosByPage(string page, string noperpage);
    }
}