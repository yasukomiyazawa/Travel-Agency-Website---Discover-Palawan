document.addEventListener('DOMContentLoaded', () => {

    console.log("DOMContentLoaded");

    let navbar = document.querySelector(".nav-bar");
  
    document.querySelector('#menu-button').onclick = () => {
        console.log("menu-btn clicked")
      navbar.classList.add("active");
    };
  
    document.querySelector('#nav-close').onclick = () => {
        console.log("close-btn clicked")
      navbar.classList.remove("active");
    };

    window.onscroll = () => {

        navbar.classList.remove("active")

    }
  });
  
