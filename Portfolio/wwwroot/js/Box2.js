document.addEventListener("DOMContentLoaded", () => {
    const groups = document.querySelectorAll(".skill-group");
    let current = 0;
    
    if (groups.length === 0) return;
    
    //showing first group
    groups[current].classList.add('active');
    
    //Every 3s, hide current and show text
    setInterval(() => {
        groups[current].classList.remove("active");
        current = (current + 1) % groups.length;
        groups[current].classList.add("active");
    }, 3000);
})