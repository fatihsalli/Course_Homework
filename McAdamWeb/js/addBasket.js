//Product Class�
class Product {
    constructor(_productName, _unitPrice) {
        this.productName = _productName;
        this.unitPrice = _unitPrice;
    }
    productName;
    unitPrice;
}

//Men�ler
//var product1 = new Product();
//product1.productName = "Big Mac� Men�";
//product1.id = 1;
//product1.price = 79;

//Men�ler
const menu1 = new Product("Big Mac� Men�", 79);
const menu2 = new Product("McChicken� Men�", 73);
const menu3 = new Product("Double McChicken� Men�", 84);
const menu4 = new Product("Gamer Men�", 89);
const menu5 = new Product("Double Cheeseburger Men�", 82);
const menu6 = new Product("McRoyal� Men�", 95);
const menu7 = new Product("Quarter Pounder� Men�", 104);
const menu8 = new Product("Double Big Mac� Men�", 104);

//Sepet ��lemleri
class Basket {
    static basketList = [];
    static sum = 0;

    static addProduct(menu) {
        this.basketList.push(menu);
        const basketList = document.getElementById('basket-list');
        const tr = document.createElement('tr');
        tr.innerHTML = `<li class="list-group-item d-flex justify-content-between">
                            <span class="badge bg-primary rounded-pill">1</span>
                            <span>${menu.productName}</span>
                            <span>${menu.unitPrice}</span>
                            </li>`;
        basketList.appendChild(tr);
        this.getTotalPrice();
    }

    static getTotalPrice() {
        let totalPrice = 0;
        for (var i = 0; i < this.basketList.length; i++) {
            totalPrice += this.basketList[i].unitPrice;
        }
        document.getElementById('totalPrice').innerText = 'Toplam Fiyat: ' + totalPrice +' TL'
    }





}






document.getElementById('button1').onclick = function () {
    Basket.addProduct(menu1);
}
document.getElementById('button2').onclick = function () {
    Basket.addProduct(menu2);
}
document.getElementById('button3').onclick = function () {
    Basket.addProduct(menu3);
}
document.getElementById('button4').onclick = function () {
    Basket.addProduct(menu4);
}
document.getElementById('button5').onclick = function () {
    Basket.addProduct(menu5);
}
document.getElementById('button6').onclick = function () {
    Basket.addProduct(menu6);
}
document.getElementById('button7').onclick = function () {
    Basket.addProduct(menu7);
}
document.getElementById('button8').onclick = function () {
    Basket.addProduct(menu8);
    console.log(sum);
}