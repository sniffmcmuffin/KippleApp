window.setTheme = (theme) => {
    document.body.setAttribute("data-theme", theme);
    localStorage.setItem("theme", theme);
}

window.getTheme = () => {
    return localStorage.getItem("theme") ?? "theme-light";
}