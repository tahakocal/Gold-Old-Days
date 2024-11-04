function sayiUret(ustLimit = 10){
  return Math.ceil(Math.random() * ustLimit)
}

//yukarıda console.log yazınca direkt functionu yazıyor

sayiUret()


var sayi1 = sayiUret()
var sayi2 = sayiUret()
var sayi3 = sayiUret()
var sayi4 = sayiUret()
var sayi5 = sayiUret()

//örnek
var sayi6 = Math.ceil(Math.random() *100)

console.log('Kolon =' + sayi1 + ' '+ sayi2+ ' '+ sayi3+ ' '+ sayi4+ ' '+ sayi5+ ' '+ sayi6)