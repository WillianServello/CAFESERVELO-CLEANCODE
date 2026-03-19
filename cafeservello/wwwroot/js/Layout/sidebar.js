    function toggleSidebar(){

        const sidebar = document.getElementById("sidebar");

        sidebar.classList.toggle("fechada");

}

    function SubmenuAtivo(setAtivo) {
        const submenu = setAtivo.nextElementSibling;
        submenu.classList.toggle("ativo");
    }