@import url("https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,100;0,300;0,500;0,600;1,100;1,300&display=swap");
* {
  font-family: "Poppins", sans-serif;
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  outline: none;
  border: none;
  text-decoration: none;
  text-transform: capitalize;
  transition: 0.2s linear;
  color: black;
}

html {
  font-size: 62.5%;
  overflow-x: hidden;
  scroll-behavior: smooth;
  scroll-padding-top: 5rem;
}
html::-webkit-scrollbar {
  width: 1rem;
}
html::-webkit-scrollbar-track {
  background: #fff;
}
html::-webkit-scrollbar-thumb {
  background: #10221b;
}

section {
  padding: 5rem 9%;
}

.heading {
  text-align: center;
  margin-bottom: 2.5rem;
  font-size: 4rem;
  color: #10221b;
}

.header {
  display: flex;
  position: fixed;
  top: 0;
  left: 0;
  right: 0;
  justify-content: center;
  width: 100%;
  padding: 2rem 9%;
  z-index: 1000;
  align-items: center;
  background-color: #fff;
}
.header .activeScroll {
  background: #fff;
  box-shadow: 0 0.5rem 1rem regb(0, 0, 0, 0.1);
}
.header .logo {
  margin-right: auto;
  font-size: 2rem;
  color: #10221b;
  font-weight: bolder;
}
.header .logo i {
  padding-right: 10px;
  color: orange;
}
.header .nav-bar a {
  padding: 0 20px;
  font-size: 1.5rem;
  color: #10221b;
}
.header .nav-bar a:hover {
  color: rgb(242, 206, 0);
}
.header #nav-close {
  font-size: 5rem;
  cursor: pointer;
  color: #10221b;
  display: none;
}
.header .icons a,
.header .icons div {
  font-size: 1.5rem;
  margin-left: 2rem;
  cursor: pointer;
  color: #10221b;
}
.header .icons a:hover,
.header .icons div:hover {
  color: rgb(242, 206, 0);
}
.header #menu-button {
  display: none;
}

.search-form {
  position: fixed;
  top: 0;
  left: 0;
  height: 100%;
  width: 100%;
  background: rgba(0, 0, 0, 0.8);
  display: flex;
  align-items: center;
  justify-content: center;
  z-index: 10000;
  transform: translateY(-110%);
}
.search-form.active {
  transform: translateY(0%);
}
.search-form #close-search {
  position: absolute;
  top: 2rem;
  right: 2.5rem;
  cursor: pointer;
  color: #fff;
  font-size: 6rem;
}
.search-form #close-search:hover {
  color: rgb(242, 206, 0);
}
.search-form form {
  width: 70rem;
  margin: 0 2rem;
  padding-bottom: 2rem;
  border-bottom: 0.2rem solid #fff;
  display: flex;
  align-items: center;
}
.search-form form input {
  width: 100%;
  font-size: 2rem;
  color: #fff;
  text-transform: none;
  background: none;
  padding-right: 2rem;
}
.search-form form input::placeholder {
  color: #aaa;
}
.search-form form label {
  font-size: 3rem;
  cursor: pointer;
  color: #fff;
}
.search-form form label:hover {
  color: gold;
}

.home {
  padding: 0;
}
.home .box {
  min-height: 100vh;
  display: flex;
  align-items: center;
  background-size: cover !important;
  background-position: center !important;
  justify-content: flex-start;
  padding: 2rem 9%;
}
.home .box.second {
  justify-content: flex-end;
}
.home .box.second p {
  color: #fff !important;
}
.home .box.second .btn {
  border: 0.2rem solid #fff !important;
  color: #fff !important;
}
.home .box .content {
  width: 50rem;
}
.home .box .content span {
  font-size: 4.5rem;
  color: gold;
}
.home .box .content h3 {
  font-size: 6rem;
  color: rgb(151, 30, 30);
  padding-top: 0.5rem;
  text-transform: uppercase;
}
.home .box .content p {
  line-height: 2;
  color: #10221b;
  font-size: 1.8rem;
  padding: 1rem 0;
  font-weight: 900;
}
.home .box .content .btn {
  margin-top: 1rem;
  display: inline-block;
  border: 0.2rem solid #10221b;
  color: #10221b;
  cursor: pointer;
  background: none;
  font-size: 1.7rem;
  padding: 1rem 4rem;
}
.home .box .content .btn:hover {
  background: rgb(151, 30, 30);
  color: #fff !important;
}

