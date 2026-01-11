using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.FeatureDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.EntitiyLayer.Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;
        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult FeatureList()
        {
            var values = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetListAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            _featureService.TAdd(new Feature()
            {
                FeatureTitle1 = createFeatureDto.FeatureTitle1,
                FeatureDesc1 = createFeatureDto.FeatureDesc1,
                FeatureTitle2 = createFeatureDto.FeatureTitle2,
                FeatureDesc2 = createFeatureDto.FeatureDesc2,
                FeatureTitle3 = createFeatureDto.FeatureTitle3,
                FeatureDesc3 = createFeatureDto.FeatureDesc3
            });
            return Ok("Ekleme Başarılı");
        }
        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            var value = _featureService.TGetById(id);
            _featureService.TDelete(value);
            return Ok("Silme Başarılı");
        }
        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            _featureService.TUpdate(new Feature()
            {
                FeatureID = updateFeatureDto.FeatureID,
                FeatureTitle1 = updateFeatureDto.FeatureTitle1,
                FeatureDesc1 = updateFeatureDto.FeatureDesc1,
                FeatureTitle2 = updateFeatureDto.FeatureTitle2,
                FeatureDesc2 = updateFeatureDto.FeatureDesc2,
                FeatureTitle3 = updateFeatureDto.FeatureTitle3,
                FeatureDesc3 = updateFeatureDto.FeatureDesc3
            });
            return Ok("Güncelleme Başarılı");
        }
        [HttpGet("GetFeature")]
        public IActionResult GetFeature(int id)
        {
            var value =_featureService.TGetById(id);
            return Ok(value);
        }
    }
}
