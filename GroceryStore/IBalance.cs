using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore
{
    /// <summary>
    /// IBalance is an interface used to declare walletbalance property and walletrecharge method<see cref="IBalance"/>
    /// </summary>
    public interface IBalance
    {
        /// <summary>
        /// WalletBalance proprerty is used to store and get wallet balance of customer<see cref="IBalance"/>
        /// </summary>
        public int WalletBalance { get; set; }
        /// <summary>
        /// WalletRecharge is used to add amount to the Wallet Balance<see cref="IBalance"/>
        /// </summary>
        /// <param name="amount">amount is a value need to be added</param>
        void WalletRecharge(int amount);
    }
}