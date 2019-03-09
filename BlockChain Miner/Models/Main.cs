﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlockChain.Models.BlockChain;
using BlockChain.Models.Networking;

namespace BlockChain.Models
{
    public class Main
    {
        /// <summary>
        /// Lew Coins!!!! 
        /// </summary>
        public BlockChainObj lewCoins;
        P2PClient client;


        /// <summary>
        /// Entry point for our programme
        /// 
        /// (Business logic, code behind, models...
        /// ...whatever you kids are calling it these days)
        /// </summary>
        public Main()
        {
            
            client = new P2PClient(1011);
            lewCoins = new BlockChainObj(client);

            try
            {
                Task.Run(() => client.Start());
            }
            catch(Exception ex)
            {

            }
        }
    }
}
