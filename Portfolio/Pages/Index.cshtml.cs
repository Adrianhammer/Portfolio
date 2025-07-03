using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public List<Skill> Frontend { get; set; } = new();
    public List<Skill> Backend { get; set; } = new();
    public List<Skill> Other { get; set; } = new();
    
    public List<Skill> Skills { get; set; } = new List<Skill>();
    
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    public void OnGet()
    {
        Frontend = new List<Skill>
        {
            new Skill { Name = "CSS" },
            new Skill { Name = "HTML" },
            new Skill { Name = "JavaScript"},
            new Skill { Name = "PHP"}
        };

        Backend = new List<Skill>
        {
            new Skill { Name = "C#" },
            new Skill { Name = "Java" },
            new Skill { Name = ".NET" }
        };

        Other = new List<Skill>
        {
            new Skill { Name = "Linux" },
            new Skill { Name = "Git" },
            new Skill { Name = "Docker" },
            new Skill { Name = "Powershell" },
            new Skill { Name = "Terraform" },
            new Skill { Name = "Azure" },
            new Skill { Name = "MariaDB" },
            new Skill { Name = "SQL" },
            new Skill { Name = "MySQL" },
            new Skill { Name = "Pl/SQL" },
            new Skill { Name = "SQLite" },
            new Skill { Name = "On-prem"}
        };
        
        
    }

    public class Skill
    {
        public string Name { get; set; }
    }
}