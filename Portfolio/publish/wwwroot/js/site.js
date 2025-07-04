//finding button
const button = document.getElementById("style-button");
const carouselContainer = document.querySelector(".carousel-container");
const layout1 = document.querySelector(".grid-container.layout-1");
const layout2 = document.querySelector(".grid-container.layout-2");
const body = document.body;

button.addEventListener("click", function() {

    const isShowingLayout1 = carouselContainer.classList.contains("show-layout-2");


    if (isShowingLayout1) {
        carouselContainer.classList.remove("show-layout-2");
        body.classList.remove("layout-2");
        button.classList.add("layout-2");

        layout1.style.opacity = '1';
        layout1.style.pointerEvents = 'auto';
        layout2.style.opacity = '0';
        layout2.style.pointerEvents = 'none';
    } else {

        carouselContainer.classList.add("show-layout-2");
        body.classList.add("layout-2");
        button.classList.remove("layout-2");

        layout1.style.opacity = '0';
        layout1.style.pointerEvents = 'none';
        layout2.style.opacity = '1';
        layout2.style.pointerEvents = 'auto';
    }
});

