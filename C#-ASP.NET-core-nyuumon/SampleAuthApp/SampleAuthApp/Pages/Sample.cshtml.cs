using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleAuthApp.Pages;

public class SampleModel : PageModel
{
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly string email;
    private readonly string password;

    public SampleModel(SignInManager<IdentityUser> signInManager)
    {
        _signInManager = signInManager;
        email = "shimizu.tkmt@gmail.com";
        password = "xwn4twu4VDY!uvr*wup";
    }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if(User.Identity.IsAuthenticated)
        {
            await _signInManager.SignOutAsync();
        }
        else
        {
            await _signInManager.PasswordSignInAsync(email, password, true, false);
        }
        return Redirect("/Sample");
    }
}
