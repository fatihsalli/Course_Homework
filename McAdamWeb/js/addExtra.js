//Sepet Aktarma - Daha sonra bakýlacak
//document.getElementById('basketTransfer').onclick = function () {
//    for (var i = 0; i < Basket.basketList.length; i++) {
//        const basketList = document.getElementById('basket-list');
//        const tr = document.createElement('tr');
//        tr.innerHTML = `<li class="list-group-item d-flex justify-content-between">
//                            <span class="badge bg-primary rounded-pill">1</span>
//                            <span>${menu.productName}</span>
//                            <span>${menu.unitPrice}</span>
//                            </li>`;
//        basketList.appendChild(tr);
//    }
//}

//ExtraProduct Classý
class ExtraProduct {
    constructor(_productName, _unitPrice) {
        this.productName = _productName;
        this.unitPrice = _unitPrice;
    }
    productName;
    unitPrice;
}

//Ekstra Ürünler
const ekstra1 = new ExtraProduct("Karýþýk Atýþtýrmalýk Kovasý", 47);
const ekstra2 = new ExtraProduct("Patates Kýzartmasý", 18);
const ekstra3 = new ExtraProduct("Çýtýr Soðan", 21);
const ekstra4 = new ExtraProduct("Chicken McNuggets", 41);
const ekstra5 = new ExtraProduct("Acýlý Chicken McBites", 36);
const ekstra6 = new ExtraProduct("Çurso (Çikolata Soslu)", 22);


class ExtraBasket {
    static extraBasketList = [];

    static addExtraProduct(ekstra) {
        this.extraBasketList.push(ekstra);
        const basketList = document.getElementById('basket-list-new');
        const exp = document.createElement('exp');
        exp.innerHTML = `<li class="list-group-item d-flex justify-content-between">
                            <span class="badge bg-primary rounded-pill">1</span>
                            <span>${ekstra.productName}</span>
                            <span>${ekstra.unitPrice}</span>
                            </li>`;
        basketList.appendChild(exp);
        this.getTotalPrice();
    }

    static getTotalPrice() {
        let totalPrice = 0;
        for (var i = 0; i < this.extraBasketList.length; i++) {
            totalPrice += this.extraBasketList[i].unitPrice;
        }
        document.getElementById('totalPrice').innerText = 'Toplam Fiyat: ' + totalPrice + ' TL'
    }
}

document.getElementById('exbutton1').onclick = function () {
    ExtraBasket.addExtraProduct(ekstra1);
}
document.getElementById('exbutton2').onclick = function () {
    ExtraBasket.addExtraProduct(ekstra2);
}
document.getElementById('exbutton3').onclick = function () {
    ExtraBasket.addExtraProduct(ekstra3);
}
document.getElementById('exbutton4').onclick = function () {
    ExtraBasket.addExtraProduct(ekstra4);
}
document.getElementById('exbutton5').onclick = function () {
    ExtraBasket.addExtraProduct(ekstra5);
}
document.getElementById('exbutton6').onclick = function () {
    ExtraBasket.addExtraProduct(ekstra6)
};
