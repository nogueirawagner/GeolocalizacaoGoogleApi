using System.ComponentModel.DataAnnotations;

namespace GestaoDDD.Infra.Identity.Model
{
    public class VerifyCodeViewModel
    {
         
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Código")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Relembrar senha")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    
    }
}
