using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    /// <summary>
    /// IBalance is used to assigne property and method related to balance<see cref="IBalance"/>
    /// </summary>
    public interface IBalance 
    {
        /// <summary>
        /// WalletBalance is a public property without any meaning<see cref="IBalance"/>
        /// </summary>
        int WalletBalance { get;  }
        /// <summary>
        /// WalletRecharge is a public method without any functionality<see cref="IBalance"/>
        /// </summary>
        void WalletRecharge(int amount);
        /// <summary>
        /// DeductAmount is a public method without any functionality<see cref="IBalance"/>
        /// </summary>
        void DeductAmount(int amount);
    }
}