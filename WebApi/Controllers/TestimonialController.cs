using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.TestimonialDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.EntityLayer.Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;
        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
                ClientName = createTestimonialDto.ClientName,
                ClientComment = createTestimonialDto.ClientComment,
                ClientImageUrl = createTestimonialDto.ClientImageUrl,
                Status = createTestimonialDto.Status,
                Title = createTestimonialDto.Title

            });
            return Ok("Ekleme Başarılı");
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            _testimonialService.TDelete(value);
            return Ok("Silme Başarılı");
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
                TestimonialID = updateTestimonialDto.TestimonialID,
                ClientName = updateTestimonialDto.ClientName,
                ClientComment = updateTestimonialDto.ClientComment,
                ClientImageUrl = updateTestimonialDto.ClientImageUrl,
                Status = updateTestimonialDto.Status,
                Title = updateTestimonialDto.Title
            });
            return Ok("Güncelleme Başarılı");

        }
        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }
    }
}
