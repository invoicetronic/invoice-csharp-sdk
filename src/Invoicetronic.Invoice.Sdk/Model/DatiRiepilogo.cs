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
    /// DatiRiepilogo
    /// </summary>
    [DataContract(Name = "DatiRiepilogo")]
    public partial class DatiRiepilogo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatiRiepilogo" /> class.
        /// </summary>
        /// <param name="aliquotaIva">aliquotaIva.</param>
        /// <param name="natura">natura.</param>
        /// <param name="speseAccessorie">speseAccessorie.</param>
        /// <param name="arrotondamento">arrotondamento.</param>
        /// <param name="imponibileImporto">imponibileImporto.</param>
        /// <param name="imposta">imposta.</param>
        /// <param name="esigibilitaIva">esigibilitaIva.</param>
        /// <param name="riferimentoNormativo">riferimentoNormativo.</param>
        public DatiRiepilogo(double aliquotaIva = default(double), string natura = default(string), double? speseAccessorie = default(double?), double? arrotondamento = default(double?), double imponibileImporto = default(double), double imposta = default(double), string esigibilitaIva = default(string), string riferimentoNormativo = default(string))
        {
            this.AliquotaIva = aliquotaIva;
            this.Natura = natura;
            this.SpeseAccessorie = speseAccessorie;
            this.Arrotondamento = arrotondamento;
            this.ImponibileImporto = imponibileImporto;
            this.Imposta = imposta;
            this.EsigibilitaIva = esigibilitaIva;
            this.RiferimentoNormativo = riferimentoNormativo;
        }

        /// <summary>
        /// Gets or Sets AliquotaIva
        /// </summary>
        [DataMember(Name = "aliquota_iva", EmitDefaultValue = false)]
        public double AliquotaIva { get; set; }

        /// <summary>
        /// Gets or Sets Natura
        /// </summary>
        [DataMember(Name = "natura", EmitDefaultValue = true)]
        public string Natura { get; set; }

        /// <summary>
        /// Gets or Sets SpeseAccessorie
        /// </summary>
        [DataMember(Name = "spese_accessorie", EmitDefaultValue = true)]
        public double? SpeseAccessorie { get; set; }

        /// <summary>
        /// Gets or Sets Arrotondamento
        /// </summary>
        [DataMember(Name = "arrotondamento", EmitDefaultValue = true)]
        public double? Arrotondamento { get; set; }

        /// <summary>
        /// Gets or Sets ImponibileImporto
        /// </summary>
        [DataMember(Name = "imponibile_importo", EmitDefaultValue = false)]
        public double ImponibileImporto { get; set; }

        /// <summary>
        /// Gets or Sets Imposta
        /// </summary>
        [DataMember(Name = "imposta", EmitDefaultValue = false)]
        public double Imposta { get; set; }

        /// <summary>
        /// Gets or Sets EsigibilitaIva
        /// </summary>
        [DataMember(Name = "esigibilita_iva", EmitDefaultValue = true)]
        public string EsigibilitaIva { get; set; }

        /// <summary>
        /// Gets or Sets RiferimentoNormativo
        /// </summary>
        [DataMember(Name = "riferimento_normativo", EmitDefaultValue = true)]
        public string RiferimentoNormativo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatiRiepilogo {\n");
            sb.Append("  AliquotaIva: ").Append(AliquotaIva).Append("\n");
            sb.Append("  Natura: ").Append(Natura).Append("\n");
            sb.Append("  SpeseAccessorie: ").Append(SpeseAccessorie).Append("\n");
            sb.Append("  Arrotondamento: ").Append(Arrotondamento).Append("\n");
            sb.Append("  ImponibileImporto: ").Append(ImponibileImporto).Append("\n");
            sb.Append("  Imposta: ").Append(Imposta).Append("\n");
            sb.Append("  EsigibilitaIva: ").Append(EsigibilitaIva).Append("\n");
            sb.Append("  RiferimentoNormativo: ").Append(RiferimentoNormativo).Append("\n");
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
