let number = document.getElementById("hej");
let bish = document.getElementById("hej2");
let bosh = document.getElementById("hej3");
let bishbash = document.getElementById("hej4");
let checker = new Array(3).fill(false);
let numberbox = document.getElementById("input");
let bishbox = document.getElementById("input2");
let boshbox = document.getElementById("input3");
let button = document.getElementById("ready");
let button2 = document.getElementById("clear");

/* for (let index = 0; index <= 1000; index++) {
  let clone = document.createElement("li");
  clone.textContent = "Helloo";
  b3.append(clone.cloneNode(true));
  b.append(clone.cloneNode(true));
  b1.append(clone.cloneNode(true));
  b2.append(clone.cloneNode(true));
} */

button.disabled = true;
button2.disabled = true;

button2.addEventListener("click", function (e) {
  clearBishBosh();
  numberbox.disabled = false;
  bishbox.disabled = false;
  boshbox.disabled = false;
  numberbox.setAttribute("placeholder", "Ange en siffra");
  bishbox.setAttribute("placeholder", "Ange en siffra för bish");
  boshbox.setAttribute("placeholder", "Ange en siffra för bosh");
  button.disabled = true;
  button2.disabled = true;
});

button.addEventListener("click", function (e) {
  if (button.disabled == false) {
    checker.fill(false);
    button2.disabled = false;
    console.log(numberbox.getAttribute("placeholder"));
    hello(
      numberbox.getAttribute("placeholder"),
      bishbox.getAttribute("placeholder"),
      boshbox.getAttribute("placeholder")
    );
  }
});

document.getElementById("input").addEventListener("keydown", function (e) {
  if (e.key === "Enter") {
    var numbers = /^[0-9]+$/;
    if (numberbox.value.match(numbers)) {
      numberforloop = numberbox.value;
      if (numberforloop > 0 && numberforloop <= 1000) {
        numberbox.setAttribute("disabled", true);
        numberbox.value = "";
        let s = numberforloop;
        numberbox.setAttribute("placeholder", `${numberforloop} `);
        checker[0] = true;
      }
      if (numberbox.value > 1000) {
        numberbox.value = "";
        numberbox.setAttribute("placeholder", "Talet är förstort");
      }
    } else {
      numberbox.value = "";
      numberbox.setAttribute("placeholder", "Får inte innehålla bokstäver");
    }
    checkifready();
  }
});

document.getElementById("input2").addEventListener("keydown", function (e) {
  if (e.key === "Enter") {
    var numbers = /^[0-9]+$/;
    if (bishbox.value.match(numbers)) {
      numberforloop = bishbox.value;
      if (numberforloop > 0 && numberforloop <= 200) {
        bishbox.setAttribute("disabled", true);
        bishbox.value = "";
        let s = numberforloop;
        bishbox.setAttribute("placeholder", `${numberforloop} `);
        checker[1] = true;
      }
      if (bishbox.value > 200) {
        bishbox.value = "";
        bishbox.setAttribute("placeholder", "Talet är förstort");
      }
    } else {
      bishbox.value = "";
      bishbox.setAttribute("placeholder", "Får inte innehålla bokstäver");
    }
    checkifready();
  }
});

document.getElementById("input3").addEventListener("keydown", function (e) {
  if (e.key === "Enter") {
    var numbers = /^[0-9]+$/;
    if (boshbox.value.match(numbers)) {
      numberforloop = boshbox.value;
      if (numberforloop > 0 && numberforloop <= 200) {
        boshbox.setAttribute("disabled", true);
        boshbox.value = "";
        let s = numberforloop;
        boshbox.setAttribute("placeholder", `${numberforloop} `);
        checker[2] = true;
      }
      if (boshbox.value > 200) {
        boshbox.value = "";
        boshbox.setAttribute("placeholder", "Talet är förstort");
      }
    } else {
      boshbox.value = "";
      boshbox.setAttribute("placeholder", "Får inte innehålla bokstäver");
    }
    checkifready();
  }
});

