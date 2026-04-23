// Theme toggle — persists to localStorage
(function () {
    var root = document.documentElement;
    var saved = localStorage.getItem("theme") || "light";
    root.setAttribute("data-theme", saved);

    function updateBtn() {
        var btn = document.getElementById("theme-toggle");
        if (!btn) return;
        btn.textContent = root.getAttribute("data-theme") === "dark" ? "☀" : "☾";
    }

    document.addEventListener("DOMContentLoaded", function () {
        var btn = document.getElementById("theme-toggle");
        if (!btn) return;
        updateBtn();
        btn.addEventListener("click", function () {
            var next = root.getAttribute("data-theme") === "dark" ? "light" : "dark";
            root.setAttribute("data-theme", next);
            localStorage.setItem("theme", next);
            updateBtn();
        });
    });

    // Reveal-on-load for direct children of .page
    document.addEventListener("DOMContentLoaded", function () {
        var page = document.querySelector(".page");
        if (!page) return;
        Array.prototype.forEach.call(page.children, function (el, i) {
            el.classList.add("reveal");
            el.style.animationDelay = (0.05 + i * 0.08) + "s";
        });
    });
})();
