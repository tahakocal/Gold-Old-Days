function sayiUret(ustLimit = 100) {
    return Math.ceil(Math.random() * ustLimit)
}

for (var i = 1; i <= 8; i++) {
    console.log(i +'. Kolon')
    for (var j = 1; j <= 6; j++) {
        console.log(sayiUret())
    }
}



// içeride ki döngüde karışmaması için j dışarı da ki döngüde i kullanuıyoruz
