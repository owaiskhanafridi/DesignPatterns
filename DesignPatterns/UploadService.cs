using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class UploadService
    {
        private UploadService() { }

        private static UploadService _instance;

        private static readonly object _lock = new object();

        public static UploadService Instance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance = new UploadService();
                }
            }


            return _instance;
        
        }


    }
}
