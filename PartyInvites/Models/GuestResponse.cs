using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required (ErrorMessage="please enter your name")]
        public string Name {  get; set; }
        [Required(ErrorMessage = "please enter your email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "please enter your phonee")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "please specify your decision")]
        public bool? WillAttend { get; set; }
    }
}
