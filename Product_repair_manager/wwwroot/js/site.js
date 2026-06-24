// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
    const favIcontag = document.getElementById('favIcontag');
    const isdark = window.matchMedia ('(prefers-color-scheme: dark)').matches;
    console.log(isdark);

const changefavIcon = () => {
    if (isdark) favIcontag.href = "favicon-dark.ico";
    else favIcontag.href = 'favicon-light.ico';
};
changefavIcon();
isdark.addEventListener('change', changefavIcon);

function swap() {
    var element = document.body;
    element.classList.toggle("darkmode");
}