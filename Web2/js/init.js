let cakeIngediants = ['Eggs', 'Milk', 'Chocolate', 'Backing Powder', 'Sugar', 'Whip Cream', 'Cake Decoration'];

let shoppingList = document.getElementById('shoppinglist');
shoppingList.setAttribute('class', 'highlight')
shoppingList.innerHTML = cakeIngediants.map(c => `<tr><td>${c}</td></tr>`).join('');