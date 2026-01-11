using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities;

public class Testimonial
{
    public int TestimonialID { get; set; }
    public string? ClientName { get; set; }
    public string? ClientComment { get; set; }
    public string? ClientImageUrl { get; set; }
    public string? Title { get; set; }
    public bool Status { get; set; }
}
