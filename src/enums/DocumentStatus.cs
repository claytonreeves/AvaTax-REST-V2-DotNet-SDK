using System;

/*
 * AvaTax API Client Library
 *
 * (c) 2004-2023 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author Jonathan Wenger <jonathan.wenger@avalara.com>
 * @author Sachin Baijal <sachin.baijal@avalara.com>
 * Swagger name: AvaTaxClient 
 */

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// The `DocumentStatus` value indicates the state of the document as it moves through the
    ///  AvaTax document workflow. More information about the AvaTax document workflow is available
    ///  in the [AvaTax Developer Guide](https://developer.avalara.com/avatax/dev-guide/transactions/should-i-commit).
    /// </summary>
    public enum DocumentStatus
    {
        /// <summary>
        /// Temporary document not saved (SalesOrder, PurchaseOrder).
        ///  
        ///  This document has not been recorded to AvaTax
        /// </summary>
        Temporary = 0,

        /// <summary>
        /// Saved document (SalesInvoice or PurchaseInvoice) ready to be posted.
        ///  
        ///  This status indicates that the transaction has been saved to AvaTax, but is not available
        ///  to be reported on a tax filing, and has not yet been verified by a business process that
        ///  posts transactions.
        ///  
        ///  To mark this transaction as `Posted`, please call `VerifyTransaction` or `SettleTransaction`.
        ///  
        ///  To mark this transaction as `Committed`, please call `CommitTransaction` or `SettleTransaction`.
        ///  
        ///  To adjust or void this transaction, call `AdjustTransaction`, `CreateOrAdjustTransaction`, or
        ///  `VoidTransaction`.
        /// </summary>
        Saved = 1,

        /// <summary>
        /// A posted document (not committed).
        ///  
        ///  This status indicates that the transaction has been saved to AvaTax, and has been verified
        ///  by a business process that posts transactions, but is not ready to report on a tax filing.
        ///  
        ///  To mark this transaction as `Committed`, please call `CommitTransaction` or `SettleTransaction`.
        ///  
        ///  To adjust or void this transaction, call `AdjustTransaction`, `CreateOrAdjustTransaction`, or
        ///  `VoidTransaction`.
        /// </summary>
        Posted = 2,

        /// <summary>
        /// A posted document that has been committed.
        ///  
        ///  This status indicates that the transaction has been saved to AvaTax and can be reported
        ///  on a tax filing.
        ///  
        ///  If you use Avalara's Managed Returns Service, these transactions will be captured and reported
        ///  on a tax return. When this occurs, the transaction's `locked` flag will be set to true. Once
        ///  the transaction is locked, no further changes may occur.
        ///  
        ///  As long as the transaction has not been locked, you may adjust or void this transaction using
        ///  `AdjustTransaction`, `CreateOrAdjustTransaction`, or `VoidTransaction`.
        /// </summary>
        Committed = 3,

        /// <summary>
        /// A document that has been cancelled.
        ///  
        ///  This status indicates that the transaction has been cancelled or voided. Cancelled and Voided
        ///  are synonyms.
        ///  
        ///  When a transaction has been cancelled, it is considered to no longer exist. You are free to create
        ///  a new transaction with the same code.
        /// </summary>
        Cancelled = 4,

        /// <summary>
        /// An older version of a document that has been adjusted.
        ///  
        ///  When you call `AdjustTransaction`, AvaTax preserves a record of the old document as well as a record
        ///  of the new document. The old document is changed to the status `Adjusted`, and the new document
        ///  is created in the status you requested.
        /// </summary>
        Adjusted = 5,

        /// <summary>
        /// DEPRECATED - A document which is queued for later processing.
        /// </summary>
        Queued = 6,

        /// <summary>
        /// Indicates that this document requires approval from a governmental agency before it can be finalized.
        ///  
        ///  Some governments require active verification of transactions before they can be finalized. When AvaTax
        ///  detects that a transaction must be verified with a governmental agency, this transaction will be flagged
        ///  as `PendingApproval` until the government has certified the transaction.
        /// </summary>
        PendingApproval = 7,

        /// <summary>
        /// DEPRECATED - Represents "a document in any status" when searching. Please search using the
        ///  [Filtering in REST](/avatax/filtering-in-rest/) documentation.
        /// </summary>
        Any = -1,

    }
}
