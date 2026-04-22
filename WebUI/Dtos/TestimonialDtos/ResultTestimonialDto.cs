namespace WebUI.Dtos.TestimonialDtos
{
    public class ResultTestimonialDto
    {
        public int TestimonialID { get; set; }
        public string? ClientName { get; set; }
        public string? ClientComment { get; set; }
        public string? ClientImageUrl { get; set; }
        public string? Title { get; set; }
        public bool Status { get; set; }
    }
}
