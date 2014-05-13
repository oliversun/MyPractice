using System;
using System.Security.Cryptography.X509Certificates;
using System.IdentityModel.Tokens;
using System.IdentityModel.Selectors;

namespace ServiceLibrary
{
    public class CustomX509CertificateValidator : X509CertificateValidator 
    {
          public override void Validate(X509Certificate2 certificate)
        {
              Console.WriteLine(certificate.Subject);
              Console.WriteLine(certificate.Thumbprint);
              if (certificate.Thumbprint != "33517bb445ed5bef678df195e2b8d0b32023d7d6")                
                  throw new SecurityTokenException("Certificate Validation Error!"); }
    }
}
