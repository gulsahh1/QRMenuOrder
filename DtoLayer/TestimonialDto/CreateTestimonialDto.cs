using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.TestimonialDto;

public class CreateTestimonialDto
{
    public string? ClientName { get; set; }
    public string? ClientComment { get; set; }
    public string? ClientImageUrl { get; set; }
    public string? Title { get; set; }
    public bool Status { get; set; }
}
