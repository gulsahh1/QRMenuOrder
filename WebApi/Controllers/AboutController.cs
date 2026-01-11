using BusinessLayer.Abstract;
using DtoLayer.AboutDto;
using DtoLayer.CategoryDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.EntitiyLayer.Entities;

namespace WebApi.Controllers;

    [Route("api/[controller]")]
[ApiController]
public class AboutController : ControllerBase
{
    private readonly IAboutService _aboutService;
    public AboutController(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }

    [HttpGet]
    public IActionResult AboutList()
    {
        var values = _aboutService.TGetListAll();
        return Ok(values);
    }

    [HttpPost]
    public IActionResult CreatAbout(CreateAboutDto createAboutDto)
    {
        About about = new About()
        {
            Title = createAboutDto.Title,
            Description = createAboutDto.Description,
            ImageUrl = createAboutDto.ImageUrl
        };
        _aboutService.TAdd(about);
        return Ok("Ekleme Başarılı");

    }

    [HttpDelete]
    public IActionResult DeleteAbout(int id)
    {
        var value = _aboutService.TGetById(id);
        _aboutService.TDelete(value);
        return Ok("Silme Başarılı");
    }
    [HttpPut]
    public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
    {
        About about = new About()
        {
            AboutID = updateAboutDto.AboutID,
            Title = updateAboutDto.Title,
            Description = updateAboutDto.Description,
            ImageUrl = updateAboutDto.ImageUrl
        };
        _aboutService.TUpdate(about);
        return Ok("Güncelleme Başarılı");
    }

    [HttpGet("GetAbout")]
    public IActionResult GetAbout(int id)
    {
        var value = _aboutService.TGetById(id);
        return Ok(value);
    }
}

