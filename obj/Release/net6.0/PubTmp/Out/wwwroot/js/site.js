$('.icon-search').on('click',function (){
    $('.slogan .search input').toggle(200);
});
window.onscroll = function(){
    aa();
} 
function aa(){
    var x = $('header').offset().top - $(window).scrollTop();
    if(x==0){
        $('.navbar').addClass('fix');
    }
    else {
        $('.navbar').removeClass('fix');
    }
}
$(document).ready(function() {
    var owl = $('#slide-auto-translate');
    owl.owlCarousel({
    nav: true,
    autoplay:true,
    autoplayTimeout:5000,
    smartSpeed:500,
    navText: ["<div class='btn-icon'><i class='fa-solid fa-angle-left'></i></div>", "<div class='btn-icon'><i class='fa-solid fa-angle-right'></i></div>"],
    loop: true,
    responsive: {
        0: {
        items: 1
        },
        600: {
        items: 1
        },
        1000: {
        items: 1
        }
    }
    })
    $('.slide').css('display','block');

})
function eventBtnTranslate(){
    var btnTranslate1 = document.querySelectorAll("#product-type-1 .btn-translate");
    var btnTranslate2 = document.querySelectorAll("#product-type-2 .btn-translate");
    var btnTranslate3 = document.querySelectorAll("#product-type-3 .btn-translate");
    var listSlide1 = document.querySelector('#product-type-1 .product-list');
    var listSlide2 = document.querySelector('#product-type-2 .product-list');
    var listSlide3 = document.querySelector('#product-type-3 .product-list');
    for(var i=0;i<btnTranslate1.length;i++){
        btnTranslate1[i].addEventListener("click",(e)=>{
            for(var j=0;j<btnTranslate1.length;j++){
                if(btnTranslate1[j].classList.contains("active")){
                    listSlide1.style.transform= `translateX(${-j*100}%)`;
                    btnTranslate1[j].classList.remove("active");
                    break;
                }
            }
            e.currentTarget.classList.add("active");
            for(var j=0;j<btnTranslate1.length;j++){
                if(btnTranslate1[j].classList.contains("active")){
                    listSlide1.style.transform= `translateX(${-j*100}%)`;
                    break;
                }
            }
        });
    }
    for(var i=0;i<btnTranslate2.length;i++){
        btnTranslate2[i].addEventListener("click",(e)=>{
            for(var j=0;j<btnTranslate2.length;j++){
                if(btnTranslate2[j].classList.contains("active")){
                    listSlide2.style.transform= `translateX(${-j*100}%)`;
                    btnTranslate2[j].classList.remove("active");
                    break;
                }
            }
            e.currentTarget.classList.add("active");
            for(var j=0;j<btnTranslate3.length;j++){
                if(btnTranslate2[j].classList.contains("active")){
                    listSlide2.style.transform= `translateX(${-j*100}%)`;
                    break;
                }
            }
        });
    }
    for(var i=0;i<btnTranslate3.length;i++){
        btnTranslate3[i].addEventListener("click",(e)=>{
            for(var j=0;j<btnTranslate3.length;j++){
                if(btnTranslate3[j].classList.contains("active")){
                    listSlide3.style.transform= `translateX(${-j*100}%)`;
                    btnTranslate3[j].classList.remove("active");
                    break;
                }
            }
            e.currentTarget.classList.add("active");
            for(var j=0;j<btnTranslate3.length;j++){
                if(btnTranslate3[j].classList.contains("active")){
                    listSlide3.style.transform= `translateX(${-j*100}%)`;
                    break;
                }
            }
        });
    }
}
function addNavMobile(id){
    $('#'+id).slideToggle(200);
}
function btnRight(listProductId,productType){
    var listProduct = document.getElementById(listProductId);
    var countItem = document.querySelectorAll(`#${listProductId} .product-item`).length;
    var viewIndex = parseInt(countItem/5)
    var maxWidth =(countItem%5==0)?100*(countItem/5-1):(viewIndex*100);
    var translateNumber = Number.parseInt(listProduct.style.transform.replace('translateX(','').replace('%)',''))
    console.log(`translateNumber: ${translateNumber} -- maxWidth: ${maxWidth}`);
    if(listProduct.style.transform!=''){
        if((-translateNumber)< maxWidth){
            listProduct.style.transform =  `translateX(${translateNumber-100}%)`;
            var translateItem = document.querySelectorAll(`#${productType} .btn-translate`);
            for(var i=0;i<translateItem.length;i++){
                if(translateItem[i].classList.contains("active")){
                    translateItem[i+1].classList.add("active");
                    translateItem[i].classList.remove("active");
                    break;
                }
            }
        }
    } else {
        if(viewIndex>0){
            document.getElementById(listProductId).style.transform =`translateX(${-100}%)`;
            var translateItem = document.querySelectorAll(`#${productType} .btn-translate`);
            for(var i=0;i<translateItem.length;i++){
                if(translateItem[i].classList.contains("active")){
                    translateItem[i].classList.remove("active");
                    translateItem[i+1].classList.add("active");
                    break;
                }
            }
        }
    }
}
function btnLeft(listProductId,productType){
    var listProduct = document.getElementById(listProductId);
    var countItem = document.querySelectorAll(`#${listProductId}`, '.product-item').length;
    var maxWidth =(countItem/5) * 100-100;
    var translateNumber = Number.parseInt(listProduct.style.transform.replace('translateX(','').replace('%)',''))
    if(listProduct.style.transform!=''){
        if(translateNumber< 0){
            listProduct.style.transform =  `translateX(${translateNumber+100}%)`;
            var translateItem = document.querySelectorAll(`#${productType} .btn-translate`);
            for(var i=0;i<translateItem.length;i++){
                if(translateItem[i].classList.contains("active")){
                    translateItem[i].classList.remove("active");
                    translateItem[i-1].classList.add("active");
                    break;
                }
            }
        }
    }
}
let translateNumber = 0;
function btnRightSlideShow(id){
    var speed = 500;
    if(translateNumber==0){
        var listSlide = document.getElementById('slide-auto-translate');
        var slide = document.getElementsByClassName('slide');
        listSlide.style.transition=`transform ${speed*0.001}s`;
        for(var i =0; i<slide.length;i++){
            if(slide[i].classList.contains('active')){
                if(i==slide.length-1){
                    slide[0].style.display="inline-block";
                    slide[0].style.float="right";
                    slide[0].style.marginRight="-100%";
                    translateNumber = -100;
                    listSlide.style.transform = `translateX(${translateNumber}%)`;
                    setTimeout(()=>{
                        slide[i].classList.remove("active");
                        listSlide.style.transition="";
                        listSlide.style.transform = ``;
                        slide[i].style.display = "";
                        slide[i].style.float = "";
                        slide[0].style.marginRight="";
                        slide[0].style.float="";
                        slide[0].classList.add("active");
                        translateNumber =0;
                    },speed)
                }
                else {
                    slide[i+1].style.display="inline-block";
                    slide[i+1].style.float="right";
                    slide[i+1].style.marginRight="-100%";
                    translateNumber = -100;
                    listSlide.style.transform = `translateX(${translateNumber}%)`;
                    setTimeout(()=>{
                        translateNumber =0;
                        listSlide.style.transition="";
                        listSlide.style.transform = ``;
                        slide[i].style.display = "";
                        slide[i].style.float = "";
                        slide[i].classList.remove("active");
                        slide[i+1].classList.add("active");
                        slide[i+1].style.marginRight="";
                        slide[i+1].style.float="";
                    },speed)
                }
                break;
            }
        }

    }
    // if(translateNumber <=-((slide.length-1)*100)){
    //     translateNumber =0;
    //     listSlide.style.transform = `translateX(${translateNumber}%)`;
    // }
}
function btnLeftSlideShow(id){
    let speed =500;
    if(translateNumber==0){
        var listSlide = document.getElementById('slide-auto-translate');
        var slide = document.getElementsByClassName('slide');
        listSlide.style.transition=`transform ${speed*0.001}s`;
        for(var i =0; i<slide.length;i++){

            if(slide[i].classList.contains('active')){
                if(i==0){
                    slide[slide.length-1].style.display="inline-block";
                    slide[slide.length-1].style.float="left";
                    slide[slide.length-1].style.marginLeft="-100%";
                    translateNumber = 100;
                    listSlide.style.transform = `translateX(${translateNumber}%)`;
                    setTimeout(()=>{
                        slide[i].classList.remove("active");
                        listSlide.style.transition="";
                        listSlide.style.transform = ``;
                        slide[i].style.display = "";
                        slide[i].style.float = "";
                        slide[slide.length-1].style.float="";
                        slide[slide.length-1].style.marginLeft="";
                        slide[slide.length-1].classList.add("active");
                        translateNumber =0;
                    },speed)
                }
                else {
                    slide[i-1].style.display="inline-block";
                    slide[i-1].style.float="left";
                    slide[i-1].style.marginLeft="-100%";
                    translateNumber = 100;
                    listSlide.style.transform = `translateX(${translateNumber}%)`;
                    setTimeout(()=>{
                        translateNumber =0;
                        listSlide.style.transition="";
                        listSlide.style.transform = ``;
                        slide[i].style.display = "";
                        slide[i].style.float = "";
                        slide[i].classList.remove("active");
                        slide[i-1].classList.add("active");
                        slide[i-1].style.marginLeft="";
                        slide[i-1].style.float="";
                    },speed)
                }
                break;
            }
        }

    }
}
function removeNavMobile(id){
    
    var navMobile = document.getElementById(id);
    navMobile.style.left = '-100%'
    
}

