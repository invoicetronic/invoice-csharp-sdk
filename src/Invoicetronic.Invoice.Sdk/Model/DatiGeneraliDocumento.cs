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
    /// DatiGeneraliDocumento
    /// </summary>
    [DataContract(Name = "DatiGeneraliDocumento")]
    public partial class DatiGeneraliDocumento : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatiGeneraliDocumento" /> class.
        /// </summary>
        /// <param name="tipoDocumento">tipoDocumento.</param>
        /// <param name="divisa">divisa.</param>
        /// <param name="data">data.</param>
        /// <param name="numero">numero.</param>
        /// <param name="datiRitenuta">datiRitenuta.</param>
        /// <param name="datiBollo">datiBollo.</param>
        /// <param name="datiCassaPrevidenziale">datiCassaPrevidenziale.</param>
        /// <param name="scontoMaggiorazione">scontoMaggiorazione.</param>
        /// <param name="importoTotaleDocumento">importoTotaleDocumento.</param>
        /// <param name="arrotondamento">arrotondamento.</param>
        /// <param name="causale">causale.</param>
        /// <param name="art73">art73.</param>
        public DatiGeneraliDocumento(string tipoDocumento = default(string), string divisa = default(string), DateTime data = default(DateTime), string numero = default(string), List<DatiRitenuta> datiRitenuta = default(List<DatiRitenuta>), DatiBollo datiBollo = default(DatiBollo), List<DatiCassaPrevidenziale> datiCassaPrevidenziale = default(List<DatiCassaPrevidenziale>), List<ScontoMaggiorazione> scontoMaggiorazione = default(List<ScontoMaggiorazione>), double? importoTotaleDocumento = default(double?), double? arrotondamento = default(double?), List<string> causale = default(List<string>), string art73 = default(string))
        {
            this.TipoDocumento = tipoDocumento;
            this.Divisa = divisa;
            this.Data = data;
            this.Numero = numero;
            this.DatiRitenuta = datiRitenuta;
            this.DatiBollo = datiBollo;
            this.DatiCassaPrevidenziale = datiCassaPrevidenziale;
            this.ScontoMaggiorazione = scontoMaggiorazione;
            this.ImportoTotaleDocumento = importoTotaleDocumento;
            this.Arrotondamento = arrotondamento;
            this.Causale = causale;
            this.Art73 = art73;
        }

        /// <summary>
        /// Gets or Sets TipoDocumento
        /// </summary>
        [DataMember(Name = "tipo_documento", EmitDefaultValue = true)]
        public string TipoDocumento { get; set; }

        /// <summary>
        /// Gets or Sets Divisa
        /// </summary>
        [DataMember(Name = "divisa", EmitDefaultValue = true)]
        public string Divisa { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public DateTime Data { get; set; }

        /// <summary>
        /// Gets or Sets Numero
        /// </summary>
        [DataMember(Name = "numero", EmitDefaultValue = true)]
        public string Numero { get; set; }

        /// <summary>
        /// Gets or Sets DatiRitenuta
        /// </summary>
        [DataMember(Name = "dati_ritenuta", EmitDefaultValue = true)]
        public List<DatiRitenuta> DatiRitenuta { get; set; }

        /// <summary>
        /// Gets or Sets DatiBollo
        /// </summary>
        [DataMember(Name = "dati_bollo", EmitDefaultValue = false)]
        public DatiBollo DatiBollo { get; set; }

        /// <summary>
        /// Gets or Sets DatiCassaPrevidenziale
        /// </summary>
        [DataMember(Name = "dati_cassa_previdenziale", EmitDefaultValue = true)]
        public List<DatiCassaPrevidenziale> DatiCassaPrevidenziale { get; set; }

        /// <summary>
        /// Gets or Sets ScontoMaggiorazione
        /// </summary>
        [DataMember(Name = "sconto_maggiorazione", EmitDefaultValue = true)]
        public List<ScontoMaggiorazione> ScontoMaggiorazione { get; set; }

        /// <summary>
        /// Gets or Sets ImportoTotaleDocumento
        /// </summary>
        [DataMember(Name = "importo_totale_documento", EmitDefaultValue = true)]
        public double? ImportoTotaleDocumento { get; set; }

        /// <summary>
        /// Gets or Sets Arrotondamento
        /// </summary>
        [DataMember(Name = "arrotondamento", EmitDefaultValue = true)]
        public double? Arrotondamento { get; set; }

        /// <summary>
        /// Gets or Sets Causale
        /// </summary>
        [DataMember(Name = "causale", EmitDefaultValue = true)]
        public List<string> Causale { get; set; }

        /// <summary>
        /// Gets or Sets Art73
        /// </summary>
        [DataMember(Name = "art73", EmitDefaultValue = true)]
        public string Art73 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatiGeneraliDocumento {\n");
            sb.Append("  TipoDocumento: ").Append(TipoDocumento).Append("\n");
            sb.Append("  Divisa: ").Append(Divisa).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Numero: ").Append(Numero).Append("\n");
            sb.Append("  DatiRitenuta: ").Append(DatiRitenuta).Append("\n");
            sb.Append("  DatiBollo: ").Append(DatiBollo).Append("\n");
            sb.Append("  DatiCassaPrevidenziale: ").Append(DatiCassaPrevidenziale).Append("\n");
            sb.Append("  ScontoMaggiorazione: ").Append(ScontoMaggiorazione).Append("\n");
            sb.Append("  ImportoTotaleDocumento: ").Append(ImportoTotaleDocumento).Append("\n");
            sb.Append("  Arrotondamento: ").Append(Arrotondamento).Append("\n");
            sb.Append("  Causale: ").Append(Causale).Append("\n");
            sb.Append("  Art73: ").Append(Art73).Append("\n");
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
