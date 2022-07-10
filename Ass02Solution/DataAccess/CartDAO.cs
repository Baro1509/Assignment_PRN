using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess {
    public class CartDAO {
        private static CartDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CartDAO Instance {
            get {
                lock (instanceLock) {
                    if (instance == null) {
                        instance = new CartDAO();
                    }
                    return instance;
                }
            }
        }
        public CartDAO() { }
    }
}