.swiper-button-next::after,
.swiper-button-prev::after {
  font-size: 3rem;
  color: #10221b;
}

.category .box-container {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(29rem, 1fr));
  gap: 1.5rem;
}
.category .box-container .box {
  text-align: center;
  padding: 2rem;
}
.category .box-container .box img {
  height: 20rem;
  width: 20rem;
  border-radius: 50%;
  margin-bottom: 1rem;
}
.category .box-container .box h3 {
  font-size: 2rem;
  color: rgb(0, 0, 77);
}
.category .box-container .box p {
  font-size: 1.4rem;
  color: #10221b;
  padding: 1rem 0;
  line-height: 2;
}
.category .box-container .box button {
  margin-top: 1rem;
  display: inline-block;
  border: 0.2rem solid #10221b;
  color: #10221b;
  cursor: pointer;
  background: none;
  font-size: 1.4rem;
  padding: 1rem 3rem;
}
.category .box-container .box button:hover {
  background: rgb(151, 30, 30);
  color: #fff;
}

.about {
  background: #eee;
  display: flex;
  align-items: center;
  flex-wrap: wrap;
  gap: 2rem;
}
.about .image {
  flex: 1 1 42rem;
  padding-right: 5rem;
  padding-left: 5rem;
}
.about .image img {
  width: 100%;
  box-shadow: 4rem 4rem rgba(0, 0, 0, 0.1);
}

.about-content {
  flex: 1 1 42rem;
}
.about-content h3 {
  font-size: 3rem;
  color: rgb(0, 0, 77);
}
.about-content p {
  font-size: 1.5rem;
  color: #10221b;
  padding: 1rem 0;
  line-height: 2;
}
.about-content button {
  margin-top: 1rem;
  display: inline-block;
  border: 0.2rem solid #10221b;
  color: #10221b;
  cursor: pointer;
  background: none;
  font-size: 1.4rem;
  padding: 1rem 3rem;
}
.about-content button:hover {
  background: rgb(151, 30, 30);
  color: #fff !important;
}

.shop .slide {
  width: 35rem;
  border: 0.2rem solid #10221b;
  /* Initially hide the icons with opacity 0 and transform off the screen */
  /* Show the icons when the parent container is hovered */
}
.shop .slide .image {
  position: relative;
  overflow: hidden;
  height: 30rem;
  width: 100%;
}
.shop .slide .image img {
  padding: 3rem;
  height: 100%;
  width: 100%;
  object-fit: cover;
}
.shop .slide .hidden-icons {
  opacity: 0;
  transform: translateY(-100%);
  transition: opacity 0.3s ease, transform 0.3s ease;
  width: 100%;
  text-align: center;
  z-index: 10;
}
.shop .slide .image-container:hover .hidden-icons {
  opacity: 1;
  transform: translateY(0);
  width: 100%;
  text-align: center;
  z-index: 10;
}
.shop .slide a {
  height: 4.5rem;
  width: 4.5rem;
  line-height: 4.5rem;
  font-size: 1.7rem;
  color: #10221b;
  background-color: #eee;
  margin: 0 0.2rem;
  border: 0.2rem solid #10221b;
}
.shop .slide a:hover {
  background-color: rgb(0, 0, 77);
  color: #fff;
}
.shop .slide .content {
  padding: 1rem 0;
  text-align: center;
}
.shop .slide .content h3 {
  font-size: 2rem;
  color: #10221b;
}
.shop .slide .content .price {
  padding: 1rem 0;
  padding-top: 0.5rem;
  font-size: 2.5rem;
  color: rgb(151, 30, 30);
}
.shop .slide .content .stars i {
  font-size: 1.7rem;
  color: #10221b;
}

