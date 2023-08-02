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

      if(window.scrollY > 0){

        document.querySelector('.header').classList.add('activeScroll');

      } else {

        document.querySelector('.header').classList.remove('activeScroll');

      }

    }

    // let imageContainers = document.querySelectorAll(".image-container");

    // imageContainers.forEach((container) => {

    //   let image = container.querySelector(".image");
    //   let hiddenIcons = container.querySelector(".hidden-icons")

    //   image.addEventListener("mouseenter", ()=> {

    //     hiddenIcons.classList.remove("hidden-icons")

    //   })

    //   container.addEventListener("mouseleave", () => {

    //     hiddenIcons.classList.add("hidden-icons")

    //   })

    // })


    var swiper = new Swiper(".home-slider", {
        loop: true,
        grabCursor: true,
        navigation: {
          nextEl: ".swiper-button-next",
          prevEl: ".swiper-button-prev",
        },
    });

    var swiper = new Swiper(".product-slider", {
      loop: true,
      grabCursor: true,
      spaceBetween: 20,
      navigation: {
        nextEl: ".swiper-button-next",
        prevEl: ".swiper-button-prev",
      },
      breakpoints: {
        0: {
          slidesPerView: 1,
        },
        640: {
          slidesPerView: 2,
        },
        768: {
          slidesPerView: 3,
        },
        1024: {
          slidesPerView: 4,
        },
      },
  });

  var swiper = new Swiper(".review-sliders", {
    loop: true,
    grabCursor: true,
    spaceBetween: 20,
    navigation: {
      nextEl: ".swiper-button-next",
      prevEl: ".swiper-button-prev",
    },
    breakpoints: {
      0: {
        slidesPerView: 1,
      },
      640: {
        slidesPerView: 2,
      },
      768: {
        slidesPerView: 3,
      },
    },
  });
  
  var swiper = new Swiper(".blogs-slider", {
    loop: true,
    grabCursor: true,
    spaceBetween: 10,
    navigation: {
      nextEl: ".swiper-button-next",
      prevEl: ".swiper-button-prev",
    },
    breakpoints: {
      0: {
        slidesPerView: 1,
      },
      768: {
        slidesPerView: 2,
      },
      991: {
        slidesPerView: 3,
      },

    },
  });

  var swiper = new Swiper(".partners-slider", {
    loop: true,
    grabCursor: true,
    spaceBetween: 8,
    breakpoints: {

      0: {
        slidesPerView: 1,
      },

      600: {
        slidesPerView: 2,
      },

      1024: {
        slidesPerView: 3,
      },

      1400: {
        slidesPerView: 4,
      },
    },
});
  

});


  
  
