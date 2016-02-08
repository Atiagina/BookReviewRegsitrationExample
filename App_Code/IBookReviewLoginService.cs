using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBookReviewLoginService" in both code and config file together.
[ServiceContract]
public interface IBookReviewLoginService
{
    [OperationContract]

    int ReviewerLogin(string username, string password);

    [OperationContract]
    int ReviewerRegistration(ReviewerLite r);
}

[DataContract]
public class ReviewerLite
{

    [DataMember]
    public string LastName { set; get; }

    [DataMember]
    public string FirstName { set; get; }

    [DataMember]
    public string UserName { set; get; }

    [DataMember]
    public string Password { set; get; }

    [DataMember]
    public string Email { set; get; }
}