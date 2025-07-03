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
            new Skill { Name = "On-prem"},
            new Skill { Name = "C#" },
            new Skill { Name = "Java" },
            new Skill { Name = ".NET" }
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
    }
}