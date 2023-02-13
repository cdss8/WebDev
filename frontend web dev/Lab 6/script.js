function display(n){

  if(n==1){
    var left = document.getElementById("left")
    left.style.width = "850px"
    var right = document.getElementById("right")
    right.style.width = "50px"
    var cat = document.getElementById("cat")
    cat.style.display = "Block"
    var dog = document.getElementById("dog")
    dog.style.display = "none"
  }

  else if (n==2) {
    var left = document.getElementById("left")
    left.style.width = "450px"
    var right = document.getElementById("right")
    right.style.width = "450px"
    var cat = document.getElementById("cat")
    cat.style.display = "Block"
    var dog = document.getElementById("dog")
    dog.style.display = "Block"
  }
  
  else {
    var left = document.getElementById("left")
    left.style.width = "50px"
    var right = document.getElementById("right")
    right.style.width = "850px"
    var cat = document.getElementById("cat")
    cat.style.display = "none"
    var dog = document.getElementById("dog")
    dog.style.display = "Block"
  }
}
