/*
 * Italian eInvoice API
 *
 * The Italian eInvoice API is a RESTful API that allows you to send and receive invoices through the Italian [Servizio di Interscambio (SDI)][1], or Interchange Service. The API is designed by Invoicetronic to be simple and easy to use, abstracting away SDI complexity while still providing complete control over the invoice send/receive process. The API also provides advanced features and a rich toolchain, such as invoice validation, multiple upload methods, webhooks, event logs, CORS support, client SDKs for commonly used languages, and CLI tools.  For more information, see  [Invoicetronic website][2]  [1]: https://www.fatturapa.gov.it/it/sistemainterscambio/cose-il-sdi/ [2]: https://invoicetronic.com/
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
using OpenAPIDateConverter = Invoicetronic.Invoice.Sdk.Client.OpenAPIDateConverter;

namespace Invoicetronic.Invoice.Sdk.Model
{
    /// <summary>
    /// FatturaOrdinaria
    /// </summary>
    [DataContract(Name = "FatturaOrdinaria")]
    public partial class FatturaOrdinaria : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FatturaOrdinaria" /> class.
        /// </summary>
        /// <param name="sistemaEmittente">sistemaEmittente.</param>
        /// <param name="fatturaElettronicaHeader">fatturaElettronicaHeader.</param>
        /// <param name="fatturaElettronicaBody">fatturaElettronicaBody.</param>
        public FatturaOrdinaria(string sistemaEmittente = default(string), FatturaElettronicaHeader fatturaElettronicaHeader = default(FatturaElettronicaHeader), List<FatturaElettronicaBody> fatturaElettronicaBody = default(List<FatturaElettronicaBody>))
        {
            this.SistemaEmittente = sistemaEmittente;
            this.FatturaElettronicaHeader = fatturaElettronicaHeader;
            this.FatturaElettronicaBody = fatturaElettronicaBody;
        }

        /// <summary>
        /// Gets or Sets SistemaEmittente
        /// </summary>
        [DataMember(Name = "sistema_emittente", EmitDefaultValue = true)]
        public string SistemaEmittente { get; set; }

        /// <summary>
        /// Gets or Sets FatturaElettronicaHeader
        /// </summary>
        [DataMember(Name = "fattura_elettronica_header", EmitDefaultValue = false)]
        public FatturaElettronicaHeader FatturaElettronicaHeader { get; set; }

        /// <summary>
        /// Gets or Sets FatturaElettronicaBody
        /// </summary>
        [DataMember(Name = "fattura_elettronica_body", EmitDefaultValue = true)]
        public List<FatturaElettronicaBody> FatturaElettronicaBody { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FatturaOrdinaria {\n");
            sb.Append("  SistemaEmittente: ").Append(SistemaEmittente).Append("\n");
            sb.Append("  FatturaElettronicaHeader: ").Append(FatturaElettronicaHeader).Append("\n");
            sb.Append("  FatturaElettronicaBody: ").Append(FatturaElettronicaBody).Append("\n");
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
