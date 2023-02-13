
function display(n) {

  var not = document.getElementById("main-notification")
  not.style.display = "Block"

  var subnot = document.getElementById("sub-notification")
  subnot.style.display = "Block"


  var headersubnot= document.getElementById("h-sub-n")
  headersubnot.innerHTML = "Новость "
  headersubnot.innerHTML += n
  headersubnot.style.fontWeight= "bold"
  headersubnot.style.fontSize= "35px"
    
  var h4subnot= document.getElementById("h4-sub-n")
  h4subnot.innerHTML = "Новость "
  h4subnot.innerHTML += n
  h4subnot.innerHTML += ": Lorem ipsum dolor sit amet consectetur adipisicing elit. A, alias."
  h4subnot.style.fontWeight= "normal"
  h4subnot.style.marginBottom= "0px"
}


function destroy() {
 
  var not = document.getElementById("main-notification")
  not.style.display = "none"

  var subnot= document.getElementById("sub-notification")
  subnot.style.display = "none"
}
