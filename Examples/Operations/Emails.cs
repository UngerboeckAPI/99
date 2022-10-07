using System.Collections.Generic;
using System.Net.Http;
using Ungerboeck.Api.Models.Subjects;
using Ungerboeck.Api.Sdk;


namespace Examples.Operations
{
  public class Emails : Base
  {

    public Emails(ApiClient apiClient) : base(apiClient) { }

    /// <summary>
    /// Sends an email through Ungerboeck
    /// </summary>
    public EmailsModel Send(EmailsModel emailRequest)
    {
      EmailsModel emailsModel = apiClient.Endpoints.Emails.Send(emailRequest);

      return emailsModel;
    }

  }
}
