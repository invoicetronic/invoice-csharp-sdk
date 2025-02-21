/*
 * Italian eInvoice API v1
 *
 * The [Italian eInvoice API][2] is a RESTful API that allows you to send and receive invoices through the Italian [Servizio di Interscambio (SDI)][1], or Interchange Service. The API is designed by Invoicetronic to be simple and easy to use, abstracting away SDI complexity while providing complete control over the invoice send/receive process. The API also provides advanced features as encryption at rest, invoice validation, multiple upload formats, webhooks, event logging, client SDKs for commonly used languages, and CLI tools.  For more information, see  [Invoicetronic website][2]  [1]: https://www.fatturapa.gov.it/it/sistemainterscambio/cose-il-sdi/ [2]: https://invoicetronic.com/
 *
 * The version of the OpenAPI document: 1
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
using OpenAPIDateConverter = Invoicetronic.Invoice.Sdk.Client.OpenAPIDateConverter;

namespace Invoicetronic.Invoice.Sdk.Model
{
    /// <summary>
    /// A company model.
    /// </summary>
    [DataContract(Name = "Company")]
    public partial class Company : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Company() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// </summary>
        /// <param name="id">Unique identifier. Leave it at 0 for new records as it will be set automatically..</param>
        /// <param name="created">Creation date. It is set automatically..</param>
        /// <param name="varVersion">Row version, for optimistic concurrency. It is set automatically..</param>
        /// <param name="userId">User id..</param>
        /// <param name="vat">Vat number. Must include the country code. (required).</param>
        /// <param name="fiscalCode">Fiscal code. In most cases it&#39;s the same as the vat number. (required).</param>
        /// <param name="name">Name (required).</param>
        /// <param name="counter">Holds the last unique value used to generate a XML filename. This is automatically updated by the system   when a raw XML file is uploaded. Normally, you do not need or want to change this value..</param>
        public Company(int id = default(int), DateTime created = default(DateTime), int varVersion = default(int), int userId = default(int), string vat = default(string), string fiscalCode = default(string), string name = default(string), int counter = default(int))
        {
            // to ensure "vat" is required (not null)
            if (vat == null)
            {
                throw new ArgumentNullException("vat is a required property for Company and cannot be null");
            }
            this.Vat = vat;
            // to ensure "fiscalCode" is required (not null)
            if (fiscalCode == null)
            {
                throw new ArgumentNullException("fiscalCode is a required property for Company and cannot be null");
            }
            this.FiscalCode = fiscalCode;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Company and cannot be null");
            }
            this.Name = name;
            this.Id = id;
            this.Created = created;
            this.VarVersion = varVersion;
            this.UserId = userId;
            this.Counter = counter;
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
        /// Vat number. Must include the country code.
        /// </summary>
        /// <value>Vat number. Must include the country code.</value>
        /*
        <example>IT01234567891</example>
        */
        [DataMember(Name = "vat", IsRequired = true, EmitDefaultValue = true)]
        public string Vat { get; set; }

        /// <summary>
        /// Fiscal code. In most cases it&#39;s the same as the vat number.
        /// </summary>
        /// <value>Fiscal code. In most cases it&#39;s the same as the vat number.</value>
        /*
        <example>RSSMRA70A01F205V</example>
        */
        [DataMember(Name = "fiscal_code", IsRequired = true, EmitDefaultValue = true)]
        public string FiscalCode { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        /*
        <example>Mario Rossi Srl</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Holds the last unique value used to generate a XML filename. This is automatically updated by the system   when a raw XML file is uploaded. Normally, you do not need or want to change this value.
        /// </summary>
        /// <value>Holds the last unique value used to generate a XML filename. This is automatically updated by the system   when a raw XML file is uploaded. Normally, you do not need or want to change this value.</value>
        [DataMember(Name = "counter", EmitDefaultValue = false)]
        public int Counter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Company {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
            sb.Append("  FiscalCode: ").Append(FiscalCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Counter: ").Append(Counter).Append("\n");
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
            // Vat (string) minLength
            if (this.Vat != null && this.Vat.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Vat, length must be greater than 1.", new [] { "Vat" });
            }

            // FiscalCode (string) minLength
            if (this.FiscalCode != null && this.FiscalCode.Length < 1)
            {
                yield return new ValidationResult("Invalid value for FiscalCode, length must be greater than 1.", new [] { "FiscalCode" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
