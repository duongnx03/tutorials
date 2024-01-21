using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoQRCode.Models;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using static QRCoder.PayloadGenerator;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoQRCode.Controllers
{
    public class QRCodeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            QRCodeModel model = new QRCodeModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(QRCodeModel model)
        {
            Payload? payload = null;
            switch(model.QRCodeType){
                case 1://SMS
                    payload = new SMS(model.SMSPhoneNumber, model.SMSBody);
                    break;

                case 2://email
                    payload = new Mail(model.ReceiveEmailAddress, model.EmailSubject, model.EmailMessage);
                    break;

                case 3: //fb url
                    payload = new Url(model.FacebookAddressUrl);
                    break;

                case 4: //wifi
                    payload = new WiFi(model.WifiName, model.WifiPassword, WiFi.Authentication.WPA);
                    break;
            }

            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(payload);
            BitmapByteQRCode qRCode = new BitmapByteQRCode(qRCodeData);
            string base64String = Convert.ToBase64String(qRCode.GetGraphic(20));
            model.QRImageUrl = "data: image/png;base64, " + base64String;
            return View(model);

        }
    }
}