function checkifready() {
  let d = false;
  for (let i = 0; i < checker.length; i++) {
    if (checker[i] == false) {
      d = false;
      return;
    } else {
      d = true;
    }
  }
  if (d == true) {
    button.disabled = false;
  }
}

function hello(numberforfoor, bishnr, boshnr) {
  button.disabled = true;

  for (let i = 1; i <= numberforfoor; i++) {
    if (i % bishnr == 0 && i % boshnr == 0) {
      let newnode = document.createElement("li");
      newnode.textContent = "bish-bosh";
      bishbash.append(newnode);

      newnode = document.createElement("li");
      newnode.textContent = "-";
      number.append(newnode);

      newnode = document.createElement("li");
      newnode.textContent = "-";
      bish.append(newnode);
      newnode = document.createElement("li");
      newnode.textContent = "-";
      bosh.append(newnode);
      continue;
    }
    if (i % bishnr == 0) {
      let newnode = document.createElement("li");
      newnode.textContent = "bish";
      bish.append(newnode);

      newnode = document.createElement("li");
      newnode.textContent = "-";
      number.append(newnode);
      newnode = document.createElement("li");
      newnode.textContent = "-";
      bosh.append(newnode);
      newnode = document.createElement("li");
      newnode.textContent = "-";
      bishbash.append(newnode);
      continue;
    }
    if (i % boshnr == 0) {
      let newnode = document.createElement("li");
      newnode.textContent = "bosh";
      bosh.append(newnode);

      newnode = document.createElement("li");
      newnode.textContent = "-";
      number.append(newnode);
      newnode = document.createElement("li");
      newnode.textContent = "-";
      bish.append(newnode);

      newnode = document.createElement("li");
      newnode.textContent = "-";
      bishbash.append(newnode);
      continue;
    }
    if (i % bish !== 0 && i % bosh !== 0) {
      let newnode = document.createElement("li");
      newnode.textContent = i;
      number.append(newnode);

      newnode = document.createElement("li");
      newnode.textContent = "-";
      bish.append(newnode);
      newnode = document.createElement("li");
      newnode.textContent = "-";
      bosh.append(newnode);
      newnode = document.createElement("li");
      newnode.textContent = "-";
      bishbash.append(newnode);
    }
  }
}

function clearBishBosh() {
  while (number.childNodes.length > 2) {
    number.removeChild(number.lastChild);
  }

  while (bish.childNodes.length > 2) {
    bish.removeChild(bish.lastChild);
  }

  while (bishbash.childNodes.length > 2) {
    bishbash.removeChild(bishbash.lastChild);
  }
  while (bosh.childNodes.length > 2) {
    bosh.removeChild(bosh.lastChild);
  }
}

// TODO IN THE BODO
let list = document.getElementById("lista");
let list2 = document.getElementById("lista2");
let beboop = document.getElementById("hider");
let listinput1 = document.getElementById("listinput1");
let listinput2 = document.getElementById("listinput2");
let bodomover = document.getElementById("bodo");
let kokomover = document.getElementById("koko");

kokomover.addEventListener("click", function (e) {
  if (list2.lastElementChild !== null) {
    checkLocalstorge(list2.lastElementChild.textContent, list2Items);
    list1Items.content[list1Items.index] = list2.lastElementChild.textContent;
    saveToLocalStorage(list1Items);
    list1Items.index++;
    list.append(list2.lastElementChild);
  }
});

bodomover.addEventListener("click", function (e) {
  if (list.lastElementChild !== null) {
    console.log(list.lastElementChild.textContent);
    checkLocalstorge(list.lastElementChild.textContent, list1Items);
    list2Items.content[list2Items.index] = list.lastElementChild.textContent;
    saveToLocalStorage(list2Items);
    list2Items.index++;
    list2.append(list.lastElementChild);
  }
});

