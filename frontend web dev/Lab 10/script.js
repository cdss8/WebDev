function curtainclick(){
    var curtain=document.querySelector('.curtain');
    curtain.style.transition = "transform 0.2s ease-in";
    curtain.style.transform = "translate(0, -100%)";
}

function lampclick(){
    var light=document.querySelector('.light');
    const all =document.querySelectorAll('img');

    var lamprode1= document.querySelector('.lamprode1');
    var lamprode2 = document.querySelector('.lamprode2');

		
    lamprode1.style.transform = "translate(0, 15px)";
    lamprode2.style.transform = "translate(0, 15px)";	
    
    setTimeout(()=>{lamprode1.style.transform = "translate(0, 0px)";
    lamprode2.style.transform = "translate(0, 0px)";}, 300);
    	
    
    if(light.style.display!="block"){
        light.style.display="block";
        for (var x = 0; x < all.length; x++) all[x].style.display = 'block';
    }

    else{
        light.style.display="none";
        for (var x = 0; x < all.length; x++) all[x].style.display = 'none';
    } 
    
    document.querySelector('.lamp').style.display = 'block';
}

function magicclick(clicked){
    var bunny= document.getElementById('bunny');
    var dove = document.getElementById('dove');
    
    if(clicked == "bunny"){
        bunny.style.transform = "translate(0, 130px)";
        dove.style.transform = "translate(0, -130px)";
    }
    else{
        bunny.style.transform = "translate(0, 0)";
        dove.style.transform = "translate(0, 0)";
    }
}