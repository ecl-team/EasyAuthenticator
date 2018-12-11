using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;

namespace qrlib
{
    public class QR
    {
        public static QRCode Generate(string In)
        {
            return new QRCode(new QRCodeGenerator().CreateQrCode(In, QRCodeGenerator.ECCLevel.Q));
        }
    }
}
