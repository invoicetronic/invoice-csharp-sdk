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
    /// CessionarioCommittente
    /// </summary>
    [DataContract(Name = "CessionarioCommittente")]
    public partial class CessionarioCommittente : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CessionarioCommittente" /> class.
        /// </summary>
        /// <param name="datiAnagrafici">datiAnagrafici.</param>
        /// <param name="sede">sede.</param>
        /// <param name="stabileOrganizzazione">stabileOrganizzazione.</param>
        /// <param name="rappresentanteFiscale">rappresentanteFiscale.</param>
        public CessionarioCommittente(DatiAnagraficiCessionarioCommittente datiAnagrafici = default(DatiAnagraficiCessionarioCommittente), SedeCessionarioCommittente sede = default(SedeCessionarioCommittente), StabileOrganizzazione stabileOrganizzazione = default(StabileOrganizzazione), RappresentanteFiscaleCessionarioCommittente rappresentanteFiscale = default(RappresentanteFiscaleCessionarioCommittente))
        {
            this.DatiAnagrafici = datiAnagrafici;
            this.Sede = sede;
            this.StabileOrganizzazione = stabileOrganizzazione;
            this.RappresentanteFiscale = rappresentanteFiscale;
        }

        /// <summary>
        /// Gets or Sets DatiAnagrafici
        /// </summary>
        [DataMember(Name = "dati_anagrafici", EmitDefaultValue = false)]
        public DatiAnagraficiCessionarioCommittente DatiAnagrafici { get; set; }

        /// <summary>
        /// Gets or Sets Sede
        /// </summary>
        [DataMember(Name = "sede", EmitDefaultValue = false)]
        public SedeCessionarioCommittente Sede { get; set; }

        /// <summary>
        /// Gets or Sets StabileOrganizzazione
        /// </summary>
        [DataMember(Name = "stabile_organizzazione", EmitDefaultValue = false)]
        public StabileOrganizzazione StabileOrganizzazione { get; set; }

        /// <summary>
        /// Gets or Sets RappresentanteFiscale
        /// </summary>
        [DataMember(Name = "rappresentante_fiscale", EmitDefaultValue = false)]
        public RappresentanteFiscaleCessionarioCommittente RappresentanteFiscale { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CessionarioCommittente {\n");
            sb.Append("  DatiAnagrafici: ").Append(DatiAnagrafici).Append("\n");
            sb.Append("  Sede: ").Append(Sede).Append("\n");
            sb.Append("  StabileOrganizzazione: ").Append(StabileOrganizzazione).Append("\n");
            sb.Append("  RappresentanteFiscale: ").Append(RappresentanteFiscale).Append("\n");
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
