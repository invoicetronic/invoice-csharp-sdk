/*
 * Italian Invoice API
 *
 * The Italian Invoice API is a RESTful API that allows you to send and receive invoices through the Italian [Servizio di Interscambio (SDI)][1] (Interchange Service). The API is designed by Invoicetronic to be simple and easy to use, abstracting away the Interchange Service's complexity while still providing complete control over the invoice send/receive process. The API also provides advanced features and a rich toolchain, such as invoice validation, multiple upload methods, webhooks, event logs, CORS support, client SDKs for commonly used languages, and CLI tools.  For more information, see:  - [Invoicetronic website][2] - [Invoice API reference][3]  [1]: https://www.fatturapa.gov.it/it/sistemainterscambio/cose-il-sdi/ [2]: https://invoicetronic.com/ [3]: https://api.invoicetronic.com/invoice/v1/docs 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@invoicetronic.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Invoicetronic.InvoiceApi.Client.OpenAPIDateConverter;

namespace Invoicetronic.InvoiceApi.Model
{
    /// <summary>
    /// WebHook
    /// </summary>
    [DataContract(Name = "WebHook")]
    public partial class WebHook : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebHook" /> class.
        /// </summary>
        /// <param name="id">Unique identifier. Leave it at 0 for new records as it will be set automatically..</param>
        /// <param name="created">Creation date. It is set automatically..</param>
        /// <param name="varVersion">Row version, for optimistic concurrency. It is set automatically..</param>
        /// <param name="userId">User id..</param>
        /// <param name="companyId">Company id..</param>
        /// <param name="url">The url of your application&#39;s endpoint that will receive a POST request when the webhook is fired..</param>
        /// <param name="enabled">Wetehr the webhooks is enabled or not. On creation, this is set to &#x60;true&#x60;..</param>
        /// <param name="secret">The secret used to generate webhook signatures, only returned on creation. You should store this value securely and validate it on every call, to ensure that the caller is InvoiceApi..</param>
        /// <param name="description">An optional description..</param>
        /// <param name="events">List of events to that trigger the webhook.  See InvoiceApi.SupportedEvents.Available for a list of valid event names..</param>
        public WebHook(int id = default(int), DateTime created = default(DateTime), int varVersion = default(int), int userId = default(int), int? companyId = default(int?), string url = default(string), bool enabled = default(bool), string secret = default(string), string description = default(string), List<string> events = default(List<string>))
        {
            this.Id = id;
            this.Created = created;
            this.VarVersion = varVersion;
            this.UserId = userId;
            this.CompanyId = companyId;
            this.Url = url;
            this.Enabled = enabled;
            this.Secret = secret;
            this.Description = description;
            this.Events = events;
        }

        /// <summary>
        /// Unique identifier. Leave it at 0 for new records as it will be set automatically.
        /// </summary>
        /// <value>Unique identifier. Leave it at 0 for new records as it will be set automatically.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Creation date. It is set automatically.
        /// </summary>
        /// <value>Creation date. It is set automatically.</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Row version, for optimistic concurrency. It is set automatically.
        /// </summary>
        /// <value>Row version, for optimistic concurrency. It is set automatically.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; set; }

        /// <summary>
        /// User id.
        /// </summary>
        /// <value>User id.</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public int UserId { get; set; }

        /// <summary>
        /// Company id.
        /// </summary>
        /// <value>Company id.</value>
        [DataMember(Name = "company_id", EmitDefaultValue = true)]
        public int? CompanyId { get; set; }

        /// <summary>
        /// The url of your application&#39;s endpoint that will receive a POST request when the webhook is fired.
        /// </summary>
        /// <value>The url of your application&#39;s endpoint that will receive a POST request when the webhook is fired.</value>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Wetehr the webhooks is enabled or not. On creation, this is set to &#x60;true&#x60;.
        /// </summary>
        /// <value>Wetehr the webhooks is enabled or not. On creation, this is set to &#x60;true&#x60;.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The secret used to generate webhook signatures, only returned on creation. You should store this value securely and validate it on every call, to ensure that the caller is InvoiceApi.
        /// </summary>
        /// <value>The secret used to generate webhook signatures, only returned on creation. You should store this value securely and validate it on every call, to ensure that the caller is InvoiceApi.</value>
        [DataMember(Name = "secret", EmitDefaultValue = true)]
        public string Secret { get; set; }

        /// <summary>
        /// An optional description.
        /// </summary>
        /// <value>An optional description.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// List of events to that trigger the webhook.  See InvoiceApi.SupportedEvents.Available for a list of valid event names.
        /// </summary>
        /// <value>List of events to that trigger the webhook.  See InvoiceApi.SupportedEvents.Available for a list of valid event names.</value>
        [DataMember(Name = "events", EmitDefaultValue = true)]
        public List<string> Events { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebHook {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