/////////////////////////////
// BEGIN: CUSTOM IMAGE DETAILS
$(document).ready(function(){
    $('.section-base-info img').on('click',function(){
        $('.image-details').toggle(0);
    })
    $('.content-icon-zoom').on('click',function(){
        $('.image-details').toggle(0);
    });
})
$(document).ready(function() {
    var owl = $('.image-details .image-list');
    owl.owlCarousel({
    nav: true,
    navText: ["<div class='btn-icon'><i class='fa-sharp fa-solid fa-caret-left'></i></div>", "<div class='btn-icon'><i class='fa-solid fa-caret-right'></i></div>"],
    loop: true,
    responsive: {
        0: {
        items: 1
        },
        600: {
        items: 1
        },
        1000: {
        items: 1
        }
    }
    })
    $('.owl-dots .owl-dot').each(function(index,element){
        $('.section-base-info .img-content img').each(function(index1,element1){
            if(index==index1){
                var src = element1.src;
                $(element).css('background-image',`url("${src}")`)
            }
        });
    })
    $('.image-details .image-item').each(function (index, element) {
        $('.section-base-info .img-content img').each(function (index1, element1) {
            if (index == index1) {
                var src = element1.src;
                $(element).css('background-image', `url("${src}")`)
            }
        });
    })
})
// END: CUSTOM IMAGE DETAILS