﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SampleRazorApp.Data;
using SampleRazorApp.Models;

namespace SampleRazorApp.Pages.Msg
{
    public class CreateModel : PageModel
    {
        private readonly SampleRazorApp.Data.SampleRazorAppContext _context;

        public CreateModel(SampleRazorApp.Data.SampleRazorAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PersonId"] = new SelectList(_context.Person, "PersonId", "Name");
            return Page();
        }

        [BindProperty]
        public Message Message { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            _context.Message.Add(Message);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