.packages {
  background: #eee;
}
.packages .box-container {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(32rem, 1fr));
  gap: 1.5rem;
}
.packages .box-container .box {
  text-align: center;
  background: #fff;
  border: 0.2rem solid #10221b;
  box-shadow: 0 0.5rem 1rem regb(0, 0, 0, 0.1);
  border-radius: 0.5rem;
}
.packages .box-container .box:hover {
  background: rgb(0, 0, 77);
}
.packages .box-container .box:hover .content > * {
  color: #fff;
}
.packages .box-container .box:hover .btn {
  border: 0.2rem solid #fff;
}
.packages .box-container .box .image {
  height: 25rem;
  overflow: hidden;
  padding: 2rem;
  padding-bottom: 0;
  border-radius: 0.5rem;
}
.packages .box-container .box .image img {
  height: 100%;
  width: 100%;
  object-fit: cover;
  border-radius: 0.5rem;
}
.packages .box-container .box .content {
  padding: 2rem;
}
.packages .box-container .box .content h3 {
  font-size: 2.5rem;
  color: #10221b;
}
.packages .box-container .box .content p {
  font-size: 1.5rem;
  color: #10221b;
  padding: 1rem 0;
  line-height: 2;
}
.packages .box-container .box .content .price {
  font-size: 2rem;
  color: rgb(151, 30, 30);
}
.packages .box-container .box .btn {
  margin-top: 1rem;
  display: inline-block;
  border: 0.2rem solid #10221b;
  color: #10221b;
  cursor: pointer;
  background: none;
  font-size: 1.7rem;
  padding: 1rem 4rem;
}
.packages .box-container .box .btn:hover {
  background: rgb(242, 206, 0);
  color: #fff !important;
}

.services {
  background: #eee;
}
.services .box-container {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(31rem, 1fr));
  gap: 1.5rem;
}
.services .box-container .box {
  text-align: center;
  padding: 2rem;
  border: 0.2rem solid #10221b;
  border-radius: 0.5rem;
  background: #fff;
}
.services .box-container .box:hover {
  background: rgb(151, 30, 30);
}
.services .box-container .box:hover img {
  filter: invert(1);
}
.services .box-container .box:hover h3 {
  color: rgb(242, 206, 0);
}
.services .box-container .box:hover p {
  color: #fff;
}
.services .box-container .box:hover .btn {
  border-color: #fff;
  color: #fff;
}
.services .box-container .box:hover .btn:hover {
  background: rgb(0, 0, 77);
}
.services .box-container .box img {
  height: 10rem;
  margin-bottom: 1rem;
}
.services .box-container .box h3 {
  font-size: 2rem;
  color: rgb(0, 0, 77);
}
.services .box-container .box p {
  font-size: 1.5rem;
  color: #10221b;
  padding: 1rem 0;
  line-height: 2;
}
.services .box-container .box .btn {
  margin-top: 1rem;
  display: inline-block;
  border: 0.2rem solid #10221b;
  color: #10221b;
  cursor: pointer;
  background: none;
  font-size: 1.7rem;
  padding: 1rem 4rem;
}
.services .box-container .box .btn:hover {
  background: rgb(151, 30, 30);
  color: #fff !important;
}

.reviews .slide .text {
  padding: 2rem;
  font-size: 1.6rem;
  font-style: italic;
  background: #eee;
  border-radius: 0.5rem;
  color: #10221b;
  line-height: 2;
  position: relative;
  z-index: 0;
  margin: 3rem 0;
}
.reviews .slide .text::before {
  content: "";
  position: absolute;
  bottom: -1.5rem;
  left: 0.7rem;
  height: 3rem;
  width: 3rem;
  background-color: #eee;
  transform: rotate(45deg);
}
.reviews .slide .user {
  display: flex;
  align-items: center;
  gap: 1rem;
}
.reviews .slide .user .review-picture {
  border: 0.2rem solid #10221b;
  height: 5rem;
  width: 5rem;
  border-radius: 50%;
  padding: 2rem;
  display: inline-block;
  background: rgb(151, 30, 30);
}
.reviews .slide .user h3 {
  font-size: 2rem;
  color: rgb(0, 0, 77);
}
.reviews .slide .user .stars-review i {
  color: rgb(242, 206, 0);
  font-size: 1.5rem;
}

