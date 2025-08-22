using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages.Kunder;

public class AlleModel : PageModel
{
	private IKundeRepository _repo;

	public List<Kunde> Data { get; private set; }

	public AlleModel(IKundeRepository repo)
	{
		_repo = repo;
	}

	public void OnGet()
	{
		Data = _repo.All;
	}

	/// <summary>
	/// Denne metode afg�r, om Kunde-objektet med det givne id m� slettes.
	/// Det m� det kun, hvis der ikke er nogle Leje-objekter, der refererer
	/// til det. Det kan vi afg�re ud fra Lejes-property, idet den KUN vil
	/// v�re tom, hvis ingen Leje-objekter refererer til dette Kunde-objekt.
	/// </summary>
	public bool CanDelete(int id)
	{
		Kunde? kunde = Data.Find(k => k.Id == id);

		return (kunde != null && kunde.Lejes.Count == 0);
	}
}
