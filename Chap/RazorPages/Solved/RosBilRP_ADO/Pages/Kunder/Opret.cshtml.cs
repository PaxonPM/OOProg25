using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages.Kunder;

public class OpretModel : PageModel
{
	private IKundeRepository _repo;

	[BindProperty]
	public Kunde Element { get; set; } = new Kunde();

	public OpretModel(IKundeRepository repo)
	{
		_repo = repo;
	}

	public IActionResult OnPost()
	{
		// Tjek om det indtastede data er validt
		if (!ModelState.IsValid)
		{
			return Page();
		}

		// Send data videre til repository
		_repo.Create(Element);

		// Vend tilbage til oversigen
		return RedirectToPage("Alle");
	}
}
