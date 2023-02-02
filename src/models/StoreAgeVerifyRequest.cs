using System;
using System.Collections.Generic;
using Newtonsoft.Json;

/*
 * AvaTax API Client Library
 *
 * (c) 2004-2019 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author Genevieve Conty
 * @author Greg Hester
 * Swagger name: AvaTaxBeverageClient
 */

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// The Request for the /ageverification/store/identity endpoint. Describes information about the person whose age has been verified and the verification result.
    /// </summary>
    public class StoreAgeVerifyRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public AgeVerifyRequest request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public AgeVerifyResult response { get; set; }


        /// <summary>
        /// Convert this object to a JSON string of itself
        /// </summary>
        /// <returns>A JSON string of this object</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings() { Formatting = Formatting.Indented });
        }
    }
}