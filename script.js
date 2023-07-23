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


    let searchForm = document.querySelector(".search-form");
  
    document.querySelector('#search-button').onclick = () => {
        console.log("menu-btn clicked")
      searchForm.classList.add("active");
    };
  
    document.querySelector('#close-search').onclick = () => {
        console.log("close-btn clicked")
      searchForm.classList.remove("active");
    };


    window.onscroll = () => {

        navbar.classList.remove("active")

    }

    var swiper = new Swiper(".home-slider", {
        loop: true,
        grabCursor: true,
        navigation: {
          nextEl: ".swiper-button-next",
          prevEl: ".swiper-button-prev",
        },
    });
});


  
  
