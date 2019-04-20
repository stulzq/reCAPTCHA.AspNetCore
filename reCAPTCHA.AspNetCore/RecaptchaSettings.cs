
namespace reCAPTCHA.AspNetCore
{
    public class RecaptchaSettings
    {
        public string Domain { get; set; } = "www.google.com";
        /// <summary>
        /// Google Recaptcha Secret Key
        /// </summary>
        public string SecretKey { get; set; }
        /// <summary>
        /// Google Recaptcha Site Key
        /// </summary>
        public string SiteKey { get; set; }
        /// <summary>
        /// Google Recaptcha Version
        /// </summary>
        public string Version { get; set; }
    }
}