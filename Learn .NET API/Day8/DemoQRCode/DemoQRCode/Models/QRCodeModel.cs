using System;
namespace DemoQRCode.Models
{
	public class QRCodeModel
	{
		public int QRCodeType { get; set; }
		public string QRImageUrl { get; set; }

		//for email
		public string ReceiveEmailAddress { get; set; } = string.Empty;
        public string EmailSubject { get; set; } = string.Empty;
        public string EmailMessage { get; set; } = string.Empty;

        //for sms
        public string SMSPhoneNumber { get; set; } = string.Empty;
        public string SMSBody { get; set; } = string.Empty;

        //facebook
        public string FacebookAddressUrl { get; set; } = string.Empty;

        //wifi
        public string WifiName { get; set; } = string.Empty;
        public string WifiPassword { get; set; } = string.Empty;
    }
}

