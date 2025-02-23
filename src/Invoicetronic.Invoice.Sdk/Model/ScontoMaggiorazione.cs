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
    /// ScontoMaggiorazione
    /// </summary>
    [DataContract(Name = "ScontoMaggiorazione")]
    public partial class ScontoMaggiorazione : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScontoMaggiorazione" /> class.
        /// </summary>
        /// <param name="tipo">tipo.</param>
        /// <param name="percentuale">percentuale.</param>
        /// <param name="importo">importo.</param>
        public ScontoMaggiorazione(string tipo = default(string), double? percentuale = default(double?), double? importo = default(double?))
        {
            this.Tipo = tipo;
            this.Percentuale = percentuale;
            this.Importo = importo;
        }

        /// <summary>
        /// Gets or Sets Tipo
        /// </summary>
        [DataMember(Name = "tipo", EmitDefaultValue = true)]
        public string Tipo { get; set; }

        /// <summary>
        /// Gets or Sets Percentuale
        /// </summary>
        [DataMember(Name = "percentuale", EmitDefaultValue = true)]
        public double? Percentuale { get; set; }

        /// <summary>
        /// Gets or Sets Importo
        /// </summary>
        [DataMember(Name = "importo", EmitDefaultValue = true)]
        public double? Importo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScontoMaggiorazione {\n");
            sb.Append("  Tipo: ").Append(Tipo).Append("\n");
            sb.Append("  Percentuale: ").Append(Percentuale).Append("\n");
            sb.Append("  Importo: ").Append(Importo).Append("\n");
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
