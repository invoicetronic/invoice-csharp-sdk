/*
 * Italian Invoice API
 *
 *  ## Overview  The Invoice API is a RESTful API that allows you to send and receive invoices through the Italian Servizio di Interscambio (Interchange Service).  ### Authentication  The Invoicetronic API uses API keys to authenticate requests. If you don't have any API Key, you can request one by registering with the [Invoicetronic Developer Portal][1].  Test mode secret keys have the prefix `ik_test_` and live mode secret keys have the prefix `ik_live_`. Make sure to use the correct key for each environment.  > Your API keys carry many privileges, so be sure to keep them secure! Do not share your secret API keys in publicly > accessible areas such as GitHub, client-side code, and so forth.  All API requests must be made over HTTPS. Calls made over plain HTTP will fail. API requests without authentication will also fail.  #### Basic Authentication  Basic Authentication is how you authenticate with the API. Use your API Key as the username and leave the password empty. If your client does not allow empty passwords, you can use any value as the password. Here's an example of how to authenticate with Basic Authentication and curl:  ```curl curl https://api.invoicetronic.com/invoice/v1/send \\     -u ik_test_1234567890abcdefg:  # The colon prevents curl from asking for a password. ```  [1]: https://invoicetronic.com/
 *
 * The version of the OpenAPI document: v1
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
    /// DatiOrdineAcquisto
    /// </summary>
    [DataContract(Name = "DatiOrdineAcquisto")]
    public partial class DatiOrdineAcquisto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatiOrdineAcquisto" /> class.
        /// </summary>
        /// <param name="riferimentoNumeroLinea">riferimentoNumeroLinea.</param>
        /// <param name="idDocumento">idDocumento.</param>
        /// <param name="data">data.</param>
        /// <param name="numItem">numItem.</param>
        /// <param name="codiceCommessaConvenzione">codiceCommessaConvenzione.</param>
        /// <param name="codiceCup">codiceCup.</param>
        /// <param name="codiceCig">codiceCig.</param>
        public DatiOrdineAcquisto(List<int> riferimentoNumeroLinea = default(List<int>), string idDocumento = default(string), DateTime? data = default(DateTime?), string numItem = default(string), string codiceCommessaConvenzione = default(string), string codiceCup = default(string), string codiceCig = default(string))
        {
            this.RiferimentoNumeroLinea = riferimentoNumeroLinea;
            this.IdDocumento = idDocumento;
            this.Data = data;
            this.NumItem = numItem;
            this.CodiceCommessaConvenzione = codiceCommessaConvenzione;
            this.CodiceCup = codiceCup;
            this.CodiceCig = codiceCig;
        }

        /// <summary>
        /// Gets or Sets RiferimentoNumeroLinea
        /// </summary>
        [DataMember(Name = "riferimento_numero_linea", EmitDefaultValue = true)]
        public List<int> RiferimentoNumeroLinea { get; set; }

        /// <summary>
        /// Gets or Sets IdDocumento
        /// </summary>
        [DataMember(Name = "id_documento", EmitDefaultValue = true)]
        public string IdDocumento { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public DateTime? Data { get; set; }

        /// <summary>
        /// Gets or Sets NumItem
        /// </summary>
        [DataMember(Name = "num_item", EmitDefaultValue = true)]
        public string NumItem { get; set; }

        /// <summary>
        /// Gets or Sets CodiceCommessaConvenzione
        /// </summary>
        [DataMember(Name = "codice_commessa_convenzione", EmitDefaultValue = true)]
        public string CodiceCommessaConvenzione { get; set; }

        /// <summary>
        /// Gets or Sets CodiceCup
        /// </summary>
        [DataMember(Name = "codice_cup", EmitDefaultValue = true)]
        public string CodiceCup { get; set; }

        /// <summary>
        /// Gets or Sets CodiceCig
        /// </summary>
        [DataMember(Name = "codice_cig", EmitDefaultValue = true)]
        public string CodiceCig { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatiOrdineAcquisto {\n");
            sb.Append("  RiferimentoNumeroLinea: ").Append(RiferimentoNumeroLinea).Append("\n");
            sb.Append("  IdDocumento: ").Append(IdDocumento).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  NumItem: ").Append(NumItem).Append("\n");
            sb.Append("  CodiceCommessaConvenzione: ").Append(CodiceCommessaConvenzione).Append("\n");
            sb.Append("  CodiceCup: ").Append(CodiceCup).Append("\n");
            sb.Append("  CodiceCig: ").Append(CodiceCig).Append("\n");
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
