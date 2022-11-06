using System;
namespace DesignPatterns.Facade
{
    public class SecurityCodeCheker
    {
        private int SecurityCode = 1234;

        public SecurityCodeCheker()
        {
        }

        public bool CheckSecurityCode(int securityCode)
        {
            return securityCode == SecurityCode;
        }
    }
}

