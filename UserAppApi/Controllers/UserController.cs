using System;
using Microsoft.AspNetCore.Mvc;
using UserAppApi.Models;

namespace UserAppApi.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class UserController : ControllerBase
{
	private List<User> users =
	[
		new (){Id=1,Name="Test",Email="Test@gmail.com"},
	];

	[HttpGet]
	public IActionResult GetAll() => new JsonResult(users);

	[HttpGet]
	public IActionResult GetById(int id)
		=> new JsonResult(users.FirstOrDefault(u => u.Id == id));
}
