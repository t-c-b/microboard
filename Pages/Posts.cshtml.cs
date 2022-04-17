#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace microboard.Pages
{
    public class PostsModel : PageModel
    {
        private readonly MicroboardContext _context;

        public PostsModel(MicroboardContext context)
        {
            _context = context;
        }

        public IList<Post> Posts { get;set; }
        [BindProperty]
        public Post post {get;set;}

        public async Task OnGetAsync()
        {
            Posts = await _context.Post.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
          if(!ModelState.IsValid)
          {
            return Page();
          }

          post.time = DateTime.Now;
          post.id = 1;
          _context.Post.Add(post);
          await _context.SaveChangesAsync();
          return Page();
        }
    }
}