list.addEventListener("mouseup", function (e) {
  e.stopPropagation();
  console.log();
  if (e.target.tagName == "LI") {
    if (e.target.style.color === "red") {
      e.target.style.color = "";
      e.target.style["text-decoration"] = "none";
      return;
    }
    e.target.style["text-decoration"] = "line-through";
    e.target.style.color = "red";
  }
});

list.addEventListener(
  "contextmenu",
  function (e) {
    if (e.target.tagName == "LI") {
      e.preventDefault();
      checkLocalstorge(e.target.textContent, list1Items);

      list.removeChild(e.target);
      return false;
    } else e.preventDefault();
  },
  false
);

list2.addEventListener(
  "contextmenu",
  function (e) {
    if (e.target.tagName == "LI") {
      e.preventDefault();
      checkLocalstorge(e.target.textContent, list2Items);

      list2.removeChild(e.target);
      return false;
    } else e.preventDefault();
  },
  false
);

list2.addEventListener("click", function (e) {
  if (e.target.tagName == "LI") {
    if (e.target.style.color === "red") {
      e.target.style.color = "";
      e.target.style["text-decoration"] = "none";
      return;
    }
    e.target.style["text-decoration"] = "line-through";
    e.target.style.color = "red";
  }
});

beboop.addEventListener("click", myFunction);
listinput1.addEventListener("keydown", function (e) {
  if (e.key === "Enter") {
    let text = listinput1.value;
    let a = document.createElement("li");
    a.textContent = text;
    list1Items.content[list1Items.index] = text;
    console.log(list1Items.content[list1Items.index]);
    saveToLocalStorage(list1Items);
    list1Items.index++;
    list.appendChild(a);
    listinput1.value = "";
  }
});
listinput2.addEventListener("keydown", function (e) {
  if (e.key === "Enter") {
    let text = listinput2.value;
    let a = document.createElement("li");
    a.textContent = text;
    list2Items.content[list2Items.index] = text;
    saveToLocalStorage(list2Items);
    list2Items.index++;
    list2.appendChild(a);
    listinput2.value = "";
  }
});

function myFunction() {
  let x = document.getElementById("todo2");
  if (x.style.display === "none") {
    x.style.display = "block";
  } else {
    x.style.display = "none";
  }
}

function saveToLocalStorage(listItem) {
  window.localStorage.setItem(
    listItem.identifier + listItem.index,
    listItem.content[listItem.index]
  );
}

let list2Items = {
  identifier: "list2-",
  index: 0,
  content: [],
};

let list1Items = {
  identifier: "list1-",
  index: 0,
  content: [],
};

function checkLocalstorge(removetext, list) {
  if (list.identifier == "list2-") {
    let list2 = [];
    for (let i = 0; i < window.localStorage.length; i++) {
      if (window.localStorage.key(i).includes("list2-")) {
        list2.push(window.localStorage.key(i));
      }
    }
    for (let j = 0; j < list2.length; j++) {
      if (window.localStorage.getItem(list2[j]) == removetext) {
        window.localStorage.removeItem(list2[j]);
        return;
      }
    }
  }

  if (list.identifier == "list1-") {
    let list1 = [];
    for (let i = 0; i < window.localStorage.length; i++) {
      if (window.localStorage.key(i).includes("list1-")) {
        list1.push(window.localStorage.key(i));
      }
    }
    for (let j = 0; j < list1.length; j++) {
      if (window.localStorage.getItem(list1[j]) == removetext) {
        window.localStorage.removeItem(list1[j]);
        return;
      }
    }
  }
}

function populateListFromStorage(){
  if(window.localStorage.length > 0){
    for(let i = 0; i < localStorage.length; i++){
      if(localStorage.key(i).includes("list1-")){
        let s = localStorage.key(i)
        let newNode = document.createElement("li")
        newNode.textContent = localStorage.getItem(s)
        list.appendChild(newNode)
      }
      if(localStorage.key(i).includes("list2-")){
        let s = localStorage.key(i)
        let newNode = document.createElement("li")
        newNode.textContent = localStorage.getItem(s)
        list2.appendChild(newNode)
      }

    }

  }
}

window.onload = populateListFromStorage()