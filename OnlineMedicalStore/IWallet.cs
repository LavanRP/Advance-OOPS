using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    /// <summary>
    /// IWallet interface is used to create property and method need for balance calculation<see cref="OnlineMedicalStore">
    /// </summary>
    public interface IWallet
    {
        /// <summary>
        /// WalletBalance property is used to give balance value<see cref="OnlineMedicalStore">
        /// </summary>
        public int WalletBalance { get;  }
        /// <summary>
        /// WalletRecharge method is used to add amount to balance<see cref="OnlineMedicalStore"/>
        /// </summary>
        /// <param name="amount">amount gives value need to be added</param>
        void WalletRecharge(int amount);
        /// <summary>
        /// DeductBalance method is used to Deduct amount from balance<see cref="OnlineMedicalStore"/>
        /// </summary>
        /// <param name="amount">amount gives value need to be Deduct</param>
        void DeductBalance(int amount);

    }
}