.blogs .slide {
  text-align: center;
  padding: 2rem;
}
.blogs .slide img {
  height: 25rem;
  width: 100%;
  object-fit: cover;
  border-radius: 0.5rem;
}
.blogs .slide .icons {
  background: #10221b;
  border-radius: 0.5rem;
  padding: 1rem;
  position: relative;
  top: -2rem;
  display: inline-block;
}
.blogs .slide .icons .date-writer {
  font-size: 1.4rem;
  color: #fff;
  margin: 0 1rem;
}
.blogs .slide .icons .date-writer:hover {
  color: rgb(242, 206, 0);
}
.blogs .slide .icons .date-writer i {
  padding-right: 0.5rem;
  color: rgb(242, 206, 0);
}
.blogs .slide .btn {
  margin-top: 1rem;
  display: inline-block;
  border: 0.2rem solid #10221b;
  color: #10221b;
  cursor: pointer;
  background: none;
  font-size: 1.5rem;
  padding: 1rem 2rem;
}
.blogs .slide .btn:hover {
  background: rgb(151, 30, 30);
  color: #fff !important;
}
.blogs .slide h3 {
  font-size: 2rem;
  color: #10221b;
}
.blogs .slide p {
  font-size: 1.4rem;
  padding: 1rem 0;
  line-height: 2;
  color: #10221b;
}

.newsletter {
  background: #eee;
}
.newsletter .content {
  max-width: 70rem;
  margin: 1rem auto;
  text-align: center;
}
.newsletter .content p {
  font-size: 1.5rem;
  line-height: 2;
  color: #10221b;
}
.newsletter .content form {
  margin-top: 2rem;
  background: #fff;
  border-radius: 5rem;
  border: 0.2rem solid #10221b;
  padding: 0.7rem;
  display: flex;
}
.newsletter .content form .email {
  width: 100%;
  background: none;
  text-transform: none;
  font-size: 1.6rem;
  color: #10221b;
  padding: 0 1.3rem;
}
.newsletter .btn {
  margin-top: 0;
  display: inline-block;
  border: 0.2rem solid #10221b;
  border-radius: 5rem;
  color: #fff;
  cursor: pointer;
  background: #10221b;
  font-size: 1.5rem;
  padding: 1rem 2rem;
}
.newsletter .btn:hover {
  background: none;
  color: #10221b;
}

.partners .slide {
  text-align: center;
}
.partners .slide img {
  height: 8rem;
  width: 200px;
}

.footer {
  background-color: black;
}
.footer .box-container {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(25rem, 1fr));
  gap: 2rem;
}
.footer .box {
  display: flex;
  flex-direction: column;
  justify-content: center;
}
.footer .box h3, .footer .box a, .footer .box i {
  color: white;
}
.footer .box h3 {
  font-size: 2rem;
  padding: 1.5rem 0;
}
.footer .box a {
  display: block;
  font-size: 1.4rem;
  padding: 1rem 0;
}
.footer .box i {
  padding-right: 0.5rem;
}
.footer .box i:hover {
  color: rgb(242, 206, 0);
}

@media (max-width: 1440px) {
  section {
    padding: 3rem 2rem;
  }
}
@media (max-width: 1200px) {
  html {
    font-size: 55%;
    scroll-padding-top: 7rem;
  }
  .header .icons {
    right: 2rem;
  }
  .header #menu-button {
    display: inline-block;
  }
  .nav-bar {
    position: fixed;
    top: 0;
    left: -110%;
    background: #fff;
    z-index: 1000;
    width: 35rem;
    height: 100%;
    display: flex;
    flex-flow: column;
    align-items: center;
    justify-content: center;
  }
  .nav-bar #nav-close {
    display: block;
    position: absolute;
    top: 1rem;
    right: 2rem;
    color: #10221b !important;
  }
  .nav-bar a {
    margin: 1rem 0;
    font-size: 3rem;
    color: #10221b !important;
  }
  .nav-bar a:hover {
    color: rgb(242, 206, 0) !important;
  }
  .active {
    left: 0;
    box-shadow: 0 0 0 100vw rgba(0, 0, 0, 0.8);
  }
  .home .box {
    padding: 2rem;
    justify-content: center;
    background-position: left !important;
  }
  .home .box.second {
    justify-content: center;
    background-position: center !important;
  }
  .home .box .content {
    text-align: center;
  }
  .home .box .content span {
    font-size: 3rem;
  }
  .home .box .content h3 {
    font-size: 4rem;
  }
}
@media (max-width: 700px) {
  .swiper-button-next::after,
  .swiper-button-prev::after {
    display: none;
  }
  .logo {
    font-size: 1.5rem !important;
  }
  .heading {
    font-size: 3rem;
  }
}

/*# sourceMappingURL=style.cs.map */
