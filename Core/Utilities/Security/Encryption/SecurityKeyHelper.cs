using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    //Web.api'de oluşturduğumuz SecurityKey'i byte array haline getirmeye yarıyor(basit stringlerle encrpytion'a parametre geçeçiyoruz. Byte array haline getirmemiz gerekiyor.)
    //Byte'ını alıp onu bir simetrik anahtar haline getirmeye yarıyor.
    public class SecurityKeyHelper
    {
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
