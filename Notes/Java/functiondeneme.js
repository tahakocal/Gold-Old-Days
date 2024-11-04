function sayiUret(üstLimit = 6) {
    return Math.ceil(Math.random() * üstLimit)
}


var sayi1 = sayiUret()
var sayi2 = sayiUret()
var sayi3 = sayiUret()
var sayi4 = sayiUret()
var sayi5 = sayiUret()


console.log('Sayılar = ' + sayi1 + ' ' + sayi2 + ' ' + sayi3 + ' ' + sayi4 + ' ' + sayi5)
