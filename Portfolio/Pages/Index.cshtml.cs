using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public List<Skill> Skills { get; set; } = new();
    public List<string> RandomSkillList { get; set; } = new();
    private int n = 0;
    
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    public void OnGet()
    {

        Skills = new List<Skill>
        {
            new Skill { Name = "Linux", ImageURL = "pics/Linux.png" },
            new Skill { Name = "Git",  ImageURL = "pics/Git.png" },
            new Skill { Name = "Docker",  ImageURL = "pics/Docker.png" },
            new Skill { Name = "Powershell",  ImageURL = "pics/Powershell.png" },
            new Skill { Name = "Terraform",   ImageURL = "pics/HashiCorp Terraform.png" },
            new Skill { Name = "Azure", ImageURL = "pics/Azure.png"},
            new Skill { Name = "MariaDB",   ImageURL = "pics/MySQL.png" },
            new Skill { Name = "SQL", ImageURL = "pics/MySQL" },
            new Skill { Name = "MySQL",   ImageURL = "pics/MySQL.png" },
            new Skill { Name = "Pl/SQL", ImageURL = "pics/SQLite.png"},
            new Skill { Name = "SQLite",    ImageURL = "pics/SQLite.png" },
            new Skill { Name = "On-prem", ImageURL = "pics/Azure.png"},
            new Skill { Name = "C#", ImageURL = "pics/Csharp_Logo.png"},
            new Skill { Name = "Java",  ImageURL = "pics/Java.png" },
            new Skill { Name = ".NET", ImageURL = "pics/NET core.png"}
        };
        
        var rand = new Random();
        RandomSkillList = Skills
            .OrderBy(x => rand.Next())
            .Select(x => x.Name)
            .ToList();
    }

    public class Skill
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }
    }
}