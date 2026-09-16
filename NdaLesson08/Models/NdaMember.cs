using System.ComponentModel.DataAnnotations;

namespace NdaLesson08.Models
{
    public class NdaMember
    {
        public string NdaMemberId { get; set; }
        public string NdaUserName { get; set; }
        
        public string NdaPassword { get; set; }
        [Display(Name = "Họ và tên")]
        public string NdaFullName { get; set; }

        public string NdaEmail { get; set; }

        
    }
}
